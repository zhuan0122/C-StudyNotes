

using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Customer
    {
        //private int Id;// if I define it as private then I cannot use it in another .cs file or in main method 
        //private string Name;
        public int Id;
        public string Name;
        //create a list class ävriable 
        public List<Order> Orders; 
        // List is a generic class holding generic paramter. the paramter could be any type 
        //including the object type here Order. so it represents a list of objects and this paramter specifies the
        //type of the object here. so we store the object types of Order. Order is the type of the objects.
        // this generic class list is declared in System.Collections.Generic namespace in .net
        // if we have resharper then when we type List resharper will load namespace generic for us automatically 
    
        //3 constructors with same method name and different signatures

        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
        // Before CLR call Customer(int id) constructor. it wll call the Constructor without parameter
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            // Before CLR call Customer(int id, string name) constructor. it wll call the Constructor without parameter
            : this(id)
        {
            //this.Id = id;
            this.Name = name;

        }
        // above avoid to add List order initializing in all constructor. we use this keyword. So this() represents the constructor() without any paramter
        // this(id) represents constructor(int id). 
        // we could use this keyword to do this. But this will increase unconvinience of maintanience of codes since we need to 
        //trace several this keyword.

        // in practice we only keep the constructor that we really want. So we need to initialze the list of order to be empty
        // otherwise it is null reference for any object created from Order class
        // the compile will crash. 
    }   // so in practice we only keep the first 
}
