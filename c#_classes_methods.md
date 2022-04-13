1.  Classes 

    1.1  an Application consists many classes and each class would present one behaviour of this application. 
        a class is simply a building block of an application 

        in a real world application like an blog engine>
        it has 3 layers> presentation layer which is for viewing of  application GUI.; business layer which also refers to domian layer like post action; database layer which also refers to persistence layer. 

        in each of these layers we could have many classes and each responsible for something particular. t.e.x in Presentation layer we could have one class called 
        postView and in our business layer we could have a class called post itself. in database layer we could have one calss called postRepository which for loading or fetching data from our database.

        These classes collabrate them eachother. 

        Anatomy of the class:
        * Data(represented by feilds)
        * Behaviour (represented by method and functions)

1.2 declare a class 
modifier + class keyword + name_of_class
t.e.x public class Person{}

Naming conventions:
Pascal Case: 
first letter of every word should be uppercase 
Naming: classes,.. fields of classes, 

camel Case: The first letter of words should be lower case then the firstwrd of other words should be uppcase. 
Naming: paramters of classes, object, 

in our real world we would not declare feilds inside classes with public. It will be private 

a method declared inside a class should have a return type. void means return nothing just execution. 

!!! The way to declare feilds

use var to replace specific type to define a variable. Complier would be able to recognize var as int, string or any other data type.

1.3 class members: 
*   Instance member: accessible from an object
   like fileds, methods 
   these calsses are members of calss and they are instansable classes.

* Static members: accessible from the class itself but not from the object of this class. 
like Console is a class from System namespace which is built-in .net framework. 
so when we use Console and call its method WriteLine. we do not create an object from it we just use Console class itself and call WriteLine()

These static classes are member of class but they are non-instanble classes. The static class could be decalred as a class as static instead of public. 
or static member also could be a public method inside one public class but it returns a static class. 
t.ex. 
public class Person

{   public string Name; //field
    public static Person Parse(string t)
    {
        var person = new Person();
        person.Name = t;
        return person;
    }
}

Why we use static members: well I think I have already known this, so we could present concepts that are singleton. like DataTime.Now. 

1.3 Constructors 

definition: A method that is called when an instance of a calss is created. It is excuted automatically once the class is created. 

why we need?
    The intention is to put an object in an earlier state that is to initialize some of the fields in the class. 

how?
a constructor of the class has the exact the same name as the class. that is the requierment 
for compiler to run. 
Not having any return type not even void 
public class Customer
{
    public Customer()
    {

    }
}

if it is empty in the construtor as above then it is a defult one. If you do not create an construtor of class when you define the class. CLR will create it automatically and it is default one . there is no parameter list in the constructor that you want to be excuted.
It will be in the IL or intermediate language dll file the result of compilation. 
and it will set fileds of this class to default value. any kind of numbers will be set as 0, boolean type are sets to false and any kind of reference types like strings or any other objects sets them to null, for charater sets to be empty char.
We usually need to initialze the constructor for reference type in the class otherwise they will be null. we have a example to show if we have a list of object in our customer class and we do not use constructor to initialize it as empty list. then we use this class in Program.cs and we add elements into the list. CLR will crash. Since we cannot add null type object to a list. 

but for vaue type we do not need to add constructor to inialize them. since they will be initialized as 0 or false. 


If we want to set value of feilds of this calss when the class is created. so we want to initialize these fileds. then we need to give these filed as paramters in the construtor. 


public class Customer
{   public string Name;
    public Customer(string name)
    {
        this.Name = name;

    }
}

!!! this keyword here is the reference of the current object, the current object means the object of class that we want to set paramter or filed value.
why we need to use this keyword? 
we use it to make sure we are assiging variable in a right way since we have two identification here and they have same spelling Name, and name with different naming convention. So we use this to clearly illustrate that we assign value to this field.

!!! Constructor Overloading
This means having a method by the same name but with different signatures. 
signatures means the same method name or constriúctor name but some of them has different paramters or no paramters, or different data type returns or different modifer. also the order of the paramter inside the method also matters,

public class Customer
{
    public Customer(){...}
    public Customer(string name) {...}
    public Custimer(int id, string name) {...}

}
// there are 3 construcors with same name but different signatures for the same class. 

why we need to do this overloading constructors?
*   to make initialization easier sometimes we may know only the name so we may use this constructor when creating an instance of this  

so if we do not declare ant constructor and also decalre a constructor with enmpty paramters. ¨
c# comlier will create a default one or set value to null or 0. 
but if we decalre several construcors with overloading way then it gives us more options to set values to our classes fileds. 

?? if we have 5 fields in class do we need to create contructors and also maybe use overloading to initialize them? 
No. we use constructor in classes where we really want to initialize an object at earliest.
The earliest state is the point. since we can change and assign values to feilds where we create the object somewhere in our code but this is not at very ealiest state. Thsi is the difference.

so when we really need to have constructor?? 
    * !!!! create a list of objects: Order is a class written in Order.cs
    public List<Order> Orders; // List is a generic class holding generic paramter. the paramter could be any type 
            //including the object type here Order. so it represents a list of objects and this paramter specifies the
            type of the object here. so we store the object types of Order. Order is the type of the objects.
            this generic class list is declared in System.Collections.Generic namespace in .net
            if we have resharper then when we type List resharper will load namespace generic for us automatically 

            // As a rule of thumb, when we have a class like here we have Customer class and the class has a list of objects. we always need to initalized that list to an empty list. 
            this is because we list has Add method and if we add any null variable to list it will crash the function.

?? then how should CLR know which constructor should be called to initialized the class when it has multiple overloading constructors?
*    The answer is so it depends what kind of onject you are creating on this calss. so usually if your class only has value type fields or some reference type like string and we also do not need to initialze at earliest state then we would not need to add any constructors in calss so when we create objects we could pass value to feilds or just leave empty using default values. 
when you create object with value to fileds then you must have constructors for these fileds that you pass value to regardless of what type of these fileds. 
so we class has no paramyer not like methods. So we usually do not write any constructor ourselves in class. This is also why when we create object on class we just use var obj1= new class1(); pass nothing inside. the class might have fields, we should not be able to pass them in parentheses if we do not create constructor there. 
we could assign value to these fileds later not when we create it. 



play with project ConsoleApp1 here: 
C:\Users\HZHSXR\Desktop\c#_\C-StudyNotes\classIheritence\excersise1\ConsoleApp1
Open it as folder(project) in visual studio



**************************************************
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1

!!! one class could be one .cs file under the same namespace along with other classes(.cs files) so one namespace would be one application.  

!!!! Refactor: change the structure of the code without changing its functionality ¨

!!!! we should not use pulic as modifier for calsses fileds so I need to learn more about when and how to use these scope modifiers.

!!!! run in debug mode with break point
move your mouse to the line you want to set break point and then ctrl+ F9-- set break point here 
then ctrl + F5 to run it with debug mode 
when we set breakpoint then the running will excute the breakpoint line and stop there and show our data

shift + F5 stop the debug 

!!!! switch betweeen opening .cs files window 
ctrl + tab hold ctrl but release tab. then use arrow key to select

!!! qiuck way to code Consol.WriteLine()
cw + tab +tab (click tab twice)

!!!! quick way to create constructor 
ctor + tab +tab 

!!! shortcuts: 
    ctrl + F7 stepinto // one step more 
    ctrl + alt +F7 step out //quit steps 
    ctrl + F9 toggle breakout point
    ctrl + F5 run debug mode 
    ctrl + R  run without debug 
    ctrl +s save 
    ctrl + B build solution  
    ctrl+alt + B rebuild solution
    ctrl +alt + C clean solution
    select lines: ctrl+K+C  comment these lines
    select lines: ctrl +K + U uncomment lines


*****************************************************



1.4 How to represent text as the sequence of UTF 16 unit ??
UTF 16 means NET uses UTF-16 to encode the text in a string . 
A char instance represents a 16-bit code unit. A single 16-bit code unit can represent any code point in the 16-bit range of the Basic Multilingual Plane. But for a code point in the supplementary range, two char instances are needed.
so two chars are one 16-bit unit. one is 8 bit : 64 bytes 1 bit 8 bytes
one char could be: H,  你， 

a string is a sequence of characters (e.g., the string "Hello, World!" contains 13 characters including letters like "H", "e" and punctuation like " ", "!" each character is actually represented by a number (e.g., "H" is represented by the number 72; this is its ASCII/Unicode value). 

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char

why zhang is not a sequence of UTF16 but ZHang is a sequence of UTF16



1.5 Object Initializers
in last part we talk about using consturctor to initialize fileds of calss at earileset state and also initialize the list of Object. 

we have another way to initialize an object as well ¨
it is called Object initialier.

what is it?
A syntax for quickly initialising an object without the need to call one of its constructors. 

why we need this?
aviod to create multiple construtors.

How ?
use curly braces when you creat object on class.

var person = new Person{ FirstName = "Huan", LastName = "zhang"};

so in this way we can reserve constructors for scenarios where we really need to use them: 



1.6 Methos

1.6.1 signature of methods
    public class point{
        public void Move(int x, int y){

        }
    }
    
    Move is the method of class point. 
    it has type of paramters and return type. 
    The methods params could be any data type, like value type, reference type like objects, srting,
    array...

1.6.2 Methods Overloading

     definition: Having a method with the same name but with different signatures: params orders, params data type. 

     Usages: you do not need to use overload your method but if there are cases where you can improve your code and make it easier for the cusumer of your method. Overloading is a technique in your toolbox. 

     practice: 1. create multiple methods with different signatures in class 
     2. but if you are overloading with similar data type with different number of params. then use Array to do so 

     see methods exercise: C:\Users\HZHSXR\source\repos\Methods\Methods\Program.cs

1.6.3 Params modifier(most used in c#)
params gives more option to pass value to methods when we call the methods. params are added where we do Methods overloading.
see methods exercise: C:\Users\HZHSXR\source\repos\Methods\Methods\Program.cs

1.6.4 Ref modifier

see example below. we need to avoid to use ref in our code. when we use ref as modifier in our method then for all consumer who will call this method and pass value to it we also need to add ref to be able to pass value. then it will not create a new allocation for the variable. it will oerwrite the original value. 
C:\Users\HZHSXR\source\repos\Methods\Methods\Program.cs

1.6.5 Out modifier






