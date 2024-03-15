using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {

        // Private attributes
        private int length;
        private int width;

        // Here default constructor to set default value ONE to both attributes 
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        //Non-Default constructor to Set Length and Width as user wants
        public Rectangle(int len, int wid)
        {
            this.length = len;
            this.width = wid;
        }

        // Method to GET Length of Rectangle
        public int GetLength()
        {
            return length;
        }

        // Method to SET Length of Rectangle
        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }

        // Method to GET Width of Rectangle
        public int GetWidth()
        {
            return width;
        }

        // Method to SET Width of Rectangle
        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }

        // Method to return Perimeter of Rectangle
        public int GetPerimeter()
        {
            return (2 * (width + length));
        }

        // Method to return Area of Rectangle
        public int GetArea()
        {
            return (length * width);
        }

    }
}
