using System;

namespace Animals
{
    interface IFormatOut
    {
        void Show(Animal a);
    }
    class FormatFull : IFormatOut
    {
        public void Show(Animal a)
        {
            Console.WriteLine(a.Name + " " + a.Age.ToString() + " " + a.Sound + " " + a.Color);
        }
    }
    class FormatShort : IFormatOut
    {
        public void Show(Animal a)
        {
            Console.WriteLine(a.Name);
        }
    }
    class Animal
    {
        public string Name { get; private set; }
        public string Sound { get; private set; }
        public string Color { get; private set; }
        public int Age { get; private set; }
        public IFormatOut format { private get; set; }
        public Animal(string name, string sound, string color, int age)
        {
            Name = name;
            Sound = sound;
            Color = color;
            Age = age;
        }
        public void Show()
        {
            format.Show(this);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Cat", "mew", "black", 5);
            a1.format = new FormatFull();
            a1.Show();

            Animal a2 = new Animal("Dog", "gav", "red", 7);
            a2.format = new FormatFull();
            a2.Show();

            Animal a3 = new Animal("Bird", "chirik", "blue", 1);
            a3.format = new FormatFull();
            a3.Show();

            a1.format = new FormatShort();
            a2.format = new FormatShort();
            a3.format = new FormatShort();

            a1.Show();
            a2.Show();
            a3.Show();
        }
    }
}