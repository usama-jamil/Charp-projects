using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_04
{
    public class Stack
    {
        private  List<object> _Obj = new List<object>();


       public void Push(object obj)
       {
           if (obj == null)
               throw new InvalidOperationException("You are givinng null value to this method");

           _Obj.Add(obj);
       }
       public object Pop()
       {
           var obj = _Obj[_Obj.Count-1];
           _Obj.Remove(obj);

           return obj;
       }
        
       public void Clear()
       {
           _Obj = null;
       }


    }
    class Program
    {
        static void Main(string[] args)
        {
           //List<object> obj = new List<object>();
           //obj.Add("usama");
           //obj.Add("jamil");
           //obj.Add("pakistan");
           //Console.WriteLine(obj[0]);
           //Console.WriteLine(obj[1]);
           //Console.WriteLine(obj[2]);

           //obj.Remove(obj[obj.Count - 1]);
           //obj.Remove(obj[0]);
           //Console.WriteLine("after removing pakistan");
           //Console.WriteLine(obj[0]);
           //Console.WriteLine(obj[1]);
            int? name = null;
            name = 10;
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
           Console.ReadKey();
        }
    }
}
