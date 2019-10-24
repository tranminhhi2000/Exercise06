using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Stack
    {
    private string[] Buffer;
    private int Top;
        public Stack (int size)
            {
            Buffer = new string[size];
            Top = -1;
            }

        //
        public Stack()
            {
            Buffer = new string [1000];
            Top = -1;
            Console.WriteLine();
            }
        
        public void Push(String value)
            {
                Buffer[Top + 1] = value;
                Top++;

            }

        public string Pop()
            {
                String value = Buffer[Top];
                Top = Top - 1;
                return value;
            }

        public string Peek()
            {
                return Buffer[Top];
            }
   
        public void Clear()
            {
                Top = -1;
            }

        public int Count()
            {
            return Top + 1;
            }
    }

}
