using System;

namespace BoxesDS
{
    // Class to serve as a composite key for box dimensions.
    // Implements IComparable for use in sorted collections.
    // Designed to be serializable.

    public class BoxKey : IComparable<BoxKey> 
    {
        public double SizeX { get; set; }
        public double SizeY { get; set; }

        public BoxKey(double sizeX, double sizeY)
        {
            SizeX = sizeX;
            SizeY = sizeY;
        }

        // Compares this instance with a specified BoxKey object.
        // Used for sorting purposes.

        public int CompareTo(BoxKey other)
        {
            // First compare by SizeX, then by SizeY if necessary.

            int comparison = SizeX.CompareTo(other.SizeX);
            return comparison == 0 ? SizeY.CompareTo(other.SizeY) : comparison;
        }

        // Overrides the Equals method for object comparison.
        public override bool Equals(object obj)
        {
            // Checks if the object can be cast to BoxKey and then compares dimensions.

            if (obj is BoxKey other)
            {
                return SizeX == other.SizeX && SizeY == other.SizeY;
            }
            return false;
        }

        // Overrides GetHashCode to provide a hash based on dimensions!

        public override int GetHashCode()
        {
            return HashCode.Combine(SizeX, SizeY);
        }

    }
}
