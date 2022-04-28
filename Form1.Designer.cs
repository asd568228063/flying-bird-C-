namespace Flyingbird
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.Top = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Bird.Location = new System.Drawing.Point(82, 252);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(84, 63);
            this.Bird.TabIndex = 1;
            this.Bird.TabStop = false;
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Top.Location = new System.Drawing.Point(414, -1);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(110, 183);
            this.Top.TabIndex = 2;
            this.Top.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ground.Location = new System.Drawing.Point(414, 428);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(110, 183);
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            this.Ground.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(35, 33);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(131, 42);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score:0";
            this.Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(764, 601);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Bird);
            this.Name = "Form1";
            this.Text = "flyingbird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyup);
          
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox Top;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer Timer;
    }
}

