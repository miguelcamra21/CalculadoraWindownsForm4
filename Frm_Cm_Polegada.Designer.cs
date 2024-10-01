namespace CalculadoraWindownsForm
{
    partial class Frm_Cm_Polegada
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
            LBL_cm = new Label();
            textbox_cm = new TextBox();
            btn_convert = new Button();
            btn_cls = new Button();
            textbox_polegada = new TextBox();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // LBL_cm
            // 
            LBL_cm.AutoSize = true;
            LBL_cm.Font = new Font("Swis721 Blk BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_cm.ForeColor = SystemColors.Control;
            LBL_cm.Location = new Point(84, 9);
            LBL_cm.Name = "LBL_cm";
            LBL_cm.Size = new Size(238, 27);
            LBL_cm.TabIndex = 0;
            LBL_cm.Text = "Valor em CM aqui";
            // 
            // textbox_cm
            // 
            textbox_cm.Location = new Point(26, 53);
            textbox_cm.Name = "textbox_cm";
            textbox_cm.Size = new Size(344, 27);
            textbox_cm.TabIndex = 1;
            // 
            // btn_convert
            // 
            btn_convert.Font = new Font("Segoe UI", 12F);
            btn_convert.Location = new Point(131, 108);
            btn_convert.Name = "btn_convert";
            btn_convert.Size = new Size(127, 39);
            btn_convert.TabIndex = 2;
            btn_convert.Text = "Converter";
            btn_convert.UseVisualStyleBackColor = true;
            btn_convert.Click += btn_convert_Click;
            // 
            // btn_cls
            // 
            btn_cls.Font = new Font("Segoe UI", 12F);
            btn_cls.Location = new Point(131, 167);
            btn_cls.Name = "btn_cls";
            btn_cls.Size = new Size(127, 39);
            btn_cls.TabIndex = 3;
            btn_cls.Text = "CLS";
            btn_cls.UseVisualStyleBackColor = true;
            btn_cls.Click += btn_cls_Click;
            // 
            // textbox_polegada
            // 
            textbox_polegada.Location = new Point(26, 299);
            textbox_polegada.Name = "textbox_polegada";
            textbox_polegada.Size = new Size(344, 27);
            textbox_polegada.TabIndex = 4;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 12F);
            btn_exit.Location = new Point(275, 414);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(109, 39);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Frm_Cm_Polegada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(396, 465);
            Controls.Add(btn_exit);
            Controls.Add(textbox_polegada);
            Controls.Add(btn_cls);
            Controls.Add(btn_convert);
            Controls.Add(textbox_cm);
            Controls.Add(LBL_cm);
            Name = "Frm_Cm_Polegada";
            Text = "Frm_Cm_Polegada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_cm;
        private TextBox textbox_cm;
        private Button btn_convert;
        private Button btn_cls;
        private TextBox textbox_polegada;
        private Button btn_exit;
    }
}