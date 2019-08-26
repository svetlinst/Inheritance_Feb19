namespace CustomStack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public Stack<string> AddRange(params string[] list)
        {
            foreach (var itm in list)
            {
                this.Push(itm);
            }
            return this;
        }
    }
}
