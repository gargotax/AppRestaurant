using Microsoft.VisualBasic.Devices;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using System;

namespace MioProgetto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_chiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var turistico = 0;
            var lavoratore = 0;

            if (ct_lavoratore.Value > 0)
            {
                for (int i = 0; i < ct_lavoratore.Value; i++)
                {
                    lavoratore = lavoratore + 7;
                }

                textBox1.Text = lavoratore.ToString();
            }

            if (ct_turistico.Value > 0)
            {
                for (int j = 0; j < ct_turistico.Value; j++)
                {
                    turistico = turistico + 10;
                }
                textBox1.Text = turistico.ToString();

            }

            if (ct_lavoratore.Value > 0 && ct_turistico.Value > 0)
            {
                for (int i = 0, j = 0; i < lavoratore && j < turistico; i++, j++)
                {
                    var tutto = turistico + lavoratore;
                    textBox1.Text = tutto.ToString();


                }

            }
        }



        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {

                string connectionString = null;
                SqlConnection cnn;

                connectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mioProgetto;
                               Integrated Security=True;Connect Timeout=30;Encrypt=False;
                               TrustServerCertificate=False;ApplicationIntent=
                               ReadWrite;MultiSubnetFailover=False");

                cnn = new SqlConnection(connectionString);

                try
                {
                    cnn.Open();
                    MessageBox.Show("Connection Open ! ");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }

            }



        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}