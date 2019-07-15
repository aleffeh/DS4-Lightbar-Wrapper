using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DS4Windows;

namespace Tester
{
    public partial class Form1 : Form
    {
        private DS4Device ds4;
        private byte r;
        private byte g;
        private byte b;

        public Form1()
        {
            InitializeComponent();
            GetDS4();
        }

        private void GetDS4()
        {
            DS4Devices.findControllers(); //Finds all DS4 using directInput --> look for xInput and directInput for more info 
            var list = DS4Devices.getDS4Controllers(); // Get an enumerable with all devices encountered.
            ds4 = list.First(); 
            ds4.StartUpdate(); // Starts the updating process on selected device --> this will start another thread to process all the inputs recieved from controller.

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ResetValues();
            UpdateColors();
        }

        void UpdateColors()
        {
            pbResult.BackColor = Color.FromArgb(r, g, b);
            ds4.LightBarColor = new DS4Color(r, g, b); // Get the colors from ui and send to ds4 through DS4Color class.

            rTrack.Value = r;
            gTrack.Value = g;
            bTrack.Value = b;

            rLbl.Text = r.ToString();
            gLbl.Text = g.ToString();
            bLbl.Text = b.ToString();

        }
        private void ResetValues()
        {
            rTrack.Value = 0;
            gTrack.Value = 0;
            bTrack.Value = 0;
            r = 0;
            g = 0;
            b = 0;
            txtHex.Text = "";
        }

        // Keep updating r,g,b vars every time sliders change value.
        #region Trackers
        private void RTrack_Scroll(object sender, EventArgs e)
        {
            rLbl.Text = rTrack.Value.ToString();
            r = (byte)rTrack.Value;
            UpdateColors();

        }

        private void GTrack_Scroll(object sender, EventArgs e)
        {
            gLbl.Text = gTrack.Value.ToString();
            g = (byte)gTrack.Value;
            UpdateColors();

        }

        private void BTrack_Scroll(object sender, EventArgs e)
        {
            bLbl.Text = bTrack.Value.ToString();
            b = (byte)bTrack.Value;
            UpdateColors();
        }
        #endregion

        private void Button2_Click(object sender, EventArgs e) // Get the input, verify if is a valid hex color, convert to rgb, update ui and send to ds4.
        {
            if (!IsValidHex(txtHex.Text))
            {
                MessageBox.Show("Digite um valor hex válido!");
                return;
            }

            var color = HexToColor(txtHex.Text);
            r = color.R;
            g = color.G;
            b = color.B;
            UpdateColors();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DS4Devices.stopControllers(); // Kill all connections with ds4 devices connected. leting the control to host os.
        }

        //A simple checker and converter from hex to Color. 
        #region Color Converter
        public static Color HexToColor(string hexColor)
        {
            //Remove # if present
            if (hexColor.IndexOf('#') != -1)
                hexColor = hexColor.Replace("#", "");

            int red = 0;
            int green = 0;
            int blue = 0;

            if (hexColor.Length == 6)
            {
                //#RRGGBB
                red = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                green = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                blue = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);


            }
            else if (hexColor.Length == 3)
            {
                //#RGB
                red = int.Parse(hexColor[0].ToString() + hexColor[0].ToString(), NumberStyles.AllowHexSpecifier);
                green = int.Parse(hexColor[1].ToString() + hexColor[1].ToString(), NumberStyles.AllowHexSpecifier);
                blue = int.Parse(hexColor[2].ToString() + hexColor[2].ToString(), NumberStyles.AllowHexSpecifier);
            }

            return Color.FromArgb(red, green, blue);
        }

        public static bool IsValidHex(string hexColor)
        {
            if (hexColor.StartsWith("#"))
                return hexColor.Length == 7 || hexColor.Length == 4;
            else
                return hexColor.Length == 6 || hexColor.Length == 3;
        }
        #endregion

    }
}
