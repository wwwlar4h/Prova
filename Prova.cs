using Microsoft.Win32.SafeHandles;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void b_cadastrar_Click(object sender, EventArgs e)
        {

            double valor = Convert.ToDouble(tx_valor.Text);
            double pis = Convert.ToDouble(tx_pis);
            double confins = Convert.ToDouble(tx_confins);
            double icms = Convert.ToDouble(tx_icms);
            double lucro = Convert.ToDouble(tx_lucro);


            pis = (pis / 100) * pis;
            icms = (icms / 100) * icms;
            confins = (confins / 100) * confins;

            lucro = (lucro / 100) * lucro;
            valor = lucro;

            MessageBox.Show();


        }

        private void tx_valor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}