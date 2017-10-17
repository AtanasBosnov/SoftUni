namespace CurrencyConverterWindowsForm
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
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.labelConvert = new System.Windows.Forms.Label();
            this.labelBgEur = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAmount.Location = new System.Drawing.Point(224, 109);
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(381, 53);
            this.numericUpDownAmount.TabIndex = 0;
            // 
            // labelConvert
            // 
            this.labelConvert.AutoSize = true;
            this.labelConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvert.Location = new System.Drawing.Point(27, 109);
            this.labelConvert.Name = "labelConvert";
            this.labelConvert.Size = new System.Drawing.Size(159, 46);
            this.labelConvert.TabIndex = 1;
            this.labelConvert.Text = "Convert";
            this.labelConvert.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBgEur
            // 
            this.labelBgEur.AutoSize = true;
            this.labelBgEur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBgEur.Location = new System.Drawing.Point(623, 111);
            this.labelBgEur.Name = "labelBgEur";
            this.labelBgEur.Size = new System.Drawing.Size(248, 46);
            this.labelBgEur.TabIndex = 2;
            this.labelBgEur.Text = "BGN to EUR";
            this.labelBgEur.Click += new System.EventHandler(this.labelBgEur_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.Red;
            this.labelResult.Location = new System.Drawing.Point(218, 187);
            this.labelResult.MaximumSize = new System.Drawing.Size(100, 200);
            this.labelResult.MinimumSize = new System.Drawing.Size(400, 100);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(400, 100);
            this.labelResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 298);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelBgEur);
            this.Controls.Add(this.labelConvert);
            this.Controls.Add(this.numericUpDownAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelConvert;
        private System.Windows.Forms.Label labelBgEur;
        private System.Windows.Forms.Label labelResult;
    }
}

