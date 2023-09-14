using System;

namespace StackClass 
{
     public class StackStr
    {
        static readonly int MAX = 10;
        int top = -1;
        string [] stack = new string[MAX];

        public bool IsEmpty() 
        {
            return (top < 0);
        }
        public bool Push(string data)
        {   
            if (top >= MAX) 
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }

            top += 1;
            stack[top] = data;

            return true;
        }

        public string Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return "";
            }

            string valor = stack[top];
            top -= 1;
            return valor;

        }

        public void Pick() 
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine($"O topo da pilha é: {stack[top]}");
        }

                public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            
            Console.WriteLine("Os itens da pilha são:");

            for (int i = top; i >= 0; i--)
            {
                string texto = $"Stack[{stack[i]}] ";
                Console.WriteLine(texto);
            }
        }



    }
}