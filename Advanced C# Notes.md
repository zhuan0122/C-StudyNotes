## Advanced C# Notes 
* object is the parent class for all .Net type classes. 
* object as a class it has several built in methods: ToString, GetType...
  
## 1. Generic class 
* what problem that generics is gonna to solve?
  I think we use Generics class to avoid duplicate class. for exaple you want a NumberList calss then you create it as>
  
  * using System;
    namespace Generics{
        public class List{
        public void Add(int number){
            throw new NotImplementationException();
        }

        public int this[int index]
        {
            //this is the class itself, here means if you call index as List[0], it will return the number at given index
            get { throw new NotImplementredEXception();}
        }
        }
    }
  
  * but if you changed your mind and you need to store book in this list then it is not allowed since the list above only for numbers. so we need to create another list and store books.
  
  public class BookList{
        public void Add(Book book){
            throw new NotImplementationException();
        }

        public Book book[int index]
        {
            //this is the class itself, here means if you call index as List[0], it will return the number at given index
            get { throw new NotImplementredEXception();}
        }
        }

* so every time you need a new data type of list you need to create a new list and it is duplicative and not productive. 
  one soöution to this is using list of objects since object is built-in parent class and could be inherited by any type in dotnet. but there is drawback for using object. tex you use it to add int and  the value will be boxed as object first and then when you get it it will do un-boxed. This will bring performance penalty. The same to reference type to an object and vice versa, it leads to performance penalty with casting. 
  * Object
  public class Objectist{
        public void Add(object value){
            throw new NotImplementationException();
        }

        public object this[int index]
        {
            //this is the class itself, here means if you call index as List[0], it will return the number at given index
            get { throw new NotImplementredEXception();}
        }
        }

* so Generics came to solve these duplication problems without performance penalty
  with Generics we created a class once and reuse it multiple times. usually class has no parameters, class's method and construct will have paramters in ()- for Generics class it has parameter and stores in angle brackets <>, we ususally put T in <T> T is short for Template or Type. so in Generics class, it is the T and means it could be any type when you call this calss somewhere and gives T to one specific type that you need like int or Book type above

  public class GenericList<T>
  {
        public void Add(T value ){
            throw new NotImplementationException();
        }

        public T this[int index]
        {
            //this is the class itself, here means if you call index as List[0], it will return the number at given index
            get { throw new NotImplementredEXception();}
        }
        }

 class Program
 {
     static void Main(string[] args)
     {
         //create a number list and add int to it using Generics
         var numbers = new GenericList<int>();
         numbers.Add(0);

         // using Generics to store book 
         var books = new GenericList<Book>();
         books.Add(new Book());
     }
 }

 In practical terms most often you will be using generics from dotnet opposed to creating ones.
 using System.Collections.Generic.... it will be able to import many Generics
 List is one of them as using.System.Collections.Generic.List..

 * we could learn more about Generics class parameter <T>. we could have multiple paramters. one use case of this is for dictionaries. A dictionary is a data structure that uses a hash table to store and retreive objects. so how does generics dic look like?

// you could use <U, V> here but using a descriptive name would be helpful for readness
  public class GenericDictionary<TKey, TValue> 
  {
        public void Add(TKey key, TValue value ){
           
        }

        public T this[int index]
        {
            //this is the class itself, here means if you call index as List[0], it will return the number at given index
            get { throw new NotImplementredEXception();}
        }
        }

  // use it 
  var dictionary = new GenericDictionary<string, Book>();
  diactionary.Add("122333", new Book());

so in conclusion, <T> is type of Generics and it shows no limitation. any type could be passed there. 

* what about the type limitation or constraints of Generics? 
  if you do not want any type is able to sent here then you could set constraints for Generics parameters. also T is any any type, it will be taken as object as well. 
  tex.
  
  public class Utilities
  {
      public int Max(int a, int b)
      {
          return a > b ? a : b;

      }

      //above is how we usually do comparsion. but for Generics, if we do so as 
      public T Max<T a, T b>
      {
          return a > b ? a : b; 
          // these will lead to error as non-comparable between a and b since the compiler does not know the type T and it thinks  a and b are both objects so it has no comparable methods. a and b have several methods that are from object class. so we want to both a and b implement the comparable interface which provides a method called compareTo. so this is a use case that we need to apply a constraint to <T>. we use where statement.  
      }

       public T Max<T a, T b> where T : IComparable
      {
          return a.CompareTo(b) > 0 ? a : b;
      }
  }

  Where is following after method?? well  aGeneric method inside a non-Generic class is perfectly fine. so where is following after generic method T Max, it is okay but potentially we could move the contraints to class level as 

  public class Utilities<T> where T : IComparable // where T is comparable or T is implementing a comparable interface
  {
      public int Max(int a, int b)
      {
          return a > b ? a : b;

      }

      //above is how we usually do comparsion. but for Generics, if we do so as 
      public T Max<T a, T b>
      {
          return a > b ? a : b; 
          // these will lead to error as non-comparable between a and b since the compiler does not know the type T and it thinks  a and b are both objects so it has no comparable methods. a and b have several methods that are from object class. so we want to both a and b implement the comparable interface which provides a method called compareTo. so this is a use case that we need to apply a constraint to <T>. we use where statement.  
      }

       public T Max<T a, T b> 
      {
          return a.CompareTo(b) > 0 ? a : b;
      }
  }

  #### type constrains
  there are five types constarints for Generic paras. 
   * where T : IComparable -- T is comparable or is implementing a comparable interface. so this is a constraint to a interface
   * where T : Product -- constraints to a class Product, so T is a product or any of its children/ any of its subclass
   * where T : struct -- T should be a value type 
   * where T: class -- T has to be a reference type
   * where T : new() -- T is an class that has a default constructor the constructor is defined inside the new(). so T become instantitable. 

* exapmles for constaints to Product
public class DiscountCalculator<TProduct> where TProduct : Product
{
    public float CalculateDiscount()
    {
        return product.Price;
    }
}

*exapmles for constaints to a value type 

public class Nullable<T> where T : struct
{
    // in c# a value type cannt be null so an integer should have value 0,1,2... so we could use this class to give our value type like struct the ability to be nullable
    // also if we define fileds or proverty as object type when we return this somewhere we need to cast it to spefic type that we want since object could be any type and it is implicit.
    //The underscore before a variable name _val is nothing more than a convention. In C#, it is used when defining the private member variable for a public property.

    // store nullable value as an object. _value is a field
    private object _value;

    //constructor
    public Nullable(T value)
    {
        _value = value
    }

    // this is a property with get/set in the class 
    public bool HasValue
    {
        get {return _value != null} 
    }

    // this is a method
    public T GetValueOrDefault()
    {
        if (HasValue)
        {
            return (T)_value; // (T)  is casting _value to type T
        }

        return default(T); //default is a keyward to get default value of a class. and default value depends which type you send when you use this generics. see below int has 0 as default value if it is null 

    }
}

// useage 
public Program
{
    static void Main(string[] args)
    {a
        var number = new Nullable<int>(5);
        Console.WriteLine("Has value?" + number.HasValue);

        var number2 = new Nullable<int>();
        Console.WriteLine("value" + number2.GetValueOrDefault());

    }
}

* in dotnet framework, it has its builtin nullable struct in System.Nullable<T> 

* exapmles for instantiate an instance of T or T has a default constructor 
  
  public class Utilities<T> where T : IComparable, new()
  {
   // T : new() adds constraints to an object with its constructor so you could instantiate T as:
   public void DoSomething(T value)
   {
       var obj = new T(); // new is keyword when you want to create a object from a class. T is the type it is an object. compiler does not know exactly what type T is refering to 
       // al it knows is that T should implement IComparable interface. if you want to instantiate T here like call new T(), you need to a default constructor. apply a second constraint after IComparable. 
   }
  }
  

## 2. Delegate> a reference to a group of methods
 A delegate is a type that represents references to methods with a particular parameter list and return type.
   When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. You can invoke (or call) the method through the delegate instance.

Delegates are used to pass methods as arguments to other methods. **Event handlers are nothing more than methods that are invoked through delegates.** You create a custom method, and a class such as a windows control can call your method when a certain event occurs. The following

 example shows a delegate declaration:
public delegate int PerformCalculation(int x, int y);

**Any method from any accessible class or struct** that matches the delegate type can be assigned to the delegate. The method can be either static or an instance method(static means cannot be instanitated). This flexibility means you can programmatically change method calls, or plug new code into existing classes.

* Delegates 
    * a delegate is An object that knows how to call a method or a group of methods
    * a delegate is A reference or a pointer to a function 
  
  A delegate is an instance of a type that derives from MulticastDelegate. 
  This class provides the ability to call one or more methods.
  Func is a delegate that represents a method that returns a value. 
  Func<float, float> can be used to store a reference to a method that gets an argument of type float, and returns a float
  
* Why do we need delagates or why do we need the reference or pointer to a group of methods or a function
   * For designing extensibke and flexible applications eg frameworks
        * so forexample you have designed a framework which is used to process photo and in the framework you defined the class called PhotoFilter which cintains several methods like ApplyBrightness(), ApplyContrast... when you release your framework, everytime any people wants to add a new filter that you did not apply then you need to come back to code and add it and recompile and release it again.  WITH delegates, we can make the framework extensiable such that a developer can create their own filters without relying on you. <span style="color: red">The same problem can be solved by Interfaces using some kind of polymorphism. Polymorphism is introcuded in inetrmediate course. here we will learn how to use delegate to achieve this. </span>
        
* Delegates have the following properties:

Delegates are similar to C++ function pointers, but delegates are fully object-oriented, and unlike C++ pointers to member functions, delegates encapsulate both an object instance and a method.
Delegates allow methods to be passed as parameters.
Delegates can be used to define callback methods.
Delegates can be chained together; for example, multiple methods can be called on a single event.
Methods don't have to match the delegate type exactly. For more information, see Using Variance in Delegates.
Lambda expressions are a more concise way of writing inline code blocks. Lambda expressions (in certain contexts) are compiled to delegate types. For more information about lambda expressions, see Lambda expressions.

* How to use delegates to make the example above or the process photo framkework extensible so other developer could add any other proccesing 
  method themselves. 

  first we need to define a delegate type method. method will have its signature. so recall what is signature? 
  A method signature is a unique identification of a method for the C# compiler. The signature consists of **a method name and the type and kind (value, reference, or output) of each of its formal parameters.**  **Method signature does not include the return type.**

  remember we use delegate to handle event but we do not care about what kind of event it is as long as the event or method since every event is one method has the matched type to our delegate parameter type. so **When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. You can invoke (or call) the method through the delegate instance.**

  see our example: 
  first without delegate, we have following photo process framework

  public class PhotoProcessor
  {
      public void Process(string path)
      {
          var photp = Photo.Load(path);

          var filters = new PhotpFilter(); // PhotoFilter is a class having all implemented filter m 
          //methods like ApplyBright; ApplyConstrast...
          filters.ApplyBright(photp);
          filters.ApplyConstrast(photo);

          photo.Save();
      }
  }

  so with the framework above, it is not extensible,this means developer orour customer who is using this framework cannot add any other filter themselves. then we always need to add it into our PhotoFilter calss and then recompile and release again. 

  ****************
  But we could use delegates to solve this problem. why throuh deledates, customer can add filter themselves? this is because delegates could have any method or struct as its paramter as long as their type matchs delegate signature type. then this provides flexibility to change the method call or plug in new code in a consumer defined method with mathcing type and then pass it to delegate instance and then delegate instance can invoke this new added method. 

  we use delegates to codes above:

  // its handler now so regardless of which processing method it is
  public class PhotoProcessor
  {
    public delegate void PhotoFilterHandler(Photo photo);
  
  //pass delegate to thsi method to make it extensible. delegate is thepointer to group of methods 
  // here it is group of filter methods,they are definable by any developer \n
  // <span style="color: red;">PhotoFilterHandler is the delegate type or a deleate. filterHandler is the instance of delegate PhotoFilterHandler. </span> 

    public void Process(string path, PhotoFilterHandler filterHandler)
    {
        var photo = Photo.Load(path);
        
        // this handler did not know which kind of filter is gonna to apply on the photo and it does not 
        // care so even developer defined their own new filter which is not in released framework, the framework is no need to be recompiled and released again. developer can apply any filter through 
        //delegate instance in user interface. it is in their Main methods where they use this framework 
        filterHandler(photo); 

        photo.Save(); 
    }
  }

// here we take this Main method as where the developer or customer where they use the framework above 
//  <span style="color: red;"> filterHandler is our delegate instance and it is pointed to ApplyBright. we could make it points to more methods </span>
class Program 
{
    public void Main(string[] args)
    {
        var processor = new PhotoProcessor(); 
        var filters = new PhotoFilters(); 

        //instantiate delegate: point delegate to a method 
        PhotoProcessor.PhotoFilterHandler.filterHandler = filters.ApplyBright;
        filterHandler += filter.ApplyConstarst; // now our delegate points two filter methods 
        filterHandler += RemovedRedEyes; // points to RemovedRedEye filter but this method is not in our filters object since it is added. 
        proccessor.Process("photo path", filterHandler); 
    }

    //user can define their designed filter methods here not necessary to be in released framework 
    static void RemovedRedEyes(Photo photo) // same paras type that our delegate type has so this method could be passed to our delegate too
    {
        // remove red eyes codes here 

    }
}

* ### what happend under the hood when we create delegate? 
  
  every delegate we create using delegate keyword is essentially a class and drived from System.MultiCastDelegate 
  when you delegate only points to one method or function, it is delegate. when it points to several methods then it becomes multidelegate 
  and delegate can use append like a string by using '+'. 

  <span style="color: red;"> instead of creating custom delegates using delegate keyword as we did above, we could use our dotnet built-in delegates they are generic class and they are Action and Func</span>

  System.Action -- non-generic delegate zero argument
  System.Action<> -- generic delegate 
  
  similar as System.Func , System.Func<>; 

  the diff between Action and Func is Action returns void with olika numbers of paramters. Func returns a value type. 
  so we use it based on needs. 
  
  #### chane our code above using built-in generic delegates. we return void type above so we use Action<> to replace our custom delegate
using System;
namespace delegate
{
  public class PhotoProcessor
  {
     // remove custom delegate 


    // Action<Photo> is our delegate type 
    public void Process(string path, Action<Photo> filterHandler)
    {
        var photo = Photo.Load(path);
        
        // this handler did not know which kind of filter is gonna to apply on the photo and it does not 
        // care so even developer defined their own new filter which is not in released framework, the framework is no need to be recompiled and released again. developer can apply any filter through 
        //delegate instance in user interface. it is in their Main methods where they use this framework 
        filterHandler(photo); 

        photo.Save(); 
    }
  }
}
// here we take this Main method as where the developer or customer where they use the framework above 
//  <span style="color: red;"> filterHandler is our delegate instance and it is pointed to ApplyBright. we could make it points to more methods </span>
class Program 
{
    public void Main(string[] args)
    {
        var processor = new PhotoProcessor(); 
        var filters = new PhotoFilters(); 

        //instantiate delegate: point delegate to a method 
        Action<Photo> filterHandler = filters.ApplyBright;
        filterHandler += filter.ApplyConstarst; // now our delegate points two filter methods 
        filterHandler += RemovedRedEyes; // points to RemovedRedEye filter but this method is not in our filters object since it is added. 
        proccessor.Process("photo path", filterHandler); 
    }

    //user can define their designed filter methods here not necessary to be in released framework 
    static void RemovedRedEyes(Photo photo) // same paras type that our delegate type has so this method could be passed to our delegate too
    {
        // remove red eyes codes here 

    }
}

#### how to decide to use interface or delegate to achieve flexibility or extensibility? 
    * use a delegate when
        *  An eventing design pattern is used. 
        *  The caller doesnot need to access other properties or methods on the object implementing the method. this means in our example the caller is our delegate instance filterHandler and it only needs to access or point to methods. if we need to access ther properties and methods in Filter objects then delegate won't work then we need to use interface. 
.


## 3. Lambda experession : arg => expression or (arg1, arg2) => expression

### 3.1 what is lamda expression?
Lambda expresssion is an anonymous method without modifier/name/no return statement. 
less code and do the same thing. => this is lamda opertor 
syntax: arguments(paramter) => expression 
    * ex1.
    return number square: number => number * number; without specify modifier as staic or public and no return statement 
    but we need to assign lambda expression to a delegate, we have many built-in delegates in dotnet. so refresh our memory we have two normal built-in delegate used in .Net
    Func<> and Action<>. here we need to out result so we need to use Func<>

    Func<int, int> -- since we take int as paras and return int. 
    Func<int, int> square = Square;
    Func<int, int> square = number => number * number; // square is the delegate name, it is generic delegate Func type and it points to our Square method where we do square calculation
    but we repalce Square to Lambda expression. 

    so remember lambda will work with delegate together??? or 

    if you have multiple args in at the left side then put them in the () as (x,y,z) => expression; 
    Lambda expression has access to all arguments at the left side and to all local variables defined in the metod where we write the Lambda expressions. 

### 3.2 Pratical use case of Lambda expressions 

example: return books with price less than 10. 

namespace LambdaExpression
{   public class BookRepository
{  // BookRepository object has method GetBooks and this method returns List<Book> as the data type which is a collection
    public List<Book> GetBooks()
    {
        //object initializing syntax
        return new List<Book>
        {
            new Book() {Title = "Title 1", Price = 5},
            new Book() {Title = "Title 1", Price = 7},
            new Book() {Title = "Title 1", Price = 17},

        }
    }
}
    class Program 
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks(); // books is a collection or generic list types of list
            
            var cheaperBooks = books.FindAll(IsCheaperThan10Dollars); //cheapBooks are elemetnt in collection that satisfy the condition

            forach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}

--- so FindAll here like any Find method they are from collection object books here. These Find/FindAll/FindLast .. is used for filtering collections. 
FindAll method accepts predicate as  argument. </scan style = "color: red"> **Predicate is always follwoing with collections. A predicate is basically a delegate which points to a method and returns a boolean value specifying if the given condition is satisfied.** </scan>

here IsCheaperThan10Dollars is the predicate. Predicate<Book> match: List<Book>. so IsCheaperThan10Dollars is our delegate and have itis defined delegate type Book as paras and return boolean by checking the condition. 

* refactor code above usig Lambda expressions 

namespace LambdaExpression
{   public class BookRepository
{  // BookRepository object has method GetBooks and this method returns List<Book> as the data type which is a collection

    public List<Book> GetBooks()
    {
        //object initializing syntax
        return new List<Book>
        {
            new Book() {Title = "Title 1", Price = 5},
            new Book() {Title = "Title 1", Price = 7},
            new Book() {Title = "Title 1", Price = 17},

        }
    }
}
    class Program 
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks(); // books is a collection or generic list types of list
            
            var cheaperBooks = books.FindAll(b => b.Price<10); //cheapBooks are elemetnt in collection that satisfy the condition

            forach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
        
        // we use Lambda expression to replace this method as the predicate 
        <!-- static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        } -->
    }
}

## 4. Event and delegates
### 4.1 Events 

    * A Mechanism for communication between objects> so something happend in one object it can notify other objects about this change
    * Used in building Loosely coupled applications 
    * Helps extending applications 
 
### 4.2 Use case 
for example we have one class called VideoEncoder and it will encode videos and then our customer will recieve the service email every time we have encoded any video. 
so inside this VideoEncode calss we have one class called SendEmailService class to send email to customer. bUT HOW about the customer wants to receive text instead of email. 
then we need to add another code to send text message when video is encoded. then recompile so it brings unconvenience and efforts. 

so how could we solve this by events? 
so we could make our VideoEncode as publisher or event sender so it will publish an **event** called videoEncoded when it encodes any video. Then make the MailService class as subscriber or event receiver to that event. <span style="color: red;"> So the point is VideoEncode knows nothing or the exsitence of MailService class and this means we can esaily add a new class called TextService to subscribe to the videoEncode event of VideoEncoder. we do not need to redeploy and recompile videoEncoder </span> 

codes:

public class VideoEncoder
{
    public void Encode(Video video)
    {
        //Encoding logic

        onVideoEncoded(); //event to simply notify our subscribers. add more subscribers without any change needed in this code or in this calss 
    }
}
--- how does event sender notify the subscribers? so event sender will send a message to subscriber and say hey there is a new encoded video. but how? so in pratical c# term. it will invoke a method in subscriber class. but how they know which method they should invoke. well through the agreement, so there is an agreement that sender and subscriber or receiver are agree upon. 
The agreement is a specific method with specific signature. <span style="color: red;"> public void OnVideoEncoded(object source, EventArgs e){} </span> this is a very typical implementation of a method in the subscriber. we usually call it as event handlers. so this event handler method is invoked by the publisher from subcriber class when event is raised. 

--- so back to our example, we need this kind of event handler in our MailService and MessageService classes. 

--- so how do we tell VideoEncoder or sender what method to call? we need delegates to do so. A Delegate is basically an agreement or a contract between publisher and subsriber. and it determines the signature of the event handler method in the subscriber. 
so delagate deterimens when a video is encoded and we want to notify subscriber we should have a method that is void with these parameters defined. 

--- <span style="color: red;"> **event and delegate contract are implemented inside publisher class, event HANDLER Is implemented in subscriber class.** </span>

--- step1. define a delegate which is a constarct between publisher and subscriber. delegate will be called when publisher publishes an event. 
--- step2. define an event, event is inside the publisher class based on the delegate above since we know delegate is the referece or pointer to any method or group of methods.
--- step3. raise the event, this is called 
--- step4 add or create subscribers with confimred signature methods that we have deifned in publisher as delegate determines.

codes: <span style="color: red;"> how to create an event and delegate </span>

public class VideoEncoder
{   //step1 
    public delegate void VideoEncodedEventHandler(object source, EventArgs args) 

    //step2 
    public event VideoEncodedEventHandler VideoEncoded; 

    public void Encode(Video video)
    {
        //Encoding logic
        
        //step3 raise the event by calling the publishing method 
        onVideoEncoded(); //event publihsing method in publisher class to simply notify our subscribers. add more subscribers without any change needed in this code or in this calss 
    }

    protected virtual void OnVideoEncoded()
    {
        //so how do we notify all subscribers. so we do it here 
        if (VideoEncoded !=null)
        {
            VideoEncoded(this, EventArgs.Empty); 
            // call event, who is the source or publisher, it is current class which is this or //VideoEncoder. no additonal data at this moment
        }



    }
}
--- public delegate void VideoEncodedEventHandler(object source, EventArgs args) -- define a delegate that holds reference to a method or function that looks like void VideoEncodedEventHandler(object source, EventArgs args). the first paras source is typically as object type and it refering to the publisher class, the args paras means additional data that we want to add when the event is raised. The delegate name convention is eventName+EventHandler. 

-- public event VideoEncodedEventHandler VideoEncoded; in this way our event VideoEncoded is based on delegate VideoEncodedEventHandler

-- To raise en event, we need a method that is responsible for that. so we create another class called OnVideoEncoded. by convention dotnet sugguests that your event publisher method should be protected. here we shoud know our publisher is VideoEncoder class and it contains one method who is responsible publishing, which is OnVideoEncoded nad it is protected and virtual. 
namespace EventAndDelegates
{
    class Program 
    {
        static void Main(string[], args)
        {
            var video = new Video() {Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher 
            var mailService = new MailServicee(); // subscriber1
            var messageService = new MessageService(); // subscriber2, our publisher even does not know this exists

            //do subscription
            videroEncoder.VideoEncoded += mailService.OnVideoEncoded; // so event is pointer to the event handler, we do not call it
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            //encode video
            VideoEncoder.Encode(video);


        }
    }

    //subscriber 1
    public class MailService
    {
        //delegate comfirmed method this is event handler. 
        public void OnVideoEncoded(object source, EventArgs e)
        {
        // send mail code here 
        }

    }

    //subscriber 2
    public class MessageService
    {
        //delegate comfirmed method this is event handler. 
        public void OnVideoEncoded(object source, EventArgs e)
        {
        // send message or text code here 
        }

    }

}
--- //do subscription: += is the operator to register the handler to the event. who is the handler. The handler is the method in our subscriber . here it is OnVideoEncoded(object source, EventArgs e)

--- we need to do the subscription before we do encode to video otherwise the subscriber won't receive notification about the event.

--- how about if I want to add additional data when the event is raised like i want to send to subcriber and notify which specific video is encoded at this event.
recap so we have a delegate called VideoEncodedEventHandler which is actually a reference to a method. The method is void and has two paras, source and args. we want to send a refence to the video so the subscriber knows which video is encoded by the encoder. To do this, we need a custom class isntaead of EventArgs. This custom class is derived from EventArgs and incude any additional data that we would like send to subscriber. 

namespace EventAndDelegates

{   //custom class derived from EventArgs which is used to send addtional data to subscriber. we name it as Video.. since we want to send Video
    //infomation to subscriber.
    public class VideoEventArgs : EventArgs
    {
        //create a property of this method. type prop + tab: public Type type {get; set;},Type is return type of this calss type is the name 
        public Video Video {get; set;}
    }

    public class VideoEncoder

    {   //step1 
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args) 

        //step2 declare an event
        public event VideoEncodedEventHandler VideoEncoded; 

        public void Encode(Video video)
        {
            //Encoding logic
            
            //step3 raise the event by calling the publishing method 
            onVideoEncoded(); //event publihsing method in publisher class to simply notify our subscribers. add more subscribers without any change needed in this code or in this calss 
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            //so how do we notify all subscribers. so we do it here 
            if (VideoEncoded !=null)
            {
                VideoEncoded(this, new VideoEventArgs(){Video = video}); 
                // replace EventArgs with instance of our custom class VideoEventArgs(){with its property}
            }



        }
    }
}

namespace EventAndDelegates
{
    class Program 
    {
        static void Main(string[], args)
        {
            var video = new Video() {Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher 
            var mailService = new MailServicee(); // subscriber1
            var messageService = new MessageService(); // subscriber2, our publisher even does not know this exists

            //do subscription
            videroEncoder.VideoEncoded += mailService.OnVideoEncoded; // so event is pointer to the event handler, we do not call it
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            //encode video
            VideoEncoder.Encode(video);


        }
    }

    //subscriber 1
    public class MailService
    {
        //delegate comfirmed method this is event handler. 
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
        // send mail code here 
        Console.WriteLine("MailsERVICE: sending an email" + e.Video.Title) 
        // e is the object of class VideoEventArgs which has Video as prop, Video is a class as well, it has fileds like Title, nAME...
        }

    }

    //subscriber 2
    public class MessageService
    {
        //delegate comfirmed method this is event handler. 
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
        // send message or text code here 
        Console.WriteLine("mESSAGERVICE: sending an MESSAGE" + e.Video.Title) 
        }

    }

}

#### **sIMPLIFY OUR code above** 
In dotnet framework, it says we do not need to create a delegate every time we want to decalre a event. so in dotnet, they have a delegate type which is called EventHandler. and it comes with two forms
// EeventHandler
// EventHandler<TEventArgs> generic form
so we could use these two buit-in delegate instead of creating our own delegate at step1.
replace step1+ step2:  
public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args) 
public event VideoEncodedEventHandler VideoEncoded; 

with: 
public EventHandler<VideoEventArgs> VideoEncoded; //less code same things by using built-in delegate of eventhandelr: EventHandler<TEventArgs>

If you do not want to send additonal data to subscriber, you could replace the generic form of EventHandler and use the normal form as:
public EventHandler VideoEncoded; 


## 5. Extension Method 
### 5.1 What is extension method?
Extension method gives ability to 
    * add methods to an existing class without changing its source code or
    *  creating a new type inheriting from the existing class. 

example of explaining ExtensionMethod 
namespace ExtensionMethods
{
    class Program 
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post balh balh balh ..."; 

        }
    }
}


## 6. ICollection Vs List vs IEnumeralble<> vs IDictionary vs IQuery 
https://www.codeproject.com/Articles/832189/List-vs-IEnumerable-vs-IQueryable-vs-ICollection-v#:~:text=IEnumerable%20is%20suitable%20just%20for%20iterating%20through%20collection,records%20so%20IEnumerable%20puts%20overhead%20on%20your%20memory. 

### 6.1 Collection

collection is a standalize concept. List, ArayList, Dictionary, Hashtable ... they are all collections. 
https://www.geeksforgeeks.org/collections-in-c-sharp/

* under namespace of System.Collections.Generic> Generic collection in C# is defined in System.Collection.Generic namespace. It provides a generic implementation of standard data structure like linked lists, stacks, queues, and dictionaries. LinkList<T>, Dictionary<TKey, TValue>...
List<T>...

* Namespace System.Collections> Non-Generic collection in C# is defined in System.Collections namespace. It is a general-purpose data structure that works on object references, so it can handle any type of object, but not in a safe-type manner. ArrayList, Hashtable. stack, queue 

### 6.2 Data type in C#: Array, List, Enumerable, Enumerator

* Array: https://www.geeksforgeeks.org/c-sharp-arrays/?ref=lbp
* ArrayList : https://www.geeksforgeeks.org/arraylist-in-c-sharp/?ref=lbp 
    * **The ArrayList class implements the IEnumerable, ICollection, IList, and ICloneable interfaces. This is a hieracy**
  * **IArrayList > IList > ICollection > IEnumerable Implements hieracy**. 
  
   *  The ArrayList class implements the IEnumerable, ICollection, IList, and ICloneable interfaces.
        The ArrayList class inherits the Object class.
        The ArrayList is defined under System.Collections namespace. So, when you use Arraylist in your program you must add System.Collections namespace.
        You cannot implement a multi-dimensional array using ArrayList.
        The capacity of an ArrayList is the number of elements the ArrayList can hold.
        You are allowed to use duplicate elements in your ArrayList.
        You can apply searching and sorting on the elements present in the ArrayList.
        Arraylist can accept null as a valid value.*
* List: https://www.geeksforgeeks.org/list-implementation-in-c-sharp/#:~:text=In%20C%23%2C%20List%20is%20a%20generic%20collection%20which,a%20generic%20whereas%20ArrayList%20is%20a%20non-generic%20collection.
* List vs ArrayList: https://www.delftstack.com/howto/csharp/arraylist-vs-list-in-csharp/  The List class must always be preferred over the ArrayList class because of the casting overhead in the ArrayList class. The List class can save us from run-time errors faced due to the different data types of the ArrayList class elements. The lists are also very easy-to-use with Linq


* Array vs List: Array has fixed size of element while List has no fixed size. It is dynamic. 

* Indexer: https://www.geeksforgeeks.org/c-sharp-indexers/?ref=lbp
  
* IEnumerable vs List : https://stackoverflow.com/questions/17448812/practical-difference-between-list-and-ienumerable#:~:text=One%20important%20difference%20between%20IEnumerable%20and%20List%20%28besides,your%20collection%20%28add%20%26%20remove%29%2C%20you%27ll%20need%20List.

* wHEN to use IEnumerable / ICollection /IList !!!! useful
    https://www.c-sharpcorner.com/blogs/when-to-use-ienumerable-or-icollection-or-ilist-or-list 
    https://medium.com/@ben.k.muller/c-ienumerable-vs-list-and-array-9f099f157f4f
  Hierachy: IArrayList > IList > ICollection > IEnumerable 

* we only expose Interface to Client and never add changes in concrete Class where we do implementation.

* Could I return List class as IEnumerable variabe? 
  
  Well, List<T> implements IEnumerale already so so it is already an enumerable.

This means that it is perfectly fine to have the following:

public IEnumerable<Book> GetBooks()
{
    List<Book> books = FetchEmFromSomewhere();    
    return books;
}
code above you create a List type variable books and then return it as a IEnumerable type 

In C# we also can convert list to Enumerable by using as keyword. 
*   List<int> ilist = new List<int> { 1, 2, 3, 4, 5 };
    IEnumerable<int> enumerable = ilist as IEnumerable<int>;
    foreach (var e in enumerable)
    {
        Console.WriteLine(e);
    }
output as 1,2,3,4,5 
In the above code, we converted the List of integers ilist to the IEnumerable of integers enumerable with the as keyword in C#.

* TypeCasting method converting 
List<int> ilist = new List<int> { 1, 2, 3, 4, 5 };
IEnumerable<int> enumerable = (IEnumerable<int>)ilist;
foreach (var e in enumerable)
{
    Console.WriteLine(e);
}
  
* LINQ method to convert 
  The LINQ integrates the SQL query functionality with the data structures in C#. We can use the AsEnumerable() function of LINQ to convert a list to an IEnumerable in C#
  List<int> ilist = new List<int> { 1, 2, 3, 4, 5 };
IEnumerable<int> enumerable = ilist.AsEnumerable();
foreach (var e in enumerable)
{
    Console.WriteLine(e);
}



There are times when doing a ToList() on your linq queries can be important to ensure your queries execute at the time and in the order that you expect them to. Those scenarios are however rare and nothing one should worry too much about until they genuinely run into them.

Long story short, use IEnumerable anytime you only need iteration, use IList when you need to index directly and need a dynamically sized array (if you need indexing on a fixed size array then just use a standard array).

**As for the execution time thing, you can always use a list as an IEnumerable variable, so feel free to return an IEnumerable by doing a .ToList();**, or pass in a parameter as an IEnumerable by executing .ToList() on the IEnumerable to force execution right then and there. Just be careful that anytime you force execution with .ToList() you don't hang on to the IEnumerable variable which you just did that to and execute it again, or else you'll end up doubling the iterations in your LINQ query unnecessarily.

In regards to MVC, there is really nothing special to note here. It's going to follow the same execution time rules as the rest of .NET, I think you might have someone who was bit by confusion caused by the delayed execution semantics in the past and blamed it on MVC telling you this is somehow related, but it's not. The delayed execution semantics confuse everybody at first (and even for a good while afterwards; they can be a touch tricky). Again though, just don't worry about it until you really care about ensuring a LINQ query doesn't get executed twice or require it executed in a certain order relative to other code, at which point assign your variable to itself.ToList() to force execution and you'll be fine.



* **Enumerable and Enumerator** 
  https://www.howtogeek.com/devops/how-do-enumerators-and-enumerables-work-in-c/#:~:text=The%20term%20%E2%80%9CEnumerable%E2%80%9D%20defines%20an%20object%20that%20is,sort%20of%20collection%20that%20implements%20the%20IEnumerable%20interface.

  * The term “Enumerable” defines an object that is meant to be iterated over, passing over each element once in order. In C#, an Enumerable is an object like an array, list, or any other sort of collection that implements the IEnumerable interface. Enumerables standardize looping over collections, and enables the use of LINQ query syntax, as well as other useful extension methods like List.Where() or List.Select().
  * All the IEnumerable interface requires is a method, GetEnumerator(), which returns an IEnumerator. So what do Enumerators do?
  * Well, IEnumerator requires two methods, MoveNext() and Current()
  * every time you write a foreach loop, you’re using enumerators. You actually can’t use foreach on a collection that doesn’t implement IEnumerable.
  * Enumerable class is refernce data type in C# like any other class, it is under namespace Linq and Provides a set of static (Shared in Visual Basic) methods for querying objects that implement IEnumerable<T>.The majority of the methods in this class are defined as extension methods that extend IEnumerable<T>. This means they can be called like an instance method on any object that implements IEnumerable<T>

* </scan style="color:red"> **Why we need to return List<T> as IEnumerable<> type? 

public IEnumerable<Book> GetBooks()
{
    List<Book> books = FetchEmFromSomewhere();    
    return books;
}
code above you create a List type variable books and then return it as a IEnumerable type 

  https://colinmackay.scot/2011/07/19/why-should-you-be-returning-an-ienumerable/#:~:text=Why%20should%20you%20be%20returning%20an%20IEnumerable%20I%E2%80%99ve,you%20can%20change%20the%20state%20of%20the%20List.  

  https://jeremylindsayni.wordpress.com/2015/01/01/c-tip-try-to-return-ienumerable-instead-of-ilist-and-when-not-to/

  Since List is mutable and Enumerable is imutable.

## 7.Linq 

* Stands for: Language Integrated Query 
* Gives your the capability to query objects.
* With LINQ you can query: 
      * Objects in memory, eg collections: list, arrayList ... which is called LINQ to objects
      * Database -- LINQ to Entinties 
      * XML -- LINQ to XML 
      * ADO.NET Data Sets --LINQ to Data Sets 

### 7.1 LINQ to objects -- LINQ provides many extension method to filter collections and any other objects

using System.Collection.Generic
namespace Linq
{
    public class Book

    {   //two properties of Book
        public string Title{get, set;}
        public float Price {get; set;}
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "book1 ", Price = 5},
                new Book() {Title = "book2 ", Price = 7},
                new Book() {Title = "book3 ", Price = 9},
                new Book() {Title = "book4 ", Price = 12},
                new Book() {Title = "book5 ", Price = 17},
                new Book() {Title = "book6 ", Price = 20},
            }
        }
    }

    //what we could do with LINQ? -- list all books with price less than 10. 

    //case 1 without LINQ 
    class Program 
    {
        static void Main(string[] args)
        {
            var books = new BookRepository.GetBooks(); --return collection of IEnumerable type 
            var cheaperBooks = new List<Book>{};
            foreach (var book in books)
            {
                if (book.Price < 10)
                {
                    cheaperBooks.Add(book);
                }
            }

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }
        }
    }

    //With LINQ, we could use WHERE to filter collection 
    using System.Linq;
    class Program 
    {
        static void Main(string[] args)
        {
            var books = new BookRepository.GetBooks(); --return collection of IEnumerable type 
            var cheaperBooks = books.where(b=>b.Price<10);  

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }
        }
        -- where(this IEnumerable<Book> source, Func<Book, bool> predicate) --Func is a delegate points to a method here is Lambda expression anynomous method and Func takes Book as input and bool as output by checking condition, this delegate with input, out put -Func<Book, bool> we also call it as predicate in LINQ 
        whenever we see Func<input, output> delegate, we could use lambda expression to replace the predicate or method that takes this paras and return bool.
    }
    

    //extension methods in LINQ that we should know to filter and work on objects

    books.OrderBy(b => b.Title) 

    //chain LINQ methods is supported 
    
    books.where(b => b.Price < 10).OrderBy(b => b.Title); 

    //Select -- projections or transfomations
    // select elements and cast them as another type or just select elements's property as string
    books.where(b => b.Price < 10).OrderBy(b => b.Title).Select( b => b.Title); 

    //lay out your query, in pratical usage lambda expression would be complex then we could lay the linq as

    //LINQ extension methods

    books
        .where(b => b.Price < 10)
        .OrderBy(b => b.Title)
        .Select( b => b.Title); 
    
    //LINQ Query Operator to replace LINQ extension methods above 

    var cheapBooks = from b in books
                    where b.Price < 10 
                    orderby b.Title
                    select b.Title; // or just select b --return list of books
    -- Linq query operator always starts with from and ends with select 
   
    -- which one is freferable to use? in terms of power and flexibility, LINQ extension method is more powerful since all keywords in linq query will be translated into extension methods 
    in more complex scenario, you might find that there are no keywords for every extension methods that you have in extension methods. 

    **but when you need to di groupBy or Group lists then Linq query operator is more friendly and cleaner.**

    // Single -- only return single element similar as where but did not return collection IEnumerable 
    books.Single(b => b.Title == "bookname 1" ); 
    
    //Single method applies when you must have one and only one object in your collection that satisifies this condition. if there is no one then crashed. if you are not sure if there is 
    //one or not use SingleOrDefault 
    
    books.SingleOrDefault(b => b.Title == "booksname");

    //First / FirstOrDefault /Last /LasrOrDefault
    -- gets first book with title is ... 
    -- no book matches the condition then return default value
    books.First(b=>b.Title == "bookname");
    books.FirstOrDefault(b => b.Title == "booksname");
    ...

    //skip().take() --skip number of objects and then take the rest of them 
    // useful to paging data 
    var pagedbooks = books.Skip(2).Take(3); -- returns an IEnumerable of book it will skip the first two book object and take from the third one. 

    //Count objects numbers
    var count = books.Count() -- 
    var highestprice = books.Max(b=> b.Price); --Min, Average, Sum, 





}
-- -- OrderBy takes Func<Book, TKey> so this is a Func delegate and Book is the input and we need to speficy the property of the book on which we woudl like to sort the collection


















### 5.2 coding example 
This part needs recap later in Visual studio. 

### 5.3



### 6 Virtual keyword 
https://www.tutorialspoint.com/What-are-virtual-functions-in-Chash

The virtual keyword is useful in modifying a method, property, indexer, or event. When you have a function defined in a class that you want to be implemented in an inherited class(es), you use virtual functions. The virtual functions could be implemented differently in different inherited class and the call to these functions will be decided at runtime.










### 4.3 Comclusion 
** So with events you could create publisher and create many subscribers without changing the publisher 
keep publisher unchanged so we do not need to redeploy and recompile it  **
























### 3. Extension Methods
This is a convention that is required for creating extension methods.
### 4. Single() method: The Single() method throws an exception if no object matching the condition is found in the collection.
 var numbers = new List<int>{2,3,4,5};
 var number = numbers.Single(n=> n==10); // condition is n from collection is 10 
 Console.WriteLine(number);

 ### 5. Nullable type
 compiler doesn't know how to translate a nullable type to a non-nullable type.

 ### 6. Operator ??., ?:, =>, ::, ...

 ### 7. dynamic vs var? 
 The resolution of types, propertites, methods for the variable defined as var is checked at compile time. 
 We use dynamic to postpone the type resolution at run time 

 what is resolution?? 

 ### 8. Indexer 
 An indexer is a special type of property that allows a **class or a structure** to be accessed like **an array** for its internal collection. C# allows us to define custom indexers, generic indexers, and also overload indexers.

 ## 9. Collections ? Generic List? 
 
 public List<Book> GetBooks()
 {
     code body 
 }
 -- List is Generic list indicated by angle bracket <>. Book is type of generic paras. So this generic List is a collection of Books. 
 but what is collection?? 

 ## 10. debugs 
 ## 11. threads woriking in c# 