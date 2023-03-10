using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter length :");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width :");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height :");
            int height = Convert.ToInt32(Console.ReadLine());

            var cube=new Cube(width,height,length);

            var triangle = new Triangle();
            var triangle1 = new Triangle() { Length = length, Height = height, Hypotenuese = 10 };
            var triangle2 = new Triangle(10);
            var triangle3 = new Triangle(length, height, 10);

            var rectangle = new Rectangle(length,width);


            //var cube = new Cube() { Length = length, Height = height, Width = width }; //v2
            //var triangle = new Triangle() { Length = length, Height = height, Hypotenuese = 10 };
            //var rectangle = new Rectangle() { Length = length, Width = width };

            //cube.Length = length;  //v1
            //cube.Width = width;
            //cube.Height = height;

            //triangle.Height = height;
            //triangle.Length = length;

            //rectangle.Length = length;
            //rectangle.Width = width;

            Console.WriteLine("Cube Area : " + cube.getArea());
            Console.WriteLine("Cube Volume : " + cube.getVolume());
            Console.WriteLine("Rectangle Area : " + rectangle.getArea());
            Console.WriteLine("Triangle Area : " + triangle.getArea());
            Console.WriteLine("Triangle Area : " + triangle1.getArea());
            Console.WriteLine("Triangle Area : " + triangle2.getArea());
            Console.WriteLine("Triangle Area : " + triangle3.getArea());


        }
    }
    interface IShape
    {
        double getArea();
    }
    abstract class Shape
    {
        public double Height { get; set; }
        public double Length { get; set; }

    }
    class Cube : Shape,IShape
    {
        public Cube(int width, int height, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }
        public double Width { get; set; }

        public double getArea()
        {
            return Length * Width;
        }

        public double getVolume()
        {
            return Length * Width * Height;
        }
    }
    class Rectangle : Shape,IShape
    {
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;

        }
        public double Width { get; set; }

        public double getArea()
        {
            return Length*Width;
        }
    }
    class Triangle : Shape,IShape
    {
        public Triangle()
        {
            
        }
        public Triangle(int hyp)
        {
            Hypotenuese = hyp;

        }
        public Triangle(int length, int height, int hyp)
        {
            Length = length;
            Height = height;
            Hypotenuese = hyp;

        }
        public double Hypotenuese { get; set; }

        public double getArea()
        {
            return .5 * Height * Length;
        }
    }
}
