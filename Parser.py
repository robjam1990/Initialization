import sys

# Constants
TERM = 0
RULE = 1

T_LPAR = 0
T_RPAR = 1
T_A = 2
T_PLUS = 3
T_END = 4
T_INVALID = 5

N_S = 0
N_F = 1

table = [[1, -1, 0, -1, -1, -1],
         [-1, -1, 2, -1, -1, -1]]

RULES = [[(RULE, N_F)],
         [(TERM, T_LPAR), (RULE, N_S), (TERM, T_PLUS), (RULE, N_F), (TERM, T_RPAR)],
         [(TERM, T_A)]]

def lexical_analysis(input_string):
    """
    Perform lexical analysis on the input string.
    """
    tokens = []
    for c in input_string:
        if c == "+":
            tokens.append(T_PLUS)
        elif c == "(":
            tokens.append(T_LPAR)
        elif c == ")":
            tokens.append(T_RPAR)
        elif c == "a":
            tokens.append(T_A)
        else:
            tokens.append(T_INVALID)
    tokens.append(T_END)
    return tokens

def syntactic_analysis(tokens):
    """
    Perform syntactic analysis on the tokens.
    """
    stack = [(TERM, T_END), (RULE, N_S)]
    position = 0
    while len(stack) > 0:
        (stype, svalue) = stack.pop()
        token = tokens[position]
        if stype == TERM:
            if svalue == token:
                position += 1
                if token == T_END:
                    return True  # Input accepted
            else:
                print("Error: Unexpected token in input")
                return False  # Input rejected
        elif stype == RULE:
            rule = table[svalue][token]
            if rule == -1:
                print("Error: No valid rule found for current state and token")
                return False  # Input rejected
            for r in reversed(RULES[rule]):
                stack.append(r)
    return False  # Input rejected

def read_file_content(file_path):
    """
    Read the content of the file at the given file path.
    """
    with open(file_path, 'r') as file:
        return file.read().strip()

if __name__ == "__main__":
    if len(sys.argv) != 2:
        print("Usage: python parser.py <file_path>")
        sys.exit(1)

    file_path = sys.argv[1]
    try:
        input_string = read_file_content(file_path)
        tokens = lexical_analysis(input_string)
        if syntactic_analysis(tokens):
            print("Input accepted")
        else:
            print("Input rejected")
    except Exception as e:
        print(f"An error occurred: {e}")
        sys.exit(1)
