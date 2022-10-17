using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment
{
    class Box
    {
        private double length;
        private double breadth;


        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public double getlength()
        {
            return length + breadth;
        }
        public double getbreadth()
        {
            return length + breadth;
        }

    }

    class Box1
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double length;
            double breadth;

            Box1.setLength(12);
            Box1.setBreadth(34);

            Box2.setLength(56);
            Box2.setBreadth(78);


            length = Box1.getlength();
            Console.WriteLine("length of Box1 : {0}", length);

            length = Box2.getlength();
            Console.WriteLine("length of Box2 : {0}", length);

            Console.ReadLine();


            breadth = Box1.getbreadth();
            Console.WriteLine("breadth of Box1 : {0}", breadth);

            breadth = Box2.getbreadth();
            Console.WriteLine("breadth of Box2 : {0}", breadth);
            Console.ReadLine();


        }
    }
}
