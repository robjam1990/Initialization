 var f = function (x) {return x + 1};
// assign a new definition to f:
    f = new Function('x', 'return x + 2');
// f is now a new function that adds 2 to its argument
