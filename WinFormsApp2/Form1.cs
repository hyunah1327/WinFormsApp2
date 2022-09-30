using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        ucpanel.ucScreen1 ucSc1 = new ucpanel.ucScreen1();
        ucpanel.ucScreen2 ucSc2 = new ucpanel.ucScreen2();
        ucpanel.ucScreen3 ucSc3 = new ucpanel.ucScreen3();

        string Conn = "Server=localhost;Database=####;Uid=root;Pwd=apmsetup;";
        // 데이터베이스 구축해서 이름 넣어줘야함

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(ucSc1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(ucSc2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(ucSc3);
        }
    }
}