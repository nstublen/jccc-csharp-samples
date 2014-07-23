using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsCalculator
{
    class Calculator
    {
        private double mSum;
        private int mCount;
        private double? mMax;
        private double? mMin;

        public void AddValue(double inNewValue)
        {
            mSum += inNewValue;
            mCount++;

            if (mMax.HasValue)
            {
                mMax = Math.Max(inNewValue, mMax.Value);
            }
            else
            {
                mMax = inNewValue;
            }

            if (mMin.HasValue)
            {
                mMin = Math.Min(inNewValue, mMin.Value);
            }
            else
            {
                mMin = inNewValue;
            }
        }

        public double Average
        {
            get { return mSum / mCount; }
        }

        public int Count
        {
            get { return mCount; }
        }

        public double? Maximum
        {
            get { return mMax; }
        }

        public double? Minimum
        {
            get { return mMin; }
        }

        public double Sum
        {
            get { return mSum; }
        }
    }
}
