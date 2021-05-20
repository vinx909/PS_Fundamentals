using System;

namespace RecordShowcase
{
    public static class DisplayRecord
    {
        public static void Display()
        {
            Console.WriteLine("a record is created in a rather simpel method.\r\nto make a record with a name and age property one simply writes: \"record NameOfRecordType (string Name, int Age);\"\r\nto then create an instance of the record one simply calls the constructor with the same parameters, like: \"new NameOfRecordType (\"example name\", 26)\"\r\nbehind the scenes a class is created with readonly properties and a couple functions.\r\n\r\n");

            ClassExample class1 = new() { PropOne = 1, PropTwo = 2 };
            ClassExample class2 = new() { PropOne = 1, PropTwo = 2 };
            RecordExample record1 = new(1,2);
            RecordExample record2 = new(1,2);

            Console.WriteLine("a record is easier to compare to other records then different classes are to one another. in the following both classes and records have the same values for their properties:\r\ncomparing classes: " + (class1 == class2) + "\r\ncomparing records: " + (record1 == record2) + "\r\nthis is because by default classes compare the reference while records compare the values\r\n\r\n");

            Console.WriteLine("records also come with a precreated .ToString() method:\r\nclass: " + class1.ToString() + "\r\nrecord: " + record1.ToString()+ "\r\n\r\n");

            Console.WriteLine("a record can also be created like a class, where it can also inherit from another record (but different record types can't be compared with the \"==\" the same way the same record types can).\r\nthis will look something like:\r\nrecord RecordExampleTwo : RecordExample\r\n{\r\n\tprivate readonly int propThree;\r\n\tpublic int PropThree { get { return propThree; } }\r\n\tpublic RecordExampleTwo(int PropOne, int PropTwo, int PropThree) : base(PropOne, PropTwo)\r\n\t{\r\n\t\tpropThree = PropThree;\r\n\t}\r\n\tpublic int AllTogether()\r\n\t{\r\n\t\treturn PropOne + PropTwo + propThree;\r\n\t}\r\n}\r\n\r\n");

            record2 = record1 with { PropTwo = 3 };
            Console.WriteLine("since the properties of a record are readonly to change a value a new instance must be made. this can be done with use of the \"with\" keyword\r\nrecord1: " + record1.ToString() + "\r\nrecord2 = record1 with { PropTwo = 3 };\r\nrecord1: " + record1.ToString() + "\r\nrecord2: " + record2.ToString());
        }
    }

    internal class ClassExample
    {
        public int PropOne { get; set; }
        public int PropTwo { get; set; }
    }
    record RecordExample(int PropOne, int PropTwo);
    record RecordExampleTwo : RecordExample
    {
        private readonly int propThree;
        public int PropThree { get { return propThree; } }
        public RecordExampleTwo(int PropOne, int PropTwo, int PropThree) : base(PropOne, PropTwo)
        {
            propThree = PropThree;
        }
        public int AllTogether()
        {
            return PropOne + PropTwo + propThree;
        }
    }
}
