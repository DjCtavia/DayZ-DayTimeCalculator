using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManager_DayZ
{
    public partial class Form1 : Form
    {
        protected const int MAXHOURSDAYTIME = 240;
        protected const int MAXMINUTESDAYTIME = 0;
        protected const int MAXSECONDSDAYTIME = 0;
        protected const int MAXALLDAYTIME = 864000;
        protected const int MINHOURSDAYTIME = 0;
        protected const int MINMINUTESDAYTIME = 22;
        protected const int MINSECONDSDAYTIME = 30;
        protected const int MINALLDAYTIME = 1350;

        protected decimal minTimeAll = -1;
        protected decimal maxTimeAll = -1;
        protected int[] minTime;
        protected int[] maxTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.label7, "If do not consider night duration, the format is based on 24 hours.\nIf night duration is set on true, only day time is considerate. (day time is from 5:01AM to 6:59PM)");
            toolTip1.SetToolTip(this.label6, "Night time is between 7PM to 5AM.\nWARNING: Night time can't be longer than day time.");
        }

        private void CheckBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsNightTime.Checked == true)
            {
                nightHours.Enabled = true;
                nightMinutes.Enabled = true;
                nightSeconds.Enabled = true;
            }
            else
            {
                nightHours.Enabled = false;
                nightMinutes.Enabled = false;
                nightSeconds.Enabled = false;
            }
        }
        // Min value must be 0.1 and max 64

        private void DaySeconds_ValueChanged(object sender, EventArgs e)
        {
            MinMaxDayTime();
        }

        private void DayMinutes_ValueChanged(object sender, EventArgs e)
        {
            MinMaxDayTime();
        }

        private void DayHours_ValueChanged(object sender, EventArgs e)
        {
            MinMaxDayTime();
        }

        private void NightSeconds_ValueChanged(object sender, EventArgs e)
        {
            MinMaxNightTime();
        }

        private void NightMinutes_ValueChanged(object sender, EventArgs e)
        {
            MinMaxNightTime();
        }

        private void NightHours_ValueChanged(object sender, EventArgs e)
        {
            MinMaxNightTime();
        }

        private void MinMaxDayTime()
        {
            if (CalculDayTime.GetTimeInSeconds(dayHours, dayMinutes, daySeconds) < MINALLDAYTIME)
            {
                dayHours.Value = MINHOURSDAYTIME;
                dayMinutes.Value = MINMINUTESDAYTIME;
                daySeconds.Value = MINSECONDSDAYTIME;
            }
            if (CalculDayTime.GetTimeInSeconds(dayHours, dayMinutes, daySeconds) > MAXALLDAYTIME)
            {
                dayHours.Value = MAXHOURSDAYTIME;
                dayMinutes.Value = MAXMINUTESDAYTIME;
                daySeconds.Value = MAXSECONDSDAYTIME;
            }
        }

        private bool MinNightToLow()
        {
            if (nightHours.Value < minTime[0] ||
                (nightHours.Value == minTime[0] && nightMinutes.Value < minTime[1]) ||
                (nightHours.Value == minTime[0] && nightMinutes.Value == minTime[1] && nightSeconds.Value < minTime[2]))
                return true;
            return false;
        }

        private bool MaxNightToHigh()
        {
            if (nightHours.Value > maxTime[0] ||
                (nightHours.Value == maxTime[0] && nightMinutes.Value > maxTime[1]) ||
                (nightHours.Value == maxTime[0] && nightMinutes.Value == maxTime[1] && nightSeconds.Value > maxTime[2]))
                return true;
            return false;
        }

        private void MinMaxNightTime()
        {
            if (IsNightTime.Checked)
            {
                if (MinNightToLow())
                {
                    nightHours.Value = minTime[0];
                    nightMinutes.Value = minTime[1];
                    nightSeconds.Value = minTime[2];
                }
                if (MaxNightToHigh())
                {
                    nightHours.Value = maxTime[0];
                    nightMinutes.Value = maxTime[1];
                    nightSeconds.Value = maxTime[2];
                }
            }
        }

        private void IsNightTime_CheckedChanged(object sender, EventArgs e)
        {
            if (IsNightTime.Checked)
            {
                maxTimeAll = CalculDayTime.CalculMinOrMaxDay(dayHours, dayMinutes, daySeconds, 0.1f);
                minTimeAll = CalculDayTime.CalculMinOrMaxDay(dayHours, dayMinutes, daySeconds, 64f);
                if (minTime == null)
                    minTime = CalculDayTime.GetArrayTime(minTimeAll);
                if (maxTime == null)
                    maxTime = CalculDayTime.GetArrayTime(maxTimeAll);
                ChangeLabelMinMaxNight();
                MinMaxNightTime();
            }
            else
            {
                minTimeAll = -1;
                maxTimeAll = -1;
                if (minTime != null)
                    minTime = null;
                if (maxTime != null)
                    maxTime = null;
            }
        }

        private void ChangeLabelMinMaxNight()
        {
            lMinHoursNight.Text = minTime[0].ToString();
            lMinMinutesNight.Text = minTime[1].ToString();
            lMinSecondsNight.Text = minTime[2].ToString();
            lMaxHoursNight.Text = maxTime[0].ToString();
            lMaxMinutesNight.Text = maxTime[1].ToString();
            lMaxSecondsNight.Text = maxTime[2].ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string dayMultiplier = CalculDayTime.GetPercent(86400, CalculDayTime.GetTimeInSeconds(dayHours, dayMinutes, daySeconds)).ToString();
            string nightMultiplier;

            dayMultiplier.Replace(',', '.');
            richTextBox1.Text = "serverTimeAcceleration=" + dayMultiplier + "; // Must be in range of 64-0.1";
            if (IsNightTime.Checked)
            {
                nightMultiplier = CalculDayTime.GetPercent(CalculDayTime.GetTimeInSeconds(dayHours, dayMinutes, daySeconds), CalculDayTime.GetTimeInSeconds(nightHours, nightMinutes, nightSeconds)).ToString();
                nightMultiplier.Replace(',', '.');
                richTextBox1.AppendText("\nserverNightTimeAcceleration=" + nightMultiplier + "; // Must be in range of 64-0.1");
                richTextBox1.AppendText("\n\n// Careful, if you change Day duration, you need to uncheck and recheck 'Consider night duration', min-max range is not updated by default for night.");
            }
        }
    }
}
