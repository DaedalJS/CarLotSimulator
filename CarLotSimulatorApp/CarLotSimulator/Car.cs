﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CarLotSimulator
{   public static class CarLot 
    {
        public static int numberOfCars = 0;
    }
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }
        public Car()
        {
            CarLot.numberOfCars++;
        }


        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable = false)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDriveable;
            CarLot.numberOfCars++;
        }
         
        public void makeEngineNoise() 
        {
            Console.WriteLine(this.EngineNoise);
        }

        public void makeHonkNoise()
        {
            Console.WriteLine(this.HonkNoise);
        }
        
    }
}
