using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverlntensity;
        public string name;
        public void SetDriverName(String name)
        {
           this.name = name;
        }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverlntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!" );
            }
        }
        public Motorcycle() { Console.WriteLine("In default ctor"); }
        public Motorcycle(int intensity)
        : this(intensity,"") { Console.WriteLine("In ctor taking an int"); }
        public Motorcycle(string name)
        : this(0, name) { Console.WriteLine("In ctor taking a string"); }
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("In master ctor ");
            SetIntensity(intensity);
            this.name = name;            
        }
        public void SetIntensity(int intensity) 
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverlntensity = intensity;
        }
    }     
}

