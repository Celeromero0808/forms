namespace forms
{
    partial class Formpromedio
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
            btnnota1 = new Label();
            btnnota2 = new Label();
            btnnota3 = new Label();
            textBoxn1 = new TextBox();
            textBoxn2 = new TextBox();
            textBoxn3 = new TextBox();
            lblresul = new Label();
            btncalcular = new Button();
            SuspendLayout();
            // 
            // btnnota1
            // 
            btnnota1.AutoSize = true;
            btnnota1.Location = new Point(72, 35);
            btnnota1.Name = "btnnota1";
            btnnota1.Size = new Size(45, 15);
            btnnota1.TabIndex = 0;
            btnnota1.Text = "Nota 1 ";
            // 
            // btnnota2
            // 
            btnnota2.AutoSize = true;
            btnnota2.Location = new Point(72, 92);
            btnnota2.Name = "btnnota2";
            btnnota2.Size = new Size(42, 15);
            btnnota2.TabIndex = 1;
            btnnota2.Text = "Nota 2";
            // 
            // btnnota3
            // 
            btnnota3.AutoSize = true;
            btnnota3.Location = new Point(72, 148);
            btnnota3.Name = "btnnota3";
            btnnota3.Size = new Size(42, 15);
            btnnota3.TabIndex = 2;
            btnnota3.Text = "Nota 3";
            // 
            // textBoxn1
            // 
            textBoxn1.Location = new Point(195, 32);
            textBoxn1.Name = "textBoxn1";
            textBoxn1.Size = new Size(100, 23);
            textBoxn1.TabIndex = 3;
            // 
            // textBoxn2
            // 
            textBoxn2.Location = new Point(195, 89);
            textBoxn2.Name = "textBoxn2";
            textBoxn2.Size = new Size(100, 23);
            textBoxn2.TabIndex = 4;
            // 
            // textBoxn3
            // 
            textBoxn3.Location = new Point(195, 148);
            textBoxn3.Name = "textBoxn3";
            textBoxn3.Size = new Size(100, 23);
            textBoxn3.TabIndex = 5;
            // 
            // lblresul
            // 
            lblresul.AutoSize = true;
            lblresul.Location = new Point(66, 216);
            lblresul.Name = "lblresul";
            lblresul.Size = new Size(100, 15);
            lblresul.TabIndex = 6;
            lblresul.Text = "EL PROMEDIO ES ";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(206, 256);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 7;
            btncalcular.Text = "CALCULAR";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // Formpromedio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(449, 293);
            Controls.Add(btncalcular);
            Controls.Add(lblresul);
            Controls.Add(textBoxn3);
            Controls.Add(textBoxn2);
            Controls.Add(textBoxn1);
            Controls.Add(btnnota3);
            Controls.Add(btnnota2);
            Controls.Add(btnnota1);
            Name = "Formpromedio";
            Text = "Formpromedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnnota1;
        private Label btnnota2;
        private Label btnnota3;
        private TextBox textBoxn1;
        private TextBox textBoxn2;
        private TextBox textBoxn3;
        private Label lblresul;
        private Button btncalcular;
    }
}