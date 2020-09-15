namespace City_Bloxx
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameCanvas = new System.Windows.Forms.PictureBox();
            this.block = new System.Windows.Forms.PictureBox();
            this.GameStats = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.blockdown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).BeginInit();
            this.GameStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockdown)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // GameCanvas
            // 
            this.GameCanvas.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GameCanvas.Dock = System.Windows.Forms.DockStyle.Left;
            this.GameCanvas.Location = new System.Drawing.Point(0, 0);
            this.GameCanvas.Name = "GameCanvas";
            this.GameCanvas.Size = new System.Drawing.Size(600, 381);
            this.GameCanvas.TabIndex = 0;
            this.GameCanvas.TabStop = false;
            // 
            // block
            // 
            this.block.Image = ((System.Drawing.Image)(resources.GetObject("block.Image")));
            this.block.Location = new System.Drawing.Point(0, 0);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(124, 118);
            this.block.TabIndex = 1;
            this.block.TabStop = false;
            // 
            // GameStats
            // 
            this.GameStats.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameStats.Controls.Add(this.label2);
            this.GameStats.Controls.Add(this.label1);
            this.GameStats.Controls.Add(this.blockdown);
            this.GameStats.Dock = System.Windows.Forms.DockStyle.Right;
            this.GameStats.Location = new System.Drawing.Point(601, 0);
            this.GameStats.Name = "GameStats";
            this.GameStats.Size = new System.Drawing.Size(200, 381);
            this.GameStats.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Блоков:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            // 
            // blockdown
            // 
            this.blockdown.Image = ((System.Drawing.Image)(resources.GetObject("blockdown.Image")));
            this.blockdown.Location = new System.Drawing.Point(-30, 263);
            this.blockdown.Name = "blockdown";
            this.blockdown.Size = new System.Drawing.Size(124, 118);
            this.blockdown.TabIndex = 3;
            this.blockdown.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 381);
            this.Controls.Add(this.GameStats);
            this.Controls.Add(this.block);
            this.Controls.Add(this.GameCanvas);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).EndInit();
            this.GameStats.ResumeLayout(false);
            this.GameStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockdown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox GameCanvas;
        private System.Windows.Forms.PictureBox block;
        private System.Windows.Forms.Panel GameStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox blockdown;
    }
}