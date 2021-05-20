using System;

namespace ShowcaseDifferenveOverrideNew
{
    public static class DisplayDifferenceOverrideNew
    {
        public static void Display()
        {
            ImplementingClass implementingClass = new ImplementingClass();
            AbstractClass abstractClass = implementingClass;

            Console.WriteLine("here we have an abstract class and a class that implements it. each time we'll first call the method on an the implementing class, then on the same instance of the class but as an abstract class." + "\r\n" +
                "\r\na virtual function (virtual keyword in abstract class. override keyword in implementing class):" +
                "\r\nimplementing class: " + implementingClass.VirtualMethod() + "" +
                "\r\nabstract class: " + abstractClass.VirtualMethod() + "\r\n" +
                "\r\na regular function for which a new implementation is given (no keyword in abstract class. new keyword in implementing class):" +
                "\r\nimplementing class: " + implementingClass.RegularMethod() + "" +
                "\r\nabstract class: " + abstractClass.RegularMethod() + "\r\n" +
                "\r\nan abstract function (abstract keyword in abstract class. override keyword in implmenting class):" +
                "\r\nimplementing class: " + implementingClass.AbstractMethod() + "" +
                "\r\nabstract class: " + abstractClass.AbstractMethod());
        }
    }

    internal abstract class AbstractClass
    {
        private const string toWrite = "AbstractClass Implementation";

        internal virtual string VirtualMethod()
        {
            return toWrite;
        }
        internal string RegularMethod()
        {
            return toWrite;
        }
        internal abstract string AbstractMethod();
    }
    internal class ImplementingClass : AbstractClass
    {
        private const string toWrite = "ImplementingClass Implementation";

        internal override string VirtualMethod()
        {
            return toWrite;
        }
        internal new string RegularMethod()
        {
            return toWrite;
        }
        internal override string AbstractMethod()
        {
            return toWrite;
        }
    }
}
