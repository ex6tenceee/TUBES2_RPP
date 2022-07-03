using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingByYanuar
{


    internal class Class1
    {
        public enum username { Yapi, Yana, Yani };
        public string[] password = { "123yapi", "123yana", "123yani" };


        private void button1_Click(object sender, EventArgs e)
        {
            string[] uname = Enum.GetNames(typeof(username));
            if (password.Contains(textBox2.Text) && uname.Contains(textBox1.Text) && Array.IndexOf(uname, textBox1.Text) == Array.IndexOf(password, textBox2.Text))
            {
                label3.Text = "Sukses";
            }
            else
            {
                label3.Text = "Coba Lagi";
            }
        }
    }
}
