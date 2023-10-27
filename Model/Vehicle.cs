namespace TesteTecnico2023.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    abstract class Vehicle
    {
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public string Fuel { get; set; }
        public int Wheels { get; set; }
        public double WeightSupported { get; set; }
        public double Autonomy { get; set; }

        public abstract string Type();

        public virtual void showInfo()
        {
            Console.WriteLine($"Marca: {Brand}, Modelo: {ModelName}, Rodas: {Wheels}, Combustivel: {Fuel}");
        }

        public Vehicle()
        {
        }
    }
}
