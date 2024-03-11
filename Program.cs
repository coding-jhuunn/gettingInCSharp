using System;

namespace MyApp
{
    internal class Program
    {
        class Wizard(string _uname,string _magicName){
            public string uname = _uname;
            public string magicName = _magicName;
        }

        static void Main(string[] args)
        {
          Wizard wizard01 = new Wizard("ME","One");
          
          Console.ReadKey();
        }
    }
}