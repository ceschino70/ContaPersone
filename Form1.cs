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
    public partial class Form1 : Form
    {
        private int m_personNumber = 0;
        private int m_MaxPerson = 1;
        private bool stringError = true;

        public Form1()
        {
            InitializeComponent();

            ExternalMon extMon = new ExternalMon();
            extMon.Bounds = Screen.AllScreens[0].Bounds;
            extMon.Show();

            tbPersonNumber.Text = m_personNumber.ToString();
            m_MaxPerson = checkMaxPerson(tbMaxPerson);
        }

        private int checkMaxPerson(TextBox tbStr)
        {
            int maxPers = 0;
            try
            {
                if (tbStr.Text != "")
                {
                    maxPers = Int32.Parse(tbStr.Text);

                    if (maxPers > 50 || maxPers <= 0)
                    {
                        tbMaxPerson.Text = m_MaxPerson.ToString();
                        maxPers = m_MaxPerson;
                    }
                    else
                    {
                        m_MaxPerson = maxPers;
                    }
                }
                else
                {
                    tbMaxPerson.Text = m_MaxPerson.ToString();
                }

                stringError = false;
            }
            catch(Exception e)
            {
                if (stringError)
                    MessageBox.Show("Settings error.\nMessage: "+ e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                stringError = false;
            }
            return maxPers;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbPersonNumber.Text = m_personNumber.ToString();
            ExternalMon.s_personNumber = m_personNumber;

            m_MaxPerson = checkMaxPerson(tbMaxPerson);

            ExternalMon.s_peopleLimit = (m_personNumber >= m_MaxPerson) ? true : false;
            ExternalMon.s_textStop = tbTextStop.Text;
            ExternalMon.s_textVia = tbTextVia.Text;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPersonAdd_Click(object sender, EventArgs e)
        {
            m_personNumber += 1;
        }

        private void byPersonMinus_Click(object sender, EventArgs e)
        {
            m_personNumber -= 1;
        }

        private void tbMaxPerson_TextChanged(object sender, EventArgs e)
        {
            m_MaxPerson = checkMaxPerson(tbMaxPerson);
        }
    }
}
