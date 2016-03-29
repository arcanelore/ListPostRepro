namespace ListPostRepro.WinForm
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
            this.buttonRunTest = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.buttonRunListValue = new System.Windows.Forms.Button();
            this.textBoxBaseUrl = new System.Windows.Forms.TextBox();
            this.labelBaseUrl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRunTest
            // 
            this.buttonRunTest.Location = new System.Drawing.Point(77, 121);
            this.buttonRunTest.Name = "buttonRunTest";
            this.buttonRunTest.Size = new System.Drawing.Size(114, 33);
            this.buttonRunTest.TabIndex = 0;
            this.buttonRunTest.Text = "Run List Item";
            this.buttonRunTest.UseVisualStyleBackColor = true;
            this.buttonRunTest.Click += new System.EventHandler(this.buttonRunTest_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(77, 160);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResults.Size = new System.Drawing.Size(423, 174);
            this.textBoxResults.TabIndex = 1;
            // 
            // buttonRunListValue
            // 
            this.buttonRunListValue.Location = new System.Drawing.Point(386, 121);
            this.buttonRunListValue.Name = "buttonRunListValue";
            this.buttonRunListValue.Size = new System.Drawing.Size(114, 33);
            this.buttonRunListValue.TabIndex = 2;
            this.buttonRunListValue.Text = "Run List Value";
            this.buttonRunListValue.UseVisualStyleBackColor = true;
            this.buttonRunListValue.Click += new System.EventHandler(this.buttonRunListValue_Click);
            // 
            // textBoxBaseUrl
            // 
            this.textBoxBaseUrl.Location = new System.Drawing.Point(77, 12);
            this.textBoxBaseUrl.Name = "textBoxBaseUrl";
            this.textBoxBaseUrl.Size = new System.Drawing.Size(423, 22);
            this.textBoxBaseUrl.TabIndex = 3;
            this.textBoxBaseUrl.Text = "http://localhost:62812/odata/v1/";
            // 
            // labelBaseUrl
            // 
            this.labelBaseUrl.AutoSize = true;
            this.labelBaseUrl.Location = new System.Drawing.Point(5, 15);
            this.labelBaseUrl.Name = "labelBaseUrl";
            this.labelBaseUrl.Size = new System.Drawing.Size(66, 17);
            this.labelBaseUrl.TabIndex = 4;
            this.labelBaseUrl.Text = "Base Url:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(62, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Works as Expected.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(367, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passes Null for List.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBaseUrl);
            this.Controls.Add(this.textBoxBaseUrl);
            this.Controls.Add(this.buttonRunListValue);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.buttonRunTest);
            this.Name = "Form1";
            this.Text = "Test List Property Insert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRunTest;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Button buttonRunListValue;
        private System.Windows.Forms.TextBox textBoxBaseUrl;
        private System.Windows.Forms.Label labelBaseUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

