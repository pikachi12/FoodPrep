namespace Resep
{
    partial class ResepCari
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
            label1 = new Label();
            txtBahan = new TextBox();
            btnCari = new Button();
            listBoxResep = new ListBox();
            label2 = new Label();
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
            button2.Location = new Point(41, 337);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(41, 264);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
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
            btnDashboard.Location = new Point(41, 198);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(112, 34);
            btnDashboard.TabIndex = 9;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FoodPrep;
            pictureBox3.Location = new Point(41, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 106);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 44);
            label1.Name = "label1";
            label1.Size = new Size(93, 38);
            label1.TabIndex = 4;
            label1.Text = "Resep";
            // 
            // txtBahan
            // 
            txtBahan.Location = new Point(241, 146);
            txtBahan.Name = "txtBahan";
            txtBahan.Size = new Size(342, 31);
            txtBahan.TabIndex = 5;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(629, 143);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(112, 34);
            btnCari.TabIndex = 6;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // listBoxResep
            // 
            listBoxResep.FormattingEnabled = true;
            listBoxResep.ItemHeight = 25;
            listBoxResep.Location = new Point(241, 218);
            listBoxResep.Name = "listBoxResep";
            listBoxResep.Size = new Size(509, 204);
            listBoxResep.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 99);
            label2.Name = "label2";
            label2.Size = new Size(464, 25);
            label2.TabIndex = 8;
            label2.Text = "Cari resep makanan dengan memasukan bahan makanan\r\n";
            // 
            // ResepCari
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(listBoxResep);
            Controls.Add(btnCari);
            Controls.Add(txtBahan);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ResepCari";
            Text = "Resep";
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
        private Label label1;
        private TextBox txtBahan;
        private Button btnCari;
        private ListBox listBoxResep;
        private Label label2;
    }
}