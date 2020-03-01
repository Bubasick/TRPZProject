﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Business_Logic
{
    public static class LoadData
    {

        public static void inputDrivers(ref List<Driver> drivers)
        {
            string textFile = @"D:\Навчання\TRPZ\Business Logic\drivers.txt";
            string[] lines = File.ReadAllLines(textFile);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(' ');
                drivers.Add(new Driver());
                drivers[i].motorbikePermit = bool.Parse(parts[0]);
                drivers[i].carPermit = bool.Parse(parts[1]);
                drivers[i].truckPermit = bool.Parse(parts[2]);

            }
        }
        public static void inputProducts(ref List<Product> products)
        {
            string textFile = @"D:\Навчання\TRPZ\Business Logic\products.txt";
            string[] lines = File.ReadAllLines(textFile);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(' ');
                products.Add(new Product());
                products[i].name = parts[0];
                products[i].price = Convert.ToInt32(parts[1]);
                products[i].size = Convert.ToInt32(parts[2]);

            }

        }
        public static void inputManagers(ref List<Manager> managers)
        {
            string textFile = @"D:\Навчання\TRPZ\Business Logic\managers.txt";
            string line = File.ReadAllText(textFile);
            int amountOfManagers = Convert.ToInt32(line);
            for (int i = 0; i < amountOfManagers; i++) managers.Add(new Manager());
        }
        public static void inputCars(ref List<Car> cars)
        {
            string textFile = @"D:\Навчання\TRPZ\Business Logic\cars.txt";
            string line = File.ReadAllText(textFile);
            int amountOfCars = Convert.ToInt32(line);
            for (int i = 0; i < amountOfCars; i++) cars.Add(new Car());
        }
        public static void inputTrucks(ref List<Truck> trucks)
        {
            string textFile = @"D:\Навчання\TRPZ\Business Logic\trucks.txt";
            string line = File.ReadAllText(textFile);
            int amountOfTrucks = Convert.ToInt32(line);
            for (int i = 0; i < amountOfTrucks; i++) trucks.Add(new Truck());
        }
        public static void inputMotorbikes(ref List<Motorbike> motorbikes)
        {
            string textFile = @"D:\Навчання\TRPZ\Business Logic\motorbikes.txt";
            string line = File.ReadAllText(textFile);
            int amountOfMotorbikes = Convert.ToInt32(line);
            for (int i = 0; i < amountOfMotorbikes; i++) motorbikes.Add(new Motorbike());
        }
        public static void inputStores(ref List<Store> stores)
        {
            string textFile = @"D:\Навчання\TRPZ\Business Logic\stores.txt";
            string[] lines = File.ReadAllLines(textFile);
            string line = lines[0];
            
            for (int i = 1; i <= Convert.ToInt32(line); i++) stores.Add(new Store(Convert.ToDouble(lines[i])));
        }
    }
}