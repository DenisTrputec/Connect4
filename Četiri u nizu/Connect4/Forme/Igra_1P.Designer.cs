using System.Windows.Forms;

namespace Connect4
{
    partial class Igra_1P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Igra_1P));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button0 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.label_BrojPoteza = new System.Windows.Forms.Label();
            this.label_NaPotezu = new System.Windows.Forms.Label();
            this.label_Rezultat = new System.Windows.Forms.Label();
            this.Button_Zvuk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Button0
            // 
            this.Button0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button0.BackColor = System.Drawing.SystemColors.Control;
            this.Button0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button0.BackgroundImage")));
            this.Button0.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button0.ForeColor = System.Drawing.Color.Transparent;
            this.Button0.Location = new System.Drawing.Point(55, 44);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(50, 50);
            this.Button0.TabIndex = 1;
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button1.BackColor = System.Drawing.SystemColors.Control;
            this.Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button1.BackgroundImage")));
            this.Button1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button1.Location = new System.Drawing.Point(155, 44);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(50, 50);
            this.Button1.TabIndex = 2;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button2.BackColor = System.Drawing.SystemColors.Control;
            this.Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2.BackgroundImage")));
            this.Button2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button2.Location = new System.Drawing.Point(255, 44);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(50, 50);
            this.Button2.TabIndex = 3;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button3.BackColor = System.Drawing.SystemColors.Control;
            this.Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button3.BackgroundImage")));
            this.Button3.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button3.Location = new System.Drawing.Point(355, 44);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(50, 50);
            this.Button3.TabIndex = 4;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button4.BackColor = System.Drawing.SystemColors.Control;
            this.Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button4.BackgroundImage")));
            this.Button4.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button4.Location = new System.Drawing.Point(455, 44);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(50, 50);
            this.Button4.TabIndex = 5;
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button5.BackColor = System.Drawing.SystemColors.Control;
            this.Button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button5.BackgroundImage")));
            this.Button5.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button5.Location = new System.Drawing.Point(555, 44);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(50, 50);
            this.Button5.TabIndex = 6;
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button6.BackColor = System.Drawing.SystemColors.Control;
            this.Button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button6.BackgroundImage")));
            this.Button6.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button6.Location = new System.Drawing.Point(655, 44);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(50, 50);
            this.Button6.TabIndex = 7;
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label_BrojPoteza
            // 
            this.label_BrojPoteza.AutoSize = true;
            this.label_BrojPoteza.Location = new System.Drawing.Point(90, 14);
            this.label_BrojPoteza.Name = "label_BrojPoteza";
            this.label_BrojPoteza.Size = new System.Drawing.Size(37, 13);
            this.label_BrojPoteza.TabIndex = 8;
            this.label_BrojPoteza.Text = "Potez:";
            // 
            // label_NaPotezu
            // 
            this.label_NaPotezu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NaPotezu.AutoSize = true;
            this.label_NaPotezu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NaPotezu.Location = new System.Drawing.Point(500, 5);
            this.label_NaPotezu.Name = "label_NaPotezu";
            this.label_NaPotezu.Size = new System.Drawing.Size(105, 22);
            this.label_NaPotezu.TabIndex = 10;
            this.label_NaPotezu.Text = "Na potezu: ";
            // 
            // label_Rezultat
            // 
            this.label_Rezultat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Rezultat.AutoSize = true;
            this.label_Rezultat.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Rezultat.Location = new System.Drawing.Point(24, 708);
            this.label_Rezultat.Name = "label_Rezultat";
            this.label_Rezultat.Size = new System.Drawing.Size(188, 32);
            this.label_Rezultat.TabIndex = 12;
            this.label_Rezultat.Text = "Igrač - AI  0:0";
            // 
            // Button_Zvuk
            // 
            this.Button_Zvuk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Zvuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Zvuk.Location = new System.Drawing.Point(610, 706);
            this.Button_Zvuk.Name = "Button_Zvuk";
            this.Button_Zvuk.Size = new System.Drawing.Size(120, 30);
            this.Button_Zvuk.TabIndex = 21;
            this.Button_Zvuk.Text = "Zvuk: uključen";
            this.Button_Zvuk.UseVisualStyleBackColor = true;
            this.Button_Zvuk.Click += new System.EventHandler(this.Button_Zvuk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pomoć (H)";
            // 
            // Igra_1P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Zvuk);
            this.Controls.Add(this.label_Rezultat);
            this.Controls.Add(this.label_NaPotezu);
            this.Controls.Add(this.label_BrojPoteza);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Igra_1P";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Četiri u nizu - 1 igrač";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Igra_1P_FormClosed);
            this.Shown += new System.EventHandler(this.Igra_1P_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.D1) || keyData == (Keys.NumPad1))
            {
                this.Button0.PerformClick();
                return true;
            }
            if (keyData == (Keys.D2) || keyData == (Keys.NumPad2))
            {
                this.Button1.PerformClick();
                return true;
            }
            if (keyData == (Keys.D3) || keyData == (Keys.NumPad3))
            {
                this.Button2.PerformClick();
                return true;
            }
            if (keyData == (Keys.D4) || keyData == (Keys.NumPad4))
            {
                this.Button3.PerformClick();
                return true;
            }
            if (keyData == (Keys.D5) || keyData == (Keys.NumPad5))
            {
                this.Button4.PerformClick();
                return true;
            }
            if (keyData == (Keys.D6) || keyData == (Keys.NumPad6))
            {
                this.Button5.PerformClick();
                return true;
            }
            if (keyData == (Keys.D7) || keyData == (Keys.NumPad7))
            {
                this.Button6.PerformClick();
                return true;
            }
            if ((keyData == (Keys.Control | Keys.Z)) && (ploca.BrojacPoteza > 2) && (omogucenUndo))
            {
                this.Undo(zadnjiX, zadnjiY, predzadnjiX, predzadnjiY);
                return true;
            }
            if (keyData == (Keys.H))
            {
                MessageBox.Show(Properties.Resources.help, "Pomoć");
                return true;
            }
            if (keyData == (Keys.M))
            {
                this.Button_Zvuk.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Label label_BrojPoteza;
        private Label label_NaPotezu;
        private Label label_Rezultat;
        private Button Button_Zvuk;
        private Label label1;
    }
}