using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AE315PressureHelp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void p_inf_in_HGTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                p_inf_PaTextbox.Text = (Convert.ToDouble(p_inf_in_HGTextbox.Text) * 3386.39).ToString();
            }
            catch (Exception)
            {
                p_inf_PaTextbox.Text = "ERROR";
            }
        }
        private void NoCharacters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void T_inf_FTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                T_inf_KTextBox.Text = ((Convert.ToDouble(T_inf_FTextBox.Text) - 32) * 5 / 9 + 273.15).ToString();
            }
            catch (Exception)
            {
                T_inf_KTextBox.Text = "ERROR";
            }

        }

        private void UpdateDensity(object sender, EventArgs e)
        {
            try
            {
                rho_SITextbox.Text = (Convert.ToDouble(p_inf_PaTextbox.Text) / (287.1 * Convert.ToDouble(T_inf_KTextBox.Text))).ToString();
            }
            catch (Exception)
            {
                rho_SITextbox.Text = "ERROR";
            }
        }

        private void UpdateDynamicPressure(object sender, EventArgs e)
        {
            try
            {
                q_inf_in_H20TextBox.Text = (.5 * Convert.ToDouble(rho_SITextbox.Text) * Math.Pow(Convert.ToDouble(v_infTextBox.Text), 2)).ToString();
            }
            catch (Exception)
            {
                q_inf_in_H20TextBox.Text = "ERROR";
            }
        }
    }
}

