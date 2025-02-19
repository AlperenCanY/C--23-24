namespace VucutKitleEndeksi
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
            label1 = new Label();
            label2 = new Label();
            txtBoy = new TextBox();
            label3 = new Label();
            txtKilo = new TextBox();
            label4 = new Label();
            lblVki = new Label();
            label5 = new Label();
            lblDurum = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 0;
            label1.Text = "* Boyu Örneği \"1,76\" Olarak Giriniz.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(185, 28);
            label2.TabIndex = 1;
            label2.Text = "Boyunuzu Giriniz :";
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(203, 53);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(125, 27);
            txtBoy.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 97);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 3;
            label3.Text = "Kilonuzu Giriniz :";
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(203, 97);
            txtKilo.Multiline = true;
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(125, 27);
            txtKilo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(41, 171);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 5;
            label4.Text = "VKİ :";
            label4.Click += label4_Click;
            // 
            // lblVki
            // 
            lblVki.AutoSize = true;
            lblVki.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVki.ForeColor = Color.DarkRed;
            lblVki.Location = new Point(102, 171);
            lblVki.Name = "lblVki";
            lblVki.Size = new Size(0, 28);
            lblVki.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(41, 219);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 7;
            label5.Text = "Durumu :";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(147, 227);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(0, 20);
            lblDurum.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(217, 139);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(363, 287);
            Controls.Add(button1);
            Controls.Add(lblDurum);
            Controls.Add(label5);
            Controls.Add(lblVki);
            Controls.Add(label4);
            Controls.Add(txtKilo);
            Controls.Add(label3);
            Controls.Add(txtBoy);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Vücut Kitle Endeksi";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoy;
        private Label label3;
        private TextBox txtKilo;
        private Label label4;
        private Label lblVki;
        private Label label5;
        private Label lblDurum;
        private Button button1;
    }
}