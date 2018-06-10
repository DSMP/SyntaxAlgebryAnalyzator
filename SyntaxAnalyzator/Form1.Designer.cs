namespace SyntaxAnalyzator
{
    partial class Form1
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
            this._inputTextBox = new System.Windows.Forms.RichTextBox();
            this._resultLabel = new System.Windows.Forms.Label();
            this._checkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _inputTextBox
            // 
            this._inputTextBox.Location = new System.Drawing.Point(12, 22);
            this._inputTextBox.Name = "_inputTextBox";
            this._inputTextBox.Size = new System.Drawing.Size(762, 132);
            this._inputTextBox.TabIndex = 0;
            this._inputTextBox.Text = "";
            // 
            // _resultLabel
            // 
            this._resultLabel.AutoSize = true;
            this._resultLabel.Location = new System.Drawing.Point(390, 252);
            this._resultLabel.Name = "_resultLabel";
            this._resultLabel.Size = new System.Drawing.Size(35, 13);
            this._resultLabel.TabIndex = 1;
            this._resultLabel.Text = "label1";
            // 
            // _checkButton
            // 
            this._checkButton.Location = new System.Drawing.Point(349, 176);
            this._checkButton.Name = "_checkButton";
            this._checkButton.Size = new System.Drawing.Size(114, 23);
            this._checkButton.TabIndex = 2;
            this._checkButton.Text = "Check Syntax";
            this._checkButton.UseVisualStyleBackColor = true;
            this._checkButton.Click += new System.EventHandler(this._checkButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this._checkButton);
            this.Controls.Add(this._resultLabel);
            this.Controls.Add(this._inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox _inputTextBox;
        private System.Windows.Forms.Label _resultLabel;
        private System.Windows.Forms.Button _checkButton;
    }
}

