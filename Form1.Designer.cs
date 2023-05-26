namespace SnakeGame
{
    partial class SnakeGameForm
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
            this.GameArea = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelScoreText = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameTitle = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameArea
            // 
            this.GameArea.ForeColor = System.Drawing.SystemColors.Control;
            this.GameArea.Location = new System.Drawing.Point(13, 13);
            this.GameArea.Margin = new System.Windows.Forms.Padding(0);
            this.GameArea.Name = "GameArea";
            this.GameArea.Size = new System.Drawing.Size(420, 420);
            this.GameArea.TabIndex = 0;
            this.GameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.GameArea_Paint);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(509, 348);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(89, 34);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "开始游戏";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelScoreText
            // 
            this.labelScoreText.AutoSize = true;
            this.labelScoreText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelScoreText.Location = new System.Drawing.Point(565, 62);
            this.labelScoreText.Name = "labelScoreText";
            this.labelScoreText.Size = new System.Drawing.Size(20, 20);
            this.labelScoreText.TabIndex = 11;
            this.labelScoreText.Text = "0";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelScore.Location = new System.Drawing.Point(487, 62);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(72, 20);
            this.labelScore.TabIndex = 10;
            this.labelScore.Text = "分数：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnakeGame.Properties.Resources.Snake_small;
            this.pictureBox1.Location = new System.Drawing.Point(468, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // GameTitle
            // 
            this.GameTitle.AutoSize = true;
            this.GameTitle.Font = new System.Drawing.Font("华文彩云", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameTitle.Location = new System.Drawing.Point(484, 106);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(114, 33);
            this.GameTitle.TabIndex = 13;
            this.GameTitle.Text = "贪吃蛇";
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // SnakeGameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelScoreText);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.GameArea);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnakeGameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贪吃蛇游戏";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SnakeGameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GameArea;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelScoreText;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label GameTitle;
        private System.Windows.Forms.Timer GameTimer;
    }
}

