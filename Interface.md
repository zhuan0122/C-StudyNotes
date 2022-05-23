# Interface (ctrl+shift+v tor review) 
![](Images/panda.gif)
## 1. what is interface?
: A languange construct that is similar to a class (in term of syntax)
use interface keyword and all name of the interface starts with letter I 
.  public interface ITaxCalculator{
  int Calculate();
  }

Unless calsses, inside interface it has no implementation. It only constains declaration.
Calculate has no body and curly braces and no access modifier. 
***!!!so interface memebers have no access modifiers 



## 2. Why we need Interface?
To build loosely-coupled applications.
that is an application which components are not tightly related to each other which mneans making a change in one of these components is easier and has zero impacts or less.

ike we define a chef that a restaurant needs with certain capabilities. BY THIS definition we could fill this role with anyone who has thoese capabilities. so the dependency between the restaurant and the chef is loose. 
In contrary if we define a restautant needs John as a chef that means the restaurant are very dependent on Johan this person or this calss. This is an analogy to explain that when building software we want our classes or our component to be loosely-related to each other. 

An intetrface is simply a declaration not a concrete class. 
Its methods or members does not have bodys. 
AS long as we keep this interface the way to use as in like we are not going to remove any its methods or change parameters. It is not going to have any impact on the order processor. 
If we diceide to change the algorithms for calculation of tax, we can create different classes that implement this interface here and that would have absolutely no impact on order prrocessor. 

* we could understand interface like this OrderPrice------->TaxCalculator. so this means OrderPrice is inheritating something from TaxCalculator t.e.x some methods or fields. but this will lead to tightly coupled application. How could we loose it. we could make OrderPrice-------->ITaxcalculator. This is a capital I followed by the calss name, then it becomes an interface and OrderPrice is depending on the interface not an concrete class now. Inside the interface, it only has some declaration of methods or members but they have no body so we only fill in the body when we create the specific class that implements this interface with concreate body. 

so when we have interface, as long as we keep its members like methods or not change its parameters. we will not affect any other calss which : to this interface. if we want to change the tax calculation way then we could create different tax calcultor methods which implements this interface here 

* declaration: declare 
* Implementation: concrete body 



## 3. Interface and testability 
 ### How to decalre and implement interface?
 One example to understand interface: 
 using System
 namespace Testability
 {
   public class OrderProcessor
   {
     priviate readonly ShippingCalculator _shippingCalculator;
     
     public OrderProcessor()
     {
       _shippingCalculator = new ShippingCalculator();
     }

     public void Process(Order order)
     {
       if (order.IsShipped)
        thorw new InvalidOperationException("This order is already shipped")
      
      //if the order is not shipped, we simply create a object type of shipment and assign it to the order's shipment property 
       order.Shipment = new Shipment
       {
         cost = _shippingCalculator.CalculatorShiPPING(ORDER),
         ShippingDate = DateTime.Today.AddDays(1)
       };

     }
   }

   ### in the same namspace Testbility 
   public class ShippingCalculator
   {
     public float CalculateShipping(Order order)
     {
       if (order.TotaPrice <30f)
       {
         retturn order.TotalPrice * 0.1f;
       }
       return 0;
     }
   }

   ### Under the same namesapce Testbility 
 }
  * class OrderProccesor and ShippingCalculator are coupled since we use ShippingCalcultor to instanitaed in OrderProcessor's constructor. so this is why we cannot isolate the ShippingCalculator calss. so when you are using unit test, you need to have a unit which has no dependency on any other class. 
  but we could solve this use interface to remove the dependency of these two class. 

   * remove dependency then unit test 

we create an interface of ShippingCalculator and make OrderProcessor inherites from that interface instead of the concreate ShippingCalculator calss itself. we have the method CalculateShipping method declared there. so interface defines the role's capability and any calss could fill in this role. It does not matter as long as the calss has the capability that defined in the calss. 
    * interface 
  namespace Testability 
  {
    public interface IShippingCalculator
    {
      float CalculateShipping(Order order); // one capability 
    }

    public class ShippingCalculator : IShippingCalculator
   {
     public float CalculateShipping(Order order)
     {
       if (order.TotaPrice <30f)
       {
         retturn order.TotalPrice * 0.1f;
       }
       return 0;
     }

     public class OrderProcessor
   {
     priviate readonly IShippingCalculator _shippingCalculator;
     
     public OrderProcessor(IShippingCalculator shippingCalculator)
     {
       _shippingCalculator = shippingCalculator;
       // why not? _shippingCalculator = IShippingCalculator shippingCalculator
     }

     public void Process(Order order)
     {
       if (order.IsShipped)
        thorw new InvalidOperationException("This order is already shipped")
      
      //if the order is not shipped, we simply create a object type of shipment and assign it to the order's shipment property 
       order.Shipment = new Shipment
       {
         cost = _shippingCalculator.CalculatorShiPPING(ORDER),
         ShippingDate = DateTime.Today.AddDays(1)
       };

     }

     public class Order
     {
       public int Id{get; set;}
       public DateTime DatePlaced {get; set;}
       public Shipment{get; set;}
       public float TotalPrice {get;set;}

       public bool IsShipped
       {
         get {return Shipment !=null;}
       }
       
      }

     public class Program 
     {
       public static void Main(String[] args)
       {
         avr orderProcessor = new OrderProcessor(new ShippingCalculatr);
         var order = new Order { DatePlaced = DateTiem.Now, TotalPrice = 100f} // this is initialize Order
        orderProcessor.Process(order);
       }
     }

  }
    * this ShippingCalculator(A) : IShippingCalculator(B) is not inheritance. inheritance means reusing code. here we are not reusing code here instead of we need to type code in our concreate class. we call it A implements B. 

    in OrderProcessor, we also need to remove dependency. So instead of define _shippingCalculator as an concreate ShippingCalculator. we want to be dependent on a role definition not concreate person or function.

    * We initialise the OrderProcessor field _shippingCalculator using creating an new object from concreate class ShippingCalculator. but we do not want this kind of dependency. So we use interface of this concreate class to initialize the filed.  
    
    * since we ininialize OrderProcessor's constructor with paramter of interface paramter. so we need to pass its concreate class which implements this interface like A above-

    * in C#, Main method is the matchmaker. It knows all conctrete type of calsses and ties them together. but none of these concreate type knows other concrete type's body or existence. 
    like in this case our concrete type OrderProcessor does not know the existence of ShippingCalculator. so if we change our methods or members in ShippingCalculator, it won't affect our OrderProcessor class. it only uses the interface which ShippingCalculator implements but any other calss who fulfilled the capability also can implement. 

    * one sulotion (one app / folder) could has multiple projects, so like Testability is one project, we could have another project. Testability.UnitTests. these two projects will be seperate. so you need to refere them in order to use one project's calss or method in another project. 

    * method declared in interface should be public. so interface defines the public interface or public service that calss provides. 



### Unitest 

  * what is the unitest
  you write code to test the peice of code without considering other codes outside of this current code part.
  the code peice usually is a calss unit. so when you need to test a class itself, we need to isolate it which means we need to assume any other calss in this application is doing their job properly so this is why we could write test around this calss. 
  we are focusing a single unit or functionality without dependency of any other parts,

  * we use microsoft unit test framework here. but it also could be x unit test framwork. Then the implementation could be slightly different but the conception will be same: isolate the calss you want to test using an interface then arrange some pre-conditions. we need to assert exception as attribute. 

  * two ways to run unit test in visual studio, one is using TEST > Run ctrl+R 
    or using Rehsaper > Unit test > Ctrl+Alt +R 

  * If we want to do unit test for your class in the project and this calss has dependency on other concrete classes then we could use interface of these classes inside the unitest class instead of using concrete classes directly. Through this way, we could recduce coupling and improve stability. 

 * Extract an interface from an existing class:
   what does this do? well if you have a concrete calss and you want to create its interface that declares all members that we have in concrete class. Instead of tying the interface yourself, you could use shortcut: click the concrete class > ctrl + shift + R: select Extract Interface then select all memvers that we have in concrete class so we need the declarions in interface without body implementation.

 * 
  

 ## 4. Interface and extendibility 
   
   we use interface to extend our class and functions 
   core> change its behaviour without changing its code. 


 ## 5. Inheritance vs Interface 
   one of the most common misconception is that we use interface to implement multiple inheritance.
   But this concept or recognition is fundamentaly wrong. Interface has nothing to do with inheritance. 

   in C# a class cannot have multiple super or base class. class A: class B, class C > errors 
   but we could make class A to implement multiple interfaces: class A : class IB, class IC ... 
   
   So class A has implemeted interface IB and IC so it will have concreate member implemetation that IB and IC has. t.e.x IB contracts two methods m1 and m2 inside the interface then class A implements IB through : syntax. Then class A will have m1 or m2 inside it with concrete actions. but should we have both? 

   what we can know is class A is not able to reuse code from IB or IC since there is no codes in IB or IC. they are just empty methods as contracts. what class A is doing is confirming to a contract that defined in IB or IC. 

   There is no access modifier in interface calss members. we implement interface members as public in our class A. 

   ## 6. Interface and Polymorphism 
   Interface has nothing related to inheritance but Interface does provide polymorphism. 

   ### 6.1 Use interface to achieve polymorphsim   
   

