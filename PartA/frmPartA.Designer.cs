namespace PartA
{
    partial class frmPartA
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(41, 106);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(221, 26);
            this.txtInput.TabIndex = 0;
            // 
            // btnPush
            // 
            this.btnPush.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.Location = new System.Drawing.Point(41, 165);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(97, 38);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.Location = new System.Drawing.Point(165, 165);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(97, 38);
            this.btnPop.TabIndex = 2;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(346, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(229, 426);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // frmPartA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtInput);
            this.Name = "frmPartA";
            this.Text = "Part A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

