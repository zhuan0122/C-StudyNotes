using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
    
{ internal class Program
    {  
        private static class Book
        {
            //this is a static class called Book. when t has method and we call its method without istance of this class. 
        }
        private static void Main(string[] args)
        {                                                                       

            var p1 = Person.Parse("MY NAME IS WORD");
            p1.Introduce("zha"+"ng");
            p1.Introduce("HELLO");
            p1.Introduce("ZHang");
            //var p1 = new Person();
            // Console.WriteLine(p1.Name)
            var customer1 = new Customer(1, "hu"+"an");
            var customer2 = new Customer(2);
            //var customer3 = new Customer("hya"); // this is not available since there is no mapped constructor.
            var customer4 = new Customer();
           // customer4.Id = 4;
            Console.WriteLine(customer1.Id);
            Console.WriteLine(customer1.Name);


        }
    }
}
