using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Circle
    {
        private float r;
        public float radius
        {

            get

            {
                Console.WriteLine("Get: ");
                return r;
            }
            set
            {
                Console.WriteLine("Set: ");
                this.r = value;
            }
        }
        public void setRadius(float value)
        {
            this.r = value;

        }
    }
    class Circle2
    {
        private float r;

        public float radius
        {
            get
            {
                Console.WriteLine("Get: ");
                return r;

            }

            set
            {
                if (this.r > 0)
                {
                    this.r = value;
                }
                else
                {
                    throw new ArgumentException("Negative not allowed");
                }

            }
        }
    }


    class Circle3
    {
        private Double radius;

        public Double Radius
        {
            get { 
                return radius; 
            }
            set { 
                if (value > 0){
                radius = value;
                }else{
                throw new System.ArgumentException("Parameter cannot be < than 0", "original");;
                }
            }
        }

        public Circle3(Double radius)
        {

        }

        public Circle3()
        {
            this.radius = 0.0;
        }

        public Double getArea(Double rad) {

            return 3.14 * (rad * rad);
        }

    }
}



