
namespace MYFACE
{
    partial class Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.timer_play = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_heart4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_heart3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_heart2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_heart1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_heart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_play
            // 
            this.timer_play.Interval = 40;
            this.timer_play.Tick += new System.EventHandler(this.timer_play_Tick);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(376, 44);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(128, 57);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(923, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score : ";
            // 
            // pictureBox_heart4
            // 
            this.pictureBox_heart4.Image = global::MYFACE.Properties.Resources.heart;
            this.pictureBox_heart4.Location = new System.Drawing.Point(1068, 82);
            this.pictureBox_heart4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_heart4.Name = "pictureBox_heart4";
            this.pictureBox_heart4.Size = new System.Drawing.Size(46, 36);
            this.pictureBox_heart4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_heart4.TabIndex = 6;
            this.pictureBox_heart4.TabStop = false;
            // 
            // pictureBox_heart3
            // 
            this.pictureBox_heart3.Image = global::MYFACE.Properties.Resources.heart;
            this.pictureBox_heart3.Location = new System.Drawing.Point(1022, 82);
            this.pictureBox_heart3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_heart3.Name = "pictureBox_heart3";
            this.pictureBox_heart3.Size = new System.Drawing.Size(46, 36);
            this.pictureBox_heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_heart3.TabIndex = 5;
            this.pictureBox_heart3.TabStop = false;
            // 
            // pictureBox_heart2
            // 
            this.pictureBox_heart2.Image = global::MYFACE.Properties.Resources.heart;
            this.pictureBox_heart2.Location = new System.Drawing.Point(976, 82);
            this.pictureBox_heart2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_heart2.Name = "pictureBox_heart2";
            this.pictureBox_heart2.Size = new System.Drawing.Size(46, 36);
            this.pictureBox_heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_heart2.TabIndex = 4;
            this.pictureBox_heart2.TabStop = false;
            // 
            // pictureBox_heart1
            // 
            this.pictureBox_heart1.Image = global::MYFACE.Properties.Resources.heart;
            this.pictureBox_heart1.Location = new System.Drawing.Point(929, 82);
            this.pictureBox_heart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_heart1.Name = "pictureBox_heart1";
            this.pictureBox_heart1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox_heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_heart1.TabIndex = 3;
            this.pictureBox_heart1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(857, 636);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1114, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 46);
            this.btnExit.TabIndex = 15;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 13);
            this.panel2.TabIndex = 16;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox_heart4);
            this.Controls.Add(this.pictureBox_heart3);
            this.Controls.Add(this.pictureBox_heart2);
            this.Controls.Add(this.pictureBox_heart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.Load += new System.EventHandler(this.Play_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_heart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_play;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_heart1;
        private System.Windows.Forms.PictureBox pictureBox_heart2;
        private System.Windows.Forms.PictureBox pictureBox_heart3;
        private System.Windows.Forms.PictureBox pictureBox_heart4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
    }
}