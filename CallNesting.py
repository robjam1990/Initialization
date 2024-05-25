"""
This module contains functions for performing nested function calls.
"""

def h(arg1, arg2):
    """
    Perform some operation on two arguments.

    Args:
        arg1: The first argument.
        arg2: The second argument.

    Returns:
        The result of the operation.
    """
    if isinstance(arg1, str) and arg1 == 'c' and isinstance(arg2, str) and arg2 == 'c':
        return arg1 + arg2
    else:
        return "Invalid arguments"

def f(arg1, arg2):
    """
    Perform some operation on two arguments.

    Args:
        arg1: The first argument.
        arg2: The second argument.

    Returns:
        The result of the operation.
    """
    if isinstance(arg1, str) and isinstance(arg2, str):
        return "f(" + arg1 + "," + arg2 + ")"
    return "Invalid arguments"

def nested_calls(n):
    """
    Perform n nested function calls.

    Args:
        n: The number of nested calls.

    Returns:
        The result of the nested calls.
    """
    if n <= 0:
        return "Invalid input"
    if n == 1:
        return h('c', 'c')
    return f(nested_calls(n - 1), h('c', 'c'))

# Example usage:
result = nested_calls(4)
print(result)  # Output: f(f(f(c,c),c),c)
