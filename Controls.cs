using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Player
{

    class Controller
    {
        private bool f1 = true;
        private bool open_flag = true;
        private List<string> files = new List<string>();
        public void open()
        {
            if (open_flag == true)
            {
                if (Play_f.myForm.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < Play_f.myForm.openFileDialog.SafeFileNames.Length; i++)
                    {
                        Play_f.myForm.music_list.Items.Add(Play_f.myForm.openFileDialog.SafeFileNames[i]);
                        files.Add(Play_f.myForm.openFileDialog.FileNames[i]);
                    }
                }
                Play_f.myForm.Player.URL = files[0];
                Play_f.myForm.music_list.SelectedIndex = 0; open_flag = false;
            }
            else
            {
                if (Play_f.myForm.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < Play_f.myForm.openFileDialog.SafeFileNames.Length; i++)
                    {
                        Play_f.myForm.music_list.Items.Add(Play_f.myForm.openFileDialog.SafeFileNames[i]);
                        files.Add(Play_f.myForm.openFileDialog.FileNames[i]);
                    }
                }
                Play_f.myForm.Player.URL = files[0];
                Play_f.myForm.music_list.SelectedIndex = 0; open_flag = false;
            }
        }

        public void next()
        {
            try
            {
                if (Play_f.myForm.music_list.SelectedIndex == files.Count - 1)
                {
                    Play_f.myForm.music_list.SelectedIndex = 0;
                    Play_f.myForm.Player.URL = files[0];
                }
                else
                {
                    Play_f.myForm.music_list.SelectedIndex++;
                    Play_f.myForm.Player.URL = files[Play_f.myForm.music_list.SelectedIndex];
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void back()
        {
            try
            {
                if (Play_f.myForm.music_list.SelectedIndex == 0)
                {
                    Play_f.myForm.music_list.SelectedIndex = files.Count - 1;
                    Play_f.myForm.Player.URL = files[Play_f.myForm.music_list.Items.Count - 1];
                }
                else
                {
                    Play_f.myForm.music_list.SelectedIndex--;
                    Play_f.myForm.Player.URL = files[Play_f.myForm.music_list.SelectedIndex];
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void play_pause()
        {
            if (f1 == false)
            {
                Play_f.myForm.Player.Ctlcontrols.play();
                f1 = true;
            }
            else
            {
                Play_f.myForm.Player.Ctlcontrols.pause();
                f1 = false;
            }
        }

        public void select()
        {
            try
            {
                Play_f.myForm.Player.URL = files[Play_f.myForm.music_list.SelectedIndex];
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
