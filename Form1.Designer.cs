namespace BKIApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.Button btnHesabla;
        private System.Windows.Forms.Label lblBKI;
        private System.Windows.Forms.Label lblNetice;
        private System.Windows.Forms.PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblBoy = new Label();
            lblKilo = new Label();
            txtBoy = new TextBox();
            txtKilo = new TextBox();
            btnHesabla = new Button();
            lblBKI = new Label();
            lblNetice = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(122, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BMI CALCULATOR";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Font = new Font("Arial", 11F);
            lblBoy.Location = new Point(52, 103);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(80, 17);
            lblBoy.TabIndex = 1;
            lblBoy.Text = "Height (m):";
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Font = new Font("Arial", 11F);
            lblKilo.Location = new Point(52, 150);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(87, 17);
            lblKilo.TabIndex = 2;
            lblKilo.Text = "Weight (kg):";
            // 
            // txtBoy
            // 
            txtBoy.Font = new Font("Arial", 11F);
            txtBoy.Location = new Point(158, 98);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(176, 24);
            txtBoy.TabIndex = 0;
            // 
            // txtKilo
            // 
            txtKilo.Font = new Font("Arial", 11F);
            txtKilo.Location = new Point(158, 145);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(176, 24);
            txtKilo.TabIndex = 1;
            // 
            // btnHesabla
            // 
            btnHesabla.BackColor = Color.DarkBlue;
            btnHesabla.FlatStyle = FlatStyle.Flat;
            btnHesabla.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnHesabla.ForeColor = Color.White;
            btnHesabla.Location = new Point(158, 198);
            btnHesabla.Name = "btnHesabla";
            btnHesabla.Size = new Size(158, 42);
            btnHesabla.TabIndex = 2;
            btnHesabla.Text = "CALCULATE";
            btnHesabla.UseVisualStyleBackColor = false;
            btnHesabla.Click += btnHesabla_Click;
            // 
            // lblBKI
            // 
            lblBKI.AutoSize = true;
            lblBKI.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblBKI.ForeColor = Color.DarkBlue;
            lblBKI.Location = new Point(153, 277);
            lblBKI.Name = "lblBKI";
            lblBKI.Size = new Size(105, 26);
            lblBKI.TabIndex = 3;
            lblBKI.Text = "BMI: 0.00";
            // 
            // lblNetice
            // 
            lblNetice.AutoSize = true;
            lblNetice.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblNetice.ForeColor = Color.Green;
            lblNetice.Location = new Point(172, 479);
            lblNetice.Name = "lblNetice";
            lblNetice.Size = new Size(86, 29);
            lblNetice.TabIndex = 4;
            lblNetice.Text = "Result";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(158, 318);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(438, 562);
            Controls.Add(lblTitle);
            Controls.Add(lblBoy);
            Controls.Add(txtBoy);
            Controls.Add(lblKilo);
            Controls.Add(txtKilo);
            Controls.Add(btnHesabla);
            Controls.Add(lblBKI);
            Controls.Add(lblNetice);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
