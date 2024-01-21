using System;

namespace LiskovSubstitutionPrinciple1
{
    public class Size
    {
        public double Height { get; init; }
        public double Width { get; init; }

        public Size(double height, double width)
        {
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height), "Height can not be negative");
            }

            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(width), "Width can not be negative");
            }

            this.Height = height;
            this.Width = width;
        }
    }
}
