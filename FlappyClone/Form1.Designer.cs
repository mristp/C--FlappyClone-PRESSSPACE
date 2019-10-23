namespace FlappyClone
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.PictureBox();
            this.t2 = new System.Windows.Forms.PictureBox();
            this.t3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.nlo = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gameoverpanel = new System.Windows.Forms.PictureBox();
            this.points = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameoverpanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox1.Location = new System.Drawing.Point(0, 350);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(694, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // t1
            // 
            this.t1.Image = ((System.Drawing.Image)(resources.GetObject("t1.Image")));
            this.t1.Location = new System.Drawing.Point(12, 150);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 200);
            this.t1.TabIndex = 1;
            this.t1.TabStop = false;
            this.t1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // t2
            // 
            this.t2.Image = ((System.Drawing.Image)(resources.GetObject("t2.Image")));
            this.t2.Location = new System.Drawing.Point(173, 130);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(189, 220);
            this.t2.TabIndex = 2;
            this.t2.TabStop = false;
            // 
            // t3
            // 
            this.t3.Image = ((System.Drawing.Image)(resources.GetObject("t3.Image")));
            this.t3.Location = new System.Drawing.Point(468, 150);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(100, 200);
            this.t3.TabIndex = 1;
            this.t3.TabStop = false;
            this.t3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Thistle;
            this.p2.Location = new System.Drawing.Point(227, 283);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(99, 191);
            this.p2.TabIndex = 3;
            this.p2.TabStop = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Thistle;
            this.p1.Location = new System.Drawing.Point(227, -1);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(99, 179);
            this.p1.TabIndex = 3;
            this.p1.TabStop = false;
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.Thistle;
            this.p4.Location = new System.Drawing.Point(589, 284);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(99, 191);
            this.p4.TabIndex = 3;
            this.p4.TabStop = false;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Thistle;
            this.p3.Location = new System.Drawing.Point(589, 0);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(99, 179);
            this.p3.TabIndex = 3;
            this.p3.TabStop = false;
            // 
            // nlo
            // 
            this.nlo.Image = ((System.Drawing.Image)(resources.GetObject("nlo.Image")));
            this.nlo.Location = new System.Drawing.Point(70, 213);
            this.nlo.Name = "nlo";
            this.nlo.Size = new System.Drawing.Size(25, 25);
            this.nlo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nlo.TabIndex = 4;
            this.nlo.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // gameoverpanel
            // 
            this.gameoverpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameoverpanel.Image = ((System.Drawing.Image)(resources.GetObject("gameoverpanel.Image")));
            this.gameoverpanel.Location = new System.Drawing.Point(200, 180);
            this.gameoverpanel.Name = "gameoverpanel";
            this.gameoverpanel.Size = new System.Drawing.Size(300, 70);
            this.gameoverpanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameoverpanel.TabIndex = 5;
            this.gameoverpanel.TabStop = false;
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.Color.MediumOrchid;
            this.points.Location = new System.Drawing.Point(13, 29);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(31, 36);
            this.points.TabIndex = 6;
            this.points.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(692, 473);
            this.Controls.Add(this.points);
            this.Controls.Add(this.gameoverpanel);
            this.Controls.Add(this.nlo);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.Text = "FlappyClone";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameoverpanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox t1;
        private System.Windows.Forms.PictureBox t2;
        private System.Windows.Forms.PictureBox t3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox nlo;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox gameoverpanel;
        private System.Windows.Forms.Label points;
    }
}

