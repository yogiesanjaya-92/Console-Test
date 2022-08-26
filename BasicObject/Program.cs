using System;

namespace BasicObject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Constructor
            Name myName = new Name("Yogie", "Sanjaya");
            Console.WriteLine(myName.Detail());
            Console.WriteLine(string.Empty);

            //Virtual and Override Modifiers
            Classic classic = new Classic();
            classic.Detail();
            Modern modern = new Modern();
            modern.Detail();
            Console.WriteLine(string.Empty);

            //Encapsulation
            Animal myPet = new Animal();
            myPet.leg = 4;
            myPet.fur = true;
            myPet.call = "Miauw Miauw Miauw";
            myPet.Description();
            Console.WriteLine(string.Empty);

            //Inheritance
            Triangle t1 = new Triangle();
            t1.width = 4;
            t1.height = 6;
            t1.Dimension();
            t1.style = "Equilateral";
            t1.ShowStyle();
            Console.WriteLine("It's area is {0}", t1.Area());
            Console.WriteLine(string.Empty);

            //Interface
            CrossBike myKlx = new CrossBike();
            myKlx.SetSpeed = 10;
            myKlx.StartRide();
            myKlx.ChangeGear(4);
            myKlx.SpeedUp(100);
            myKlx.ApplyBrake(20);
            Console.WriteLine(myKlx.GetType().Name);
            myKlx.PrintDetail();

            SportBike myCbr = new SportBike();
            myCbr.SetSpeed = 10;
            myCbr.StartRide();
            myCbr.ChangeGear(4);
            myCbr.SpeedUp(100);
            myCbr.ApplyBrake(10);
            Console.WriteLine(myCbr.GetType().Name);
            myCbr.PrintDetail();
            Console.WriteLine(string.Empty);

            //Static Polymorphism
            Summation mySum = new Summation();
            string firstSum = mySum.Add(3, 4).ToString();
            string secondSum = mySum.Add(3, 4, 5).ToString();
            Console.WriteLine("The first summation is {0} and the second is {1}", firstSum, secondSum);
            Console.WriteLine(string.Empty);

            //Inherit Polymorphism
            Drawing myCircle = new Circle();
            string firstDraw = string.Format("{0:0.##}", myCircle.Area());
            Console.WriteLine("The first drawing is {0} and it's area is {1}", myCircle.GetType().Name, firstDraw);
            Drawing mySquare = new Square();
            string secondDraw = mySquare.Area().ToString();
            Console.WriteLine("The second drawing is {0} and it's area is {1}", mySquare.GetType().Name, secondDraw);
            Drawing myRectangle = new Rectangle();
            string thirdDraw = myRectangle.Area().ToString();
            Console.WriteLine("The third drawing is {0} and it's area is {1}", myRectangle.GetType().Name, thirdDraw);
            Drawing myParallelogram = new Parallelogram();
            string fourthDraw = myParallelogram.Area().ToString();
            Console.WriteLine("The fourth drawing is {0} and it's area is {1}", myParallelogram.GetType().Name, fourthDraw);
            Console.WriteLine(string.Empty);

            //Interface Polymorphism
            Computer myPC = new PC();
            myPC.TurnOn(myPC.GetType().Name);
            myPC.TurnOff(myPC.GetType().Name);
            Computer myDesktop = new Desktop();
            myDesktop.TurnOff(myDesktop.GetType().Name);
            myDesktop.TurnOff(myDesktop.GetType().Name);
            Computer myLaptop = new Laptop();
            myLaptop.TurnOn(myLaptop.GetType().Name);
            myLaptop.TurnOn(myLaptop.GetType().Name);
            Computer myNotebook = new Notebook();
            myNotebook.TurnOff(myNotebook.GetType().Name);
            myNotebook.TurnOn(myNotebook.GetType().Name);
            Console.WriteLine(string.Empty);

            Console.ReadLine();
        }
    }

    public class Name
    {
        private string first;
        private string last;

        public Name(string st, string th)
        {
            this.first = st;
            this.last = th;
        }

        public string Detail()
        {
            return "First name is " + first + " and last name is " + last;
        }
    }

    public class Classic
    {
        public virtual void Detail()
        {
            Console.WriteLine("This is classic life");
        }
    }

    public class Modern : Classic
    {
        public override void Detail()
        {
            Console.WriteLine("This is modern life");
        }
    }


    public class Animal
    {
        public int leg { get; set; }
        public bool fur { get; set; }
        private string voice;
        public string call
        {
            get
            {
                return voice;
            }
            set
            {
                voice = value;
            }
        }

        public void Description()
        {
            Console.WriteLine("It has {0} leg and Is it has fur ? {1}. It sounds {2}", leg, fur, call);
        }
    }

    public class Shape
    {
        public int width { get; set; }
        public int height { get; set; }
        public void Dimension()
        {
            Console.WriteLine("Shape width {0} and height {1}", width, height);
        }
    }

    public class Triangle : Shape
    {
        public string style { get; set; }
        public float Area()
        {
            return width * height / 2;
        }
        public void ShowStyle()
        {
            Console.WriteLine("It is triangle with {0} style ", style);
        }
    }

    interface IBike
    {
        void ChangeGear(int a);
        void SpeedUp(int a);
        void ApplyBrake(int a);
        void StartRide();
        int SetSpeed { get; set; }
    }

    public class CrossBike : IBike
    {
        private int speed;
        private int gear;
        public int SetSpeed { get; set; }

        public void StartRide()
        {
            speed = SetSpeed;
        }

        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }

        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }

        public void ApplyBrake(int decrement)
        {
            speed = speed - decrement;
        }

        public void PrintDetail()
        {
            Console.WriteLine("Current gears is {0} with speed is {1}", gear, speed);
        }
    }

    public class SportBike : IBike
    {
        private int speed;
        private int gear;
        public int SetSpeed { get; set; }

        public void StartRide()
        {
            speed = SetSpeed;
        }

        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }

        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }

        public void ApplyBrake(int decrement)
        {
            speed = speed - decrement;
        }

        public void PrintDetail()
        {
            Console.WriteLine("Current gears is {0} with speed is {1}", gear, speed);
        }
    }

    public class Summation
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Add(int first, int second, int third)
        {
            return first + second + third;
        }
    }

    public class Drawing
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Circle : Drawing
    {
        public int radius { get; set; }

        public Circle()
        {
            radius = 7;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Square : Drawing
    {
        public int length { get; set; }

        public Square()
        {
            length = 5;
        }

        public override double Area()
        {
            return Math.Pow(length, 2);
        }
    }

    public class Rectangle : Drawing
    {
        public int width { get; set; }
        public int height { get; set; }

        public Rectangle()
        {
            width = 6;
            height = 7;
        }

        public override double Area()
        {
            return width * height;
        }
    }


    public class Parallelogram : Drawing
    {
        public int width { get; set; }
        public int height { get; set; }

        public Parallelogram()
        {
            width = 6;
            height = 7;
        }

        public override double Area()
        {
            return width * height / 2;
        }
    }

    public interface IPowerController
    {
        bool isOn { get; set; }
        bool isOff { get; set; }
        void TurnOn(string computer);
        void TurnOff(string computer);
    }

    public class Computer : IPowerController
    {
        public bool isOn { get; set; }
        public bool isOff { get; set; }

        public void TurnOn(string computer)
        {

            if (isOff)
            {
                isOn = true;
                isOff = false;
                Console.WriteLine("{0} is turning on", computer);
            }
            else
            {
                Console.WriteLine("{0} is already on", computer);
            }
        }

        public void TurnOff(string computer)
        {
            if (isOn)
            {
                isOn = false;
                isOff = true;
                Console.WriteLine("{0} is turning off", computer);
            }
            else
            {
                Console.WriteLine("{0} is already off", computer);
            }
        }
    }

    public class PC : Computer
    {
        public PC()
        {
            isOn = true;
            isOff = false;
            Console.WriteLine("PC is on");
        }
    }

    public class Desktop : Computer
    {
        public Desktop()
        {
            isOn = true;
            isOff = false;
            Console.WriteLine("Desktop is on");
        }
    }

    public class Laptop : Computer
    {
        public Laptop()
        {
            isOn = true;
            isOff = false;
            Console.WriteLine("Laptop is on");
        }
    }

    public class Notebook : Computer
    {
        public Notebook()
        {
            isOn = true;
            isOff = false;
            Console.WriteLine("Notebook is on");
        }
    }
}
