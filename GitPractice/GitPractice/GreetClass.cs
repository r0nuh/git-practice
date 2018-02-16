using System;
using System.Collections.Generic;
using System.Text;

namespace GitPractice
{
    class GreetClass
    {
        public void Greet(string german, string name)
        {
            german = "Guten Tag, ";

            name = "Herr Müller!";

            Console.WriteLine(german + name);
            Console.ReadLine();
        }
    }
}
