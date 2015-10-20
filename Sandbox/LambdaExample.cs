using System;
using System.Collections.Generic;

namespace Sandbox
{
   internal class LambdaExample : IExample
   {
      public void Run()
      {
         Console.WriteLine();
         Console.WriteLine("Calculating with anonymous function");
         Console.WriteLine("-> 6 * 2 = {0}", this.Calculate(6, delegate(int o) { return o * 2; }));

         Console.WriteLine();
         Console.WriteLine("Calculating with lambda");
         Console.WriteLine("-> 6 * 2 = {0}", this.Calculate(6, _ => _ * 2));

         Console.WriteLine();
         Console.WriteLine("Calculating with closures");
         var funcs = new List<Action>();
         foreach (var i in new[] { 1, 2, 3, 4, 5 })
         {
            funcs.Add(() => {
               Console.WriteLine("-> {0} * 2 = {1}", i, i*2);
            });
         }
         foreach (var func in funcs) { func(); }
      }

      private int Calculate(int value, Func<int, int> func)
      {
         return func(value);
      }
   }
}