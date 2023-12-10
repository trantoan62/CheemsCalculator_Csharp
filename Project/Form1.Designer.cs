namespace Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OF1 = new System.Windows.Forms.OpenFileDialog();
            this.L_PERCENT = new System.Windows.Forms.Label();
            this.B_TIME = new System.Windows.Forms.Button();
            this.LB_SOURCE = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.LB_TRACKLIST = new System.Windows.Forms.ListBox();
            this.WMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_PLAYING = new System.Windows.Forms.Label();
            this.B_Sound = new System.Windows.Forms.Button();
            this.L_END = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L_STATE = new System.Windows.Forms.Label();
            this.B_VISIBLE = new System.Windows.Forms.Button();
            this.B_DEL = new System.Windows.Forms.Button();
            this.CB_RAND = new System.Windows.Forms.CheckBox();
            this.CB_REP = new System.Windows.Forms.CheckBox();
            this.L_PLAY = new System.Windows.Forms.Label();
            this.B_STOP = new System.Windows.Forms.Button();
            this.B_ADD = new System.Windows.Forms.Button();
            this.B_NEXT = new System.Windows.Forms.Button();
            this.B_PLAY = new System.Windows.Forms.Button();
            this.B_PRE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OF1
            // 
            this.OF1.FileName = "OF1";
            this.OF1.Multiselect = true;
            // 
            // L_PERCENT
            // 
            this.L_PERCENT.AutoSize = true;
            this.L_PERCENT.Location = new System.Drawing.Point(509, 289);
            this.L_PERCENT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_PERCENT.Name = "L_PERCENT";
            this.L_PERCENT.Size = new System.Drawing.Size(33, 13);
            this.L_PERCENT.TabIndex = 49;
            this.L_PERCENT.Text = "100%";
            // 
            // B_TIME
            // 
            this.B_TIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_TIME.Location = new System.Drawing.Point(301, 297);
            this.B_TIME.Margin = new System.Windows.Forms.Padding(2);
            this.B_TIME.Name = "B_TIME";
            this.B_TIME.Size = new System.Drawing.Size(50, 20);
            this.B_TIME.TabIndex = 48;
            this.B_TIME.Text = "B_TIME";
            this.B_TIME.UseVisualStyleBackColor = true;
            this.B_TIME.Visible = false;
            // 
            // LB_SOURCE
            // 
            this.LB_SOURCE.FormattingEnabled = true;
            this.LB_SOURCE.Location = new System.Drawing.Point(4, 16);
            this.LB_SOURCE.Margin = new System.Windows.Forms.Padding(2);
            this.LB_SOURCE.Name = "LB_SOURCE";
            this.LB_SOURCE.Size = new System.Drawing.Size(80, 95);
            this.LB_SOURCE.TabIndex = 46;
            this.LB_SOURCE.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(63, 318);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(432, 10);
            this.progressBar1.TabIndex = 41;
            this.progressBar1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseClick);
            this.progressBar1.MouseLeave += new System.EventHandler(this.progressBar1_MouseLeave);
            this.progressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseMove);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Pink;
            this.trackBar1.Location = new System.Drawing.Point(502, 303);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 77);
            this.trackBar1.TabIndex = 39;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // LB_TRACKLIST
            // 
            this.LB_TRACKLIST.BackColor = System.Drawing.Color.LightYellow;
            this.LB_TRACKLIST.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TRACKLIST.FormattingEnabled = true;
            this.LB_TRACKLIST.ItemHeight = 17;
            this.LB_TRACKLIST.Location = new System.Drawing.Point(308, 16);
            this.LB_TRACKLIST.Margin = new System.Windows.Forms.Padding(2);
            this.LB_TRACKLIST.Name = "LB_TRACKLIST";
            this.LB_TRACKLIST.Size = new System.Drawing.Size(232, 191);
            this.LB_TRACKLIST.TabIndex = 38;
            this.LB_TRACKLIST.SelectedIndexChanged += new System.EventHandler(this.LB_TRACKLIST_SelectedIndexChanged);
            // 
            // WMP1
            // 
            this.WMP1.Enabled = true;
            this.WMP1.Location = new System.Drawing.Point(120, 16);
            this.WMP1.Margin = new System.Windows.Forms.Padding(2);
            this.WMP1.Name = "WMP1";
            this.WMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP1.OcxState")));
            this.WMP1.Size = new System.Drawing.Size(146, 95);
            this.WMP1.TabIndex = 32;
            this.WMP1.Visible = false;
            this.WMP1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WMP1_PlayStateChange);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-497, 146);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(92, 251);
            this.listBox1.TabIndex = 46;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.anhnen1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 380);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // L_PLAYING
            // 
            this.L_PLAYING.AutoSize = true;
            this.L_PLAYING.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PLAYING.Image = ((System.Drawing.Image)(resources.GetObject("L_PLAYING.Image")));
            this.L_PLAYING.Location = new System.Drawing.Point(37, 303);
            this.L_PLAYING.Name = "L_PLAYING";
            this.L_PLAYING.Size = new System.Drawing.Size(47, 12);
            this.L_PLAYING.TabIndex = 58;
            this.L_PLAYING.Text = "add songs";
            // 
            // B_Sound
            // 
            this.B_Sound.FlatAppearance.BorderSize = 0;
            this.B_Sound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_Sound.Image = global::Project.Properties.Resources.sound;
            this.B_Sound.Location = new System.Drawing.Point(479, 285);
            this.B_Sound.Name = "B_Sound";
            this.B_Sound.Size = new System.Drawing.Size(32, 21);
            this.B_Sound.TabIndex = 59;
            this.B_Sound.UseVisualStyleBackColor = true;
            this.B_Sound.Click += new System.EventHandler(this.B_Sound_Click);
            // 
            // L_END
            // 
            this.L_END.AutoSize = true;
            this.L_END.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_END.ForeColor = System.Drawing.SystemColors.ControlText;
            this.L_END.Image = ((System.Drawing.Image)(resources.GetObject("L_END.Image")));
            this.L_END.Location = new System.Drawing.Point(34, 316);
            this.L_END.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_END.Name = "L_END";
            this.L_END.Size = new System.Drawing.Size(28, 12);
            this.L_END.TabIndex = 57;
            this.L_END.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(27, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 12);
            this.label1.TabIndex = 56;
            this.label1.Text = "/";
            // 
            // L_STATE
            // 
            this.L_STATE.AutoSize = true;
            this.L_STATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_STATE.Image = ((System.Drawing.Image)(resources.GetObject("L_STATE.Image")));
            this.L_STATE.Location = new System.Drawing.Point(2, 303);
            this.L_STATE.Name = "L_STATE";
            this.L_STATE.Size = new System.Drawing.Size(33, 12);
            this.L_STATE.TabIndex = 52;
            this.L_STATE.Text = "Please";
            // 
            // B_VISIBLE
            // 
            this.B_VISIBLE.FlatAppearance.BorderSize = 0;
            this.B_VISIBLE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_VISIBLE.Image = global::Project.Properties.Resources.hidee;
            this.B_VISIBLE.Location = new System.Drawing.Point(510, 0);
            this.B_VISIBLE.Margin = new System.Windows.Forms.Padding(2);
            this.B_VISIBLE.Name = "B_VISIBLE";
            this.B_VISIBLE.Size = new System.Drawing.Size(30, 15);
            this.B_VISIBLE.TabIndex = 47;
            this.B_VISIBLE.UseVisualStyleBackColor = true;
            this.B_VISIBLE.Click += new System.EventHandler(this.B_VISIBLE_Click);
            // 
            // B_DEL
            // 
            this.B_DEL.FlatAppearance.BorderSize = 0;
            this.B_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_DEL.Image = global::Project.Properties.Resources.del;
            this.B_DEL.Location = new System.Drawing.Point(516, 207);
            this.B_DEL.Margin = new System.Windows.Forms.Padding(2);
            this.B_DEL.Name = "B_DEL";
            this.B_DEL.Size = new System.Drawing.Size(24, 24);
            this.B_DEL.TabIndex = 45;
            this.B_DEL.UseVisualStyleBackColor = true;
            this.B_DEL.Click += new System.EventHandler(this.B_DEL_Click);
            // 
            // CB_RAND
            // 
            this.CB_RAND.AutoSize = true;
            this.CB_RAND.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB_RAND.BackgroundImage")));
            this.CB_RAND.FlatAppearance.BorderSize = 0;
            this.CB_RAND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_RAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_RAND.Location = new System.Drawing.Point(415, 355);
            this.CB_RAND.Margin = new System.Windows.Forms.Padding(2);
            this.CB_RAND.Name = "CB_RAND";
            this.CB_RAND.Size = new System.Drawing.Size(65, 16);
            this.CB_RAND.TabIndex = 44;
            this.CB_RAND.Text = "RANDOM";
            this.CB_RAND.UseVisualStyleBackColor = true;
            // 
            // CB_REP
            // 
            this.CB_REP.AutoSize = true;
            this.CB_REP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB_REP.BackgroundImage")));
            this.CB_REP.FlatAppearance.BorderSize = 0;
            this.CB_REP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_REP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_REP.Location = new System.Drawing.Point(415, 335);
            this.CB_REP.Margin = new System.Windows.Forms.Padding(2);
            this.CB_REP.Name = "CB_REP";
            this.CB_REP.Size = new System.Drawing.Size(58, 16);
            this.CB_REP.TabIndex = 43;
            this.CB_REP.Text = "REPEAT";
            this.CB_REP.UseVisualStyleBackColor = true;
            this.CB_REP.CheckedChanged += new System.EventHandler(this.CB_REP_CheckedChanged);
            // 
            // L_PLAY
            // 
            this.L_PLAY.AutoSize = true;
            this.L_PLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PLAY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.L_PLAY.Image = ((System.Drawing.Image)(resources.GetObject("L_PLAY.Image")));
            this.L_PLAY.Location = new System.Drawing.Point(2, 316);
            this.L_PLAY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_PLAY.Name = "L_PLAY";
            this.L_PLAY.Size = new System.Drawing.Size(28, 12);
            this.L_PLAY.TabIndex = 42;
            this.L_PLAY.Text = "00:00";
            // 
            // B_STOP
            // 
            this.B_STOP.FlatAppearance.BorderSize = 0;
            this.B_STOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_STOP.Image = global::Project.Properties.Resources.stop;
            this.B_STOP.Location = new System.Drawing.Point(160, 336);
            this.B_STOP.Margin = new System.Windows.Forms.Padding(2);
            this.B_STOP.Name = "B_STOP";
            this.B_STOP.Size = new System.Drawing.Size(40, 40);
            this.B_STOP.TabIndex = 37;
            this.B_STOP.UseVisualStyleBackColor = true;
            this.B_STOP.Click += new System.EventHandler(this.B_STOP_Click);
            // 
            // B_ADD
            // 
            this.B_ADD.FlatAppearance.BorderSize = 0;
            this.B_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_ADD.Image = global::Project.Properties.Resources.addd;
            this.B_ADD.Location = new System.Drawing.Point(308, 207);
            this.B_ADD.Margin = new System.Windows.Forms.Padding(2);
            this.B_ADD.Name = "B_ADD";
            this.B_ADD.Size = new System.Drawing.Size(22, 22);
            this.B_ADD.TabIndex = 36;
            this.B_ADD.UseVisualStyleBackColor = true;
            this.B_ADD.Click += new System.EventHandler(this.B_ADD_Click);
            // 
            // B_NEXT
            // 
            this.B_NEXT.FlatAppearance.BorderSize = 0;
            this.B_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_NEXT.Image = global::Project.Properties.Resources.next;
            this.B_NEXT.Location = new System.Drawing.Point(313, 339);
            this.B_NEXT.Margin = new System.Windows.Forms.Padding(2);
            this.B_NEXT.Name = "B_NEXT";
            this.B_NEXT.Size = new System.Drawing.Size(50, 33);
            this.B_NEXT.TabIndex = 35;
            this.B_NEXT.UseVisualStyleBackColor = true;
            this.B_NEXT.Click += new System.EventHandler(this.B_NEXT_Click);
            // 
            // B_PLAY
            // 
            this.B_PLAY.FlatAppearance.BorderSize = 0;
            this.B_PLAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_PLAY.Image = global::Project.Properties.Resources.play;
            this.B_PLAY.Location = new System.Drawing.Point(258, 329);
            this.B_PLAY.Margin = new System.Windows.Forms.Padding(2);
            this.B_PLAY.Name = "B_PLAY";
            this.B_PLAY.Size = new System.Drawing.Size(50, 50);
            this.B_PLAY.TabIndex = 34;
            this.B_PLAY.UseVisualStyleBackColor = true;
            this.B_PLAY.Click += new System.EventHandler(this.B_PLAY_Click);
            // 
            // B_PRE
            // 
            this.B_PRE.FlatAppearance.BorderSize = 0;
            this.B_PRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_PRE.Image = global::Project.Properties.Resources.prev;
            this.B_PRE.Location = new System.Drawing.Point(204, 339);
            this.B_PRE.Margin = new System.Windows.Forms.Padding(2);
            this.B_PRE.Name = "B_PRE";
            this.B_PRE.Size = new System.Drawing.Size(50, 33);
            this.B_PRE.TabIndex = 33;
            this.B_PRE.UseVisualStyleBackColor = true;
            this.B_PRE.Click += new System.EventHandler(this.B_PRE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 380);
            this.Controls.Add(this.B_TIME);
            this.Controls.Add(this.L_PLAYING);
            this.Controls.Add(this.B_Sound);
            this.Controls.Add(this.L_END);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_STATE);
            this.Controls.Add(this.L_PERCENT);
            this.Controls.Add(this.B_VISIBLE);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LB_SOURCE);
            this.Controls.Add(this.B_DEL);
            this.Controls.Add(this.CB_RAND);
            this.Controls.Add(this.CB_REP);
            this.Controls.Add(this.L_PLAY);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.LB_TRACKLIST);
            this.Controls.Add(this.B_STOP);
            this.Controls.Add(this.B_ADD);
            this.Controls.Add(this.B_NEXT);
            this.Controls.Add(this.B_PLAY);
            this.Controls.Add(this.B_PRE);
            this.Controls.Add(this.WMP1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAY NGHE NHAC";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OF1;
        private System.Windows.Forms.Label L_PERCENT;
        private System.Windows.Forms.Button B_TIME;
        private System.Windows.Forms.Button B_VISIBLE;
        private System.Windows.Forms.ListBox LB_SOURCE;
        private System.Windows.Forms.Button B_DEL;
        private System.Windows.Forms.CheckBox CB_RAND;
        private System.Windows.Forms.CheckBox CB_REP;
        private System.Windows.Forms.Label L_PLAY;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox LB_TRACKLIST;
        private System.Windows.Forms.Button B_STOP;
        private System.Windows.Forms.Button B_ADD;
        private System.Windows.Forms.Button B_NEXT;
        private System.Windows.Forms.Button B_PLAY;
        private System.Windows.Forms.Button B_PRE;
        private AxWMPLib.AxWindowsMediaPlayer WMP1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label L_STATE;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_END;
        private System.Windows.Forms.Label L_PLAYING;
        private System.Windows.Forms.Button B_Sound;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

