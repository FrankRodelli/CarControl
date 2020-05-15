using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CarControl.Models
{
    class CarDataSimulator
    {
        public CarDataSimulator()
        {

            Thread speed = new Thread(GenerateSpeed);
            Thread rpm = new Thread(GenerateRPM);
            Thread temp = new Thread(GenerateTemp);
            Thread gas = new Thread(GenerateGas);

            speed.Start();
            rpm.Start();
            temp.Start();
            gas.Start();
        }

        public void GenerateSpeed()
        {
            while (true)
            {
                Random r = new Random();
                CarData.Speed = r.Next(0, 100);
                Thread.Sleep(100);
                DisplayReadouts();
            }
        }

        public void GenerateRPM()
        {
            while (true)
            {
                Random r = new Random();
                CarData.RPM = r.Next(0, 7000);
                Thread.Sleep(100);
            }

        }
        public void GenerateTemp()
        {
            while (true)
            {
                Random r = new Random();
                CarData.Temp = Math.Round(r.NextDouble() * 100,2);
                Thread.Sleep(100);
            }
        }
        public void GenerateGas()
        {
            CarData.Gas = 1;

            while (true)
            {
                CarData.Gas -=.01;
                Thread.Sleep(500);
            }
        }

        public void DisplayReadouts()
        {
            Console.WriteLine(string.Format("Speed: {0}\nRPM: {1}\nTemp: {2}\nGas: {3}\n", CarData.Speed, CarData.RPM, CarData.Temp, CarData.Gas));
        }
    }
}
