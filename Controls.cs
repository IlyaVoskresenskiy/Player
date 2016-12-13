using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Player
{
    class Ilya
    {
        private bool f1 = true;
        private bool open_flag = true;
        private List<string> files = new List<string>();
        public void open(ref OpenFileDialog openFileDialog1, ref ListBox listBox1, ref AxWMPLib.AxWindowsMediaPlayer Player)
        {
            if (open_flag == true)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
                    {
                        listBox1.Items.Add(openFileDialog1.SafeFileNames[i]);
                        files.Add(openFileDialog1.FileNames[i]);
                    }
                }
                Player.URL = files[0];
                listBox1.SelectedIndex = 0; open_flag = false;
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
                    {
                        listBox1.Items.Add(openFileDialog1.SafeFileNames[i]);
                        files.Add(openFileDialog1.FileNames[i]);
                    }
                }
                Player.URL = files[0];
                listBox1.SelectedIndex = 0; open_flag = false;
            }
        }

        public void next(ref OpenFileDialog openFileDialog1, ref ListBox listBox1, ref AxWMPLib.AxWindowsMediaPlayer Player)
        {
            try
            {
                if (listBox1.SelectedIndex == files.Count - 1)
                {
                    listBox1.SelectedIndex = 0;
                    Player.URL = files[0];
                }
                else
                {
                    listBox1.SelectedIndex++;
                    Player.URL = files[listBox1.SelectedIndex];
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void back(ref OpenFileDialog openFileDialog1, ref ListBox listBox1, ref AxWMPLib.AxWindowsMediaPlayer Player)
        {
            try
            {
                if (listBox1.SelectedIndex == 0)
                {
                    listBox1.SelectedIndex = files.Count - 1;
                    Player.URL = files[listBox1.Items.Count - 1];
                }
                else
                {
                    listBox1.SelectedIndex--;
                    Player.URL = files[listBox1.SelectedIndex];
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void play_pause(ref AxWMPLib.AxWindowsMediaPlayer Player)
        {
            if (f1 == false)
            {
                Player.Ctlcontrols.play();
                f1 = true;
            }
            else
            {
                Player.Ctlcontrols.pause();
                f1 = false;
            }
        }

        public void select(ref ListBox listBox1, ref AxWMPLib.AxWindowsMediaPlayer Player)
        {
            try
            {
                Player.URL = files[listBox1.SelectedIndex];
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
