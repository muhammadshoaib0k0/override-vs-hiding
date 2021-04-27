using System;

namespace override_vs_hiding
{
    /// <summary>
    /// ////////////////////////////////////// methods override//////////////////////////////
    /// </summary>
    public class parent
    {
        public virtual void print()
        {
            Console.WriteLine("i am the method of parent class");
        }
    }
    public class child : parent
    {
        public override void print()
        {
            Console.WriteLine("i am the method of child  class");
        }

    }


    /// <summary>
    /// /////////////////////////////////////////// methods hiding///////////////////////////////
    /// </summary>
    /// 
    public class base_class 
    {
        public virtual void display()
        {
            Console.WriteLine("i am the method of base class");
        }
    }
    public class derived_class:base_class
    {
        public new void display()
        {
            Console.WriteLine("i am the method of derived class");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /// its for over ride
            parent obj = new child();
            Console.WriteLine("its for over riding    , run time late binding " );
            obj.print();
            Console.WriteLine("");
            ////// its for hiding
            Console.WriteLine(" now method hiding");
            base_class obj1 = new derived_class();
            obj1.display();
            

        }
    }
}
