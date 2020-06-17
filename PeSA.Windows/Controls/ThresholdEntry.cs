using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeSA.Windows.Controls
{
    public partial class ThresholdEntry : UserControl
    {
        bool skipSetPositiveThreshold = false;
        bool skipSetNegativeThreshold = false;
        double positiveThreshold = 0.5, negativeThreshold = 0.5;

        private event EventHandler thresholdChanged;
        public event EventHandler ThresholdChanged { add => thresholdChanged += value; remove => thresholdChanged -= value; }

        public ThresholdEntry()
        {
            InitializeComponent();
        }

        public void SetInitialValues(double pos, double neg)
        {
            skipSetPositiveThreshold = true;
            PositiveThreshold = pos;
            skipSetPositiveThreshold = false;

            skipSetNegativeThreshold = true;
            NegativeThreshold = neg;
            skipSetNegativeThreshold = false;
        }

        public double PositiveThreshold
        {
            get { return positiveThreshold; }
            set
            {
                positiveThreshold = value;
                eThreshold.Text = value.ToString();
                FormUtil.SetTrackBarValue(trackThreshold, (int)(value * 100));
            }
        }

        public double NegativeThreshold
        {
            get { return negativeThreshold; }
            set
            {
                negativeThreshold = value;
                eNegativeThreshold.Text = value.ToString();
                FormUtil.SetTrackBarValue(trackNegativeThreshold, (int)(value * 100));
            }
        }


        private void eThreshold_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(eThreshold.Text, out double d))
            {
                skipSetPositiveThreshold = true;
                SetPositiveThreshold(d);
                skipSetPositiveThreshold = false;
            }
        }

        private void trackThreshold_ValueChanged(object sender, EventArgs e)
        {
            if (skipSetPositiveThreshold) return;
            if (trackThresholdMouseDown) return;
            if (sender == trackThreshold)
            {
                double d = (double)trackThreshold.Value / 100;
                eThreshold.Text = d.ToString();
                SetPositiveThreshold(d);
            }
        }

        public bool trackThresholdMouseDown = false;
        private void trackThreshold_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            trackThresholdMouseDown = true;
        }

        private void trackThreshold_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            trackThresholdMouseDown = false;
            trackThreshold_ValueChanged(sender, null);
        }


        private void SetPositiveThreshold(double val)
        {
            PositiveThreshold = val;
            if (negativeThreshold>positiveThreshold)
                NegativeThreshold = val;
            thresholdChanged?.Invoke(this, new EventArgs());

        }

        private void eNegativeThreshold_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(eNegativeThreshold.Text, out double d))
            {
                skipSetNegativeThreshold = true;
                SetNegativeThreshold(d);
                skipSetNegativeThreshold = false;
            }
        }

        private void trackNegativeThreshold_ValueChanged(object sender, EventArgs e)
        {
            if (skipSetNegativeThreshold) return;
            if (trackNegThresholdMouseDown) return;
            if (sender == trackNegativeThreshold)
            {
                double d = (double)trackNegativeThreshold.Value / 100;
                eNegativeThreshold.Text = d.ToString();
                SetNegativeThreshold(d);
            }

        }

        public bool trackNegThresholdMouseDown = false;
        private void trackNegativeThreshold_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            trackNegThresholdMouseDown = true;
        }

        private void trackNegativeThreshold_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            trackNegThresholdMouseDown = false;
            trackNegativeThreshold_ValueChanged(sender, null);
        }

        private void SetNegativeThreshold(double val)
        {
            NegativeThreshold = val;
            if (negativeThreshold > positiveThreshold)
                PositiveThreshold= val;
            thresholdChanged?.Invoke(this, new EventArgs());
        }
    }
}
