// See https://aka.ms/new-console-template for more information

//Declare stack of ty
Stack<string> stack = new Stack<string>();

//inserts entry in stack
stack.Push("Sanju");
stack.Push("Sanju1");
stack.Push("Sanju2");
stack.Push("Sanju3");
stack.Push("Sanju4");

//removes the last element from the stack and assign to the variable something
var something = stack.Pop();

// prints the variable something
Console.WriteLine(something);


// lets us view the last element without poping from stack.
Console.WriteLine(stack.Peek());


