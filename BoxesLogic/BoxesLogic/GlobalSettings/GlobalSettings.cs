using System;

namespace BoxesDS
{
    // Global variables, have default values, can me adjusted by the user any time
    // The settings are saved for the program life-time until re-set occurs
    public class GlobalSettings 
    {
        private int _maxBoxQuantity;
        private int _minBoxQuantity;
        private double _dispersionLimitPercent;
        private TimeSpan _bestBeforeDuration;

        public int MaxBoxQuantity
        {
            get { return _maxBoxQuantity; }
            set
            {
                if (value < 1 || value > 100)
                    throw new ArgumentException("Max Box Quantity should be between 1 and 100");
                _maxBoxQuantity = value;
            }
        }

        public int MinBoxQuantity
        {
            get { return _minBoxQuantity; }
            set
            {
                if (value < 0 || value > MaxBoxQuantity)
                    throw new ArgumentException("Min Box Quantity should be between 0 and Max Box Quantity");
                _minBoxQuantity = value;
            }
        }


        public double DispersionLimitPercent
        {
            get { return _dispersionLimitPercent; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Dispersion Limit should be between 0 and 100");
                _dispersionLimitPercent = value;
            }

        }

        public TimeSpan BestBeforeDuration
        {
            get { return _bestBeforeDuration; }
            set
            {
                if (value.Minutes < 0 || value.Hours <0 || value.Days <0)
                    throw new ArgumentException("Best Before Duration should be positive");
                _bestBeforeDuration = value;
            }
        }

        private static GlobalSettings _instance;

        private GlobalSettings()
        {
            // Set default values in the constructor
            _maxBoxQuantity = 10;
            _minBoxQuantity = 1;
            _dispersionLimitPercent = 50;
            _bestBeforeDuration = TimeSpan.FromDays(5);
        }

        public static GlobalSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GlobalSettings();
                }
                return _instance;
            }
        }



    }
}
