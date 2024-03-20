namespace forms
{
    partial class Form2
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
            lblV = new Label();
            lblT = new Label();
            txtboxV = new TextBox();
            txtboxT = new TextBox();
            lblresul = new Label();
            label1 = new Label();
            btncalcular = new Button();
            SuspendLayout();
            // 
            // lblV
            // 
            lblV.AutoSize = true;
            lblV.BackColor = SystemColors.ActiveCaption;
            lblV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblV.Location = new Point(40, 59);
            lblV.Name = "lblV";
            lblV.RightToLeft = RightToLeft.No;
            lblV.Size = new Size(170, 21);
            lblV.TabIndex = 0;
            lblV.Text = "INGRESE VELOCIDAD";
            // 
            // lblT
            // 
            lblT.AutoSize = true;
            lblT.BackColor = SystemColors.ActiveCaption;
            lblT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblT.Location = new Point(40, 157);
            lblT.Name = "lblT";
            lblT.Size = new Size(140, 21);
            lblT.TabIndex = 1;
            lblT.Text = "INGRESE TIEMPO";
            // 
            // txtboxV
            // 
            txtboxV.Location = new Point(265, 57);
            txtboxV.Name = "txtboxV";
            txtboxV.Size = new Size(129, 23);
            txtboxV.TabIndex = 2;
           
            // 
            // txtboxT
            // 
            txtboxT.Location = new Point(265, 158);
            txtboxT.Name = "txtboxT";
            txtboxT.Size = new Size(133, 23);
            txtboxT.TabIndex = 3;
            // 
            // lblresul
            // 
            lblresul.AutoSize = true;
            lblresul.Location = new Point(62, 233);
            lblresul.Name = "lblresul";
            lblresul.Size = new Size(88, 15);
            lblresul.TabIndex = 4;
            lblresul.Text = "El resultado es :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(375, 229);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "TOTAL";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(220, 272);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 6;
            btncalcular.Text = "CALCULAR";
            btncalcular.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(545, 307);
            Controls.Add(btncalcular);
            Controls.Add(label1);
            Controls.Add(lblresul);
            Controls.Add(txtboxT);
            Controls.Add(txtboxV);
            Controls.Add(lblT);
            Controls.Add(lblV);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblV;
        private Label lblT;
        private TextBox txtboxV;
        private TextBox txtboxT;
        private Label lblresul;
        private Label label1;
        private Button btncalcular;
    }
}