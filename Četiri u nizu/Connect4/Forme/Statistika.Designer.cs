namespace Connect4.Forme
{
    partial class Statistika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistika));
            this.Button_1igrac = new System.Windows.Forms.Button();
            this.Button_2igraca = new System.Windows.Forms.Button();
            this.Button_Nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_1igrac
            // 
            this.Button_1igrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_1igrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Button_1igrac.Location = new System.Drawing.Point(13, 13);
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
            this.Button_2igraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Button_2igraca.Location = new System.Drawing.Point(13, 94);
            this.Button_2igraca.Name = "Button_2igraca";
            this.Button_2igraca.Size = new System.Drawing.Size(175, 75);
            this.Button_2igraca.TabIndex = 1;
            this.Button_2igraca.Text = "&2 igrača";
            this.Button_2igraca.UseVisualStyleBackColor = true;
            this.Button_2igraca.Click += new System.EventHandler(this.Button_2igraca_Click);
            // 
            // Button_Nazad
            // 
            this.Button_Nazad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Button_Nazad.Location = new System.Drawing.Point(15, 175);
            this.Button_Nazad.Name = "Button_Nazad";
            this.Button_Nazad.Size = new System.Drawing.Size(175, 75);
            this.Button_Nazad.TabIndex = 2;
            this.Button_Nazad.Text = "&Nazad";
            this.Button_Nazad.UseVisualStyleBackColor = true;
            this.Button_Nazad.Click += new System.EventHandler(this.Button_Nazad_Click);
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 265);
            this.Controls.Add(this.Button_Nazad);
            this.Controls.Add(this.Button_2igraca);
            this.Controls.Add(this.Button_1igrac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_1igrac;
        private System.Windows.Forms.Button Button_2igraca;
        private System.Windows.Forms.Button Button_Nazad;
    }
}