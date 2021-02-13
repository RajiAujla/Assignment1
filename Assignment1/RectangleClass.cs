using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class RectangleClass
    {
        private int length_rec, width_rec;

        //Default Constructor
        public RectangleClass()
        {
            length_rec = 1;
            width_rec = 1;
        }

        //Non-default constructor
        public RectangleClass(int userLength,int userWidth)
        {
            length_rec = userLength;
            width_rec = userWidth;
        }

        //Methods
        public int GetLength()
        {
            return length_rec;
        }

        public int SetLength(int length)
        {
           return length_rec = length;
        }

        public int GetWidth()
        {
            return width_rec;
        }

        public int SetWidth(int width)
        {
            return width_rec = width;
        }

        public int GetPerimeter()
        {
            return 2*(length_rec + width_rec);
        }

        public int GetArea()
        {
            return length_rec * width_rec;
        }
    }
}
