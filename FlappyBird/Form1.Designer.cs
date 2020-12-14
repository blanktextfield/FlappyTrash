namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopPipe = new System.Windows.Forms.PictureBox();
            this.BottomPipe = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.YellowFuck = new System.Windows.Forms.PictureBox();
            this.Counter = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.Restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowFuck)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPipe
            // 
            this.TopPipe.Image = ((System.Drawing.Image)(resources.GetObject("TopPipe.Image")));
            this.TopPipe.Location = new System.Drawing.Point(329, -4);
            this.TopPipe.Name = "TopPipe";
            this.TopPipe.Size = new System.Drawing.Size(125, 296);
            this.TopPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopPipe.TabIndex = 0;
            this.TopPipe.TabStop = false;
            // 
            // BottomPipe
            // 
            this.BottomPipe.Image = ((System.Drawing.Image)(resources.GetObject("BottomPipe.Image")));
            this.BottomPipe.Location = new System.Drawing.Point(329, 457);
            this.BottomPipe.Name = "BottomPipe";
            this.BottomPipe.Size = new System.Drawing.Size(125, 172);
            this.BottomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomPipe.TabIndex = 1;
            this.BottomPipe.TabStop = false;
            this.BottomPipe.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(0, 626);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(544, 91);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            this.Ground.Click += new System.EventHandler(this.Ground_Click);
            // 
            // YellowFuck
            // 
            this.YellowFuck.Image = ((System.Drawing.Image)(resources.GetObject("YellowFuck.Image")));
            this.YellowFuck.Location = new System.Drawing.Point(12, 319);
            this.YellowFuck.Name = "YellowFuck";
            this.YellowFuck.Size = new System.Drawing.Size(96, 77);
            this.YellowFuck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YellowFuck.TabIndex = 3;
            this.YellowFuck.TabStop = false;
            this.YellowFuck.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Counter.Location = new System.Drawing.Point(44, 63);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(107, 35);
            this.Counter.TabIndex = 4;
            this.Counter.Text = "Score: 0";
            this.Counter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Counter.Click += new System.EventHandler(this.label1_Click);
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 20;
            this.Time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Restart
            // 
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Restart.ForeColor = System.Drawing.Color.Red;
            this.Restart.Location = new System.Drawing.Point(154, 319);
            this.Restart.Name = "Restart";
            this.Restart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Restart.Size = new System.Drawing.Size(244, 88);
            this.Restart.TabIndex = 5;
            this.Restart.Text = "Give another try!";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(542, 715);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.YellowFuck);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.BottomPipe);
            this.Controls.Add(this.TopPipe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowFuck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopPipe;
        private System.Windows.Forms.PictureBox BottomPipe;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox YellowFuck;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Button Restart;
    }
}

