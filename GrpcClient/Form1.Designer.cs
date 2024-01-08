namespace GrpcClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstNumberInput = new System.Windows.Forms.TextBox();
            this.magicBtn = new System.Windows.Forms.Button();
            this.sumResult = new System.Windows.Forms.TextBox();
            this.multResult = new System.Windows.Forms.TextBox();
            this.secondNumberInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNumberInput
            // 
            this.firstNumberInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.firstNumberInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNumberInput.Location = new System.Drawing.Point(66, 51);
            this.firstNumberInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNumberInput.Name = "firstNumberInput";
            this.firstNumberInput.Size = new System.Drawing.Size(110, 27);
            this.firstNumberInput.TabIndex = 0;
            this.firstNumberInput.Text = "10";
            // 
            // magicBtn
            // 
            this.magicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.magicBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.magicBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.magicBtn.Location = new System.Drawing.Point(131, 96);
            this.magicBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.magicBtn.Name = "magicBtn";
            this.magicBtn.Size = new System.Drawing.Size(175, 43);
            this.magicBtn.TabIndex = 1;
            this.magicBtn.Text = "Get sum and mult";
            this.magicBtn.UseVisualStyleBackColor = false;
            // 
            // sumResult
            // 
            this.sumResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sumResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumResult.Location = new System.Drawing.Point(58, 157);
            this.sumResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sumResult.Name = "sumResult";
            this.sumResult.ReadOnly = true;
            this.sumResult.Size = new System.Drawing.Size(316, 27);
            this.sumResult.TabIndex = 2;
            this.sumResult.Text = "...";
            // 
            // multResult
            // 
            this.multResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.multResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multResult.Location = new System.Drawing.Point(58, 201);
            this.multResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multResult.Name = "multResult";
            this.multResult.ReadOnly = true;
            this.multResult.Size = new System.Drawing.Size(316, 27);
            this.multResult.TabIndex = 3;
            this.multResult.Text = "...";
            // 
            // secondNumberInput
            // 
            this.secondNumberInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.secondNumberInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondNumberInput.Location = new System.Drawing.Point(242, 51);
            this.secondNumberInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondNumberInput.Name = "secondNumberInput";
            this.secondNumberInput.Size = new System.Drawing.Size(110, 27);
            this.secondNumberInput.TabIndex = 4;
            this.secondNumberInput.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(457, 275);
            this.Controls.Add(this.secondNumberInput);
            this.Controls.Add(this.multResult);
            this.Controls.Add(this.sumResult);
            this.Controls.Add(this.magicBtn);
            this.Controls.Add(this.firstNumberInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstNumberInput;
        private Button magicBtn;
        private TextBox sumResult;
        private TextBox multResult;
        private TextBox secondNumberInput;
    }
}
