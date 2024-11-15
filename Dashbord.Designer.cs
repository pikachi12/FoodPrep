namespace Resep
{
    partial class Dashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbord));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnDashboard = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnResep = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnPenyimpanan = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            button2.Location = new Point(39, 331);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(39, 258);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
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
            btnDashboard.Location = new Point(39, 192);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(112, 34);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FoodPrep;
            pictureBox3.Location = new Point(39, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 106);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 38);
            label1.Name = "label1";
            label1.Size = new Size(304, 38);
            label1.TabIndex = 3;
            label1.Text = "Halo, Selamat Datang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 97);
            label2.Name = "label2";
            label2.Size = new Size(493, 25);
            label2.TabIndex = 4;
            label2.Text = "Simpan bahan makanan dengan benar dan masak lebih lezat";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LemonChiffon;
            panel3.Controls.Add(btnResep);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(528, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(196, 200);
            panel3.TabIndex = 7;
            // 
            // btnResep
            // 
            btnResep.Location = new Point(34, 151);
            btnResep.Name = "btnResep";
            btnResep.Size = new Size(126, 34);
            btnResep.TabIndex = 1;
            btnResep.Text = "Resep";
            btnResep.UseVisualStyleBackColor = true;
            btnResep.Click += btnResep_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(34, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LemonChiffon;
            panel2.Controls.Add(btnPenyimpanan);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(259, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(196, 200);
            panel2.TabIndex = 6;
            // 
            // btnPenyimpanan
            // 
            btnPenyimpanan.Location = new Point(34, 151);
            btnPenyimpanan.Name = "btnPenyimpanan";
            btnPenyimpanan.Size = new Size(126, 34);
            btnPenyimpanan.TabIndex = 1;
            btnPenyimpanan.Text = "Penyimpanan";
            btnPenyimpanan.UseVisualStyleBackColor = true;
            btnPenyimpanan.Click += btnPenyimpanan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Dashbord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Dashbord";
            Text = "Form1";
            Load += Dashbord_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Button btnResep;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btnPenyimpanan;
        private PictureBox pictureBox1;
    }
}
