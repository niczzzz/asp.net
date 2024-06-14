namespace asp_ps_1_DI
{
    interface IFormatOut
    {
        void ShowPerson(Person p);
    }
    class FormatOut : IFormatOut
    {
        public void ShowPerson(Person p)
        {
            Console.WriteLine(p.firstName + " " + p.lastName + " (" + p.age + ")");
        }
    }
    class FormatShort : IFormatOut
    {
        public void ShowPerson(Person p)
        {
            Console.WriteLine(p.firstName[0] + ". " + p.lastName);
        }
    }
    class Person
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public int age { get; private set; }
        public IFormatOut format { private get; set; }

        public Person(string fName, string lName, int age)
        {
            firstName = fName;
            lastName = lName;
            this.age = age;
        }
        public void Print()
        {
            //Console.WriteLine(firstName + " " + lastName + " (" + age + ")");
            format.ShowPerson(this);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person("Ivan", "Popov", 32);
            user.format = new FormatOut();
            user.Print();

            user.format = new FormatShort();
            // change format

            user.Print();
            //Console.ReadKey();
        }
    }
}
