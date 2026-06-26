//A program that creates a stack thats able to undo and redo actions such as popping and pushing




    var stack = new UndoableStack<string>();

    stack.Push("A");
    stack.Push("B");
    stack.Push("C");

    Console.WriteLine(stack.Pop());  // C
    Console.WriteLine(stack.Pop());  // B

    stack.Undo();  // B is back on top
    stack.Redo();  // B is removed again
    public class UndoableStack<T>{
        private Stack<T> _main = new();
        private Stack<T> _undo = new();
        private Stack<T> _redo = new();

        public void Push(T item) //adds an item to the main Stack
        {
            _main.Push(item);
            _redo.Clear();//clears the redo stack after a new action is done
        }
        
        public T Pop() //first checks if there are items in the stack able to be removed then Pops it
        {
            if (_main.Count == 0)
                throw new InvalidOperationException("Stack is Empty");

            T item = _main.Pop();// removes the first item and puts it into the variable item
            _undo.Push(item);// item gets pushed unto the Undo Stack
            return item;// returns that item variable as the output of the function
        }

        public void Undo()
        {
            if (_undo.Count == 0)
                throw new InvalidOperationException("No item to Undo");

            T item = _undo.Pop();// Takes out the item from undo and puts it into variable item
            _main.Push(item);//puts the item in the main stack to undo the delete
            _redo.Push(item);//puts it into redo as well if u want


        }

        public void Redo()
        {
            if (_redo.Count == 0) 
                throw new InvalidOperationException("no item to redo");
            
            T item = _redo.Pop();
            _main.Pop();
            _undo.Push(item);

        }

        
    }