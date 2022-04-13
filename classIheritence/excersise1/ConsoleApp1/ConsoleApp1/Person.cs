using System;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("hey  {0}, {1}", to, Name);

        }

        //decalre an method returns Person object. so keyword could be any class or class itslf 
        // we use static here then we do not need to call his Parse method on ínstance class. we coyld yse Person itself 
        //add static after public Parse is public method inside this class but it returns a static class Person. So we 

        // Parse is static member of Person class. actually Parse is a method which return a static class. ¨so it is also static member 
        // static member could be static class or a method that returns a static class like this Parse 
        public static Person Parse(string str)
        {
            //basically we need to create an object Person here and this Person as we know it has one paramter which string
            var person = new Person();
            person.Name = str; // we want to set name to this Person so we need to give str as the Parse method. 
            return person;
        }
    }
}
