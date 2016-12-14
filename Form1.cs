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
    public partial class Play_f : Form
    {
        public static Play_f myForm = null;
        private Controller ctrl = null;
        private Receive rec = null;
        public Play_f()
        {
            myForm = this;
            ctrl = new Controller();
            rec = new Receive();
            InitializeComponent();
        }

        public void open_button_Click(object sender, EventArgs e)
        {

            ctrl.open();
        }

        private void music_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrl.select();
        }

        public void next_button_Click(object sender, EventArgs e)
        {
            ctrl.next();   
        }

        public void back_button_Click(object sender, EventArgs e)
        {
            ctrl.back();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ip_label.Text = IpGet.GetIP();
            rec.receiveCode();
        }

        public void click_pause()
        {
            ctrl.play_pause();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
