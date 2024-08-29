```
<builder pattern>
namespace BuilderPatternConsole
{
   
        public class Computer
        {
            public string CPU { get; set; }
            public string RAM { get; set; }
            public string Storage { get; set; }
            public string GraphicsCard { get; set; }

            public override string ToString()
            {
                return $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, Graphics Card: {GraphicsCard}";
            }
        }

        public interface IComputerBuilder
        {
            void SetCPU();
            void SetRAM();
            void SetStorage();
            void SetGraphicsCard();
            Computer GetComputer();
        }

        public class GamingComputerBuilder : IComputerBuilder
        {
            private Computer computer = new Computer();

            public void SetCPU()
            {
                computer.CPU = "Intel Core i9";
            }

            public void SetRAM()
            {
                computer.RAM = "32GB";
            }

            public void SetStorage()
            {
                computer.Storage = "1TB SSD";
            }

            public void SetGraphicsCard()
            {
                computer.GraphicsCard = "NVIDIA RTX 3080";
            }

            public Computer GetComputer()
            {
                return computer;
            }
        }

        public class OfficeComputerBuilder : IComputerBuilder
        {
            private Computer computer = new Computer();

            public void SetCPU()
            {
                computer.CPU = "Intel Core i5";
            }

            public void SetRAM()
            {
                computer.RAM = "16GB";
            }
            public void SetStorage()
            {
                computer.Storage = "512GB SSD";
            }
            public void SetGraphicsCard()
            {
                computer.GraphicsCard = "Integrated Graphics";
            }
            public Computer GetComputer()
            {
                return computer;
            }
        }
        public class Director
        {
            public Computer BuildComputer(IComputerBuilder builder)
            {
                builder.SetCPU();
                builder.SetRAM();
                builder.SetStorage();
                builder.SetGraphicsCard();
                return builder.GetComputer();
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Director director = new Director();

                IComputerBuilder gamingBuilder = new GamingComputerBuilder();
                Computer gamingComputer = director.BuildComputer(gamingBuilder);
                Console.WriteLine("게이밍 컴퓨터:");
                Console.WriteLine(gamingComputer);

                IComputerBuilder officeBuilder = new OfficeComputerBuilder();
                Computer officeComputer = director.BuildComputer(officeBuilder);
                Console.WriteLine("오피스 컴퓨터:");
                Console.WriteLine(officeComputer);
            }
        }
    }
```
```
<Quiz. Builder 패턴 응용>
namespace BuilderPatternConsole
{

    public class Computer

    {

        public string CPU { get; set; }

        public string RAM { get; set; }

        public string Storage { get; set; }

        public string GraphicsCard { get; set; }



        public override string ToString()

        {

            return $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, Graphics Card: {GraphicsCard}";

        }

    }



    public interface IComputerBuilder

    {

        void SetCPU();

        void SetRAM();

        void SetStorage();

        void SetGraphicsCard();

        Computer GetComputer();

    }



    public class GamingComputerBuilder : IComputerBuilder

    {

        private Computer computer = new Computer();



        public void SetCPU()

        {

            computer.CPU = "Intel Core i9";

        }



        public void SetRAM()

        {

            computer.RAM = "32GB";

        }



        public void SetStorage()

        {

            computer.Storage = "1TB SSD";

        }



        public void SetGraphicsCard()

        {

            computer.GraphicsCard = "NVIDIA RTX 3080";

        }



        public Computer GetComputer()

        {

            return computer;

        }

    }//게이밍 컴퓨터



    public class OfficeComputerBuilder : IComputerBuilder

    {

        private Computer computer = new Computer();



        public void SetCPU()

        {

            computer.CPU = "Intel Core i5";

        }



        public void SetRAM()

        {

            computer.RAM = "16GB";

        }

        public void SetStorage()

        {

            computer.Storage = "512GB SSD";

        }

        public void SetGraphicsCard()

        {

            computer.GraphicsCard = "Integrated Graphics";

        }

        public Computer GetComputer()

        {

            return computer;

        }

    }//사무실 컴퓨터

    public class PcroomComputerBuilder : IComputerBuilder

    {

        private Computer computer = new Computer();



        public void SetCPU()

        {

            computer.CPU = "Intel Core i9";

        }

        public void SetRAM()

        {

            computer.RAM = "32GB";

        }

        public void SetStorage()

        {

            computer.Storage = "2TB SSD";

        }

        public void SetGraphicsCard()

        {

            computer.GraphicsCard = "NVDIA RTX 4080";

        }

        public Computer GetComputer()

        {

            return computer;

        }

    }//피시방 컴퓨터

    public class Director

    {

        public Computer BuildComputer(IComputerBuilder builder)

        {

            builder.SetCPU();

            builder.SetRAM();

            builder.SetStorage();

            builder.SetGraphicsCard();

            return builder.GetComputer();

        }

    }

    internal class Program

    {

        static void Main(string[] args)

        {

            Director director = new Director();



            IComputerBuilder gamingBuilder = new GamingComputerBuilder();

            Computer gamingComputer = director.BuildComputer(gamingBuilder);

            Console.WriteLine("게이밍 컴퓨터:");

            Console.WriteLine(gamingComputer);



            IComputerBuilder officeBuilder = new OfficeComputerBuilder();

            Computer officeComputer = director.BuildComputer(officeBuilder);

            Console.WriteLine("오피스 컴퓨터:");

            Console.WriteLine(officeComputer);



            IComputerBuilder PcroomComputerBuilder = new PcroomComputerBuilder();

            Computer pcroomComputerBuilder = director.BuildComputer(PcroomComputerBuilder);

            Console.WriteLine("PC방용 컴퓨터:");

            Console.WriteLine(pcroomComputerBuilder);

        }

    }
}
```
```
<MethodChain 방식>
namespace BuilderPatternConsole
{

    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GraphicsCard { get; set; }

        public override string ToString()
        {
            return $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, Graphics Card: {GraphicsCard}";
        }
    }

    public interface IComputerBuilder
    {
        IComputerBuilder SetCPU(string cpu);
        IComputerBuilder SetRAM(string ram);
        IComputerBuilder SetStorage(string storage);
        IComputerBuilder SetGraphicsCard(string graphicsCard);
        Computer Build();
    }

    public class ComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();

        public IComputerBuilder SetCPU(string cpu)
        {
            computer.CPU = cpu;
            return this;
        }

        public IComputerBuilder SetRAM(string ram)
        {
            computer.RAM = ram;
            return this;
        }

        public IComputerBuilder SetStorage(string storage)
        {
            computer.Storage = storage;
            return this;
        }

        public IComputerBuilder SetGraphicsCard(string graphicsCard)
        {
            computer.GraphicsCard = graphicsCard;
            return this;
        }

        public Computer Build()
        {
            return computer;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IComputerBuilder gamingBuilder = new ComputerBuilder();
            Computer gamingComputer = gamingBuilder
                                        .SetCPU("Intel Core i9")
                                        .SetRAM("32GB")
                                        .SetStorage("1TB SSD")
                                        .SetGraphicsCard("NVIDIA RTX 3080")
                                        .Build();
            Console.WriteLine("게이밍 컴퓨터:");
            Console.WriteLine(gamingComputer);

            IComputerBuilder officeBuilder = new ComputerBuilder();
            Computer officeComputer = officeBuilder
                                        .SetCPU("Intel Core i5")
                                        .SetRAM("16GB")
                                        .SetStorage("512GB SSD")
                                        .SetGraphicsCard("Integrated Graphics")
                                        .Build();
            Console.WriteLine("오피스 컴퓨터:");
            Console.WriteLine(officeComputer);
            IComputerBuilder pcBuilder = new ComputerBuilder();
            Computer pcComputer = officeBuilder
                                        .SetCPU("Intel Core i9")
                                        .SetRAM("32GB")
                                        .SetStorage("2TB SSD")
                                        .SetGraphicsCard("NVIDIA RTX 4080")
                                        .Build();
            Console.WriteLine("PC방용 컴퓨터:");
            Console.WriteLine(officeComputer);
        }
    }
}
```
