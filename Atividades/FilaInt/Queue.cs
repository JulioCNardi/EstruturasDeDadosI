using System;

namespace QueueClass
{
    public class Queue{
        static readonly int MAX = 10;
        int back = -1;
        int front = -1;
        int [] queue = new int[MAX];

        public bool IsEmpty() {
            if (back == -1 && front == -1){
                return true;
            } else
            return false;
        }

        public bool IsFull()
        {
            if (back == MAX - 1)
            {
                return true;
            } else {
                return false;
            }

        }

        public void Enqueue(int data)
        {
            if (IsFull()) 
            {
                Console.WriteLine("Fila está cheia");
            } else if (front == -1 && back == -1){
                front = back = 0;
                queue[back] = data;
            } else {
                back++;
                queue[back] = data;
            }

        }

      public void Dequeue() 
      {
            if (IsEmpty()) 
            {
                Console.WriteLine("Fila está vazia");
            } else if (front == back){
                front = back = -1;
            } else {
                front++;
            }
           
      }

      public void Peek()
      {
           if (back < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine($"O começo da fila é: {queue[front]}");
            Console.WriteLine($"O final da fila é: {queue[back]}");
      }


    }  
}