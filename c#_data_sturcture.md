# C# 

### 1. Variable naming convention 
 * _mailService:  The underscore before a variable name _val is nothing more than a convention. In C#, it is used when defining the private member variable for a public property. For private fields of a class, you use _camelNotation. (Note the underline). property in c# is a class to get and set value for class fields. 
 * The name of classes and their members (properties, methods) follow PascalNamingConvention.
 * in C# name your local variable in the methods in camel case: t.e.x int number; but for fileds in a class which is outside of methods, it follows pascal naming convention
 * name your constant in pascal case: const int MaxZom=12;



*****************************************************************************************
when you are gonna run c# project in visual studio code or visual studo community. It is different. 
	* visual studio code 
	  Follow this to be able to run c# .NET project in visual studio code: https://code.visualstudio.com/docs/languages/dotnet
	  it runs project fast sicne it is lighter IDE. when you run project in .NET core. you need 
	  first to install .NET SDK in your computer then install c# in visual studio code extension 
	  och sen after you create a folder where you want to initialize your running envs with typing 
	  dotnet new console in command or git bash in this folder.This command will help us initialize 
	  our running ens and will create one .csproj and .cs files and one obj/ folder automatically
	  then programmer do progrmamming in .cs or create new .cs for each class. The main method is in 
	  the automatically created .cs. 

	* Visual studio:
	create project from visual studio we will be able to select .NET framework and c# as langauge directlly.
	for App type we also can select WPF as template then it will provide XAML as well for us to add controls and programming 
	with C# and XAML. 
	
//****************************************************************************************************************
1. UNDERSTAND what is .NET and C# relations 
2. understand what is ILC and why we need this when we work with C# 
3. why we need .NET when we work with C# to develop web or APP
so this also means what does .NET can provide as a framework 

4. what is relations of classes, namespace, assembly
assembly is the signle unit of complication?

5. what is primitive data type in C#?
In C#, The most famous primitive data types are: int, object, short, char, float, double, char, bool. 
They are called primitive because they are the main built-in types, and could be used to build other data types. 

5.2 does constant and vairables are different? 
In C#, constant fields and locals are not variables, a constant is a number, string, null reference, boolean values.

6. declare a variable in C# 
: (keyword) + data type + identifier(varibaleName)
keyword like const; void 
const and readonly are not data type so they are not beloging to primitive data type. 
const cannot be used to decalre all data type 
You’ll get this error in your C# code when you are using a const declaration on type that is not supported. 
In C#, const declaration can only be applied on specified primitive data types, enums and any reference types that is assigned a value of null.
the reference type that is assigned a value of null means it has not been assigned to any value before the decalration
https://developerpublish.com/c-error-cs0283-the-type-type-cannot-be-declared-const/#:~:text=In%20C%23%2C%20const%20declaration%20can%20only%20be%20applied,lets%20try%20to%20compile%20the%20below%20code%20snippet.


identifier: 
1. cannot start with an number
 2. cannot have white spaces. 
 3. cannot be a reserved keyword like int. if you are desperate to use a word that coincidentally clashes with one of the C-sharp keyword then you can use prefixe that with @
 sign 
4. always use meaningful names
5. naming convention 
 camel case: firstName. 
 pascal case: FirstName
 Hungarain notation: strFirstNmae: prefixed the name of the variable with the data type and then its uses (not recommendaed and used often in C#)
 ***************************************
in C# name your local variable in camel case: int number; and name your constant in pascal case: const int MaxZom=12; 

Correct! The name of classes and their members (properties, methods) follow PascalNamingConvention.

For local variables you use camelNotation which is common in Java. what is local variables in C#? variables are located in method. properities or fileds are outside the method but inside 
the class.

For private fields of a class, you use _camelNotation. (Note the underline).
********************************************************

7. C# is case sensitive language so the lowercase and uppercase varies 

you cannot use a variable until you initialize it. initialze means to assign value to the varible you have decleared
so declarition and initializtion are two things 

int number; # this is declarition
int number = 1; # this is decalarition and initialization


*********************
. what is primitive data type in C#?
In C#, The most famous primitive data types are: int, object, short, char, float, double, char, bool. 
They are called primitive because they are the main built-in types, and could be used to build other data types. 


8. Primitive data type 
often used primitive data type in C# 
intergral numbers: byte, short , int, long
real numbers: float, double, decimal 
character: char # decalre by single quote ''
boolean: bool

different DATA TYPE has different ablility to store the value how big it can store. 
1 byte has 8 bites and store value from 0-255 
short has 2 bytes -32678 to 32677

when you complie your application the complier internally will the c# data type keyword to equaivelant .Net data type keyword 
why this happen? where is the complier running? is it running in .NET envs or? 
.NET provides a compliation envs and classes? 
so how do we connect C# and our .NET framework? through compliler or visual studio? 
what does visual studio do in C#? 

mapping: 
c#                  .NET      Bytes                   range
byte                 Byte       1                      0-255
short                Int16      2                   -32678- 32676 
int                   Int32      4                   ...
long                  Int64      8                   ... 

float                 Single      4 
double                Double      8 
decimal                Decimal     16 
 
char                   Char         2                Unicode Character
boolean                 Bool         1                True/False


10. readonly vs const keyword in C#
https://www.geeksforgeeks.org/difference-between-readonly-and-const-keyword-in-c-sharp/

11. char lower case used as the alias in langaugge like c# 
it represents The System.Char data type is used to hold a single, unicode character. C# has an alias for it, called char, which you can use when declaring your char variables:
char ch;
Know more about char data type in c#
https://csharp.net-tutorials.com/data-types/the-char-type/

12 for real number you need to tell complier that this number is a float when you declare it 
with the suffix 
eg. float number= 1.2f ;
    decimal number= 1.4m;
	double number = 1.2; (defualt)
	
if you do not give the suffix then comlimer will take it as double since double is the default data type in c# complier for real number when 
the compiler is comliling 

9. Non-premitive data type 
String
Array
Enums 
Class 


13. Overflowing 
when the data value has exceeded the bundary of data type in C#
well by default in C'# we do not have overflow checking 
but this is not good for application so when this happens we need to avoid this 
we could add check keeyword to avoid this 
so basically we should know here if we add check keyword and its block in code the overflow won't happen and it will throw 
an exception but how to handle the exception it is the advanced topic and we will learn it later 


14. Scope 
what is sceope?
scope is where the varibale or a constant has meaning or accessible 
{
 byte a=1;
 {
  byte b=2;
  {
   byte c =3;
  }
 }
}

variable a is accessible anywhere inside the first big block and or any of its child block.
it is applied to variables b and c as well

15. decalre strings in double quotes while declare char in single quote
a string is a series of unicode characters 
a char is a unicode characters 

usually if we decalre byte using var instead of byte type keyword 
like var number=2 # compiler will take this number as int for this intergal number instead of byte 
but usually it is working with int 
if you know you just need byte then decalre it as byte numver=2; 

use Console.WriteLine to display different data type range in C# compiler 
eg. Console.WriteLine("{0} {1}", byte.MinValue(), byte.MaxValue()); this will show 0-255 range of byte in storage 
the first is the string format and 0 means will show the first object after this format and 1 is the second 

if you declalee the constant variable like const pi=3.14f; then you cannot change the value of this variable like pi=4f; compliing error pops up 



16. what is the requiered stesps to run an application program in C#?
should we build first then run(ctrl+F5) or we could run directly without buidling 

17. using System# here System is a namespace which containing nultiple calsses 

18. shortcut or trick 
type: CW + tab then it will show Console.WriteLine();


19. type Conversion 
implicit type conversion: 
Explicit type conversion casting aslso called 
Conversion between non-compatible type 

Implicit type conversion: you could easily copy a smaller byte data type value to a bigger one 
like byte a=1; int b = a; so a is assigned to b where b has 2 bytes a only has 1 byte so this works

byte a =1; # 00000001
int b= a; # b is 00000000 00000000 00000000 00000001

so implicit conversion has no data loss and compatible types 


int a=1;
byte b=a;
here it might lead to data loss when the data we want to store in b exceed the data range boundary. 
this is not always happening but it will. 
so like here 1 as  an int stored in byte it will have 3 bytes losses but it will be able to stored 
but if we have int as 300 then it will exceeed the boundary of byte

so if the complier detects that if there is possibility of having data loss then it won't allow the implicitly data conversion 
it will requeire explicit data conversion so user needs to tell the complier that you know they will might have data losses but you still want to do this
kind of data conversion then use the data type keyword 
byte b = (byte) a;  # this is explicit conversion. so if the a is 1 then casting works since it has no data loss but you must give explicit byte as prefix in the bracket
but if a is 300 then it out of boundary  so it will lead to data loss but it still can be complied just not correct complete value as output

float a=1.4f
int b= (int) a ; 


when the data type are not compatible like converting a string to an integer 
these two are not compatible so we cannot do explict conversion. we need to use the Convert class or the Parse method
Convert calss is the part of .NET framework and belongs to the System namespace 

Int32 is a .net framework data type mapping to int c# data type 
string i ="1";
int k = Convert.ToInt32(i) # i will be converted to Int32 in .NET data type why we need to Int32 not ToInt? I think this class Convert is the part of .Net so it uses data type of 
.NET

or 

int j = int.Parse(i)  # Parse is the method. all primitive data tyoe in C# all have this Parse method

often-used conversion: 
.ToByte()
.ToInt64
.ToInt32()
.ToInt16



21. click try and if we want to get the code snippet. just click tab or enter to get the try block 
the same as type cw+tab to get Console.WriteLine

how to avoid crashing or peventing application from Crashing if any exception happens. 

wrap the block of code with try catch 
then we just put our code in try block for monitoring. if something unexpencted undtag happens it will excute the code or action in our catch block 

so if we do not handle the exception the exception will be cathced by .net running time and will abort the running time 
so we need to handle the exception and make the running continued 


//avoid to have carshing if any exception happens
            try
            {
                var i = "1234";
                int b = Convert.ToInt32(i);
                Console.WriteLine(b);
                byte c = Convert.ToByte(i);
                Console.WriteLine(c);
            }
            catch (Exception)
            {

                // throw; comment or delete throw here why? explained in advanced course 
                Console.WriteLine("The number cannot be converted to a byte since it has overflow");
            }
			
22.C# operators 

2.1 Arithmetic operators:
		Add+, substract -; multiply *; divide /; Remainder %, 
		increment ++; decrement --
		
		* postfix increment : int a=1; int b= a++; >>> b=1 a=2. a++ is excuted after a is assgined to b 
		  prefix increment	: int a=1; int b= ++a >>> b=2, a=2 a is incremnetd by 1 so a is 2 and then assign a to b so b is 2 as well
		 
2.2 Comparison operators 
		* ==; !=; >=, <; <=; 
		
2.3 assign operator:

		* =; +=; -=; *=; /=; 
		a+=3 --- a=a+3 
		a/=3 -- a=a/3 
		
2.4 logical operator 
	
	&& AND; ||  OR; !a; NOT a 

& is ampersand, | is vertical line,! exclamation mark 

2.5 Bit-wise operator : used in low level programming 

	* & bitwise and 
	* | bitwise OR 
	


23. add comments in C# 

	* // prefix the code line with double slash  for single line 
	* multiple line comments /* */
	
	when to use the comments: explain whys, hows, contraints etc, do not explain what the code is doing
	since your code should be straightforward and clean and do not need comments 


24. does LR complier will complie the c# code to .net code? ??? in visual studio 
 like in c# code we declare the boolean as lower case as var or bool tt = true 
 but after build and run with .Net core it will give result as True with uppercase which is the data type in .Net framework 
 
 
 
 ************************************
 Non-primitive data type in C#
 **************************************
 1. Classes - related variables (attributes) or we call it as fileds  + functions (methods)
    
	instance of calss is called Objects 
	
	* how to decalare a class in c# 
	 access modifier + class keyword + idendifier(name)
	 eg. 
	 public class Car{
	   public string ss; // we also need to give access modifier for field inside the class 
	   
	   //methods need to give return type like void is often used as returning nothing 
	   public void Drive{
		Console.WriteLine("return nothing from this method")
	   }
	   
	   public int Add(int a,int b){
	   
	   }
	 }
	 
	 * how to create object from class 
	 Car car; // Car is the type of identifier car, where here object is the type of its class so we use Car as its data type just like int string what we have 
	 // used before as primitive data type 
	 
	 but we need to allocate memeory for object so we use new operator to create object
	 the correct one is :
	 Car car = new Car(); 
	 
	 *** buy not like C or c++ You do not need to worry about these allocating memeory sicne CLR or Common language runner will take care of that for you 
      it has a gabager collection will remove all of objects that are not used. 
	  
	  or use var keyword to replace Car type 
	  var car = new Car();
	  
	  ****************
	  static modifier 
	  
	  public class Calculator{
		public static int Add(int a, int b)
		{
		return a+b; 
		}
	  
	  }
     
	 // so we add a static modifer in our method. then 
	 we could access the method directly by calling the class itself. so we do not need to create an obejct to access the methods of the class
	 
	 int res = Calculator.Add(1,2);  // return 3 to be assigned to res 
	 **
	 
	 so this also means we cannot access static method from objects so we only can access static methods from class itself.
	 
	 
	 *** why we need the static method and what is the behind the scene? 
	 so if this filed or method has static as its modofier then it can only be accessed by class itself not any object. 
	 So this will avoid to have several place in memory where you use or call the method since you only need one place in memory to use the method 
	 but if it is accessible for objects then we could have several objects created from class then it will occupy multiple places in memory but actualy we might do not need it 
	 like the check date time method. we might want to check the current date whenever we want then we do not need to create objects when we want to check this will increase 
	 meomery occcupation, we just call class.method
	 
	 
	 ***When you want to create a class object then you use class_name + identifier = new class_name() then C# ussually suggest you to use var to replace the class_name to define it ***
	 
1.2.  ussally we could have a load of classes in the real world application. we will follow one class per file 
for example you have wrote two or more classes in one namespace but you want to move the class to create a file for one class 
then you have two ways to do so if you have rsharpe then lay your sensor on the class name and cilcik the hammer ico and select move to cs
it will create another .cs file to contain this class. Or you could use Solution expler. RIght click the name space and clicl 'ADD' > select class 

but note that all these classes created by default will be gathered inside one namespace. since c# organizes files, classes in this way
. recall it by scrolling up to review 
but we want to put all related classes in one namespace. if the class you create is not related to other classes inside the current namespace 
then what we could do is create a fodler and name it as expressive name and then click inside the calss, change its namespace as currentNamspace.Math t.example
teh folder created is under current name space. So one namespace is the gathering of applications. application could be presented as one folder it consists of all 
related classes files. one classes one .cs file. they are working interactively to contribute the application and then all folders togeters to contribute to the 
application(namespace) ?? correct comprehension? 

when you have put one class file or .cs file into another folder than it comes a sub-namespace of current namespace when you want to use this calss 
inside your current namesppace then you need to use 'using currentnamespace.Math' inside your current namespace file.

26 when we call Console.WriteLine(): WriteLine is the method we call directly on Console calss itself. what does this mean? because Console class is defined as 
static so we couold avoid to create to many objects to be able to access or call WriteLine method. In this case all methods in Console class are defined as 
static since we only need one Console calss when we run the application  

2. Non-premitive type: struct 
struct is quite similar to class with a few nuances. struct also combines related fields and methods. But in C# 90% of the time in the real world we use class to create this 
data type. these subtle difference between these two are non-pragmatic. when we use struct instead of class. 
when we need to create a light-weight or samll obejct then we use struct instead of class. since we might want to create 1000 objects of the struct 
or class then it will be better to use struct in terms of the efficeincy

DECLARE struct
public struct Mathh{}
like the rgb color here: 
public struct Rgbcolor{
	public int red;
	public int green;
	public int black;
}


//****************************************************************************************************************

3. Non-premitive type: Array 
what is the Arry?
Arry is the a data structure to store a collection of variables of the same type 
t.ex you want to declare 3 int 
public int num1;
public int num2;
public int num3;
    ^^^^^^^^
# use array instead 

int[] numbers = new int[3];// [] tells compiler that we want to declare an array; 3 sets the size of the array. so array has the fixed size with definition 
// and cannot be changed later. 
// new operator used here to declare the array since we need to allocate memory for the array 
// an array is an object behind the scene. in short in C# we have a class behind the scene called array and when we declare arry using the 
//syntax here it will tell compiler to create an object called numbers. it is the object of class arry. 

assign values to arry elements:
numbers[0] =1;
numbers[1]=2; // array starts with index 0 
or use the simplize way:
int[] numbers = new int[3] {1,2,3}; 

# when you need to display the array element. we need to display each element instead of just print numbers. 
# we use for loop to loop it or print it one by one using index 
if you do not assign values to the array element then it will assigned as 0 by default. 
if it a boolean arry then all initialized default values are false ;


//****************************************************************************************************************
4. Non-premitive type: Strings 
a string is a sequence of characters surrounded by double quote as opposed to Char we use single quote
string = firstname+"" + lastname; // concatenation with double quotes 
 string is a calss in c# it is static class so we have field and methods that could be called on string and avoid to create object to use them. 
 string has one method called format we use it alot to format the string 

 string name = string.Format(" {0} {1}", firstname, lastname )// the first "" is the template to show how we want to display our string. 
 inside the template we have placeholders they are indicated by curly bracket and they are 0 indexed. 

 # use join in string 
 var num = new inte[3]{1,2,3};
 string list = string.join(",", num); // array of object , , is a string seperator 

 # slice string element using index 
 string name = "huan";
 char firstCha = name[0]; // h 

 **********strings are immutable 
 so one it has been assigned and deifned and its elelments cannot be changed . 
 but there are methods in the sring class allows us to modify the string and its values but all these methods returns a new string
 so the original one is unchanged so it is immutable. 

 ### there are some escap char in c# to be used in string and have different meanings 
 \n: new line 
 \t : tab 
 \\: backslash 
 \' : single quotation mark 
 \" : double quotation marks 

 ### verbatim string: 
 so as we know in c# we type \\ to present backslah as \ recognized by c# compiler then this will make the string a liitle bit messy 
 as path variable: string path = "C\\desktop\\local\\c#_nmote\\new"

 then we could add a prefix to simplify it as string path = @ "C\desktop\local\c#\new" this is called verbatim string 


 ****
 when we decalre a string we use a keyword string with lower case of first char of string. this keyword is the non-premitive data type 
 string in c#. Compiler will map it to String calsses in our .net framework 

 so either:
 string name = "huan";

 or we use:

 String name = "huan"; // requieres System is imported in our .cs file at the top of namespace 

 therse two are exactly the same like 

 Int32 i =1; # .net data type Int32 
 int i =1; # c# keyword int 

 
//****************************************************************************************************************

5. Non-premitive; Enums 
 a set of name/value pairs (constant value) like dict
 t.ex. for the post comany they map different shipping method to different value to do calculation

 const int RegulationShip = 1;
 const int Express = 2;
 const PostNode = 3;

 replace this with enums:
 public enum ShippingMethod{

	 RgulationShip =1;
	 Express=2;
	 PostNode =3;
 }

 by defualt the enum elements are integer. if you want to specify it is byte then add it in declarion 
 public enum ShippingMethod: byte
 {

	 RgulationShip =1;
	 Express=2;
	 PostNode =3;
 }

 # use . notation to access enum elements
 var method = 	ShippingMethod.Express; 

 ### where should we declare the enums? inside the class? or inside the method?
 enum is a new type as class and struct we need to decalre it in the level of name space so it has the same indention as class type


 namespace ConsoleApp3
{
    // enum is a new type as struct and class we need to declare it in the namespace level 
    public enum ShippingMethod
    {
        Regular = 1,
        Express = 2,
        PostNode = 3
    }
 	internal class Program
    {

        static void Main(string[] args)
        {

            // var is a local keyword used inside the method and since ShippMethod is defined as 
            // public accessible method so we call it here is possible 
            var method = ShippingMethod.Express;
            Console.WriteLine("the messod is\t" + method);
            // method returns the element name in the enum if we want its pairing value we need to cast it to int
            Console.WriteLine((int) method);

			// cast int value to shipping method 
            var methodId = 3; 
            Console.WriteLine((ShippingMethod) methodId);

            //covert enum element to a string
            // in console even we do not use ToString method, console will also convert the method to string
            // but if we do not want to use console just explicitly convert the enum element to a string 
            Console.WriteLine(method.ToString());

            string meth = method.ToString(); // use var in local variable 
            Console.WriteLine(meth);

            // convert the string back to enum value : parsing new ter,. parsing in c# gets a string and convert it
            // to different type 
            var mm = "Express";

            // type of is defining the type we want to convert andShippingMethod is a new type 
            // this returns an object not the shippingmethod so we need to cast it to Shipping Method
            var shipping = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), mm);
            Console.WriteLine(shipping);
            Console.WriteLine(shipping.GetType()); // return type as namespace.ShippingMethod type 
        }
    }
}

### so the enum is a new type and we could take it as calss or struct 
we could convert enum element to be string and vice versa 
int and vice versa 


//****************************************************************************************************************

6. !!!!!!!!!!! reference type and value type
so far we have learned
primitive type: int, bool, float, char
non-primitive type: class, structures, arry (it is a class mapping to System.Arry in .net), string (it is class and mapping to System.String) 

so both arry and strings are class.

This lead to an interest topic> two main types in C#. so every type we have learned so far they are either classes type or structures type
so sturectures: primitive types(int, bool,... these are very small class it takes no more than 8 bytes. So we 
call it as sturctures like GDBColor) + Custom structures 

Classes: Arrays + strings + custom classes 

In C# these classes and structures are treated differently in terms of memory management.!!!!! this will be covered below.

************************Understand what happens under the hood in the memory! you when you program does not behave as what you expect then 
you will be able to troubleshoot it. 

in C# structures >> Value type including primitive type + custom structures 
      classes >>> reference type  including Arrays, strings, custom classes 

so in C# we call Structures as Value Types! for value types when we define them in C#, a part of memory called stack is allocated automatically
when the variable is growing like int when it is out of scope it will be immediately removed from stack by run-time or C-L Runner

while with reference type, you as a programmer needs to allocate memory yourself. t.e.x we use new operator to define classes or instance 
of classes. object created from classes is class as well. so when we use this new operator we tell run time or CLR to allocate memory for 
this variable. This happens from a different area of memory called heap memory. this meomry is more sustainable versus stack.
so if you created an object and it gets our of scope. it will continue to exsit in heap for a while and not be removed immediately. There is 
a class called garbage collection that is done by run time or CLR who is taking care of this.so once in a while, CLR will look at objects 
that are not used and will remove them from our memory heap

in pragmactic terms you need to know is when you copied an object to an new variable depending on the variable is reference type or value type 
there will be two outcomes and we could see in code to deepen the comprehensions. : var oldobject = anotherObject. ask youself what is the
type of the anotherobject.

7.för varibale som är typ av värde, när du kopirera variale a tilldelas variable b. Så en ny tilldeling i minnes stack är skapade and lagrade 
variable a's värde. variable a och b i minnes är helt oberoende. om du ändrar värde i a som ska inte påverka värde i variable b. 

men för reference typ variable, när du skapar en ny variable kallas arr1 med new operator som ska skapa en heap i minnes och lagrar värde av arr1 
arr1 är lagras i stack och det pekar på värde i heap i minnes.  arr1 -----> {1,2,3} och sen du kopirerar arr1 till arr2. Annan variable arr2 skapas i stack minnes som lagras i 
samma minnes som variable arr1. arr2 pekar på heap värde också. arr1 och arr2 i stack håller minnes adress var vi lagrar värder. arr1 och arr2 har samma adress 0x004416A till example.

detta adress är adress på heap så alla variable som pekar på samma heap värder i minnes har samma adress lagras. 
så när du ändrar vårt heap värde element via arr1 eller arr2, ändringarna är synliga genom andra variabler. Så alla variable som pekar på den adress har värder ändras också. 
de är inte oberoende kontra värde typ variable som vi beskriva/ förklara ovan. när du koperira arr1 tilldelas varible b, du kopirerar adrss
inte värder. 

So in demo, we create two type variable. first we have one class called Person. it has 2 properities as names and age. 
this class has two static method we define it as static since we want to use Person class to call it directly instead of creating object
first then call methods. 

then in the main method in program class we create value type variable number which is int type and initilaze it as 1 in main method. 
then pass it in Person.Increment(number) method where the paramter will be increased by 10 without return. Then print number in main 
we find it is still 1. so nothing changed in this number address. because when we create the number in main, it has the same name as 
the method paramter but they are indepent, CLR allocates another separate memory in statck for this number in main. 
if we want to see the increased value as 11, then we need to define the static return type as int instead of void in Person class 
then copy its return to variable number. then it will be changed as 11. 

for reference type, so we have another static method in Person, it is called MakeOld, it takes class or objects as paramter, then it will 
increase Person.Age by 10. we create a reference type variable huan2 in main, why it is referece type? since it is copied from class 
Person() and initialize age as 20. Then we pass huan2 object to method MakeOld, it will change age as 30. when we print out huan2.Age, 
it will be 30. since huan2 and Person points to the same adress of heap where we store value 20. // Age as first name are properties of class Person, and they are not static
            // we cannot use class to call them we need to create objects first then call them. while we could use static to define age



???? how about to add static to properties in a class? then how could we decalre objects from this calss? it is possible to create 
objects from class if it has static property? 


//*********************************************************************************


8. Control flow in C#

8.1 Conditional statement -- control the program flow 

	8.1.1 If statement 
		if (condition)
		{
			action // only one line code here then curly braces are not requiered but if it has several code lines here then use curly braces 
		}
		else if (condition)
		{
			action
		}
		else 
		{
			action
		}

		!!! nested if statement is avaliable but not recommended to use multiple nested if statement. it makes the code hard to read and understand and hard to 
		test. 
	
	8.1.2  Switch statement - we compare variable values instead of conditions in if statement

		switch (role)
		{
			case role.Admin:
				...
				break;
			case role.Actor:
				...
				break;
			default:
				...
				break;
		}

		!!! in the example above, role is an enumeration. so we check the role, in case of Admin then excute block. If it is none of the cases then perfom 
		default  block 
		In C# 6, the match expression must be an expression that returns a value of the following types:

                a char.

                a string.

                a bool.

                an integral value, such as an int or a long.

                an enum value.

                Starting with C# 7, the match expression can be any non-null expression.
		
		!!! The requirement in C# is that the end of every switch section, including the final one, is unreachable. 
		Although this requirement usually is met by using a jump statement, 
		the following case also is valid, because the end of the statement list cannot be reached. what does this mean? It means the code will be finshed and jump out from 
		switch section before we reach the end of section. so we always needs brake or other jump statement in each case statement including the final default otherwise 
		the code will be possible to reach end of the switch section which is not allowed in c# for switch 

		!!!! if you want to use or case in switch like the expression value could be either one of case it will print out in console else it will be default case 
		int m = 5;
            switch (m)
            {
                //case 1 or 2 or 5:
                case 1:
                case 2:
                case 5:
                    Console.WriteLine("this is the valid or case selection so it will come here as long as it is one" +
                                      "of them");
                    break;
                default:
                    Console.Write("heyyyyyy");
                    break;
            }
		// out put: "this is the valid or case selection so it will come here as long as it is one" +
                                      "of them"

	
	8.1.3 Conditional operators - a short way of expressing if and else 

		a?b:c // if a is true then b else return c. so a could be a boolean or an condition 

	Exercise:
	Conditional.cs 

9. Iterantional statement

	9.1 for loop 
		for (var i=0; i<10; i++):
		{
			statement; 
		}
    
	9.2 foreach statement -- loop over element in an enumerable object. what does eumerable mean? well it means anything that has kind of list or array nature.
	so far we have learned enumerable objects are arrays + strings. A string is a sequence of Char(character). An array is a list of any type variables. it could be 
	an array of string, an array of int... 

	use foreach loop to replace if statement will make our code cleaner tighter. 

	9.3 while loop, 
		while (i<10)
		{
			statement;
			i++;
		}
	
	9.4 do while loop: slightly different from while loop. Do while performs action before checking condition so it will excute action at least once
	do 
	{
		statement;
		i++;
	}
	while (i<10);
	
	!!!! so when we use while loop versus for loop. when we do not know how many times the code will be exactly executed. we use while loop 
	like 
		while(true)
		{
			statement;
		}
	t.ex .
			// when we do not know how many times the code will repeat we use while loop instead of for loop
            // for example we use to read user's input 
            while (true)
            {
                Console.Write("Please type your password:");
                var input = Console.ReadLine(); // returns the string

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("@Echo" + input);
                }

10. jump statement 

break: jumps out of the loop 

continue: jump to the next iteration 


11§. Ramdom class -- a useful class in .net framework 


12. List and Collections
