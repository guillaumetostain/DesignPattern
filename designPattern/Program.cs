using designPattern.AbstractFactoryPattern;
using designPattern.AdapterPattern;
using designPattern.BridgePattern;
using designPattern.BuilderPattern;
using designPattern.CommandPattern;
using designPattern.CompositePattern;
using designPattern.DecoratorPattern;
using designPattern.FacadePattern;
using designPattern.InterpreterPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Pattern");

            // Singleton Pattern
            SingleObject singleObject = SingleObject.Instance();
            singleObject.ShowMessage();

            Console.WriteLine("\nBuilder Pattern");

            // Builder Pattern
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.ShowItems();
            Console.WriteLine("Total Cost : " + vegMeal.GetCost());

            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("NonVeg Meal");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total Cost : " + nonVegMeal.GetCost());

            Console.WriteLine("\nAbstract Factory");

            // Abstract Factory Pattern
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("shape");
            IShape circleShape = shapeFactory.GetShape("circle");
            circleShape.Draw();

            AbstractFactory colorFactory = FactoryProducer.GetFactory("color");
            IColor blueColor = colorFactory.GetColor("blue");
            blueColor.Fill();

            Console.WriteLine("\nAdapter");

            //Adapter Pattern
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp4");
            audioPlayer.Play("flac");
            audioPlayer.Play("vlc");

            Console.WriteLine("\nFacade");

            //Facade Pattern
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();

            Console.WriteLine("\nDecorator doesn't work");

            //Decorator Pattern
            IDecoratorShape rectangle = new RectangleDecorator();
            IDecoratorShape redRectangle = new RedShapeDecorator(new RectangleDecorator());
            Console.WriteLine("Rectangle with no color");
            rectangle.Draw();
            Console.WriteLine("Rectangle with color");
            redRectangle.Draw();

            Console.WriteLine("\nComposite");

            //Composite Pattern
            Employee DSI = new Employee("employee1", "DSI", 100000);
            Employee chefDeProjet1 = new Employee("employee2", "Chef de projet", 60000);
            Employee chefDeProjet2 = new Employee("employee3", "Chef de projet", 60000);
            Employee dev1 = new Employee("employee4", "Développeur", 40000);
            Employee dev2 = new Employee("employee5", "Développeur", 40000);
            DSI.Add(chefDeProjet1);
            DSI.Add(chefDeProjet2);
            chefDeProjet1.Add(dev1);
            chefDeProjet2.Add(dev2);

            Console.WriteLine(DSI.Details());
            foreach (Employee e1 in DSI.GetSubordinates())
            {
                Console.WriteLine(e1.Details());
                foreach (Employee e2 in e1.GetSubordinates())
                {
                    Console.WriteLine(e2.Details());
                }
            }

            Console.WriteLine("\nBridge");

            //Bridge Pattern
            BridgeShape shape1 = new BridgeCircle(10, 10, 1, new GreenCircle());
            BridgeShape shape2 = new BridgeCircle(100, 100, 10, new RedCircle());
            shape1.Draw();
            shape2.Draw();

            Console.WriteLine("\nCommand");

            //Command Pattern
            Stock stock1 = new Stock("laptop", 100);
            BuyStock buyStock = new BuyStock(stock1);

            Stock stock2 = new Stock("screen", 30);
            SellStock sellStock = new SellStock(stock2);

            Broker broker = new Broker();
            broker.TakeOrder(buyStock);
            broker.TakeOrder(sellStock);
            broker.PlaceOrders();

            Console.WriteLine("\nInterpreter");

            //Interpreter Pattern
            IExpression isMale = InterpreterPatternDemo.GetMaleExpression();
            IExpression isMarried = InterpreterPatternDemo.GetMarriedWomanExpression();

            Console.WriteLine("John is male ? " + isMale.Interpret("john"));
            Console.WriteLine("Barbara is male ? " + isMale.Interpret("barbara"));

            Console.WriteLine("Julie is married ? " + isMarried.Interpret("julie married"));
            Console.WriteLine("Bob is married ? " + isMarried.Interpret("bob married"));

        }
    }
}