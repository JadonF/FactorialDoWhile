namespace FactorialDoWhile
{
    partial class frmFactorialDoWhile
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstListBox = new System.Windows.Forms.ListBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblInput.Location = new System.Drawing.Point(12, 33);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(398, 26);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Choose a number to find the factorial of:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(443, 38);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lstListBox
            // 
            this.lstListBox.FormattingEnabled = true;
            this.lstListBox.Location = new System.Drawing.Point(17, 102);
            this.lstListBox.Name = "lstListBox";
            this.lstListBox.Size = new System.Drawing.Size(120, 95);
            this.lstListBox.TabIndex = 2;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAnswer.Location = new System.Drawing.Point(17, 278);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(85, 26);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Answer";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(443, 114);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmFactorialDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 363);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lstListBox);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "frmFactorialDoWhile";
            this.Text = "Factorial Do While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstListBox;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnStart;
    }
}

