namespace RandomWalk
{
    partial class AdvancedWalk
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_Density = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_SpawnRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_GridSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_FolderName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_FrameStep = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_CreateFrames = new System.Windows.Forms.Button();
            this.tb_Images = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_FixPEdit = new System.Windows.Forms.Button();
            this.btn_FpEdit = new System.Windows.Forms.Button();
            this.btn_BgEdit = new System.Windows.Forms.Button();
            this.pb_FixedParticle = new System.Windows.Forms.PictureBox();
            this.pb_FreeParticle = new System.Windows.Forms.PictureBox();
            this.pb_Background = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Fractal = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_PixelSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Image = new System.Windows.Forms.Button();
            this.tb_Interations = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.cb_RandomWalk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FixedParticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FreeParticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Background)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_RandomWalk);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tb_Density);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_SpawnRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_GridSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(242, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random Walk Properties";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 85);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label13.Size = new System.Drawing.Size(102, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "Is Random Walk: ";
            // 
            // tb_Density
            // 
            this.tb_Density.Location = new System.Drawing.Point(109, 64);
            this.tb_Density.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Density.Name = "tb_Density";
            this.tb_Density.Size = new System.Drawing.Size(118, 20);
            this.tb_Density.TabIndex = 5;
            this.tb_Density.Text = "0.08";
            this.tb_Density.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Density: ";
            // 
            // tb_SpawnRate
            // 
            this.tb_SpawnRate.Location = new System.Drawing.Point(109, 43);
            this.tb_SpawnRate.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SpawnRate.Name = "tb_SpawnRate";
            this.tb_SpawnRate.Size = new System.Drawing.Size(118, 20);
            this.tb_SpawnRate.TabIndex = 3;
            this.tb_SpawnRate.Text = "1";
            this.tb_SpawnRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spawn Rate: ";
            // 
            // tb_GridSize
            // 
            this.tb_GridSize.Location = new System.Drawing.Point(109, 22);
            this.tb_GridSize.Margin = new System.Windows.Forms.Padding(2);
            this.tb_GridSize.Name = "tb_GridSize";
            this.tb_GridSize.Size = new System.Drawing.Size(118, 20);
            this.tb_GridSize.TabIndex = 1;
            this.tb_GridSize.Text = "500";
            this.tb_GridSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grid Size: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_FolderName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_FrameStep);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btn_CreateFrames);
            this.groupBox2.Controls.Add(this.tb_Images);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_FixPEdit);
            this.groupBox2.Controls.Add(this.btn_FpEdit);
            this.groupBox2.Controls.Add(this.btn_BgEdit);
            this.groupBox2.Controls.Add(this.pb_FixedParticle);
            this.groupBox2.Controls.Add(this.pb_FreeParticle);
            this.groupBox2.Controls.Add(this.pb_Background);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cb_Fractal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_PixelSize);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_Image);
            this.groupBox2.Controls.Add(this.tb_Interations);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(256, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(242, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animation Properties";
            // 
            // tb_FolderName
            // 
            this.tb_FolderName.Location = new System.Drawing.Point(121, 191);
            this.tb_FolderName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FolderName.Name = "tb_FolderName";
            this.tb_FolderName.Size = new System.Drawing.Size(118, 20);
            this.tb_FolderName.TabIndex = 27;
            this.tb_FolderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 191);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Folder Name:";
            // 
            // tb_FrameStep
            // 
            this.tb_FrameStep.Location = new System.Drawing.Point(121, 170);
            this.tb_FrameStep.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FrameStep.Name = "tb_FrameStep";
            this.tb_FrameStep.Size = new System.Drawing.Size(118, 20);
            this.tb_FrameStep.TabIndex = 25;
            this.tb_FrameStep.Text = "1";
            this.tb_FrameStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 170);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label11.Size = new System.Drawing.Size(77, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Frame Step: ";
            // 
            // btn_CreateFrames
            // 
            this.btn_CreateFrames.Location = new System.Drawing.Point(4, 252);
            this.btn_CreateFrames.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CreateFrames.Name = "btn_CreateFrames";
            this.btn_CreateFrames.Size = new System.Drawing.Size(233, 24);
            this.btn_CreateFrames.TabIndex = 23;
            this.btn_CreateFrames.Text = "Create Frames";
            this.btn_CreateFrames.UseVisualStyleBackColor = true;
            this.btn_CreateFrames.Click += new System.EventHandler(this.btn_CreateFrames_Click);
            // 
            // tb_Images
            // 
            this.tb_Images.Location = new System.Drawing.Point(121, 149);
            this.tb_Images.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Images.Name = "tb_Images";
            this.tb_Images.Size = new System.Drawing.Size(118, 20);
            this.tb_Images.TabIndex = 22;
            this.tb_Images.Text = "1";
            this.tb_Images.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label10.Size = new System.Drawing.Size(50, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Images:";
            // 
            // btn_FixPEdit
            // 
            this.btn_FixPEdit.Location = new System.Drawing.Point(194, 128);
            this.btn_FixPEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FixPEdit.Name = "btn_FixPEdit";
            this.btn_FixPEdit.Size = new System.Drawing.Size(44, 21);
            this.btn_FixPEdit.TabIndex = 20;
            this.btn_FixPEdit.Text = "Edit";
            this.btn_FixPEdit.UseVisualStyleBackColor = true;
            this.btn_FixPEdit.Click += new System.EventHandler(this.btn_FixPEdit_Click);
            // 
            // btn_FpEdit
            // 
            this.btn_FpEdit.Location = new System.Drawing.Point(194, 106);
            this.btn_FpEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FpEdit.Name = "btn_FpEdit";
            this.btn_FpEdit.Size = new System.Drawing.Size(44, 21);
            this.btn_FpEdit.TabIndex = 19;
            this.btn_FpEdit.Text = "Edit";
            this.btn_FpEdit.UseVisualStyleBackColor = true;
            this.btn_FpEdit.Click += new System.EventHandler(this.btn_FpEdit_Click);
            // 
            // btn_BgEdit
            // 
            this.btn_BgEdit.Location = new System.Drawing.Point(194, 85);
            this.btn_BgEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BgEdit.Name = "btn_BgEdit";
            this.btn_BgEdit.Size = new System.Drawing.Size(44, 21);
            this.btn_BgEdit.TabIndex = 18;
            this.btn_BgEdit.Text = "Edit";
            this.btn_BgEdit.UseVisualStyleBackColor = true;
            this.btn_BgEdit.Click += new System.EventHandler(this.btn_BgEdit_Click);
            // 
            // pb_FixedParticle
            // 
            this.pb_FixedParticle.BackColor = System.Drawing.Color.Blue;
            this.pb_FixedParticle.Location = new System.Drawing.Point(121, 128);
            this.pb_FixedParticle.Margin = new System.Windows.Forms.Padding(2);
            this.pb_FixedParticle.Name = "pb_FixedParticle";
            this.pb_FixedParticle.Size = new System.Drawing.Size(68, 21);
            this.pb_FixedParticle.TabIndex = 17;
            this.pb_FixedParticle.TabStop = false;
            // 
            // pb_FreeParticle
            // 
            this.pb_FreeParticle.BackColor = System.Drawing.Color.Black;
            this.pb_FreeParticle.Location = new System.Drawing.Point(121, 106);
            this.pb_FreeParticle.Margin = new System.Windows.Forms.Padding(2);
            this.pb_FreeParticle.Name = "pb_FreeParticle";
            this.pb_FreeParticle.Size = new System.Drawing.Size(68, 21);
            this.pb_FreeParticle.TabIndex = 16;
            this.pb_FreeParticle.TabStop = false;
            // 
            // pb_Background
            // 
            this.pb_Background.BackColor = System.Drawing.Color.White;
            this.pb_Background.Location = new System.Drawing.Point(121, 85);
            this.pb_Background.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Background.Name = "pb_Background";
            this.pb_Background.Size = new System.Drawing.Size(68, 21);
            this.pb_Background.TabIndex = 15;
            this.pb_Background.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fixed Particle:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Free Particle:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Background: ";
            // 
            // cb_Fractal
            // 
            this.cb_Fractal.AutoSize = true;
            this.cb_Fractal.Location = new System.Drawing.Point(224, 67);
            this.cb_Fractal.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Fractal.Name = "cb_Fractal";
            this.cb_Fractal.Size = new System.Drawing.Size(15, 14);
            this.cb_Fractal.TabIndex = 11;
            this.cb_Fractal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fractal Only: ";
            // 
            // tb_PixelSize
            // 
            this.tb_PixelSize.Location = new System.Drawing.Point(121, 43);
            this.tb_PixelSize.Margin = new System.Windows.Forms.Padding(2);
            this.tb_PixelSize.Name = "tb_PixelSize";
            this.tb_PixelSize.Size = new System.Drawing.Size(118, 20);
            this.tb_PixelSize.TabIndex = 9;
            this.tb_PixelSize.Text = "1";
            this.tb_PixelSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pixel Size: ";
            // 
            // btn_Image
            // 
            this.btn_Image.Location = new System.Drawing.Point(4, 223);
            this.btn_Image.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(233, 24);
            this.btn_Image.TabIndex = 7;
            this.btn_Image.Text = "Create Image";
            this.btn_Image.UseVisualStyleBackColor = true;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // tb_Interations
            // 
            this.tb_Interations.Location = new System.Drawing.Point(121, 22);
            this.tb_Interations.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Interations.Name = "tb_Interations";
            this.tb_Interations.Size = new System.Drawing.Size(118, 20);
            this.tb_Interations.TabIndex = 6;
            this.tb_Interations.Text = "5000";
            this.tb_Interations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Iterations: ";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 288);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(506, 25);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "bottomToolStrip";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Margin = new System.Windows.Forms.Padding(1, 2, 16, 1);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(225, 22);
            this.progressBar.Step = 1;
            this.progressBar.Visible = false;
            // 
            // cb_RandomWalk
            // 
            this.cb_RandomWalk.AutoSize = true;
            this.cb_RandomWalk.Location = new System.Drawing.Point(212, 89);
            this.cb_RandomWalk.Margin = new System.Windows.Forms.Padding(2);
            this.cb_RandomWalk.Name = "cb_RandomWalk";
            this.cb_RandomWalk.Size = new System.Drawing.Size(15, 14);
            this.cb_RandomWalk.TabIndex = 28;
            this.cb_RandomWalk.UseVisualStyleBackColor = true;
            // 
            // AdvancedWalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 313);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdvancedWalk";
            this.ShowIcon = false;
            this.Text = "AdvancedWalk";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FixedParticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FreeParticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Background)).EndInit();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_GridSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_SpawnRate;
        private System.Windows.Forms.TextBox tb_Density;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_PixelSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Image;
        private System.Windows.Forms.TextBox tb_Interations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.CheckBox cb_Fractal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_FixPEdit;
        private System.Windows.Forms.Button btn_FpEdit;
        private System.Windows.Forms.Button btn_BgEdit;
        private System.Windows.Forms.PictureBox pb_FixedParticle;
        private System.Windows.Forms.PictureBox pb_FreeParticle;
        private System.Windows.Forms.PictureBox pb_Background;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Images;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_FrameStep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_CreateFrames;
        private System.Windows.Forms.TextBox tb_FolderName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cb_RandomWalk;
    }
}