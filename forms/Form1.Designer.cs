namespace forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblus = new Label();
            lbl2 = new Label();
            txtboxus = new TextBox();
            txtboxcon = new TextBox();
            btnok = new Button();
            btncerrar = new Button();
            SuspendLayout();
            // 
            // lblus
            // 
            lblus.AutoSize = true;
            lblus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblus.Location = new Point(131, 82);
            lblus.Name = "lblus";
            lblus.Size = new Size(64, 17);
            lblus.TabIndex = 0;
            lblus.Text = "USUARIO";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(131, 170);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(94, 17);
            lbl2.TabIndex = 1;
            lbl2.Text = "CONTRASEÑA";
            // 
            // txtboxus
            // 
            txtboxus.Location = new Point(231, 76);
            txtboxus.Name = "txtboxus";
            txtboxus.Size = new Size(238, 23);
            txtboxus.TabIndex = 2;
            txtboxus.TextChanged += txtboxus_TextChanged;
            // 
            // txtboxcon
            // 
            txtboxcon.Location = new Point(231, 169);
            txtboxcon.Name = "txtboxcon";
            txtboxcon.Size = new Size(238, 23);
            txtboxcon.TabIndex = 3;
            // 
            // btnok
            // 
            btnok.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnok.Location = new Point(201, 257);
            btnok.Name = "btnok";
            btnok.Size = new Size(75, 23);
            btnok.TabIndex = 4;
            btnok.Text = "OK";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // btncerrar
            // 
            btncerrar.Location = new Point(422, 257);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(75, 23);
            btncerrar.TabIndex = 5;
            btncerrar.Text = "CERRAR";
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncerrar);
            Controls.Add(btnok);
            Controls.Add(txtboxcon);
            Controls.Add(txtboxus);
            Controls.Add(lbl2);
            Controls.Add(lblus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblus;
        private Label lbl2;
        private TextBox txtboxus;
        private TextBox txtboxcon;
        private Button btnok;
        private Button btncerrar;
    }
}
