namespace Projekt_Programowanie_Obiektowe___KNN
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
            this.tbSciezkaTrening = new System.Windows.Forms.TextBox();
            this.tbSciezkaTest = new System.Windows.Forms.TextBox();
            this.btnWczytajTreningowe = new System.Windows.Forms.Button();
            this.btnWczytajTestowe = new System.Windows.Forms.Button();
            this.tbDaneTreningowe = new System.Windows.Forms.RichTextBox();
            this.tbDaneTestowe = new System.Windows.Forms.RichTextBox();
            this.ofdTrening = new System.Windows.Forms.OpenFileDialog();
            this.ofdTest = new System.Windows.Forms.OpenFileDialog();
            this.numericSasiedzi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLicz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMetryki = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbWyniki = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericSasiedzi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSciezkaTrening
            // 
            this.tbSciezkaTrening.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSciezkaTrening.Location = new System.Drawing.Point(6, 19);
            this.tbSciezkaTrening.Name = "tbSciezkaTrening";
            this.tbSciezkaTrening.ReadOnly = true;
            this.tbSciezkaTrening.Size = new System.Drawing.Size(275, 20);
            this.tbSciezkaTrening.TabIndex = 0;
            // 
            // tbSciezkaTest
            // 
            this.tbSciezkaTest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSciezkaTest.Location = new System.Drawing.Point(6, 67);
            this.tbSciezkaTest.Name = "tbSciezkaTest";
            this.tbSciezkaTest.ReadOnly = true;
            this.tbSciezkaTest.Size = new System.Drawing.Size(275, 20);
            this.tbSciezkaTest.TabIndex = 1;
            // 
            // btnWczytajTreningowe
            // 
            this.btnWczytajTreningowe.Location = new System.Drawing.Point(287, 12);
            this.btnWczytajTreningowe.Name = "btnWczytajTreningowe";
            this.btnWczytajTreningowe.Size = new System.Drawing.Size(155, 32);
            this.btnWczytajTreningowe.TabIndex = 2;
            this.btnWczytajTreningowe.Text = "Wczytaj Dane Treningowe";
            this.btnWczytajTreningowe.UseVisualStyleBackColor = true;
            this.btnWczytajTreningowe.Click += new System.EventHandler(this.btnWczytajTreningowe_Click);
            // 
            // btnWczytajTestowe
            // 
            this.btnWczytajTestowe.Location = new System.Drawing.Point(287, 60);
            this.btnWczytajTestowe.Name = "btnWczytajTestowe";
            this.btnWczytajTestowe.Size = new System.Drawing.Size(155, 32);
            this.btnWczytajTestowe.TabIndex = 3;
            this.btnWczytajTestowe.Text = "Wczytaj Dane Testowe";
            this.btnWczytajTestowe.UseVisualStyleBackColor = true;
            this.btnWczytajTestowe.Click += new System.EventHandler(this.btnWczytajTestowe_Click);
            // 
            // tbDaneTreningowe
            // 
            this.tbDaneTreningowe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDaneTreningowe.Location = new System.Drawing.Point(6, 18);
            this.tbDaneTreningowe.Name = "tbDaneTreningowe";
            this.tbDaneTreningowe.ReadOnly = true;
            this.tbDaneTreningowe.Size = new System.Drawing.Size(94, 107);
            this.tbDaneTreningowe.TabIndex = 4;
            this.tbDaneTreningowe.Text = "";
            // 
            // tbDaneTestowe
            // 
            this.tbDaneTestowe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDaneTestowe.Location = new System.Drawing.Point(6, 17);
            this.tbDaneTestowe.Name = "tbDaneTestowe";
            this.tbDaneTestowe.ReadOnly = true;
            this.tbDaneTestowe.Size = new System.Drawing.Size(94, 108);
            this.tbDaneTestowe.TabIndex = 5;
            this.tbDaneTestowe.Text = "";
            // 
            // ofdTest
            // 
            this.ofdTest.FileName = "openFileDialog2";
            // 
            // numericSasiedzi
            // 
            this.numericSasiedzi.Enabled = false;
            this.numericSasiedzi.Location = new System.Drawing.Point(88, 20);
            this.numericSasiedzi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSasiedzi.Name = "numericSasiedzi";
            this.numericSasiedzi.Size = new System.Drawing.Size(57, 20);
            this.numericSasiedzi.TabIndex = 6;
            this.numericSasiedzi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ilość sąsiadów";
            // 
            // btnLicz
            // 
            this.btnLicz.Enabled = false;
            this.btnLicz.Location = new System.Drawing.Point(9, 77);
            this.btnLicz.Name = "btnLicz";
            this.btnLicz.Size = new System.Drawing.Size(203, 23);
            this.btnLicz.TabIndex = 8;
            this.btnLicz.Text = "Licz";
            this.btnLicz.UseVisualStyleBackColor = true;
            this.btnLicz.Click += new System.EventHandler(this.btnLicz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Metryka";
            // 
            // cbMetryki
            // 
            this.cbMetryki.BackColor = System.Drawing.SystemColors.Window;
            this.cbMetryki.FormattingEnabled = true;
            this.cbMetryki.Location = new System.Drawing.Point(88, 46);
            this.cbMetryki.Name = "cbMetryki";
            this.cbMetryki.Size = new System.Drawing.Size(121, 21);
            this.cbMetryki.TabIndex = 10;
            this.cbMetryki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZablokowanieComboboxa);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSciezkaTest);
            this.groupBox1.Controls.Add(this.tbSciezkaTrening);
            this.groupBox1.Controls.Add(this.btnWczytajTreningowe);
            this.groupBox1.Controls.Add(this.btnWczytajTestowe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 99);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wczytywanie danych";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDaneTreningowe);
            this.groupBox2.Location = new System.Drawing.Point(466, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 131);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane treningowe";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbDaneTestowe);
            this.groupBox3.Location = new System.Drawing.Point(578, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 131);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane testowe";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.numericSasiedzi);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cbMetryki);
            this.groupBox4.Controls.Add(this.btnLicz);
            this.groupBox4.Location = new System.Drawing.Point(466, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 108);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ustawienia";
            // 
            // tbWyniki
            // 
            this.tbWyniki.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbWyniki.Location = new System.Drawing.Point(6, 17);
            this.tbWyniki.Name = "tbWyniki";
            this.tbWyniki.ReadOnly = true;
            this.tbWyniki.Size = new System.Drawing.Size(436, 119);
            this.tbWyniki.TabIndex = 15;
            this.tbWyniki.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbWyniki);
            this.groupBox5.Location = new System.Drawing.Point(12, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(448, 142);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Raport z klasyfikacji";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 272);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Klasyfikator k − NN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSasiedzi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSciezkaTrening;
        private System.Windows.Forms.TextBox tbSciezkaTest;
        private System.Windows.Forms.Button btnWczytajTreningowe;
        private System.Windows.Forms.Button btnWczytajTestowe;
        private System.Windows.Forms.RichTextBox tbDaneTreningowe;
        private System.Windows.Forms.RichTextBox tbDaneTestowe;
        private System.Windows.Forms.OpenFileDialog ofdTrening;
        private System.Windows.Forms.OpenFileDialog ofdTest;
        private System.Windows.Forms.NumericUpDown numericSasiedzi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLicz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMetryki;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox tbWyniki;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

