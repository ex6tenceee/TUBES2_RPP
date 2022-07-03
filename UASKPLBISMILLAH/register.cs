using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASKPLBISMILLAH
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama, alamat, username, password;
            long telp;
             
            nama = textBox1.Text;
            alamat = textBox2.Text;
            username = textBox3.Text;
            password = textBox4.Text;
            telp = long.Parse(textBox2.Text);
            MessageBox.Show("nama : " + nama + "\nN.telp:" + telp + "\nAlamat : " + alamat + "\nUsername : " + username + "\nPassword :" + password);

        }
    }
}
