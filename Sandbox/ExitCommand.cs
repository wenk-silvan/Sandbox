using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
   class ExitCommand : IExample
   {
      public void Run()
      {
         Console.WriteLine("Bye");
         Console.ReadKey();
         Environment.Exit(0);
      }
   }
}
