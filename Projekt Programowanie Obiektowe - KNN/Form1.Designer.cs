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
            this.SuspendLayout();
            // 
            // tbSciezkaTrening
            // 
            this.tbSciezkaTrening.Location = new System.Drawing.Point(23, 13);
            this.tbSciezkaTrening.Name = "tbSciezkaTrening";
            this.tbSciezkaTrening.Size = new System.Drawing.Size(206, 20);
            this.tbSciezkaTrening.TabIndex = 0;
            // 
            // tbSciezkaTest
            // 
            this.tbSciezkaTest.Location = new System.Drawing.Point(23, 61);
            this.tbSciezkaTest.Name = "tbSciezkaTest";
            this.tbSciezkaTest.Size = new System.Drawing.Size(206, 20);
            this.tbSciezkaTest.TabIndex = 1;
            // 
            // btnWczytajTreningowe
            // 
            this.btnWczytajTreningowe.Location = new System.Drawing.Point(235, 1);
            this.btnWczytajTreningowe.Name = "btnWczytajTreningowe";
            this.btnWczytajTreningowe.Size = new System.Drawing.Size(115, 42);
            this.btnWczytajTreningowe.TabIndex = 2;
            this.btnWczytajTreningowe.Text = "Wczytaj Dane Treningowe";
            this.btnWczytajTreningowe.UseVisualStyleBackColor = true;
            this.btnWczytajTreningowe.Click += new System.EventHandler(this.btnWczytajTreningowe_Click);
            // 
            // btnWczytajTestowe
            // 
            this.btnWczytajTestowe.Location = new System.Drawing.Point(235, 49);
            this.btnWczytajTestowe.Name = "btnWczytajTestowe";
            this.btnWczytajTestowe.Size = new System.Drawing.Size(115, 42);
            this.btnWczytajTestowe.TabIndex = 3;
            this.btnWczytajTestowe.Text = "Wczytaj Dane Testowe";
            this.btnWczytajTestowe.UseVisualStyleBackColor = true;
            this.btnWczytajTestowe.Click += new System.EventHandler(this.btnWczytajTestowe_Click);
            // 
            // tbDaneTreningowe
            // 
            this.tbDaneTreningowe.Location = new System.Drawing.Point(23, 112);
            this.tbDaneTreningowe.Name = "tbDaneTreningowe";
            this.tbDaneTreningowe.Size = new System.Drawing.Size(100, 124);
            this.tbDaneTreningowe.TabIndex = 4;
            this.tbDaneTreningowe.Text = "";
            // 
            // tbDaneTestowe
            // 
            this.tbDaneTestowe.Location = new System.Drawing.Point(129, 112);
            this.tbDaneTestowe.Name = "tbDaneTestowe";
            this.tbDaneTestowe.Size = new System.Drawing.Size(100, 124);
            this.tbDaneTestowe.TabIndex = 5;
            this.tbDaneTestowe.Text = "";
            // 
            // ofdTest
            // 
            this.ofdTest.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 340);
            this.Controls.Add(this.tbDaneTestowe);
            this.Controls.Add(this.tbDaneTreningowe);
            this.Controls.Add(this.btnWczytajTestowe);
            this.Controls.Add(this.btnWczytajTreningowe);
            this.Controls.Add(this.tbSciezkaTest);
            this.Controls.Add(this.tbSciezkaTrening);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

