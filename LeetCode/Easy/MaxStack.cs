using System.Collections;

namespace CodingAlgorithms.LeetCode.Easy
{
    public class MaxStack
    {
        private Stack stack;
        private Stack maxStack;

        public MaxStack()
        {
            stack = new Stack();
            maxStack = new Stack();
        }

        public void Push(int x)
        {
            int max = maxStack.Count == 0 ? x : (int)maxStack.Peek();
            stack.Push(x);
            maxStack.Push(max > x ? max : x);
        }

        public int Pop()
        {
            return (int)stack.Pop();
        }

        public int Top()
        {
            return (int)stack.Peek();
        }

        public int PeekMax()
        {
            return (int)maxStack.Peek();
        }

        public int PopMax()
        {
            return (int)maxStack.Pop();
        }
    }
}