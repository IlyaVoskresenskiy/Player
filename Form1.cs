using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;


namespace Player
{
    public partial class Form1 : Form
    {
        
        private Ilya il;
        private Receive obj;
        private string value;
        private bool flag;
        private Thread stream_rec;
        public Form1()
        {
            
            flag = false;
            value = null;
            il = new Ilya();
            obj = new Receive();
            InitializeComponent();
        }
         
        public void button1_Click(object sender, EventArgs e)
        {
            
            il.open(ref openFileDialog1, ref listBox1, ref Player);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            il.select(ref listBox1, ref Player);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            il.next(ref openFileDialog1, ref listBox1, ref Player);   
        }

        public void button3_Click(object sender, EventArgs e)
        {
            il.back(ref openFileDialog1, ref listBox1, ref Player);
        }

          
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                if (!flag)
                {
                    stream_rec = new Thread(() => value = obj.receiveCode());
                    stream_rec.Start();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (value == "1")
                {
                    il.next(ref openFileDialog1, ref listBox1, ref Player);
                    value = " ";
                    flag = false;
                }
            if (value == "-1")
            {
                il.back(ref openFileDialog1, ref listBox1, ref Player);
                value = " ";
                flag = false;
            }
            if (value == "0")
            {
                il.play_pause(ref Player);
                value = " ";
                flag = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = IpGet.GetIP();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
