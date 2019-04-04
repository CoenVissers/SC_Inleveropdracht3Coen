// Vergeleken met bestand van Loes
// Samen gemaakt door Hakan & Coen

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poging3
{
    public partial class Form1 : Form
    {
        private double R;
        private double G;
        private double B;

        private double H;
        private double S;
        private double L;
        private double V;

        private bool suspendEventsHSV = false;
        private bool suspendEventsHSL = false;
        private bool suspendEventsRGB = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trbRed_Scroll(object sender, EventArgs e)
        {

        }

        private void UpDownToTrackbar(object sender, EventArgs e)
        {
            if(suspendEventsHSL)
            {
                return;
            }
            if(suspendEventsHSV)
            {
                return;
            }
            trbRed.Value = Convert.ToInt32(nudRed.Value);
            trbGreen.Value = Convert.ToInt32(nudGreen.Value);
            trbBlue.Value = Convert.ToInt32(nudBlue.Value);
        }

        private void UpdateFromRGB(object sender, EventArgs e)
        {
            if(suspendEventsHSL)
            {
                return;
            }
            if (suspendEventsHSV)
            {
                return;
            }
            nudRed.Value = trbRed.Value;
            nudGreen.Value = trbGreen.Value;
            nudBlue.Value = trbBlue.Value;

            Color RGBColor = new Color();
            RGBColor = Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);

            suspendEventsRGB = true;
            // RGB to HSL and HSV
            double H = RGBColor.GetHue();
            trbHhsl.Value = (int)H;
            trbHhsv.Value = (int)H;
            double S = RGBColor.GetSaturation();
            trbShsl.Value = (int)(S * 100);
            trbShsv.Value = (int)(S * 100);
            double L = RGBColor.GetBrightness();
            trbLhsl.Value = (int)(L * 100);
            int max = Math.Max((int)trbRed.Value, Math.Max((int)trbGreen.Value, (int)trbBlue.Value));
            double V = (int)max / 255.0;
            trbVhsv.Value = (int)(V * 100);

            nudHhsl.Value = trbHhsl.Value;
            nudShsl.Value = trbShsl.Value;
            nudLhsl.Value = trbLhsl.Value;
            nudHhsv.Value = trbHhsv.Value;
            nudShsv.Value = trbShsv.Value;
            nudVhsv.Value = trbVhsv.Value;
            suspendEventsRGB = false;

            // Change Color
            pnlColorBox.BackColor = RGBColor;

            // Color code
            String webColorCode = String.Empty;
            webColorCode = '#' + RGBColor.R.ToString("X2") + RGBColor.G.ToString("X2") + RGBColor.B.ToString("X2");
            txtColorCode.Text = webColorCode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nudHhsl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudShsl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudLhsl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpDownToTrack(object sender, EventArgs e)
        {
            if (suspendEventsRGB)
            {
                return;
            }
            if (suspendEventsHSV)
            {
                return;
            }
            trbHhsl.Value = Convert.ToInt32(nudHhsl.Value);
            trbShsl.Value = Convert.ToInt32(nudShsl.Value);
            trbLhsl.Value = Convert.ToInt32(nudLhsl.Value);
        }

        private void UpdateFromHSL(object sender, EventArgs e)
        {
            if (suspendEventsRGB)
            {
                return;
            }
            if (suspendEventsHSV)
            {
                return;
            }
            nudHhsl.Value = trbHhsl.Value;
            nudShsl.Value = trbShsl.Value;
            nudLhsl.Value = trbLhsl.Value;

            double H = trbHhsl.Value;
            double S = trbShsl.Value / 100.0;
            double L = trbLhsl.Value / 100.0;

            // Bron: https://en.wikipedia.org/wiki/HSL_and_HSV#HSV
            double C = (1 - Math.Abs(2 * L - 1)) * S;
            double H1 = H / 60.0;
            double X = C * (1 - Math.Abs(H1 % 2 - 1));

            double R1, G1, B1;
            R1 = 0;
            G1 = 0;
            B1 = 0;

            if (0 <= H1 && H1 <= 1)
            {
                R1 = C;
                G1 = X;
            }
            else if (1 <= H1 && H1 <= 2)
            {
                R1 = X;
                G1 = C;
            }
            else if (2 <= H1 && H1 <= 3)
            {
                G1 = C;
                B1 = X;
            }
            else if (3 <= H1 && H1 <= 4)
            {
                G1 = X;
                B1 = C;
            }
            else if (4 <= H1 && H1 <= 5)
            {
                R1 = X;
                B1 = C;
            }
            else if (5 <= H1 && H1 <= 6)
            {
                R1 = C;
                B1 = X;
            }

            double m = L - (C / 2);

            suspendEventsHSL = true;
            double maxRGB = 255.0;
            trbRed.Value = (int)((R1 + m) * maxRGB);
            trbGreen.Value = (int)((G1 + m) * maxRGB);
            trbBlue.Value = (int)((B1 + m) * maxRGB);
            trbHhsv.Value = trbHhsl.Value;
            trbShsv.Value = trbShsl.Value;
            int max = Math.Max((int)trbRed.Value, Math.Max((int)trbGreen.Value, (int)trbBlue.Value));
            double V = (int)max / 255.0;
            trbVhsv.Value = (int)(V * 100);

            nudRed.Value = trbRed.Value;
            nudGreen.Value = trbGreen.Value;
            nudBlue.Value = trbBlue.Value;
            nudHhsv.Value = trbHhsv.Value;
            nudShsv.Value = trbShsv.Value;
            nudVhsv.Value = trbVhsv.Value;
            suspendEventsHSL = false;

            Color RGBColor = new Color();
            RGBColor = Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
            
            // Change Color
            pnlColorBox.BackColor = RGBColor;

            // Color code
            String webColorCode = String.Empty;
            webColorCode = '#' + RGBColor.R.ToString("X2") + RGBColor.G.ToString("X2") + RGBColor.B.ToString("X2");
            txtColorCode.Text = webColorCode;

        }

        private void UpDownToTrackbarHSV(object sender, EventArgs e)
        {
            if (suspendEventsRGB)
            {
                return;
            }
            if (suspendEventsHSL)
            {
                return;
            }
            trbHhsv.Value = Convert.ToInt32(nudHhsv.Value);
            trbShsv.Value = Convert.ToInt32(nudShsv.Value);
            trbVhsv.Value = Convert.ToInt32(nudVhsv.Value);
        }

        private void UpdateFromHSV(object sender, EventArgs e)
        {
            if (suspendEventsRGB)
            {
                return;
            }
            if (suspendEventsHSL)
            {
                return;
            }
            nudHhsv.Value = trbHhsv.Value;
            nudShsv.Value = trbShsv.Value;
            nudVhsv.Value = trbVhsv.Value;

            double H = trbHhsv.Value;
            double S = trbShsv.Value / 100.0;
            double V = trbVhsv.Value / 100.0;

            double C = (double)(V * S);
            double H1 = H / 60.0;
            double X = C * (1 - Math.Abs(H1 % 2 - 1));

            double R1, G1, B1;
            R1 = 0.0;
            G1 = 0.0;
            B1 = 0.0;

            if (0 <= H1 && H1 <= 1)
            {
                R1 = C;
                G1 = X;
            }
            else if (1 <= H1 && H1 <= 2)
            {
                R1 = X;
                G1 = C;
            }
            else if (2 <= H1 && H1 <= 3)
            {
                G1 = C;
                B1 = X;
            }
            else if (3 <= H1 && H1 <= 4)
            {
                G1 = X;
                B1 = C;
            }
            else if (4 <= H1 && H1 <= 5)
            {
                R1 = X;
                B1 = C;
            }
            else if (5 <= H1 && H1 <= 6)
            {
                R1 = C;
                B1 = X;
            }

            double m = V - C;

            suspendEventsHSV = true;
            double maxRGB = 255.0;
            trbRed.Value = (int)((R1 + m) * maxRGB);
            trbGreen.Value = (int)((G1 + m) * maxRGB);
            trbBlue.Value = (int)((B1 + m) * maxRGB);
            trbHhsl.Value = trbHhsv.Value;
            trbShsl.Value = trbShsv.Value;

            nudRed.Value = trbRed.Value;
            nudGreen.Value = trbGreen.Value;
            nudBlue.Value = trbBlue.Value;
            nudHhsl.Value = trbHhsl.Value;
            nudShsl.Value = trbShsl.Value;
            
            Color RGBColor = new Color();
            RGBColor = Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);

            double L = RGBColor.GetBrightness();
            trbLhsl.Value = (int)(L * 100);
            nudLhsl.Value = trbLhsl.Value;
            suspendEventsHSV = false;

            // Change Color
            pnlColorBox.BackColor = RGBColor;

            // Color code
            String webColorCode = String.Empty;
            webColorCode = '#' + RGBColor.R.ToString("X2") + RGBColor.G.ToString("X2") + RGBColor.B.ToString("X2");
            txtColorCode.Text = webColorCode;
        }
    }
}
