namespace CalculadoraWindownsForm
{
    partial class Frm_conversor_celsius
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
            LBL_TempC = new Label();
            TB_TempC = new TextBox();
            TB_Fahrenheit = new TextBox();
            lBL_Convert = new Label();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            BTN_Exit = new Button();
            SuspendLayout();
            // 
            // LBL_TempC
            // 
            LBL_TempC.AutoSize = true;
            LBL_TempC.Font = new Font("Swis721 Blk BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_TempC.ForeColor = SystemColors.ControlLightLight;
            LBL_TempC.Location = new Point(35, 9);
            LBL_TempC.Name = "LBL_TempC";
            LBL_TempC.Size = new Size(322, 27);
            LBL_TempC.TabIndex = 0;
            LBL_TempC.Text = "Temperatura em celsius";
            // 
            // TB_TempC
            // 
            TB_TempC.Location = new Point(21, 39);
            TB_TempC.Name = "TB_TempC";
            TB_TempC.Size = new Size(358, 27);
            TB_TempC.TabIndex = 1;
            // 
            // TB_Fahrenheit
            // 
            TB_Fahrenheit.Location = new Point(35, 381);
            TB_Fahrenheit.Name = "TB_Fahrenheit";
            TB_Fahrenheit.Size = new Size(335, 27);
            TB_Fahrenheit.TabIndex = 3;
            // 
            // lBL_Convert
            // 
            lBL_Convert.AutoSize = true;
            lBL_Convert.Font = new Font("Swis721 Blk BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lBL_Convert.ForeColor = SystemColors.ControlLightLight;
            lBL_Convert.Location = new Point(58, 112);
            lBL_Convert.Name = "lBL_Convert";
            lBL_Convert.Size = new Size(289, 27);
            lBL_Convert.TabIndex = 4;
            lBL_Convert.Text = "Clique para converter";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(134, 153);
            button1.Name = "button1";
            button1.Size = new Size(120, 36);
            button1.TabIndex = 5;
            button1.Text = "Converter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(134, 247);
            button2.Name = "button2";
            button2.Size = new Size(120, 36);
            button2.TabIndex = 7;
            button2.Text = "CLS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(75, 202);
            label1.Name = "label1";
            label1.Size = new Size(258, 27);
            label1.TabIndex = 6;
            label1.Text = "Clique para Limpar";
            // 
            // BTN_Exit
            // 
            BTN_Exit.Font = new Font("Segoe UI", 12F);
            BTN_Exit.ForeColor = Color.Black;
            BTN_Exit.Location = new Point(295, 428);
            BTN_Exit.Name = "BTN_Exit";
            BTN_Exit.Size = new Size(84, 52);
            BTN_Exit.TabIndex = 8;
            BTN_Exit.Text = "Exit";
            BTN_Exit.UseVisualStyleBackColor = true;
            BTN_Exit.Click += BTN_Exit_Click;
            // 
            // Frm_conversor_celsius
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(391, 482);
            Controls.Add(BTN_Exit);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lBL_Convert);
            Controls.Add(TB_Fahrenheit);
            Controls.Add(TB_TempC);
            Controls.Add(LBL_TempC);
            ForeColor = Color.Aquamarine;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_conversor_celsius";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_conversor_celsius";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_TempC;
        private TextBox TB_TempC;
        private TextBox TB_Fahrenheit;
        private Label lBL_Convert;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button BTN_Exit;
    }
}