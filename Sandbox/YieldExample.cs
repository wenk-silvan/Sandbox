using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
   class YieldExample : IExample
   {
      public void Run()
      {
         Console.WriteLine("Yield values are: {0}", string.Join(", ", this.GetElements()));
         Console.WriteLine();
      }

      public IEnumerable<int> GetElements()
      {
         yield return 1;
         yield return 2;
         yield return 3;
      }
   }
}
