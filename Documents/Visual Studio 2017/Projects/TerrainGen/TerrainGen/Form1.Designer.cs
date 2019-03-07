namespace TerrainGen
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
            this.InsRandomPeaks_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ElevationPropVar_LB = new System.Windows.Forms.Label();
            this.ElevationPropVar_TxtBox = new System.Windows.Forms.TextBox();
            this.ELayers_TxtBox = new System.Windows.Forms.TextBox();
            this.ELayers_LB = new System.Windows.Forms.Label();
            this.ELayers_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumPeaks_txtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ProbElevationDrop_TxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ElevationDropIterrations_Textbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ExpandIterrations_TxtBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsRandomPeaks_Btn
            // 
            this.InsRandomPeaks_Btn.Location = new System.Drawing.Point(132, 6);
            this.InsRandomPeaks_Btn.Name = "InsRandomPeaks_Btn";
            this.InsRandomPeaks_Btn.Size = new System.Drawing.Size(64, 23);
            this.InsRandomPeaks_Btn.TabIndex = 0;
            this.InsRandomPeaks_Btn.Text = "Insert";
            this.InsRandomPeaks_Btn.UseVisualStyleBackColor = true;
            this.InsRandomPeaks_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(250, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 1000);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ElevationPropVar_LB
            // 
            this.ElevationPropVar_LB.AutoSize = true;
            this.ElevationPropVar_LB.Location = new System.Drawing.Point(68, 50);
            this.ElevationPropVar_LB.Name = "ElevationPropVar_LB";
            this.ElevationPropVar_LB.Size = new System.Drawing.Size(108, 13);
            this.ElevationPropVar_LB.TabIndex = 2;
            this.ElevationPropVar_LB.Text = "Proportional Variance";
            // 
            // ElevationPropVar_TxtBox
            // 
            this.ElevationPropVar_TxtBox.Location = new System.Drawing.Point(68, 66);
            this.ElevationPropVar_TxtBox.Name = "ElevationPropVar_TxtBox";
            this.ElevationPropVar_TxtBox.Size = new System.Drawing.Size(108, 20);
            this.ElevationPropVar_TxtBox.TabIndex = 3;
            this.ElevationPropVar_TxtBox.Text = ".25";
            // 
            // ELayers_TxtBox
            // 
            this.ELayers_TxtBox.Location = new System.Drawing.Point(6, 32);
            this.ELayers_TxtBox.Name = "ELayers_TxtBox";
            this.ELayers_TxtBox.Size = new System.Drawing.Size(82, 20);
            this.ELayers_TxtBox.TabIndex = 4;
            this.ELayers_TxtBox.Text = "10";
            this.ELayers_TxtBox.TextChanged += new System.EventHandler(this.ELayers_TxtBox_TextChanged);
            // 
            // ELayers_LB
            // 
            this.ELayers_LB.AutoSize = true;
            this.ELayers_LB.Location = new System.Drawing.Point(3, 13);
            this.ELayers_LB.Name = "ELayers_LB";
            this.ELayers_LB.Size = new System.Drawing.Size(85, 13);
            this.ELayers_LB.TabIndex = 5;
            this.ELayers_LB.Text = "Elevation Layers";
            // 
            // ELayers_Btn
            // 
            this.ELayers_Btn.Location = new System.Drawing.Point(132, 13);
            this.ELayers_Btn.Name = "ELayers_Btn";
            this.ELayers_Btn.Size = new System.Drawing.Size(64, 23);
            this.ELayers_Btn.TabIndex = 6;
            this.ELayers_Btn.Text = "Accept";
            this.ELayers_Btn.UseVisualStyleBackColor = true;
            this.ELayers_Btn.Click += new System.EventHandler(this.ELayers_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Insert Random Peaks";
            // 
            // NumPeaks_txtbox
            // 
            this.NumPeaks_txtbox.Location = new System.Drawing.Point(6, 66);
            this.NumPeaks_txtbox.Name = "NumPeaks_txtbox";
            this.NumPeaks_txtbox.Size = new System.Drawing.Size(56, 20);
            this.NumPeaks_txtbox.TabIndex = 8;
            this.NumPeaks_txtbox.Text = "10";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NumPeaks_txtbox);
            this.panel1.Controls.Add(this.InsRandomPeaks_Btn);
            this.panel1.Controls.Add(this.ElevationPropVar_TxtBox);
            this.panel1.Controls.Add(this.ElevationPropVar_LB);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 100);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "# of Peaks";
            // 
            // ProbElevationDrop_TxtBox
            // 
            this.ProbElevationDrop_TxtBox.Location = new System.Drawing.Point(132, 63);
            this.ProbElevationDrop_TxtBox.Name = "ProbElevationDrop_TxtBox";
            this.ProbElevationDrop_TxtBox.Size = new System.Drawing.Size(64, 20);
            this.ProbElevationDrop_TxtBox.TabIndex = 10;
            this.ProbElevationDrop_TxtBox.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Expand Terrain";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Expand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ElevationDropIterrations_Textbox
            // 
            this.ElevationDropIterrations_Textbox.Location = new System.Drawing.Point(132, 89);
            this.ElevationDropIterrations_Textbox.Name = "ElevationDropIterrations_Textbox";
            this.ElevationDropIterrations_Textbox.Size = new System.Drawing.Size(64, 20);
            this.ElevationDropIterrations_Textbox.TabIndex = 13;
            this.ElevationDropIterrations_Textbox.Text = "10";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.ExpandIterrations_TxtBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ElevationDropIterrations_Textbox);
            this.panel2.Controls.Add(this.ProbElevationDrop_TxtBox);
            this.panel2.Location = new System.Drawing.Point(12, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 127);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Probabilty of Drop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Potential Drop Iterrations";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.ELayers_LB);
            this.panel3.Controls.Add(this.ELayers_TxtBox);
            this.panel3.Controls.Add(this.ELayers_Btn);
            this.panel3.Location = new System.Drawing.Point(12, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 100);
            this.panel3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bitmap Terrain Generator";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(12, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 35);
            this.panel4.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Expand Iterrations";
            // 
            // ExpandIterrations_TxtBox
            // 
            this.ExpandIterrations_TxtBox.Location = new System.Drawing.Point(132, 36);
            this.ExpandIterrations_TxtBox.Name = "ExpandIterrations_TxtBox";
            this.ExpandIterrations_TxtBox.Size = new System.Drawing.Size(64, 20);
            this.ExpandIterrations_TxtBox.TabIndex = 17;
            this.ExpandIterrations_TxtBox.Text = "1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(12, 393);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 87);
            this.panel5.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Smooth Terrain";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Smooth";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(12, 486);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 67);
            this.panel6.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "CLEAR MAP";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(956, 683);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InsRandomPeaks_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ElevationPropVar_LB;
        private System.Windows.Forms.TextBox ElevationPropVar_TxtBox;
        private System.Windows.Forms.TextBox ELayers_TxtBox;
        private System.Windows.Forms.Label ELayers_LB;
        private System.Windows.Forms.Button ELayers_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumPeaks_txtbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProbElevationDrop_TxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ElevationDropIterrations_Textbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ExpandIterrations_TxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
    }
}

