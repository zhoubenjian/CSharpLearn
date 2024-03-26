using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Class
{
    internal class Vehicle
    {
        private string _brand;
        private float _speed;
        private float _maxSpeed;
        private float _weight;


        public string Brand { get => _brand; set => _brand = value; }
        public float Speed 
        { 
            get => _speed; 
            set 
            {
                if (value >= 0)
                {
                    _speed = value;
                }
                else
                {
                    _speed = 0;
                }
            }
        }
        public float MaxSpeed 
        { 
            get => _maxSpeed; 
            set
            {
                if (value >= _maxSpeed)
                {
                    _maxSpeed = value;
                }
                else
                {
                    _maxSpeed = 0;
                }
            }
        }
        public float Weight 
        { 
            get => _weight; 
            set
            {
                if (value >= 0)
                {
                    _weight = value;
                }
                else
                {
                    _weight = 0;
                }
            }
        }


        public Vehicle(string brand, float speed, float maxSpeed, float weigth)
        {
            _brand = brand;
            _speed = speed;
            _maxSpeed = maxSpeed;
            _weight = weigth;
        }


        public void Run()
        {
            Console.WriteLine($"{_brand} was running...");
        }

        public void Stop()
        {
            Console.WriteLine($"{_brand} stopped");
        }
    }
}
