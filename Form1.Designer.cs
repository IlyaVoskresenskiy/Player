namespace Player
{
    partial class Play_f
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play_f));
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.open_button = new System.Windows.Forms.Button();
            this.music_list = new System.Windows.Forms.ListBox();
            this.next_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.ip_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(12, 4);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(416, 208);
            this.Player.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // open_button
            // 
            this.open_button.AutoSize = true;
            this.open_button.BackColor = System.Drawing.Color.DarkGray;
            this.open_button.Location = new System.Drawing.Point(12, 218);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 1;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = false;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // music_list
            // 
            this.music_list.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music_list.FormattingEnabled = true;
            this.music_list.ItemHeight = 16;
            this.music_list.Location = new System.Drawing.Point(12, 244);
            this.music_list.Name = "music_list";
            this.music_list.Size = new System.Drawing.Size(416, 68);
            this.music_list.TabIndex = 3;
            this.music_list.SelectedIndexChanged += new System.EventHandler(this.music_list_SelectedIndexChanged);
            // 
            // next_button
            // 
            this.next_button.BackColor = System.Drawing.Color.DarkGray;
            this.next_button.Location = new System.Drawing.Point(328, 218);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(75, 23);
            this.next_button.TabIndex = 4;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DarkGray;
            this.back_button.Location = new System.Drawing.Point(247, 218);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Prev";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Location = new System.Drawing.Point(94, 219);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(17, 13);
            this.ip_label.TabIndex = 6;
            this.ip_label.Text = "IP";
            // 
            // Play_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.music_list);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Play_f";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public AxWMPLib.AxWindowsMediaPlayer Player;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.Button open_button;
        public System.Windows.Forms.ListBox music_list;
        public System.Windows.Forms.Button next_button;
        public System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label ip_label;
    }
}

