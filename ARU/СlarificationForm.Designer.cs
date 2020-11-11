namespace ARU
{
    partial class СlarificationForm
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
            this.txtClarificationOrder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtClarificationOrder
            // 
            this.txtClarificationOrder.Location = new System.Drawing.Point(12, 12);
            this.txtClarificationOrder.Multiline = true;
            this.txtClarificationOrder.Name = "txtClarificationOrder";
            this.txtClarificationOrder.Size = new System.Drawing.Size(438, 426);
            this.txtClarificationOrder.TabIndex = 0;
            // 
            // СlarificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.txtClarificationOrder);
            this.Name = "СlarificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СlarificationForm";
            this.Load += new System.EventHandler(this.СlarificationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClarificationOrder;
    }
}