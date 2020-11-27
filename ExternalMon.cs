using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContaPersone
{
    public partial class ExternalMon : Form
    {
        public static int s_personNumber { set; get; }
        public static bool s_peopleLimit { set; get; }
        public static string s_textStop { set; get; }
        public static string s_textVia { set; get; }

        private static int s_blinkText = 0;

    public ExternalMon()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbPersNumber.Text = s_personNumber.ToString();

            if (!s_peopleLimit)
            {
                pictureBox.Image = Properties.Resources.Freccia;
                lbText.Text = s_textVia;


                if (s_blinkText > 2)
                {
                    lbText.Text = "";
                    s_blinkText = 0;
                }
                else
                {
                    lbText.Text = s_textVia;
                    lbText.ForeColor = Color.Green;
                    s_blinkText += 1;
                }
            }
            else
            {
                pictureBox.Image = Properties.Resources.Stop;

                if (s_blinkText > 2)
                {
                    lbText.Text = "";
                    s_blinkText = 0;
                }
                else
                {
                    lbText.Text = s_textStop;
                    lbText.ForeColor = Color.Red;
                    s_blinkText += 1;
                }

            }
        }
    }
}
