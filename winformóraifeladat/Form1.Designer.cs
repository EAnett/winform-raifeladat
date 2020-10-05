namespace winformóraifeladat
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
            this.lb_rendszam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_adatok = new System.Windows.Forms.ListBox();
            this.tb_rendszam = new System.Windows.Forms.TextBox();
            this.tb_tipus = new System.Windows.Forms.TextBox();
            this.tb_teljesítmény = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_lóerő = new System.Windows.Forms.Label();
            this.lb_jel = new System.Windows.Forms.Label();
            this.tb_rendszamszam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_rendszam
            // 
            this.lb_rendszam.AutoSize = true;
            this.lb_rendszam.Location = new System.Drawing.Point(13, 13);
            this.lb_rendszam.Name = "lb_rendszam";
            this.lb_rendszam.Size = new System.Drawing.Size(75, 17);
            this.lb_rendszam.TabIndex = 0;
            this.lb_rendszam.Text = "Rendszám";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Típus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gyártmány";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teljesítmény";
            // 
            // lb_adatok
            // 
            this.lb_adatok.FormattingEnabled = true;
            this.lb_adatok.ItemHeight = 16;
            this.lb_adatok.Location = new System.Drawing.Point(475, 13);
            this.lb_adatok.Name = "lb_adatok";
            this.lb_adatok.Size = new System.Drawing.Size(313, 420);
            this.lb_adatok.TabIndex = 4;
            // 
            // tb_rendszam
            // 
            this.tb_rendszam.Location = new System.Drawing.Point(169, 13);
            this.tb_rendszam.Name = "tb_rendszam";
            this.tb_rendszam.Size = new System.Drawing.Size(128, 22);
            this.tb_rendszam.TabIndex = 5;
            // 
            // tb_tipus
            // 
            this.tb_tipus.Location = new System.Drawing.Point(169, 47);
            this.tb_tipus.Name = "tb_tipus";
            this.tb_tipus.Size = new System.Drawing.Size(300, 22);
            this.tb_tipus.TabIndex = 6;
            // 
            // tb_teljesítmény
            // 
            this.tb_teljesítmény.Location = new System.Drawing.Point(169, 130);
            this.tb_teljesítmény.Name = "tb_teljesítmény";
            this.tb_teljesítmény.Size = new System.Drawing.Size(148, 22);
            this.tb_teljesítmény.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(169, 86);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(300, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_lóerő
            // 
            this.lb_lóerő.AutoSize = true;
            this.lb_lóerő.Location = new System.Drawing.Point(323, 135);
            this.lb_lóerő.Name = "lb_lóerő";
            this.lb_lóerő.Size = new System.Drawing.Size(40, 17);
            this.lb_lóerő.TabIndex = 10;
            this.lb_lóerő.Text = "lóerő";
            // 
            // lb_jel
            // 
            this.lb_jel.AutoSize = true;
            this.lb_jel.Location = new System.Drawing.Point(314, 18);
            this.lb_jel.Name = "lb_jel";
            this.lb_jel.Size = new System.Drawing.Size(13, 17);
            this.lb_jel.TabIndex = 11;
            this.lb_jel.Text = "-";
            // 
            // tb_rendszamszam
            // 
            this.tb_rendszamszam.Location = new System.Drawing.Point(343, 14);
            this.tb_rendszamszam.Name = "tb_rendszamszam";
            this.tb_rendszamszam.Size = new System.Drawing.Size(126, 22);
            this.tb_rendszamszam.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_rendszamszam);
            this.Controls.Add(this.lb_jel);
            this.Controls.Add(this.lb_lóerő);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tb_teljesítmény);
            this.Controls.Add(this.tb_tipus);
            this.Controls.Add(this.tb_rendszam);
            this.Controls.Add(this.lb_adatok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_rendszam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_rendszam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_adatok;
        private System.Windows.Forms.TextBox tb_rendszam;
        private System.Windows.Forms.TextBox tb_tipus;
        private System.Windows.Forms.TextBox tb_teljesítmény;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_lóerő;
        private System.Windows.Forms.Label lb_jel;
        private System.Windows.Forms.TextBox tb_rendszamszam;
    }
}

