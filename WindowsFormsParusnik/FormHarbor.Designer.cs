﻿namespace WindowsFormsParusnik
{
    partial class FormHarbor
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
            this.pictureBoxMVeh = new System.Windows.Forms.PictureBox();
            this.buttonSetLodka = new System.Windows.Forms.Button();
            this.buttonSetParusnik = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMVeh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMVeh
            // 
            this.pictureBoxMVeh.Location = new System.Drawing.Point(4, 2);
            this.pictureBoxMVeh.Name = "pictureBoxMVeh";
            this.pictureBoxMVeh.Size = new System.Drawing.Size(539, 301);
            this.pictureBoxMVeh.TabIndex = 0;
            this.pictureBoxMVeh.TabStop = false;
            // 
            // buttonSetLodka
            // 
            this.buttonSetLodka.Location = new System.Drawing.Point(547, 12);
            this.buttonSetLodka.Name = "buttonSetLodka";
            this.buttonSetLodka.Size = new System.Drawing.Size(106, 40);
            this.buttonSetLodka.TabIndex = 1;
            this.buttonSetLodka.Text = "Пришвартовать\r\nлодку";
            this.buttonSetLodka.UseVisualStyleBackColor = true;
            this.buttonSetLodka.Click += new System.EventHandler(this.buttonSetLodka_Click);
            // 
            // buttonSetParusnik
            // 
            this.buttonSetParusnik.Location = new System.Drawing.Point(549, 59);
            this.buttonSetParusnik.Name = "buttonSetParusnik";
            this.buttonSetParusnik.Size = new System.Drawing.Size(104, 42);
            this.buttonSetParusnik.TabIndex = 2;
            this.buttonSetParusnik.Text = "Пришвартовать\r\nпарусник";
            this.buttonSetParusnik.UseVisualStyleBackColor = true;
            this.buttonSetParusnik.Click += new System.EventHandler(this.buttonSetParusnik_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTake);
            this.groupBox1.Controls.Add(this.buttonTake);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(549, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(0, 88);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(104, 83);
            this.pictureBoxTake.TabIndex = 4;
            this.pictureBoxTake.TabStop = false;
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(25, 62);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(59, 21);
            this.buttonTake.TabIndex = 3;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Место:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(62, 40);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Забрать\r\nморское т/c";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHarbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetParusnik);
            this.Controls.Add(this.buttonSetLodka);
            this.Controls.Add(this.pictureBoxMVeh);
            this.Name = "FormHarbor";
            this.Text = "Гавань";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMVeh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMVeh;
        private System.Windows.Forms.Button buttonSetLodka;
        private System.Windows.Forms.Button buttonSetParusnik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
    }
}