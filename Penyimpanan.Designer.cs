namespace Resep
{
    partial class Penyimpanan
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnDashboard = new Button();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            txtSimpan = new TextBox();
            btnSimpan = new Button();
            txtStorageGuidelines = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 450);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(40, 336);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 15;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(40, 263);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 14;
            button1.Text = "Koleksi";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Orange;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.Location = new Point(40, 197);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(112, 34);
            btnDashboard.TabIndex = 13;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FoodPrep;
            pictureBox3.Location = new Point(40, 43);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 106);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 98);
            label2.Name = "label2";
            label2.Size = new Size(464, 25);
            label2.TabIndex = 10;
            label2.Text = "Cari resep makanan dengan memasukan bahan makanan\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 43);
            label1.Name = "label1";
            label1.Size = new Size(195, 38);
            label1.TabIndex = 9;
            label1.Text = "Penyimpanan";
            // 
            // txtSimpan
            // 
            txtSimpan.Location = new Point(250, 148);
            txtSimpan.Name = "txtSimpan";
            txtSimpan.Size = new Size(329, 31);
            txtSimpan.TabIndex = 12;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(619, 148);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 13;
            btnSimpan.Text = "Cari";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtStorageGuidelines
            // 
            txtStorageGuidelines.BorderStyle = BorderStyle.None;
            txtStorageGuidelines.Location = new Point(250, 225);
            txtStorageGuidelines.Multiline = true;
            txtStorageGuidelines.Name = "txtStorageGuidelines";
            txtStorageGuidelines.Size = new Size(300, 145);
            txtStorageGuidelines.TabIndex = 14;
            // 
            // Penyimpanan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStorageGuidelines);
            Controls.Add(btnSimpan);
            Controls.Add(txtSimpan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Penyimpanan";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private TextBox txtSimpan;
        private Button btnSimpan;
        private TextBox txtStorageGuidelines;
    }
}