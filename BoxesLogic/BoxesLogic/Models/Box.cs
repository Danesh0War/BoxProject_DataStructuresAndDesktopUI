using System;

namespace BoxesDS
{
    public class Box : IComparable<Box>
    {
        private double sizeX;
        private double sizeY;
        private int quantity;

        public double SizeX
        {
            get { return sizeX; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("SizeX must be a positive value.");
                }
                sizeX = value;
            }
        }

        public double SizeY
        {
            get { return sizeY; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("SizeY must be a positive value.");
                }
                sizeY = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Quantity must be positive.");
                }
                quantity = value;
            }
        }
        public DateTime LastUsed { get; set; } = DateTime.Now;


        public Box(double sizeX, double sizeY)
        {
            SizeX = sizeX;
            SizeY = sizeY;
        }

        public override string ToString()
        {
            return $"{SizeX} x {SizeY}";
        }

        public int CompareTo(Box other)
        {
            int comparison = SizeX.CompareTo(other.SizeX);
            if (comparison == 0)
            {
                return SizeY.CompareTo(other.SizeY);
            }
            else
            {
                return comparison;
            }

        }

        public Box Copy()
        {
            Box newBox = new Box(this.SizeX, this.SizeY);
            newBox.Quantity = this.Quantity;
            newBox.LastUsed = this.LastUsed;
            return newBox;
        }

    }


}
