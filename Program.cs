using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Business_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            MainStore mainStore = new MainStore();
            LoadData.inputDrivers(ref mainStore.drivers);
            LoadData.inputCars(ref mainStore.cars);
            LoadData.inputManagers(ref mainStore.managers);
            LoadData.inputProducts(ref mainStore.products);
            LoadData.inputMotorbikes(ref mainStore.motorbikes);
            LoadData.inputTrucks(ref mainStore.trucks);
            LoadData.inputStores(ref mainStore.stores);
            
            //  Serializator ser = new Serializator(new XMLSerializator(typeof(Store)));
            //  ser.Serialize(store, @"C:\Users\Danylo\source\repos\OOProject\store1.txt");
            Calculator.SetStore(ref mainStore);
            var productList = mainStore.displayProducts();
            foreach (var product in productList) Console.WriteLine(product);
            for (int i = 0; i < 20; i++)
            {
                string name = Console.ReadLine();
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Calculator.timeToDeliver(name, id));
            }
            Console.Read();

            
        }

    }
}
