using System;
Namespace MyWork  //namespace is like a container holding related classes, members and nested namespaces for organised code
  //it allows the existence of same name classes if present in different namespace
  //not a mandatory element to have in our code
{
  public class HelloWorld  // object oriented lang hence class is mandatory 
  {
      public static void Main(string[] args)  //main method of class HelloWorld, mandatory element as this is where the prog begins to execute
      {
    
          Console.WriteLine("hello");  
          Console.WriteLine("World");  //cmd for printing output on console on different line
          Console.Write("hello")
          Console.WriteLine("world");  //cmd for printing output on console on same line
          Console.ReadKey();  //generally the console terminates by itself, this cmd to hold it until a key is pressed 
      }
  }
}
