using System;
using System.Collections.Generic;
using System.Text;

namespace ValueAndReferenceType
{
    struct Rectangle
    {
        public ShapeInfo ShInfo;
        public int Top, Left, Bottom, Right;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            ShInfo = new ShapeInfo(info);
            Top = top;
            Left = left;
            Bottom = bottom;
            Right = right;
        }

        public void Display()
        {
            Console.WriteLine($"info = {ShInfo.Info}," +
                              $" top = {Top}, " +
                              $"left = {Left}, " +
                              $"bottom = {Bottom}, " +
                              $"right = {Right}");
        }
    }
}
