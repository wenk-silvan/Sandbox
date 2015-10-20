using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         new Program().Run();
      }

      public IEnumerable<Type> Types { get; set; }

      public Program()
      {
         this.Types = typeof(Program).Assembly.GetTypes().Where(t => typeof(IExample).IsAssignableFrom(t) && typeof(IExample) != t);
      }

      public void Run()
      {
         while (true)
         {
            Console.WriteLine("Please enter the project to run:");
            Console.WriteLine("('LambdaExample', 'YieldExample', 'ExitCommand')");
            Console.WriteLine();
            Console.Write(">> ");
            var command = Console.ReadLine();

            try
            {
               this.GetProject(command).Run();
            }
            catch (Exception ex)
            {
               Console.WriteLine("Error: {0}", ex.Message);
               Console.WriteLine();
            }
         }
      }

      private IExample GetProject(string command)
      {
         try
         {
            var type = Types.First(t => t.Name == command);
            return (IExample) Activator.CreateInstance(type);
         }
         catch(Exception ex)
         {
            throw new Exception("Command not found", ex);
         }
      }

   }
}