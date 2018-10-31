namespace Connect4
{
    partial class GlavniIzbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavniIzbornik));
            this.Button_1igrac = new System.Windows.Forms.Button();
            this.Button_2igraca = new System.Windows.Forms.Button();
            this.Button_Statistika = new System.Windows.Forms.Button();
            this.Button_Pravila = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Zvuk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_1igrac
            // 
            this.Button_1igrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_1igrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_1igrac.Location = new System.Drawing.Point(115, 135);
            this.Button_1igrac.Name = "Button_1igrac";
            this.Button_1igrac.Size = new System.Drawing.Size(175, 75);
            this.Button_1igrac.TabIndex = 0;
            this.Button_1igrac.Text = "&1 igrač";
            this.Button_1igrac.UseVisualStyleBackColor = true;
            this.Button_1igrac.Click += new System.EventHandler(this.Button_1igrac_Click);
            // 
            // Button_2igraca
            // 
            this.Button_2igraca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_2igraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_2igraca.Location = new System.Drawing.Point(115, 216);
            this.Button_2igraca.Name = "Button_2igraca";
            this.Button_2igraca.Size = new System.Drawing.Size(175, 75);
            this.Button_2igraca.TabIndex = 1;
            this.Button_2igraca.Text = "&2 igrača";
            this.Button_2igraca.UseVisualStyleBackColor = true;
            this.Button_2igraca.Click += new System.EventHandler(this.Button_2igraca_Click);
            // 
            // Button_Statistika
            // 
            this.Button_Statistika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Statistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Statistika.Location = new System.Drawing.Point(115, 297);
            this.Button_Statistika.Name = "Button_Statistika";
            this.Button_Statistika.Size = new System.Drawing.Size(175, 75);
            this.Button_Statistika.TabIndex = 2;
            this.Button_Statistika.Text = "&Statistika";
            this.Button_Statistika.UseVisualStyleBackColor = true;
            this.Button_Statistika.Click += new System.EventHandler(this.Button_Statistika_Click);
            // 
            // Button_Pravila
            // 
            this.Button_Pravila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Pravila.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Pravila.Location = new System.Drawing.Point(115, 378);
            this.Button_Pravila.Name = "Button_Pravila";
            this.Button_Pravila.Size = new System.Drawing.Size(175, 75);
            this.Button_Pravila.TabIndex = 3;
            this.Button_Pravila.Text = "&O igri";
            this.Button_Pravila.UseVisualStyleBackColor = true;
            this.Button_Pravila.Click += new System.EventHandler(this.Button_Pravila_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Glavni izbornik";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(90, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Četiri u nizu";
            // 
            // Button_Zvuk
            // 
            this.Button_Zvuk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Zvuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Zvuk.Location = new System.Drawing.Point(342, 429);
            this.Button_Zvuk.Name = "Button_Zvuk";
            this.Button_Zvuk.Size = new System.Drawing.Size(50, 40);
            this.Button_Zvuk.TabIndex = 6;
            this.Button_Zvuk.UseVisualStyleBackColor = true;
            this.Button_Zvuk.Click += new System.EventHandler(this.Button_Zvuk_Click);
            // 
            // GlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(404, 481);
            this.Controls.Add(this.Button_Zvuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_1igrac);
            this.Controls.Add(this.Button_Pravila);
            this.Controls.Add(this.Button_Statistika);
            this.Controls.Add(this.Button_2igraca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Četiri u nizu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_1igrac;
        private System.Windows.Forms.Button Button_2igraca;
        private System.Windows.Forms.Button Button_Statistika;
        private System.Windows.Forms.Button Button_Pravila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Zvuk;
    }
}

