using System.Windows.Forms;

namespace Connect4
{
    partial class DvaIgraca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DvaIgraca));
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_ImeIgraca2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_PrviPotez = new System.Windows.Forms.GroupBox();
            this.radioButton_PrviIgraIgrac2 = new System.Windows.Forms.RadioButton();
            this.radioButton_PrviIgraIgrac1 = new System.Windows.Forms.RadioButton();
            this.groupBox_Igrac2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Crvena2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Plava2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Zuta2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Zelena2 = new System.Windows.Forms.RadioButton();
            this.groupBox_Igrac1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Zelena1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Zuta1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Plava1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Crvena1 = new System.Windows.Forms.RadioButton();
            this.TextBox_ImeIgraca1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Zapocni = new System.Windows.Forms.Button();
            this.Button_Povratak = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox_PrviPotez.SuspendLayout();
            this.groupBox_Igrac2.SuspendLayout();
            this.groupBox_Igrac1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(203, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Odaberi postojećeg igrača";
            // 
            // TextBox_ImeIgraca2
            // 
            this.TextBox_ImeIgraca2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_ImeIgraca2.Location = new System.Drawing.Point(206, 40);
            this.TextBox_ImeIgraca2.Name = "TextBox_ImeIgraca2";
            this.TextBox_ImeIgraca2.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ImeIgraca2.TabIndex = 36;
            this.TextBox_ImeIgraca2.Click += new System.EventHandler(this.TextBox_ImeIgraca2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(203, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ime";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Odaberi postojećeg igrača";
            // 
            // groupBox_PrviPotez
            // 
            this.groupBox_PrviPotez.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_PrviPotez.Controls.Add(this.radioButton_PrviIgraIgrac2);
            this.groupBox_PrviPotez.Controls.Add(this.radioButton_PrviIgraIgrac1);
            this.groupBox_PrviPotez.Location = new System.Drawing.Point(15, 275);
            this.groupBox_PrviPotez.Name = "groupBox_PrviPotez";
            this.groupBox_PrviPotez.Size = new System.Drawing.Size(110, 70);
            this.groupBox_PrviPotez.TabIndex = 31;
            this.groupBox_PrviPotez.TabStop = false;
            this.groupBox_PrviPotez.Text = "Prvi na potezu";
            // 
            // radioButton_PrviIgraIgrac2
            // 
            this.radioButton_PrviIgraIgrac2.AutoSize = true;
            this.radioButton_PrviIgraIgrac2.Location = new System.Drawing.Point(25, 42);
            this.radioButton_PrviIgraIgrac2.Name = "radioButton_PrviIgraIgrac2";
            this.radioButton_PrviIgraIgrac2.Size = new System.Drawing.Size(58, 17);
            this.radioButton_PrviIgraIgrac2.TabIndex = 1;
            this.radioButton_PrviIgraIgrac2.TabStop = true;
            this.radioButton_PrviIgraIgrac2.Text = "Igrač 2";
            this.radioButton_PrviIgraIgrac2.UseVisualStyleBackColor = true;
            // 
            // radioButton_PrviIgraIgrac1
            // 
            this.radioButton_PrviIgraIgrac1.AutoSize = true;
            this.radioButton_PrviIgraIgrac1.Location = new System.Drawing.Point(25, 19);
            this.radioButton_PrviIgraIgrac1.Name = "radioButton_PrviIgraIgrac1";
            this.radioButton_PrviIgraIgrac1.Size = new System.Drawing.Size(58, 17);
            this.radioButton_PrviIgraIgrac1.TabIndex = 0;
            this.radioButton_PrviIgraIgrac1.TabStop = true;
            this.radioButton_PrviIgraIgrac1.Text = "Igrač 1";
            this.radioButton_PrviIgraIgrac1.UseVisualStyleBackColor = true;
            // 
            // groupBox_Igrac2
            // 
            this.groupBox_Igrac2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Igrac2.Controls.Add(this.radioButton_Crvena2);
            this.groupBox_Igrac2.Controls.Add(this.radioButton_Plava2);
            this.groupBox_Igrac2.Controls.Add(this.radioButton_Zuta2);
            this.groupBox_Igrac2.Controls.Add(this.radioButton_Zelena2);
            this.groupBox_Igrac2.Location = new System.Drawing.Point(206, 144);
            this.groupBox_Igrac2.Name = "groupBox_Igrac2";
            this.groupBox_Igrac2.Size = new System.Drawing.Size(111, 114);
            this.groupBox_Igrac2.TabIndex = 30;
            this.groupBox_Igrac2.TabStop = false;
            this.groupBox_Igrac2.Text = "Boja";
            // 
            // radioButton_Crvena2
            // 
            this.radioButton_Crvena2.AutoSize = true;
            this.radioButton_Crvena2.Location = new System.Drawing.Point(26, 17);
            this.radioButton_Crvena2.Name = "radioButton_Crvena2";
            this.radioButton_Crvena2.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Crvena2.TabIndex = 7;
            this.radioButton_Crvena2.TabStop = true;
            this.radioButton_Crvena2.Text = "Crvena";
            this.radioButton_Crvena2.UseVisualStyleBackColor = true;
            this.radioButton_Crvena2.CheckedChanged += new System.EventHandler(this.OdabirBoje);
            // 
            // radioButton_Plava2
            // 
            this.radioButton_Plava2.AutoSize = true;
            this.radioButton_Plava2.Location = new System.Drawing.Point(26, 40);
            this.radioButton_Plava2.Name = "radioButton_Plava2";
            this.radioButton_Plava2.Size = new System.Drawing.Size(52, 17);
            this.radioButton_Plava2.TabIndex = 6;
            this.radioButton_Plava2.TabStop = true;
            this.radioButton_Plava2.Text = "Plava";
            this.radioButton_Plava2.UseVisualStyleBackColor = true;
            this.radioButton_Plava2.CheckedChanged += new System.EventHandler(this.OdabirBoje);
            // 
            // radioButton_Zuta2
            // 
            this.radioButton_Zuta2.AutoSize = true;
            this.radioButton_Zuta2.Location = new System.Drawing.Point(26, 64);
            this.radioButton_Zuta2.Name = "radioButton_Zuta2";
            this.radioButton_Zuta2.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Zuta2.TabIndex = 5;
            this.radioButton_Zuta2.TabStop = true;
            this.radioButton_Zuta2.Text = "Žuta";
            this.radioButton_Zuta2.UseVisualStyleBackColor = true;
            this.radioButton_Zuta2.CheckedChanged += new System.EventHandler(this.OdabirBoje);
            // 
            // radioButton_Zelena2
            // 
            this.radioButton_Zelena2.AutoSize = true;
            this.radioButton_Zelena2.Location = new System.Drawing.Point(26, 87);
            this.radioButton_Zelena2.Name = "radioButton_Zelena2";
            this.radioButton_Zelena2.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Zelena2.TabIndex = 4;
            this.radioButton_Zelena2.TabStop = true;
            this.radioButton_Zelena2.Text = "Zelena";
            this.radioButton_Zelena2.UseVisualStyleBackColor = true;
            this.radioButton_Zelena2.CheckedChanged += new System.EventHandler(this.OdabirBoje);
            // 
            // groupBox_Igrac1
            // 
            this.groupBox_Igrac1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Igrac1.Controls.Add(this.radioButton_Zelena1);
            this.groupBox_Igrac1.Controls.Add(this.radioButton_Zuta1);
            this.groupBox_Igrac1.Controls.Add(this.radioButton_Plava1);
            this.groupBox_Igrac1.Controls.Add(this.radioButton_Crvena1);
            this.groupBox_Igrac1.Location = new System.Drawing.Point(15, 144);
            this.groupBox_Igrac1.Name = "groupBox_Igrac1";
            this.groupBox_Igrac1.Size = new System.Drawing.Size(109, 116);
            this.groupBox_Igrac1.TabIndex = 29;
            this.groupBox_Igrac1.TabStop = false;
            this.groupBox_Igrac1.Text = "Boja";
            // 
            // radioButton_Zelena1
            // 
            this.radioButton_Zelena1.AutoSize = true;
            this.radioButton_Zelena1.Location = new System.Drawing.Point(25, 89);
            this.radioButton_Zelena1.Name = "radioButton_Zelena1";
            this.radioButton_Zelena1.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Zelena1.TabIndex = 3;
            this.radioButton_Zelena1.TabStop = true;
            this.radioButton_Zelena1.Text = "Zelena";
            this.radioButton_Zelena1.UseVisualStyleBackColor = true;
            this.radioButton_Zelena1.CheckedChanged += new System.EventHandler(this.OdabirBoje);
            // 
            // radioButton_Zuta1
            // 
            this.radioButton_Zuta1.AutoSize = true;
            this.radioButton_Zuta1.Location = new System.Drawing.Point(25, 66);
            this.radioButton_Zuta1.Name = "radioButton_Zuta1";
            this.radioButton_Zuta1.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Zuta1.TabIndex = 2;
            this.radioButton_Zuta1.TabStop = true;
            this.radioButton_Zuta1.Text = "Žuta";
            this.radioButton_Zuta1.UseVisualStyleBackColor = true;
            this.radioButton_Zuta1.CheckedChanged += new System.EventHandler(this.OdabirBoje);
            // 
            // radioButton_Plava1
            // 
            this.radioButton_Plava1.AutoSize = true;
            this.radioButton_Plava1.Location = new System.Drawing.Point(25, 43);
            this.radioButton_Plava1.Name = "radioButton_Plava1";
            this.radioButton_Plava1.Size = new System.Drawing.Size(52, 17);
            this.radioButton_Plava1.TabIndex = 1;
            this.radioButton_Plava1.TabStop = true;
            this.radioButton_Plava1.Text = "Plava";
            this.radioButton_Plava1.UseVisualStyleBackColor = true;
            this.radioButton_Plava1.CheckedChanged += new System.EventHandler(this.OdabirBoje);
            // 
            // radioButton_Crvena1
            // 
            this.radioButton_Crvena1.AutoSize = true;
            this.radioButton_Crvena1.Location = new System.Drawing.Point(25, 19);
            this.radioButton_Crvena1.Name = "radioButton_Crvena1";
            this.radioButton_Crvena1.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Crvena1.TabIndex = 0;
            this.radioButton_Crvena1.TabStop = true;
            this.radioButton_Crvena1.Text = "Crvena";
            this.radioButton_Crvena1.UseVisualStyleBackColor = true;
            this.radioButton_Crvena1.CheckedChanged += new System.EventHandler(this.OdabirBoje);
            // 
            // TextBox_ImeIgraca1
            // 
            this.TextBox_ImeIgraca1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_ImeIgraca1.Location = new System.Drawing.Point(15, 40);
            this.TextBox_ImeIgraca1.Name = "TextBox_ImeIgraca1";
            this.TextBox_ImeIgraca1.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ImeIgraca1.TabIndex = 28;
            this.TextBox_ImeIgraca1.Click += new System.EventHandler(this.TextBox_ImeIgraca1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ime";
            // 
            // Button_Zapocni
            // 
            this.Button_Zapocni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Zapocni.Location = new System.Drawing.Point(206, 373);
            this.Button_Zapocni.Name = "Button_Zapocni";
            this.Button_Zapocni.Size = new System.Drawing.Size(75, 23);
            this.Button_Zapocni.TabIndex = 41;
            this.Button_Zapocni.Text = "Započni igru";
            this.Button_Zapocni.UseVisualStyleBackColor = true;
            this.Button_Zapocni.Click += new System.EventHandler(this.Button_Zapocni_Click);
            // 
            // Button_Povratak
            // 
            this.Button_Povratak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Povratak.Location = new System.Drawing.Point(61, 373);
            this.Button_Povratak.Name = "Button_Povratak";
            this.Button_Povratak.Size = new System.Drawing.Size(75, 23);
            this.Button_Povratak.TabIndex = 40;
            this.Button_Povratak.Text = "Povratak";
            this.Button_Povratak.UseVisualStyleBackColor = true;
            this.Button_Povratak.Click += new System.EventHandler(this.Button_Povratak_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(15, 93);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 21);
            this.ComboBox1.Sorted = true;
            this.ComboBox1.TabIndex = 42;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // ComboBox2
            // 
            this.ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(206, 93);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(121, 21);
            this.ComboBox2.Sorted = true;
            this.ComboBox2.TabIndex = 43;
            this.ComboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // DvaIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 431);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Button_Zapocni);
            this.Controls.Add(this.Button_Povratak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_ImeIgraca2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox_PrviPotez);
            this.Controls.Add(this.groupBox_Igrac2);
            this.Controls.Add(this.groupBox_Igrac1);
            this.Controls.Add(this.TextBox_ImeIgraca1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DvaIgraca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Četiri u nizu - 2 igrača";
            this.groupBox_PrviPotez.ResumeLayout(false);
            this.groupBox_PrviPotez.PerformLayout();
            this.groupBox_Igrac2.ResumeLayout(false);
            this.groupBox_Igrac2.PerformLayout();
            this.groupBox_Igrac1.ResumeLayout(false);
            this.groupBox_Igrac1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter | Keys.Control))
            {
                this.Button_Zapocni.PerformClick();
                return true;
            }
            if (keyData == (Keys.Back | Keys.Control))
            {
                this.Button_Povratak.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_ImeIgraca2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox_PrviPotez;
        private System.Windows.Forms.RadioButton radioButton_PrviIgraIgrac2;
        private System.Windows.Forms.RadioButton radioButton_PrviIgraIgrac1;
        private System.Windows.Forms.GroupBox groupBox_Igrac2;
        private System.Windows.Forms.RadioButton radioButton_Crvena2;
        private System.Windows.Forms.RadioButton radioButton_Plava2;
        private System.Windows.Forms.RadioButton radioButton_Zuta2;
        private System.Windows.Forms.RadioButton radioButton_Zelena2;
        private System.Windows.Forms.GroupBox groupBox_Igrac1;
        private System.Windows.Forms.RadioButton radioButton_Zelena1;
        private System.Windows.Forms.RadioButton radioButton_Zuta1;
        private System.Windows.Forms.RadioButton radioButton_Plava1;
        private System.Windows.Forms.RadioButton radioButton_Crvena1;
        private System.Windows.Forms.TextBox TextBox_ImeIgraca1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Zapocni;
        private System.Windows.Forms.Button Button_Povratak;
        private ComboBox ComboBox1;
        private ComboBox ComboBox2;
    }
}