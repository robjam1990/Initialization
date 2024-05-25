#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

// Define data types for abstract syntax tree
enum _kind { 
    kVar, kConst, kSum, kDiff, kMult, kDiv, 
    kPlus, kMinus, kNot, kAnd, kOr, kXor 
};

struct _variable { 
    int *memory; 
};

struct _constant { 
    int intValue; 
    float floatValue;  // New: Support for floating-point numbers
};

struct _unaryOperation { 
    struct _node *right; 
};

struct _binaryOperation { 
    struct _node *left, *right; 
};

struct _node {
    enum _kind kind;
    union _expression {
        struct _variable variable;
        struct _constant constant;
        struct _binaryOperation binary;
        struct _unaryOperation unary;
    } e;
};

// Interpreter procedure for executing integer expressions
int executeIntExpression(const struct _node *n) {
    int leftValue, rightValue;
    switch (n->kind) {
        case kVar: return *n->e.variable.memory;
        case kConst: return n->e.constant.intValue;
        case kSum: 
            leftValue = executeIntExpression(n->e.binary.left);
            rightValue = executeIntExpression(n->e.binary.right);
            return leftValue + rightValue;
        case kDiff: 
            leftValue = executeIntExpression(n->e.binary.left);
            rightValue = executeIntExpression(n->e.binary.right);
            return leftValue - rightValue;
        case kMult: 
            leftValue = executeIntExpression(n->e.binary.left);
            rightValue = executeIntExpression(n->e.binary.right);
            return leftValue * rightValue;
        case kDiv: 
            leftValue = executeIntExpression(n->e.binary.left);
            rightValue = executeIntExpression(n->e.binary.right);
            if (rightValue == 0) {
                exception("division by zero");
                exit(1);
            }
            return leftValue / rightValue;
        case kPlus: 
            rightValue = executeIntExpression(n->e.unary.right);
            return +rightValue;
        case kMinus: 
            rightValue = executeIntExpression(n->e.unary.right);
            return -rightValue;
        case kNot: 
            rightValue = executeIntExpression(n->e.unary.right);
            return !rightValue;
        case kAnd: 
            leftValue = executeIntExpression(n->e.binary.left);
            rightValue = executeIntExpression(n->e.binary.right);
            return leftValue && rightValue;
        case kOr: 
            leftValue = executeIntExpression(n->e.binary.left);
            rightValue = executeIntExpression(n->e.binary.right);
            return leftValue || rightValue;
        case kXor: 
            leftValue = executeIntExpression(n->e.binary.left);
            rightValue = executeIntExpression(n->e.binary.right);
            return leftValue ^ rightValue;
        default: 
            exception("internal error: illegal expression kind");
            exit(1);
    }
}

// Exception handling function
void exception(const char* message) {
    printf("Exception: %s\n", message);
}

int main() {
    // Example AST construction and evaluation
    struct _node *n1 = malloc(sizeof(struct _node));
    n1->kind = kConst;
    n1->e.constant.intValue = 10;

    struct _node *n2 = malloc(sizeof(struct _node));
    n2->kind = kConst;
    n2->e.constant.intValue = 20;

    struct _node *n3 = malloc(sizeof(struct _node));
    n3->kind = kSum;
    n3->e.binary.left = n1;
    n3->e.binary.right = n2;

    printf("Result: %d\n", executeIntExpression(n3));

    free(n1);
    free(n2);
    free(n3);

    return 0;
}
