namespace Connect4.Forme
{
    partial class Statistika_1P_Razine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistika_1P_Razine));
            this.Button_Lako = new System.Windows.Forms.Button();
            this.Button_Srednje = new System.Windows.Forms.Button();
            this.Button_Tesko = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Lako
            // 
            this.Button_Lako.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Lako.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Button_Lako.Location = new System.Drawing.Point(12, 12);
            this.Button_Lako.Name = "Button_Lako";
            this.Button_Lako.Size = new System.Drawing.Size(175, 75);
            this.Button_Lako.TabIndex = 0;
            this.Button_Lako.Text = "&Lako";
            this.Button_Lako.UseVisualStyleBackColor = true;
            this.Button_Lako.Click += new System.EventHandler(this.Button_Lako_Click);
            // 
            // Button_Srednje
            // 
            this.Button_Srednje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Srednje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Button_Srednje.Location = new System.Drawing.Point(12, 93);
            this.Button_Srednje.Name = "Button_Srednje";
            this.Button_Srednje.Size = new System.Drawing.Size(175, 75);
            this.Button_Srednje.TabIndex = 1;
            this.Button_Srednje.Text = "&Srednje";
            this.Button_Srednje.UseVisualStyleBackColor = true;
            this.Button_Srednje.Click += new System.EventHandler(this.Button_Srednje_Click);
            // 
            // Button_Tesko
            // 
            this.Button_Tesko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Tesko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Button_Tesko.Location = new System.Drawing.Point(12, 174);
            this.Button_Tesko.Name = "Button_Tesko";
            this.Button_Tesko.Size = new System.Drawing.Size(175, 75);
            this.Button_Tesko.TabIndex = 2;
            this.Button_Tesko.Text = "&Teško";
            this.Button_Tesko.UseVisualStyleBackColor = true;
            this.Button_Tesko.Click += new System.EventHandler(this.Button_Tesko_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(12, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Nazad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statistika_1P_Razine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_Tesko);
            this.Controls.Add(this.Button_Srednje);
            this.Controls.Add(this.Button_Lako);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistika_1P_Razine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Lako;
        private System.Windows.Forms.Button Button_Srednje;
        private System.Windows.Forms.Button Button_Tesko;
        private System.Windows.Forms.Button button1;
    }
}