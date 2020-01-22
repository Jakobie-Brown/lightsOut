namespace lightsOutProject
{
    partial class Form2
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
            this.difficultyBox = new System.Windows.Forms.GroupBox();
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.difficultyTextBox = new System.Windows.Forms.TextBox();
            this.difficultyNegativeButton = new System.Windows.Forms.Button();
            this.difficultyPositiveButton = new System.Windows.Forms.Button();
            this.xNegativeButton = new System.Windows.Forms.Button();
            this.yNegativeButton = new System.Windows.Forms.Button();
            this.xPositiveButton = new System.Windows.Forms.Button();
            this.yPositiveButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.difficultyBox.SuspendLayout();
            this.sizeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // difficultyBox
            // 
            this.difficultyBox.Controls.Add(this.difficultyPositiveButton);
            this.difficultyBox.Controls.Add(this.difficultyNegativeButton);
            this.difficultyBox.Controls.Add(this.difficultyTextBox);
            this.difficultyBox.Location = new System.Drawing.Point(12, 12);
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(235, 107);
            this.difficultyBox.TabIndex = 0;
            this.difficultyBox.TabStop = false;
            this.difficultyBox.Text = "Difficulty";
            // 
            // sizeBox
            // 
            this.sizeBox.Controls.Add(this.yPositiveButton);
            this.sizeBox.Controls.Add(this.xPositiveButton);
            this.sizeBox.Controls.Add(this.yNegativeButton);
            this.sizeBox.Controls.Add(this.xNegativeButton);
            this.sizeBox.Controls.Add(this.yTextBox);
            this.sizeBox.Controls.Add(this.xTextBox);
            this.sizeBox.Controls.Add(this.yLabel);
            this.sizeBox.Controls.Add(this.xLabel);
            this.sizeBox.Location = new System.Drawing.Point(12, 125);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(235, 105);
            this.sizeBox.TabIndex = 1;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Size";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(15, 32);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(26, 13);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "X = ";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(15, 58);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(23, 13);
            this.yLabel.TabIndex = 3;
            this.yLabel.Text = "Y =";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(47, 29);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 4;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(47, 55);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 20);
            this.yTextBox.TabIndex = 5;
            // 
            // difficultyTextBox
            // 
            this.difficultyTextBox.Location = new System.Drawing.Point(47, 48);
            this.difficultyTextBox.Name = "difficultyTextBox";
            this.difficultyTextBox.Size = new System.Drawing.Size(100, 20);
            this.difficultyTextBox.TabIndex = 0;
            // 
            // difficultyNegativeButton
            // 
            this.difficultyNegativeButton.Location = new System.Drawing.Point(154, 44);
            this.difficultyNegativeButton.Name = "difficultyNegativeButton";
            this.difficultyNegativeButton.Size = new System.Drawing.Size(19, 23);
            this.difficultyNegativeButton.TabIndex = 1;
            this.difficultyNegativeButton.Text = "-";
            this.difficultyNegativeButton.UseVisualStyleBackColor = true;
            this.difficultyNegativeButton.Click += new System.EventHandler(this.difficultyNegativeButton_Click);
            // 
            // difficultyPositiveButton
            // 
            this.difficultyPositiveButton.Location = new System.Drawing.Point(179, 44);
            this.difficultyPositiveButton.Name = "difficultyPositiveButton";
            this.difficultyPositiveButton.Size = new System.Drawing.Size(19, 23);
            this.difficultyPositiveButton.TabIndex = 2;
            this.difficultyPositiveButton.Text = "+";
            this.difficultyPositiveButton.UseVisualStyleBackColor = true;
            this.difficultyPositiveButton.Click += new System.EventHandler(this.difficultyPositiveButton_Click);
            // 
            // xNegativeButton
            // 
            this.xNegativeButton.Location = new System.Drawing.Point(154, 26);
            this.xNegativeButton.Name = "xNegativeButton";
            this.xNegativeButton.Size = new System.Drawing.Size(19, 23);
            this.xNegativeButton.TabIndex = 6;
            this.xNegativeButton.Text = "-";
            this.xNegativeButton.UseVisualStyleBackColor = true;
            this.xNegativeButton.Click += new System.EventHandler(this.xNegativeButton_Click);
            // 
            // yNegativeButton
            // 
            this.yNegativeButton.Location = new System.Drawing.Point(154, 52);
            this.yNegativeButton.Name = "yNegativeButton";
            this.yNegativeButton.Size = new System.Drawing.Size(19, 23);
            this.yNegativeButton.TabIndex = 7;
            this.yNegativeButton.Text = "-";
            this.yNegativeButton.UseVisualStyleBackColor = true;
            this.yNegativeButton.Click += new System.EventHandler(this.yNegativeButton_Click);
            // 
            // xPositiveButton
            // 
            this.xPositiveButton.Location = new System.Drawing.Point(179, 26);
            this.xPositiveButton.Name = "xPositiveButton";
            this.xPositiveButton.Size = new System.Drawing.Size(19, 23);
            this.xPositiveButton.TabIndex = 8;
            this.xPositiveButton.Text = "+";
            this.xPositiveButton.UseVisualStyleBackColor = true;
            this.xPositiveButton.Click += new System.EventHandler(this.xPositiveButton_Click);
            // 
            // yPositiveButton
            // 
            this.yPositiveButton.Location = new System.Drawing.Point(179, 52);
            this.yPositiveButton.Name = "yPositiveButton";
            this.yPositiveButton.Size = new System.Drawing.Size(19, 23);
            this.yPositiveButton.TabIndex = 9;
            this.yPositiveButton.Text = "+";
            this.yPositiveButton.UseVisualStyleBackColor = true;
            this.yPositiveButton.Click += new System.EventHandler(this.yPositiveButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(68, 236);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 296);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.difficultyBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.difficultyBox.ResumeLayout(false);
            this.difficultyBox.PerformLayout();
            this.sizeBox.ResumeLayout(false);
            this.sizeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox difficultyBox;
        private System.Windows.Forms.Button difficultyPositiveButton;
        private System.Windows.Forms.Button difficultyNegativeButton;
        private System.Windows.Forms.TextBox difficultyTextBox;
        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.Button yPositiveButton;
        private System.Windows.Forms.Button xPositiveButton;
        private System.Windows.Forms.Button yNegativeButton;
        private System.Windows.Forms.Button xNegativeButton;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Button submitButton;
    }
}