using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] tennhac;
        string[] duonglink;

        private void WMP1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 1:     // Stopped
                    this.L_STATE.Text = "Stopped";
                    this.B_PLAY.Image = global::Project.Properties.Resources.play;
                    this.L_PLAY.Text = "";
                    this.L_END.Text = "";
                    break;
                case 2:     // Paused
                    this.L_STATE.Text = "Paused";
                    this.B_PLAY.Image = global::Project.Properties.Resources.play;
                    break;
                case 3:    // Playing
                    dem = 7;
                    this.L_STATE.Text = "Playing";
                    this.B_PLAY.Image = global::Project.Properties.Resources.pause;
                    this.L_PLAYING.Text = Convert.ToString(this.LB_TRACKLIST.SelectedItem);
                    this.progressBar1.Maximum = (int)WMP1.Ctlcontrols.currentItem.duration;
                    this.L_END.Text = this.WMP1.Ctlcontrols.currentItem.durationString.ToString();
                    break;
                case 8:    // MediaEnded
                    this.L_STATE.Text = "MediaEnded";
                    break;
                case 0:    // Undefined
                    this.L_STATE.Text = "";
                    break;
                default:   // nó là default
                    this.L_STATE.Text = "";
                    break;
            }
        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            if (this.OF1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tennhac = this.OF1.SafeFileNames;
                duonglink = this.OF1.FileNames;
                for (int i = 0; i < this.tennhac.Length; i++)
                {
                    this.LB_TRACKLIST.Items.Add(tennhac[i]);
                    this.LB_SOURCE.Items.Add(duonglink[i]);
                }
            }
        }

        private void B_DEL_Click(object sender, EventArgs e)
        {
            if (this.LB_TRACKLIST.SelectedIndex != -1)
            {
                this.WMP1.Ctlcontrols.stop();
                this.LB_SOURCE.Items.Remove(this.LB_SOURCE.Items[this.LB_TRACKLIST.SelectedIndex]);
                this.LB_TRACKLIST.Items.Remove(this.LB_TRACKLIST.Items[this.LB_TRACKLIST.SelectedIndex]);
                this.WMP1.URL = "";
                this.LB_TRACKLIST.SelectedIndex = -1;
            }
        }

        private void LB_TRACKLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.LB_TRACKLIST.SelectedIndex == -1) { 
                return; }
            this.WMP1.URL = Convert.ToString(this.LB_SOURCE.Items[this.LB_TRACKLIST.SelectedIndex]);
            this.WMP1.Ctlcontrols.play();
        }

        private void B_PLAY_Click(object sender, EventArgs e)
        {
            if (this.L_STATE.Text != "Playing" && this.L_STATE.Text != "Please")
            {
                if (this.LB_TRACKLIST.SelectedIndex == -1) {
                    this.WMP1.URL = Convert.ToString(this.LB_SOURCE.Items[0]);
                    this.WMP1.Ctlcontrols.play();
                    this.LB_TRACKLIST.SelectedIndex = 0;
                }
                else {
                    if (this.L_STATE.Text == "Stopped")
                        this.WMP1.Ctlcontrols.play();
                    else if (this.L_STATE.Text == "Paused")
                        this.WMP1.Ctlcontrols.play();
                }
                return;
            }
            if (this.L_STATE.Text == "Playing"){
                this.WMP1.Ctlcontrols.pause();
                return;
            }

        }

        private void B_STOP_Click(object sender, EventArgs e)
        {
            this.WMP1.Ctlcontrols.stop();
            this.progressBar1.Value = 0;
        }

        private void B_NEXT_Click(object sender, EventArgs e)
        {
            if (this.CB_RAND.Checked == true) {
                randum();
                return;
            }
            if (this.LB_TRACKLIST.SelectedIndex < this.LB_TRACKLIST.Items.Count - 1) {
                this.LB_TRACKLIST.SelectedIndex = this.LB_TRACKLIST.SelectedIndex + 1; }
            else { 
                this.LB_TRACKLIST.SelectedIndex = 0; }
        }

        private void B_PRE_Click(object sender, EventArgs e) 
        {
            if (this.CB_RAND.Checked == true) {
                randum();
                return;
            }
            if (this.LB_TRACKLIST.SelectedIndex > 0) {
                this.LB_TRACKLIST.SelectedIndex = this.LB_TRACKLIST.SelectedIndex - 1; }
            else {
                this.LB_TRACKLIST.SelectedIndex = this.LB_TRACKLIST.Items.Count - 1;
            }
        }

        private void randum()
        {
            Random randd = new Random();
            this.LB_TRACKLIST.SelectedIndex = randd.Next(0, this.LB_TRACKLIST.Items.Count - 1);
        }

        private void B_VISIBLE_Click(object sender, EventArgs e)
        {
            if (this.LB_TRACKLIST.Visible == false) {
                this.LB_TRACKLIST.Visible = true;
                this.B_ADD.Visible = true;
                this.B_DEL.Visible = true;
            }
            else if (this.LB_TRACKLIST.Visible == true)
            {
                this.LB_TRACKLIST.Visible = false;
                this.B_ADD.Visible = false;
                this.B_DEL.Visible = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.WMP1.settings.volume = this.trackBar1.Value;
            this.L_PERCENT.Text = Convert.ToString(this.trackBar1.Value) + "%";
        }

        double vitri;
        private void progressBar1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.L_STATE.Text == "Playing" || this.L_STATE.Text == "Paused") {
                vitri = e.X;
                double ketthuc = this.WMP1.Ctlcontrols.currentItem.duration;
                this.progressBar1.Value = Convert.ToInt32(Math.Round(vitri / 432 * ketthuc));
                WMP1.Ctlcontrols.currentPosition = this.progressBar1.Value;
            }
        }

        private void progressBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.L_STATE.Text == "Playing" || this.L_STATE.Text == "Paused") {
                this.L_PLAYING.Visible = false;
                this.B_TIME.Visible = true;
                double vitrichuot = e.X;
                double ketthucnhac = this.WMP1.Ctlcontrols.currentItem.duration;
                int nhacchay = Convert.ToInt32(Math.Round(vitrichuot / 432 * ketthucnhac));
                string phut = "0" + Convert.ToString(Math.Floor(Convert.ToDouble(nhacchay) / 60));
                string giay = Convert.ToString(nhacchay % 60);
                if (nhacchay % 60 <= 9) {
                    giay = "0" + Convert.ToString(nhacchay % 60);
                }
                this.B_TIME.Text = phut + ":" + giay;
                this.B_TIME.Location = new Point(Convert.ToInt32(62 + vitrichuot), 297);
            }
        }

        private void progressBar1_MouseLeave(object sender, EventArgs e)
        {
            this.B_TIME.Visible = false;
            this.L_PLAYING.Visible = true;
        }

        int dem = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.L_STATE.Text == "Playing")
            {
                this.progressBar1.Value = (int)WMP1.Ctlcontrols.currentPosition;
                this.L_PLAY.Text = this.WMP1.Ctlcontrols.currentPositionString;
            }
            if (this.progressBar1.Value == this.progressBar1.Maximum - 1)
            {
                this.progressBar1.Value = 0;
                if (this.LB_TRACKLIST.SelectedIndex == this.LB_TRACKLIST.Items.Count - 1) {
                    return;
                }
                if (this.CB_REP.Checked == false) {
                    this.LB_TRACKLIST.SelectedIndex = this.LB_TRACKLIST.SelectedIndex + 1;
                }
                if (this.CB_REP.Checked == true) {
                    this.LB_TRACKLIST.SelectedIndex = this.LB_TRACKLIST.SelectedIndex;
                }
                this.WMP1.Ctlcontrols.play();
            }
            if (this.LB_TRACKLIST.Items.Count == 0)
            {
                this.L_STATE.Text = "Please";
                this.L_PLAYING.Text = "add songs";
                this.B_STOP.Enabled = false;
                this.B_NEXT.Enabled = false;
                this.B_PRE.Enabled = false;
                this.B_PLAY.Enabled = false;
                this.B_DEL.Enabled = false;
                this.CB_RAND.Enabled = false;
                this.CB_REP.Enabled = false;
            }
            if (this.LB_TRACKLIST.Items.Count > 0 && this.CB_REP.Checked == false)
            {
                this.B_STOP.Enabled = true;
                this.B_NEXT.Enabled = true;
                this.B_PRE.Enabled = true;
                this.B_PLAY.Enabled = true;
                this.B_DEL.Enabled = true;
                this.CB_RAND.Enabled = true;
                this.CB_REP.Enabled = true;
            }
            dem++;
            if (dem % 8 == 0) {
                Anhnen();
            }
        }

        int hinhnen = 0;
        private void Anhnen()
        {
            Random ngaunhien = new Random();
            hinhnen = ngaunhien.Next(1, 12);
            if (hinhnen == 1) {
                this.pictureBox1.Image = global::Project.Properties.Resources.anhnen1; }
            if (hinhnen == 2) {
                this.pictureBox1.Image = global::Project.Properties.Resources.anhnen2; }
            if (hinhnen == 3) {
                this.pictureBox1.Image = global::Project.Properties.Resources.anhnen3; }
            if (hinhnen == 4) {
                this.pictureBox1.Image = global::Project.Properties.Resources.anhnen4; }
            if (hinhnen == 5) {
                this.pictureBox1.Image = global::Project.Properties.Resources.anhnen5; }
            if (hinhnen == 6) {
                this.pictureBox1.Image = global::Project.Properties.Resources.anhnen6; }
            if (hinhnen == 7) {
                this.pictureBox1.Image = global::Project.Properties.Resources.anhnen7; }
            if (hinhnen == 8) {
                this.pictureBox1.Image = global::Project.Properties.Resources.anhnen8; }
            if (hinhnen == 9) {
                this.pictureBox1.Image = global::Project.Properties.Resources.anhnen9; }
            if (hinhnen == 10) {
                this.pictureBox1.Image = global::Project.Properties.Resources.anhnen10; }
            if (hinhnen == 11) {
                this.pictureBox1.Image = global::Project.Properties.Resources.anhnen11; }
        }

        private void CB_REP_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CB_REP.Checked == true) {
                this.LB_TRACKLIST.Enabled = false;
                this.B_NEXT.Enabled = false;
                this.B_PRE.Enabled = false;
                this.B_DEL.Enabled = false;
                this.CB_RAND.Enabled = false;
            }
            if (this.CB_REP.Checked == false)  {
                this.LB_TRACKLIST.Enabled = true;
                this.B_NEXT.Enabled = true;
                this.B_PRE.Enabled = true;
                this.B_DEL.Enabled = true;
                this.CB_RAND.Enabled = true;
            }
        }

        private void B_Sound_Click(object sender, EventArgs e)
        {
            if (this.WMP1.settings.mute == false) {
                this.WMP1.settings.mute = true;
                this.L_PERCENT.Text = "Mute";
                this.B_Sound.Image = global::Project.Properties.Resources.mute;
            return;
            }
            if (this.WMP1.settings.mute == true) {
                this.WMP1.settings.mute = false;
                this.L_PERCENT.Text = Convert.ToString(this.trackBar1.Value) + "%";
                this.B_Sound.Image = global::Project.Properties.Resources.sound;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Anhnen();
        }
    }
}
