using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        interface IChair
        {
            public void Info();
        }
        interface IBed
        {
            public void Info();
        }

        public class ModernChair : IChair
        {
            public void Info()
            {
                Console.WriteLine("Кресло в стиле модерн");
            }
        }
        public class VictorianChair : IChair
        {
            public void Info()
            {
                Console.WriteLine("Кресло в викторианском стиле");
            }
        }

        public class ModernBed : IBed
        {
            public void Info()
            {
                Console.WriteLine("Кровать в стиле модерн");
            }
        }
        public class VictorianBed : IBed
        {
            public void Info()
            {
                Console.WriteLine("Кровать в викторианском стиле");
            }
        }

        abstract class AbstractFactory
        {
            public abstract IChair MakeChair();
            public abstract IBed MakeBed();
        }

        class ModernFactory : AbstractFactory
        {
            public override IBed MakeBed()
            {
                return new ModernBed();
            }

            public override IChair MakeChair()
            {
                return new ModernChair();
            }
        }
        class VictorianFactory : AbstractFactory
        {
            public override IBed MakeBed()
            {
                return new VictorianBed();
            }

            public override IChair MakeChair()
            {
                return new VictorianChair();
            }
        }

        static void Main(string[] args)
        {
            AbstractFactory factory;
            factory = new ModernFactory();

            IChair chair;
            IBed bed;

            chair = factory.MakeChair();
            bed = factory.MakeBed();

            chair.Info();
            bed.Info();

            factory = new VictorianFactory();

            chair = factory.MakeChair();
            bed = factory.MakeBed();

            chair.Info();
            bed.Info();

            Console.Read();
        }
    }
}
