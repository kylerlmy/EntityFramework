using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectShared
{
    public class Person
    {

        public Person()
        {
            SelfIntroduction = "Hello World";
            System.Console.WriteLine(SelfIntroduction);
        }
        public string SelfIntroduction { get; set; }
    }
}
