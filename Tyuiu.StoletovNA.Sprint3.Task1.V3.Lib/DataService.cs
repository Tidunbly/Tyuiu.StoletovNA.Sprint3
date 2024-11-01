﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StoletovNA.Sprint3.Task1.V3.Lib
{
    public class DataService : ISprint3Task1V3 {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries *= startValue / Math.Pow(Math.Cos(5) + 1, 2);
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
