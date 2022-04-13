using System;

namespace string_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "Gasimova Safura";
            Console.WriteLine("The length of the string txt is:" + txt.Length);
            Console.WriteLine(txt.ToUpper()); 
            Console.WriteLine(txt.ToLower());
            string firstname = "Safura";
            string lastname = "Gasimova";
            string name = firstname + lastname;
            Console.WriteLine(name);    
            string name1 = string.Concat(firstname, lastname);
            Console.WriteLine(name1);
            string name2 = $"My full name is:{firstname} {lastname}";
            Console.WriteLine(name2);
            string myString = "Happiness";
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString.IndexOf("s"));
            string name3 = "Gasimova Safura";
            int charPos = name.IndexOf("v");
            Console.WriteLine(charPos); 
            string lastname1 = name.Substring(charPos);
            Console.WriteLine(lastname1);   


        }
    }
}
