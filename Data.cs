namespace TesteTecnico2023
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Model;
    static class Data
    {
        public static List<Vehicle> VEHICLES = new List<Vehicle>();
        public static List<Fuel> FUEL_PRICES = new List<Fuel>();
        public static string[] VEHICLE_TYPES = new string[] { "Carro", "Moto", "Caminhao", "Aviao" };
        public static string[] FUEL_TYPES = new string[] { "Gasolina", "Álcool", "Diesel" };
    }
}
