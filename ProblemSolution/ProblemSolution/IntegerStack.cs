using System.Collections.Generic;
using System.Linq;

namespace ProblemSolution
{
    public class IntegerStack
    {
        private Stack<int> stack = new Stack<int>();
        
        private Stack<int> minStack = new Stack<int>();

        public void Push(int newValue)
        {
            stack.Push(newValue);

            if (!minStack.Any() || newValue <= minStack.Peek())
            {
                minStack.Push(newValue);
            }
        }

        public int Pop()
        {
            var poppedInt = stack.Pop();

            if (minStack.Any() && poppedInt == minStack.Peek())
            {
                minStack.Pop();
            }

            return poppedInt;
        }

        public int Min()
        {
            return minStack.Peek();            
        }
    }
}
