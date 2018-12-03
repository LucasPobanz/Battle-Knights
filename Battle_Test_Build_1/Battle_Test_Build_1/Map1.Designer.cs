namespace Battle_Test_Build_1
{
    partial class Map1
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
            this.player1 = new System.Windows.Forms.PictureBox();
            this.movementTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cpu1 = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.mainPlatform = new System.Windows.Forms.PictureBox();
            this.cpuTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlatform)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player1.Location = new System.Drawing.Point(333, 138);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(34, 43);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // movementTime
            // 
            this.movementTime.Enabled = true;
            this.movementTime.Interval = 1;
            this.movementTime.Tick += new System.EventHandler(this.movementTime_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cpu1);
            this.panel1.Controls.Add(this.platform2);
            this.panel1.Controls.Add(this.platform1);
            this.panel1.Controls.Add(this.mainPlatform);
            this.panel1.Controls.Add(this.player1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 649);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cpu1
            // 
            this.cpu1.BackColor = System.Drawing.Color.Red;
            this.cpu1.Location = new System.Drawing.Point(459, 138);
            this.cpu1.Name = "cpu1";
            this.cpu1.Size = new System.Drawing.Size(34, 43);
            this.cpu1.TabIndex = 4;
            this.cpu1.TabStop = false;
            // 
            // platform2
            // 
            this.platform2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.platform2.Location = new System.Drawing.Point(333, 440);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(188, 14);
            this.platform2.TabIndex = 3;
            this.platform2.TabStop = false;
            // 
            // platform1
            // 
            this.platform1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.platform1.Location = new System.Drawing.Point(670, 440);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(188, 14);
            this.platform1.TabIndex = 2;
            this.platform1.TabStop = false;
            // 
            // mainPlatform
            // 
            this.mainPlatform.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mainPlatform.Location = new System.Drawing.Point(176, 599);
            this.mainPlatform.Name = "mainPlatform";
            this.mainPlatform.Size = new System.Drawing.Size(826, 50);
            this.mainPlatform.TabIndex = 1;
            this.mainPlatform.TabStop = false;
            // 
            // cpuTimer
            // 
            this.cpuTimer.Enabled = true;
            this.cpuTimer.Interval = 1000;
            // 
            // Map1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 649);
            this.Controls.Add(this.panel1);
            this.Name = "Map1";
            this.Text = "Map1";
            this.Load += new System.EventHandler(this.Map1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Map1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Map1_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlatform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Timer movementTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox mainPlatform;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox cpu1;
        private System.Windows.Forms.Timer cpuTimer;
    }
}