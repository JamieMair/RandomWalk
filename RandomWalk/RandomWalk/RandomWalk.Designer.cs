namespace RandomWalk
{
    partial class RandomWalk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomWalk));
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_gridsize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tb_spawn = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tb_Density = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tb_Interval = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tb_Updates = new System.Windows.Forms.ToolStripTextBox();
            this.btn_Pause = new System.Windows.Forms.ToolStripButton();
            this.btn_Play = new System.Windows.Forms.ToolStripButton();
            this.btn_Reset = new System.Windows.Forms.ToolStripButton();
            this.btn_Advanced = new System.Windows.Forms.ToolStripButton();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btn_RandomWalk = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 40;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tb_gridsize,
            this.toolStripLabel2,
            this.tb_spawn,
            this.toolStripLabel4,
            this.tb_Density,
            this.toolStripLabel3,
            this.tb_Interval,
            this.toolStripLabel5,
            this.tb_Updates,
            this.btn_Pause,
            this.btn_Play,
            this.btn_Reset,
            this.btn_Advanced,
            this.btn_RandomWalk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(716, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 24);
            this.toolStripLabel1.Text = "Grid Size: ";
            // 
            // tb_gridsize
            // 
            this.tb_gridsize.Name = "tb_gridsize";
            this.tb_gridsize.Size = new System.Drawing.Size(46, 27);
            this.tb_gridsize.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(79, 24);
            this.toolStripLabel2.Text = "Spawn Rate: ";
            // 
            // tb_spawn
            // 
            this.tb_spawn.Name = "tb_spawn";
            this.tb_spawn.Size = new System.Drawing.Size(46, 27);
            this.tb_spawn.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabel4.Text = "Density: ";
            // 
            // tb_Density
            // 
            this.tb_Density.Name = "tb_Density";
            this.tb_Density.Size = new System.Drawing.Size(46, 27);
            this.tb_Density.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(57, 24);
            this.toolStripLabel3.Text = "Interval: ";
            // 
            // tb_Interval
            // 
            this.tb_Interval.Name = "tb_Interval";
            this.tb_Interval.Size = new System.Drawing.Size(46, 27);
            this.tb_Interval.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Interval.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Interval_KeyUp);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(59, 24);
            this.toolStripLabel5.Text = "Updates: ";
            // 
            // tb_Updates
            // 
            this.tb_Updates.Name = "tb_Updates";
            this.tb_Updates.Size = new System.Drawing.Size(46, 27);
            this.tb_Updates.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Updates.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Updates_KeyUp);
            // 
            // btn_Pause
            // 
            this.btn_Pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pause.Image")));
            this.btn_Pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(24, 24);
            this.btn_Pause.Text = "toolStripButton1";
            this.btn_Pause.ToolTipText = "Pause";
            this.btn_Pause.Visible = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Play.Image = ((System.Drawing.Image)(resources.GetObject("btn_Play.Image")));
            this.btn_Play.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(24, 24);
            this.btn_Play.Text = "btn_play";
            this.btn_Play.ToolTipText = "Play";
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(24, 24);
            this.btn_Reset.Text = "toolStripButton2";
            this.btn_Reset.ToolTipText = "Restart";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Advanced
            // 
            this.btn_Advanced.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Advanced.Image = ((System.Drawing.Image)(resources.GetObject("btn_Advanced.Image")));
            this.btn_Advanced.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Advanced.Name = "btn_Advanced";
            this.btn_Advanced.Size = new System.Drawing.Size(24, 24);
            this.btn_Advanced.Text = "toolStripButton1";
            this.btn_Advanced.ToolTipText = "Advanced";
            this.btn_Advanced.Click += new System.EventHandler(this.btn_Advanced_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Left;
            this.canvas.Location = new System.Drawing.Point(0, 27);
            this.canvas.Margin = new System.Windows.Forms.Padding(0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(375, 564);
            this.canvas.TabIndex = 2;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // btn_RandomWalk
            // 
            this.btn_RandomWalk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_RandomWalk.Image = ((System.Drawing.Image)(resources.GetObject("btn_RandomWalk.Image")));
            this.btn_RandomWalk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_RandomWalk.Name = "btn_RandomWalk";
            this.btn_RandomWalk.Size = new System.Drawing.Size(24, 24);
            this.btn_RandomWalk.Text = "toolStripButton1";
            this.btn_RandomWalk.ToolTipText = "Random Walk";
            this.btn_RandomWalk.Click += new System.EventHandler(this.btn_RandomWalk_Click);
            // 
            // RandomWalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(716, 591);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RandomWalk";
            this.ShowIcon = false;
            this.Text = "Random Walk";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tb_gridsize;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tb_spawn;
        private System.Windows.Forms.ToolStripButton btn_Pause;
        private System.Windows.Forms.ToolStripButton btn_Play;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ToolStripButton btn_Reset;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox tb_Density;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tb_Interval;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox tb_Updates;
        private System.Windows.Forms.ToolStripButton btn_Advanced;
        private System.Windows.Forms.ToolStripButton btn_RandomWalk;
    }
}

