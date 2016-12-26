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
            this.nrcSasiedzi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLicz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMetryki = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nrcSasiedzi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSciezkaTrening
            // 
            this.tbSciezkaTrening.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSciezkaTrening.Location = new System.Drawing.Point(23, 13);
            this.tbSciezkaTrening.Name = "tbSciezkaTrening";
            this.tbSciezkaTrening.ReadOnly = true;
            this.tbSciezkaTrening.Size = new System.Drawing.Size(229, 20);
            this.tbSciezkaTrening.TabIndex = 0;
            // 
            // tbSciezkaTest
            // 
            this.tbSciezkaTest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSciezkaTest.Location = new System.Drawing.Point(23, 61);
            this.tbSciezkaTest.Name = "tbSciezkaTest";
            this.tbSciezkaTest.ReadOnly = true;
            this.tbSciezkaTest.Size = new System.Drawing.Size(229, 20);
            this.tbSciezkaTest.TabIndex = 1;
            // 
            // btnWczytajTreningowe
            // 
            this.btnWczytajTreningowe.Location = new System.Drawing.Point(258, 1);
            this.btnWczytajTreningowe.Name = "btnWczytajTreningowe";
            this.btnWczytajTreningowe.Size = new System.Drawing.Size(115, 42);
            this.btnWczytajTreningowe.TabIndex = 2;
            this.btnWczytajTreningowe.Text = "Wczytaj Dane Treningowe";
            this.btnWczytajTreningowe.UseVisualStyleBackColor = true;
            this.btnWczytajTreningowe.Click += new System.EventHandler(this.btnWczytajTreningowe_Click);
            // 
            // btnWczytajTestowe
            // 
            this.btnWczytajTestowe.Location = new System.Drawing.Point(258, 49);
            this.btnWczytajTestowe.Name = "btnWczytajTestowe";
            this.btnWczytajTestowe.Size = new System.Drawing.Size(115, 42);
            this.btnWczytajTestowe.TabIndex = 3;
            this.btnWczytajTestowe.Text = "Wczytaj Dane Testowe";
            this.btnWczytajTestowe.UseVisualStyleBackColor = true;
            this.btnWczytajTestowe.Click += new System.EventHandler(this.btnWczytajTestowe_Click);
            // 
            // tbDaneTreningowe
            // 
            this.tbDaneTreningowe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDaneTreningowe.Location = new System.Drawing.Point(23, 112);
            this.tbDaneTreningowe.Name = "tbDaneTreningowe";
            this.tbDaneTreningowe.ReadOnly = true;
            this.tbDaneTreningowe.Size = new System.Drawing.Size(100, 124);
            this.tbDaneTreningowe.TabIndex = 4;
            this.tbDaneTreningowe.Text = "";
            // 
            // tbDaneTestowe
            // 
            this.tbDaneTestowe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDaneTestowe.Location = new System.Drawing.Point(129, 112);
            this.tbDaneTestowe.Name = "tbDaneTestowe";
            this.tbDaneTestowe.ReadOnly = true;
            this.tbDaneTestowe.Size = new System.Drawing.Size(100, 124);
            this.tbDaneTestowe.TabIndex = 5;
            this.tbDaneTestowe.Text = "";
            // 
            // ofdTest
            // 
            this.ofdTest.FileName = "openFileDialog2";
            // 
            // nrcSasiedzi
            // 
            this.nrcSasiedzi.Location = new System.Drawing.Point(317, 110);
            this.nrcSasiedzi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrcSasiedzi.Name = "nrcSasiedzi";
            this.nrcSasiedzi.Size = new System.Drawing.Size(56, 20);
            this.nrcSasiedzi.TabIndex = 6;
            this.nrcSasiedzi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ilość sąsiadów";
            // 
            // btnLicz
            // 
            this.btnLicz.Location = new System.Drawing.Point(238, 213);
            this.btnLicz.Name = "btnLicz";
            this.btnLicz.Size = new System.Drawing.Size(75, 23);
            this.btnLicz.TabIndex = 8;
            this.btnLicz.Text = "Licz";
            this.btnLicz.UseVisualStyleBackColor = true;
            this.btnLicz.Click += new System.EventHandler(this.btnLicz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Metryka";
            // 
            // cbMetryki
            // 
            this.cbMetryki.FormattingEnabled = true;
            this.cbMetryki.Location = new System.Drawing.Point(286, 151);
            this.cbMetryki.Name = "cbMetryki";
            this.cbMetryki.Size = new System.Drawing.Size(87, 21);
            this.cbMetryki.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 340);
            this.Controls.Add(this.cbMetryki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLicz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nrcSasiedzi);
            this.Controls.Add(this.tbDaneTestowe);
            this.Controls.Add(this.tbDaneTreningowe);
            this.Controls.Add(this.btnWczytajTestowe);
            this.Controls.Add(this.btnWczytajTreningowe);
            this.Controls.Add(this.tbSciezkaTest);
            this.Controls.Add(this.tbSciezkaTrening);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrcSasiedzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.NumericUpDown nrcSasiedzi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLicz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMetryki;
    }
}

