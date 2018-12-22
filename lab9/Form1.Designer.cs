namespace lab9
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dialogCheckBox = new System.Windows.Forms.CheckBox();
            this.fileCHeckBox = new System.Windows.Forms.CheckBox();
            this.goButton = new System.Windows.Forms.Button();
            this.oneArgRadio = new System.Windows.Forms.RadioButton();
            this.twoArgRadio = new System.Windows.Forms.RadioButton();
            this.arg1TextBox = new System.Windows.Forms.TextBox();
            this.arg2TextBox = new System.Windows.Forms.TextBox();
            this.operationCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dialogCheckBox
            // 
            this.dialogCheckBox.AutoSize = true;
            this.dialogCheckBox.Location = new System.Drawing.Point(71, 218);
            this.dialogCheckBox.Name = "dialogCheckBox";
            this.dialogCheckBox.Size = new System.Drawing.Size(86, 17);
            this.dialogCheckBox.TabIndex = 0;
            this.dialogCheckBox.Text = "Show Dialog";
            this.dialogCheckBox.UseVisualStyleBackColor = true;
            this.dialogCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fileCHeckBox
            // 
            this.fileCHeckBox.AutoSize = true;
            this.fileCHeckBox.Location = new System.Drawing.Point(71, 257);
            this.fileCHeckBox.Name = "fileCHeckBox";
            this.fileCHeckBox.Size = new System.Drawing.Size(86, 17);
            this.fileCHeckBox.TabIndex = 1;
            this.fileCHeckBox.Text = "Save To File";
            this.fileCHeckBox.UseVisualStyleBackColor = true;
            this.fileCHeckBox.CheckedChanged += new System.EventHandler(this.fileCHeckBox_CheckedChanged);
            // 
            // goButton
            // 
            this.goButton.Enabled = false;
            this.goButton.Location = new System.Drawing.Point(223, 233);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "GO!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // oneArgRadio
            // 
            this.oneArgRadio.AutoSize = true;
            this.oneArgRadio.Location = new System.Drawing.Point(71, 71);
            this.oneArgRadio.Name = "oneArgRadio";
            this.oneArgRadio.Size = new System.Drawing.Size(93, 17);
            this.oneArgRadio.TabIndex = 3;
            this.oneArgRadio.TabStop = true;
            this.oneArgRadio.Text = "One Argument";
            this.oneArgRadio.UseVisualStyleBackColor = true;
            // 
            // twoArgRadio
            // 
            this.twoArgRadio.AutoSize = true;
            this.twoArgRadio.Location = new System.Drawing.Point(213, 71);
            this.twoArgRadio.Name = "twoArgRadio";
            this.twoArgRadio.Size = new System.Drawing.Size(99, 17);
            this.twoArgRadio.TabIndex = 4;
            this.twoArgRadio.TabStop = true;
            this.twoArgRadio.Text = "Two Arguments";
            this.twoArgRadio.UseVisualStyleBackColor = true;
            // 
            // arg1TextBox
            // 
            this.arg1TextBox.Location = new System.Drawing.Point(12, 138);
            this.arg1TextBox.Name = "arg1TextBox";
            this.arg1TextBox.Size = new System.Drawing.Size(100, 20);
            this.arg1TextBox.TabIndex = 5;
            // 
            // arg2TextBox
            // 
            this.arg2TextBox.Location = new System.Drawing.Point(296, 138);
            this.arg2TextBox.Name = "arg2TextBox";
            this.arg2TextBox.Size = new System.Drawing.Size(100, 20);
            this.arg2TextBox.TabIndex = 6;
            // 
            // operationCombo
            // 
            this.operationCombo.FormattingEnabled = true;
            this.operationCombo.Location = new System.Drawing.Point(141, 137);
            this.operationCombo.Name = "operationCombo";
            this.operationCombo.Size = new System.Drawing.Size(121, 21);
            this.operationCombo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 385);
            this.Controls.Add(this.operationCombo);
            this.Controls.Add(this.arg2TextBox);
            this.Controls.Add(this.arg1TextBox);
            this.Controls.Add(this.twoArgRadio);
            this.Controls.Add(this.oneArgRadio);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.fileCHeckBox);
            this.Controls.Add(this.dialogCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox dialogCheckBox;
        private System.Windows.Forms.CheckBox fileCHeckBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.RadioButton oneArgRadio;
        private System.Windows.Forms.RadioButton twoArgRadio;
        private System.Windows.Forms.TextBox arg1TextBox;
        private System.Windows.Forms.TextBox arg2TextBox;
        private System.Windows.Forms.ComboBox operationCombo;
    }
}

