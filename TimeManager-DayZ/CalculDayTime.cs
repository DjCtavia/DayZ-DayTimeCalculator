using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManager_DayZ
{
    public class CalculDayTime
    {
        static public decimal CalculMinOrMaxDay(decimal baseNumber, float percentToFind)
        {
            decimal ToReturn = baseNumber;
            decimal AddOrSubstract = 1;
            float result = 1;

            if (percentToFind > 1)
                AddOrSubstract = -1;
            while (result != percentToFind)
            {
                ToReturn = ToReturn + AddOrSubstract;
                result = (float)baseNumber / (float)ToReturn;
            }
            return ToReturn;
        }

        static public decimal CalculMinOrMaxDay(NumericUpDown n_hours, NumericUpDown n_minutes, NumericUpDown n_seconds, float percentToFind)
        {
            decimal baseNumber = GetTimeInSeconds(n_hours, n_minutes, n_seconds);
            decimal ToReturn;

            if (percentToFind > 1)
                ToReturn = GetHighestPercent(baseNumber, percentToFind);
            else
                ToReturn = GetLowestPercent(baseNumber, percentToFind);
            return ToReturn;
        }

        static public decimal GetLowestPercent(decimal baseNumber, float percentToFind)
        {
            decimal number = baseNumber;
            double percent = (double)baseNumber / (double)number;
            double pPercent = percent + 0.1f;

            while (percent < pPercent && percent > percentToFind)
            {
                pPercent = percent;
                number += 3600;
                if (number == 0)
                    break;
                percent = (float)(baseNumber / number);
            }
            if (percent == percentToFind)
                return number;
            number -= 3600;
            percent = pPercent;
            pPercent -= 0.1f;
            while (percent < pPercent && percent > percentToFind)
            {
                pPercent = percent;
                number += 60;
                if (number == 0)
                    break;
                percent = (float)(baseNumber / number);
            }
            if (percent == percentToFind)
                return number;
            number -= 60;
            percent = pPercent;
            pPercent -= 0.1f;
            while (percent < pPercent && percent > percentToFind)
            {
                pPercent = percent;
                ++number;
                if (number == 0)
                    break;
                percent = (float)(baseNumber / number);
            }
            if (percent == percentToFind)
                return number;
            --number;
            return number;
        }

        static public decimal GetHighestPercent(decimal baseNumber, float percentToFind)
        {
            decimal number = baseNumber;
            float percent = (float)baseNumber / (float)number;
            float pPercent = percent - 0.1f;

            while (percent > pPercent && percent < percentToFind)
            {
                pPercent = percent;
                number -= 3600;
                if (number == 0)
                    break;
                percent = (float)(baseNumber / number);
            }
            if (percent == percentToFind)
                return number;
            number += 3600;
            percent = pPercent;
            pPercent -= 0.1f;
            while (percent > pPercent && percent < percentToFind)
            {
                pPercent = percent;
                number -= 60;
                if (number == 0)
                    break;
                percent = (float)(baseNumber / number);
            }
            if (percent == percentToFind)
                return number;
            number += 60;
            percent = pPercent;
            pPercent -= 0.1f;
            while (percent > pPercent && percent < percentToFind)
            {
                pPercent = percent;
                --number;
                if (number == 0)
                    break;
                percent = (float)(baseNumber / number);
            }
            if (percent == percentToFind)
                return number;
            ++number;
            return number;
        }

        static public float GetPercent(decimal baseNumber, decimal toVerify)
        {
            return (float)baseNumber / (float)toVerify;
        }

        static public void SetTime(decimal time, NumericUpDown n_hours, NumericUpDown n_minutes, NumericUpDown n_seconds)
        {
            int n_time = (int)time;
            decimal hours = (decimal)Math.Floor((double)n_time / 3600);
            n_time -= (int)hours * 3600;
            decimal minutes = (decimal)Math.Floor((double)n_time / 60);
            n_time -= (int)minutes * 60;
            decimal seconds = n_time;

            Console.WriteLine(hours.ToString() + minutes.ToString() + seconds.ToString()) ;
            n_hours.Value = hours;
            n_minutes.Value = minutes;
            n_seconds.Value = seconds;
        }

        static public decimal GetTimeInSeconds(NumericUpDown n_hours, NumericUpDown n_minutes, NumericUpDown n_seconds)
        {
            decimal toReturn = n_hours.Value * 3600;

            toReturn += n_minutes.Value * 60;
            toReturn += n_seconds.Value;
            return toReturn;
        }

        static public decimal GetTimeInSeconds(decimal n_hours, decimal n_minutes, decimal n_seconds)
        {
            decimal toReturn = n_hours * 3600;

            toReturn += n_minutes * 60;
            toReturn += n_seconds;
            return toReturn;
        }

        static public int[] GetArrayTime(decimal nTime)
        {
            int[] timeArray = new int[3];
            decimal n_time = nTime;

            timeArray[0] = (int)Math.Floor(n_time / 3600);
            n_time -= timeArray[0] * 3600;
            timeArray[1] = (int)Math.Floor(n_time / 60);
            n_time -= timeArray[1] * 60;
            timeArray[2] = (int)n_time;
            return timeArray;
        }
    }
}
