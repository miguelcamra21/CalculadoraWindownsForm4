﻿namespace CalculadoraWindownsForm
{
    partial class Frm_Calculadora
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
            BtnMais = new Button();
            BtnMenos = new Button();
            BtnMulti = new Button();
            btnDiv = new Button();
            BtnClear = new Button();
            Btn3 = new Button();
            Btn2 = new Button();
            Btn1 = new Button();
            Btn6 = new Button();
            Btn5 = new Button();
            Btn4 = new Button();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn7 = new Button();
            BtnIgual = new Button();
            Btn0 = new Button();
            Visor = new TextBox();
            BtnExit = new Button();
            SuspendLayout();
            // 
            // BtnMais
            // 
            BtnMais.BackColor = Color.FromArgb(224, 224, 224);
            BtnMais.Font = new Font("Segoe UI", 14F);
            BtnMais.Location = new Point(8, 68);
            BtnMais.Margin = new Padding(2);
            BtnMais.Name = "BtnMais";
            BtnMais.Size = new Size(66, 43);
            BtnMais.TabIndex = 1;
            BtnMais.Text = "+";
            BtnMais.UseVisualStyleBackColor = false;
            BtnMais.Click += BtnMais_Click;
            // 
            // BtnMenos
            // 
            BtnMenos.BackColor = Color.FromArgb(224, 224, 224);
            BtnMenos.Font = new Font("Segoe UI", 14F);
            BtnMenos.Location = new Point(78, 68);
            BtnMenos.Margin = new Padding(2);
            BtnMenos.Name = "BtnMenos";
            BtnMenos.Size = new Size(66, 43);
            BtnMenos.TabIndex = 2;
            BtnMenos.Text = "-";
            BtnMenos.UseVisualStyleBackColor = false;
            BtnMenos.Click += BtnMenos_Click;
            // 
            // BtnMulti
            // 
            BtnMulti.BackColor = Color.FromArgb(224, 224, 224);
            BtnMulti.Font = new Font("Segoe UI", 14F);
            BtnMulti.Location = new Point(149, 68);
            BtnMulti.Margin = new Padding(2);
            BtnMulti.Name = "BtnMulti";
            BtnMulti.Size = new Size(66, 43);
            BtnMulti.TabIndex = 3;
            BtnMulti.Text = "*";
            BtnMulti.UseVisualStyleBackColor = false;
            BtnMulti.Click += BtnMulti_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(224, 224, 224);
            btnDiv.Font = new Font("Segoe UI", 14F);
            btnDiv.Location = new Point(220, 68);
            btnDiv.Margin = new Padding(2);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(66, 43);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "/\r\n";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.FromArgb(224, 224, 224);
            BtnClear.Font = new Font("Segoe UI", 12F);
            BtnClear.Location = new Point(220, 115);
            BtnClear.Margin = new Padding(2);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(66, 43);
            BtnClear.TabIndex = 8;
            BtnClear.Text = "cls";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.FromArgb(224, 224, 224);
            Btn3.Font = new Font("Segoe UI", 12F);
            Btn3.Location = new Point(149, 115);
            Btn3.Margin = new Padding(2);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(66, 43);
            Btn3.TabIndex = 7;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += Btn3_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.FromArgb(224, 224, 224);
            Btn2.Font = new Font("Segoe UI", 12F);
            Btn2.Location = new Point(78, 115);
            Btn2.Margin = new Padding(2);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(66, 43);
            Btn2.TabIndex = 6;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += Btn2_Click;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.FromArgb(224, 224, 224);
            Btn1.Font = new Font("Segoe UI", 12F);
            Btn1.Location = new Point(8, 115);
            Btn1.Margin = new Padding(2);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(66, 43);
            Btn1.TabIndex = 5;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += Btn1_Click;
            // 
            // Btn6
            // 
            Btn6.BackColor = Color.FromArgb(224, 224, 224);
            Btn6.Font = new Font("Segoe UI", 12F);
            Btn6.Location = new Point(149, 161);
            Btn6.Margin = new Padding(2);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(66, 43);
            Btn6.TabIndex = 11;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += Btn6_Click;
            // 
            // Btn5
            // 
            Btn5.BackColor = Color.FromArgb(224, 224, 224);
            Btn5.Font = new Font("Segoe UI", 12F);
            Btn5.Location = new Point(78, 161);
            Btn5.Margin = new Padding(2);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(66, 43);
            Btn5.TabIndex = 10;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += Btn5_Click;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.FromArgb(224, 224, 224);
            Btn4.Font = new Font("Segoe UI", 12F);
            Btn4.Location = new Point(8, 161);
            Btn4.Margin = new Padding(2);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(66, 43);
            Btn4.TabIndex = 9;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += Btn4_Click;
            // 
            // Btn9
            // 
            Btn9.BackColor = Color.FromArgb(224, 224, 224);
            Btn9.Font = new Font("Segoe UI", 12F);
            Btn9.Location = new Point(149, 207);
            Btn9.Margin = new Padding(2);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(66, 43);
            Btn9.TabIndex = 14;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += Btn9_Click;
            // 
            // Btn8
            // 
            Btn8.BackColor = Color.FromArgb(224, 224, 224);
            Btn8.Font = new Font("Segoe UI", 12F);
            Btn8.Location = new Point(78, 207);
            Btn8.Margin = new Padding(2);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(66, 43);
            Btn8.TabIndex = 13;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += Btn8_Click;
            // 
            // Btn7
            // 
            Btn7.BackColor = Color.FromArgb(224, 224, 224);
            Btn7.Font = new Font("Segoe UI", 12F);
            Btn7.Location = new Point(8, 207);
            Btn7.Margin = new Padding(2);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(66, 43);
            Btn7.TabIndex = 12;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += Btn7_Click;
            // 
            // BtnIgual
            // 
            BtnIgual.BackColor = Color.FromArgb(224, 224, 224);
            BtnIgual.Font = new Font("Segoe UI", 12F);
            BtnIgual.Location = new Point(220, 161);
            BtnIgual.Margin = new Padding(2);
            BtnIgual.Name = "BtnIgual";
            BtnIgual.Size = new Size(66, 89);
            BtnIgual.TabIndex = 15;
            BtnIgual.Text = "=";
            BtnIgual.UseVisualStyleBackColor = false;
            BtnIgual.Click += BtnIgual_Click;
            // 
            // Btn0
            // 
            Btn0.BackColor = Color.FromArgb(224, 224, 224);
            Btn0.Font = new Font("Segoe UI", 12F);
            Btn0.Location = new Point(8, 253);
            Btn0.Margin = new Padding(2);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(208, 35);
            Btn0.TabIndex = 16;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = false;
            Btn0.Click += Btn0_Click;
            // 
            // Visor
            // 
            Visor.Font = new Font("Segoe UI", 16F);
            Visor.Location = new Point(8, 14);
            Visor.Margin = new Padding(2);
            Visor.Name = "Visor";
            Visor.Size = new Size(281, 36);
            Visor.TabIndex = 17;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(219, 253);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(67, 35);
            BtnExit.TabIndex = 18;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // Frm_Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(295, 301);
            Controls.Add(BtnExit);
            Controls.Add(Visor);
            Controls.Add(Btn0);
            Controls.Add(BtnIgual);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(BtnClear);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(btnDiv);
            Controls.Add(BtnMulti);
            Controls.Add(BtnMenos);
            Controls.Add(BtnMais);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Frm_Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnMais;
        private Button BtnMenos;
        private Button BtnMulti;
        private Button btnDiv;
        private Button BtnClear;
        private Button Btn3;
        private Button Btn2;
        private Button Btn1;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button Btn9;
        private Button Btn8;
        private Button Btn7;
        private Button BtnIgual;
        private Button Btn0;
        private TextBox Visor;
        private Button BtnExit;
    }
}