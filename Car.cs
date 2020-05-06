using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace SimpleException284
{
    class Car
    {
        public int MaxSpeed = 150;

        public int CurrentSpeed { get; set; } = 0;
        public string PetNaNE { get; set; } = "";


        private bool IsDead;




        private Radio TheMusicBox = new Radio();

        public Car() { }
        public Car(int Speed,string Name)
        {
            CurrentSpeed = Speed;
            PetNaNE = Name;
        }
        public void TurnTunes(bool state)
        {
            TheMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if(IsDead)
                Console.WriteLine("{0} is out of order...", PetNaNE);
            else
            {
                CurrentSpeed += delta;
                if( CurrentSpeed>=MaxSpeed)
                {
                    
                    CurrentSpeed = 0;
                    IsDead = true;
                    Exception exception = new Exception($"{PetNaNE} has overheated");

                    
                    exception.HelpLink = "http://www.CarsRUs.com";
                    exception.Data.Add("TimeStamp",$"The car exploded at {DateTime.Now}");
                    exception.Data.Add("Cause", "You have a lead foot.");
                    throw exception;

                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }

        }
    }
}
