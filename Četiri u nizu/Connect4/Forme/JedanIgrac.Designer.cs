using System.Windows.Forms;

namespace Connect4
{
    partial class JedanIgrac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JedanIgrac));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_ImeIgraca = new System.Windows.Forms.TextBox();
            this.groupBox_Igrac = new System.Windows.Forms.GroupBox();
            this.radioButton_Zelena1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Zuta1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Plava1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Crvena1 = new System.Windows.Forms.RadioButton();
            this.groupBox_AI = new System.Windows.Forms.GroupBox();
            this.radioButton_Crvena2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Plava2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Zuta2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Zelena2 = new System.Windows.Forms.RadioButton();
            this.groupBox_RazinaTezine = new System.Windows.Forms.GroupBox();
            this.radioButton_Razina3 = new System.Windows.Forms.RadioButton();
            this.radioButton_Razina2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Razina1 = new System.Windows.Forms.RadioButton();
            this.groupBox_PrviPotez = new System.Windows.Forms.GroupBox();
            this.radioButton_PrviIgraAI = new System.Windows.Forms.RadioButton();
            this.radioButton_PrviIgraIgrac = new System.Windows.Forms.RadioButton();
            this.label_ImeAI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Povratak = new System.Windows.Forms.Button();
            this.Button_Zapocni = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox_Igrac.SuspendLayout();
            this.groupBox_AI.SuspendLayout();
            this.groupBox_RazinaTezine.SuspendLayout();
            this.groupBox_PrviPotez.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(216, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "AI";
            // 
            // TextBox_ImeIgraca
            // 
            this.TextBox_ImeIgraca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_ImeIgraca.Location = new System.Drawing.Point(27, 37);
            this.TextBox_ImeIgraca.Name = "TextBox_ImeIgraca";
            this.TextBox_ImeIgraca.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ImeIgraca.TabIndex = 2;
            this.TextBox_ImeIgraca.Click += new System.EventHandler(this.TextBox_ImeIgraca_Click);
            // 
            // groupBox_Igrac
            // 
            this.groupBox_Igrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Igrac.Controls.Add(this.radioButton_Zelena1);
            this.groupBox_Igrac.Controls.Add(this.radioButton_Zuta1);
            this.groupBox_Igrac.Controls.Add(this.radioButton_Plava1);
            this.groupBox_Igrac.Controls.Add(this.radioButton_Crvena1);
            this.groupBox_Igrac.Location = new System.Drawing.Point(27, 143);
            this.groupBox_Igrac.Name = "groupBox_Igrac";
            this.groupBox_Igrac.Size = new System.Drawing.Size(109, 116);
            this.groupBox_Igrac.TabIndex = 3;
            this.groupBox_Igrac.TabStop = false;
            this.groupBox_Igrac.Text = "Boja";
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
            // groupBox_AI
            // 
            this.groupBox_AI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_AI.Controls.Add(this.radioButton_Crvena2);
            this.groupBox_AI.Controls.Add(this.radioButton_Plava2);
            this.groupBox_AI.Controls.Add(this.radioButton_Zuta2);
            this.groupBox_AI.Controls.Add(this.radioButton_Zelena2);
            this.groupBox_AI.Location = new System.Drawing.Point(207, 145);
            this.groupBox_AI.Name = "groupBox_AI";
            this.groupBox_AI.Size = new System.Drawing.Size(111, 114);
            this.groupBox_AI.TabIndex = 4;
            this.groupBox_AI.TabStop = false;
            this.groupBox_AI.Text = "Boja";
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
            // groupBox_RazinaTezine
            // 
            this.groupBox_RazinaTezine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_RazinaTezine.Controls.Add(this.radioButton_Razina3);
            this.groupBox_RazinaTezine.Controls.Add(this.radioButton_Razina2);
            this.groupBox_RazinaTezine.Controls.Add(this.radioButton_Razina1);
            this.groupBox_RazinaTezine.Location = new System.Drawing.Point(207, 287);
            this.groupBox_RazinaTezine.Name = "groupBox_RazinaTezine";
            this.groupBox_RazinaTezine.Size = new System.Drawing.Size(111, 92);
            this.groupBox_RazinaTezine.TabIndex = 5;
            this.groupBox_RazinaTezine.TabStop = false;
            this.groupBox_RazinaTezine.Text = "Razina težine";
            // 
            // radioButton_Razina3
            // 
            this.radioButton_Razina3.AutoSize = true;
            this.radioButton_Razina3.Location = new System.Drawing.Point(26, 65);
            this.radioButton_Razina3.Name = "radioButton_Razina3";
            this.radioButton_Razina3.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Razina3.TabIndex = 2;
            this.radioButton_Razina3.TabStop = true;
            this.radioButton_Razina3.Text = "Teško";
            this.radioButton_Razina3.UseVisualStyleBackColor = true;
            this.radioButton_Razina3.CheckedChanged += new System.EventHandler(this.OdabirTezine);
            // 
            // radioButton_Razina2
            // 
            this.radioButton_Razina2.AutoSize = true;
            this.radioButton_Razina2.Location = new System.Drawing.Point(26, 42);
            this.radioButton_Razina2.Name = "radioButton_Razina2";
            this.radioButton_Razina2.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Razina2.TabIndex = 1;
            this.radioButton_Razina2.TabStop = true;
            this.radioButton_Razina2.Text = "Srednje";
            this.radioButton_Razina2.UseVisualStyleBackColor = true;
            this.radioButton_Razina2.CheckedChanged += new System.EventHandler(this.OdabirTezine);
            // 
            // radioButton_Razina1
            // 
            this.radioButton_Razina1.AutoSize = true;
            this.radioButton_Razina1.Location = new System.Drawing.Point(26, 19);
            this.radioButton_Razina1.Name = "radioButton_Razina1";
            this.radioButton_Razina1.Size = new System.Drawing.Size(49, 17);
            this.radioButton_Razina1.TabIndex = 0;
            this.radioButton_Razina1.TabStop = true;
            this.radioButton_Razina1.Text = "Lako";
            this.radioButton_Razina1.UseVisualStyleBackColor = true;
            this.radioButton_Razina1.CheckedChanged += new System.EventHandler(this.OdabirTezine);
            // 
            // groupBox_PrviPotez
            // 
            this.groupBox_PrviPotez.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_PrviPotez.Controls.Add(this.radioButton_PrviIgraAI);
            this.groupBox_PrviPotez.Controls.Add(this.radioButton_PrviIgraIgrac);
            this.groupBox_PrviPotez.Location = new System.Drawing.Point(27, 287);
            this.groupBox_PrviPotez.Name = "groupBox_PrviPotez";
            this.groupBox_PrviPotez.Size = new System.Drawing.Size(109, 69);
            this.groupBox_PrviPotez.TabIndex = 6;
            this.groupBox_PrviPotez.TabStop = false;
            this.groupBox_PrviPotez.Text = "Prvi na potezu";
            // 
            // radioButton_PrviIgraAI
            // 
            this.radioButton_PrviIgraAI.AutoSize = true;
            this.radioButton_PrviIgraAI.Location = new System.Drawing.Point(25, 42);
            this.radioButton_PrviIgraAI.Name = "radioButton_PrviIgraAI";
            this.radioButton_PrviIgraAI.Size = new System.Drawing.Size(35, 17);
            this.radioButton_PrviIgraAI.TabIndex = 1;
            this.radioButton_PrviIgraAI.TabStop = true;
            this.radioButton_PrviIgraAI.Text = "AI";
            this.radioButton_PrviIgraAI.UseVisualStyleBackColor = true;
            // 
            // radioButton_PrviIgraIgrac
            // 
            this.radioButton_PrviIgraIgrac.AutoSize = true;
            this.radioButton_PrviIgraIgrac.Location = new System.Drawing.Point(25, 19);
            this.radioButton_PrviIgraIgrac.Name = "radioButton_PrviIgraIgrac";
            this.radioButton_PrviIgraIgrac.Size = new System.Drawing.Size(49, 17);
            this.radioButton_PrviIgraIgrac.TabIndex = 0;
            this.radioButton_PrviIgraIgrac.TabStop = true;
            this.radioButton_PrviIgraIgrac.Text = "Igrač";
            this.radioButton_PrviIgraIgrac.UseVisualStyleBackColor = true;
            // 
            // label_ImeAI
            // 
            this.label_ImeAI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ImeAI.AutoSize = true;
            this.label_ImeAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ImeAI.Location = new System.Drawing.Point(215, 37);
            this.label_ImeAI.Name = "label_ImeAI";
            this.label_ImeAI.Size = new System.Drawing.Size(15, 20);
            this.label_ImeAI.TabIndex = 7;
            this.label_ImeAI.Text = "-";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(24, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Odaberi postojećeg igrača";
            // 
            // Button_Povratak
            // 
            this.Button_Povratak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Povratak.Location = new System.Drawing.Point(61, 396);
            this.Button_Povratak.Name = "Button_Povratak";
            this.Button_Povratak.Size = new System.Drawing.Size(75, 23);
            this.Button_Povratak.TabIndex = 11;
            this.Button_Povratak.Text = "Povratak";
            this.Button_Povratak.UseVisualStyleBackColor = true;
            this.Button_Povratak.Click += new System.EventHandler(this.Button_Povratak_Click);
            // 
            // Button_Zapocni
            // 
            this.Button_Zapocni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Zapocni.Location = new System.Drawing.Point(193, 396);
            this.Button_Zapocni.Name = "Button_Zapocni";
            this.Button_Zapocni.Size = new System.Drawing.Size(75, 23);
            this.Button_Zapocni.TabIndex = 12;
            this.Button_Zapocni.Text = "Započni igru";
            this.Button_Zapocni.UseVisualStyleBackColor = true;
            this.Button_Zapocni.Click += new System.EventHandler(this.Button_Zapocni_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(27, 98);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.Sorted = true;
            this.ComboBox.TabIndex = 13;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // JedanIgrac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(356, 431);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.Button_Zapocni);
            this.Controls.Add(this.Button_Povratak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_ImeAI);
            this.Controls.Add(this.groupBox_PrviPotez);
            this.Controls.Add(this.groupBox_RazinaTezine);
            this.Controls.Add(this.groupBox_AI);
            this.Controls.Add(this.groupBox_Igrac);
            this.Controls.Add(this.TextBox_ImeIgraca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JedanIgrac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Četiri u nizu - 1 igrač";
            this.groupBox_Igrac.ResumeLayout(false);
            this.groupBox_Igrac.PerformLayout();
            this.groupBox_AI.ResumeLayout(false);
            this.groupBox_AI.PerformLayout();
            this.groupBox_RazinaTezine.ResumeLayout(false);
            this.groupBox_RazinaTezine.PerformLayout();
            this.groupBox_PrviPotez.ResumeLayout(false);
            this.groupBox_PrviPotez.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter | Keys.Control))
            {
                PromijeniBojuPloce();
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_ImeIgraca;
        private System.Windows.Forms.GroupBox groupBox_Igrac;
        private System.Windows.Forms.GroupBox groupBox_AI;
        private System.Windows.Forms.GroupBox groupBox_RazinaTezine;
        private System.Windows.Forms.GroupBox groupBox_PrviPotez;
        private System.Windows.Forms.Label label_ImeAI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_Zelena1;
        private System.Windows.Forms.RadioButton radioButton_Zuta1;
        private System.Windows.Forms.RadioButton radioButton_Plava1;
        private System.Windows.Forms.RadioButton radioButton_Crvena1;
        private System.Windows.Forms.RadioButton radioButton_Crvena2;
        private System.Windows.Forms.RadioButton radioButton_Plava2;
        private System.Windows.Forms.RadioButton radioButton_Zuta2;
        private System.Windows.Forms.RadioButton radioButton_Zelena2;
        private System.Windows.Forms.RadioButton radioButton_Razina3;
        private System.Windows.Forms.RadioButton radioButton_Razina2;
        private System.Windows.Forms.RadioButton radioButton_Razina1;
        private System.Windows.Forms.RadioButton radioButton_PrviIgraAI;
        private System.Windows.Forms.RadioButton radioButton_PrviIgraIgrac;
        private System.Windows.Forms.Button Button_Povratak;
        private System.Windows.Forms.Button Button_Zapocni;
        private ComboBox ComboBox;
    }
}