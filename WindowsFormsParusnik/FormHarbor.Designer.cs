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
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelTake = new System.Windows.Forms.Label();
            this.buttonNewHarbor = new System.Windows.Forms.Button();
            this.buttonCleanHarbor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMVeh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMVeh
            // 
            this.pictureBoxMVeh.Location = new System.Drawing.Point(4, 2);
            this.pictureBoxMVeh.Name = "pictureBoxMVeh";
            this.pictureBoxMVeh.Size = new System.Drawing.Size(539, 383);
            this.pictureBoxMVeh.TabIndex = 0;
            this.pictureBoxMVeh.TabStop = false;
            // 
            // buttonSetLodka
            // 
            this.buttonSetLodka.Location = new System.Drawing.Point(549, 2);
            this.buttonSetLodka.Name = "buttonSetLodka";
            this.buttonSetLodka.Size = new System.Drawing.Size(106, 40);
            this.buttonSetLodka.TabIndex = 1;
            this.buttonSetLodka.Text = "Пришвартовать\r\nлодку";
            this.buttonSetLodka.UseVisualStyleBackColor = true;
            this.buttonSetLodka.Click += new System.EventHandler(this.buttonSetLodka_Click);
            // 
            // buttonSetParusnik
            // 
            this.buttonSetParusnik.Location = new System.Drawing.Point(551, 42);
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
            this.groupBox1.Controls.Add(this.labelPlace);
            this.groupBox1.Controls.Add(this.maskedTextBoxPlace);
            this.groupBox1.Controls.Add(this.labelTake);
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
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(17, 43);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 2;
            this.labelPlace.Text = "Место:";
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(62, 40);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelTake
            // 
            this.labelTake.AutoSize = true;
            this.labelTake.Location = new System.Drawing.Point(17, 11);
            this.labelTake.Name = "labelTake";
            this.labelTake.Size = new System.Drawing.Size(70, 26);
            this.labelTake.TabIndex = 0;
            this.labelTake.Text = "Забрать\r\nморское т/c";
            this.labelTake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNewHarbor
            // 
            this.buttonNewHarbor.Location = new System.Drawing.Point(551, 108);
            this.buttonNewHarbor.Name = "buttonNewHarbor";
            this.buttonNewHarbor.Size = new System.Drawing.Size(104, 22);
            this.buttonNewHarbor.TabIndex = 4;
            this.buttonNewHarbor.Text = "Перепарковать";
            this.buttonNewHarbor.UseVisualStyleBackColor = true;
            this.buttonNewHarbor.Click += new System.EventHandler(this.buttonNewHarbor_Click);
            // 
            // buttonCleanHarbor
            // 
            this.buttonCleanHarbor.Location = new System.Drawing.Point(551, 85);
            this.buttonCleanHarbor.Name = "buttonCleanHarbor";
            this.buttonCleanHarbor.Size = new System.Drawing.Size(104, 22);
            this.buttonCleanHarbor.TabIndex = 5;
            this.buttonCleanHarbor.Text = "Очистить гавань";
            this.buttonCleanHarbor.UseVisualStyleBackColor = true;
            this.buttonCleanHarbor.Click += new System.EventHandler(this.buttonCleanHarbor_Click);
            // 
            // FormHarbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetParusnik);
            this.Controls.Add(this.buttonSetLodka);
            this.Controls.Add(this.buttonCleanHarbor);
            this.Controls.Add(this.buttonNewHarbor);
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
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelTake;
        private System.Windows.Forms.Button buttonNewHarbor;
        private System.Windows.Forms.Button buttonCleanHarbor;
    }
}