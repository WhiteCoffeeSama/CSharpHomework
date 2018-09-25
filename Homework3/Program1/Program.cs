using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//以下有参照书上例题
namespace Program1
{
    public abstract class Shape
    {
        private string id;

        public Shape(string s)
        {
            ID = s;
        }

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public abstract double Area
        {
            get;
        }

        public virtual void Draw()
        {
            Console.WriteLine("绘制，虚方法");
        }

        //下一个函数我认为暂无用处
        public override string ToString()
        {
            return ID + " Area = " + string.Format("{0:F2}", Area);
        }
    }

    //我认为接下来暂不需要base(id)

    public class Square:Shape
    {
        private double mySide;

        public Square(double side, string id) : base(id)
        {
            mySide = side;
        }

        public override double Area
        {
            get
            {
                return mySide * mySide;
            }
        }

        public override void Draw()
        {
            Console.WriteLine("边长为" + mySide + "的正方形的面积为" + Area);
        }
    }

    public class Circle : Shape
    {
        private double myRadius;

        public Circle(double radius, string id):base(id)
        {
            myRadius = radius;
        }

        public override double Area
        {
            get
            {
                return myRadius * myRadius * Math.PI;
            }
        }

        public override void Draw()
        {
            Console.WriteLine("半径为" + myRadius + "的圆形的面积为" + Area);
        }
    }

    public class Rectangle : Shape
    {
        private double myWidth;
        private double myHeight;

        public Rectangle(double a, double b, string id):base(id)
        {
            myHeight = a > b ? a : b;
            myWidth = a > b ? b : a;
        }

        public override double Area
        {
            get
            {
                return myWidth * myHeight;
            }
        }

        public override void Draw()
        {
            Console.WriteLine("长为" + myHeight + "，宽为" + myWidth + "的矩形的面积为" + Area);
        }
    }

    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;
        private double[] d = new double[3];

        public Triangle(double a, double b, double c, string id):base(id)
        {
            //this.a = a <= b ? a : (b <= c ? b : c);
            //this.c = b >= this.a ? b : (c >= this.a ? c : a);
            //this.b = 

            d[0] = a;
            d[1] = b;
            d[2] = c;

            double temp = d[0];

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    if(d[j] > d[j+1])
                    {
                        temp = d[j + 1];
                        d[j + 1] = d[j];
                        d[j] = temp;
                    }
                }
            }
        }

        public override double Area
        {
            get
            {
                //借鉴现有求面积公式
                double p = (d[0] + d[1] + d[2]) / 2;
                double sum = Math.Sqrt(p * (p - d[0]) * (p - d[1]) * (p - d[2]));

                //错误
                //double sum = (d[0] * d[0] + d[1] * d[1] - d[2] * d[2]) / 4;
                return sum;
            }
        }

        public override void Draw()
        {
            Console.WriteLine("三边为{0}, {1}, {2}的三角形的面积为{3}", d[0], d[1], d[2], Area);
        }
    }

    public class Factory
    {
        public static Shape getShape(string type, double a = 0, double b = 0, double c = 0)
        {
            Shape shape = null;
            if (type.Equals("Square"))
                shape = new Square(a, type);
            else if (type.Equals("Circle"))
                shape = new Circle(a, type);
            else if (type.Equals("Rectangle"))
                shape = new Rectangle(a, b, type);
            else if (type.Equals("Triangle"))
                shape = new Triangle(a, b, c, type);
            return shape;
        }
    }

    class program
    {
        static void Main()
        {
            Shape square = Factory.getShape("Square", 1);
            square.Draw();
            Shape circle = Factory.getShape("Circle", 10);
            circle.Draw();
            Shape rectangle = Factory.getShape("Rectangle", 3, 4);
            rectangle.Draw();
            Shape triangle = Factory.getShape("Triangle", 3, 4, 5);
            triangle.Draw();

            Console.ReadLine();
        }
    }
}
