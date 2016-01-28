using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string tag = "Hello World";
        private bool content = true;
        private Int32 i = 35;
        private string mystring = "Hello World";
        private int[] myInts = { 5, 10, 15, 20 };
       

        private void btnEnter_Click(object sender, EventArgs e)
        {
            txtNombre.Text = content.ToString();
            btnClear.Enabled = true;
            txtInt.Text = i.ToString();
            txtHello.Text = mystring;

            string nuevo="";
            //for (int j = 0; j < myInts.Length; j++ )
            //nuevo +=  myInts[j].ToString() + " - ";
            //txtArray.Text = nuevo;

            foreach (int array in myInts)
            {
                int j = 0;
                nuevo += array + " - ";
                txtArray.Text = nuevo.Substring(0, nuevo.Length - 3);
                j++;
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";//txtNombre.Text.Substring(0, txtNombre.Text.Length - 1);
            txtInt.Text = "";
            txtHello.Text = "";
            txtArray.Text = "";
            btnClear.Enabled = false;
                       


        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
        }
    }
}
