namespace FirstGraphsProgram
{
    partial class GiveNames
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.NamesLB = new System.Windows.Forms.Label();
            this.NamesTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(258, 64);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(126, 45);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Location = new System.Drawing.Point(33, 64);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 45);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            // 
            // NamesLB
            // 
            this.NamesLB.AutoSize = true;
            this.NamesLB.Location = new System.Drawing.Point(12, 19);
            this.NamesLB.Name = "NamesLB";
            this.NamesLB.Size = new System.Drawing.Size(133, 25);
            this.NamesLB.TabIndex = 2;
            this.NamesLB.Text = "Give a name";
            // 
            // NamesTB
            // 
            this.NamesTB.Location = new System.Drawing.Point(186, 12);
            this.NamesTB.Multiline = true;
            this.NamesTB.Name = "NamesTB";
            this.NamesTB.Size = new System.Drawing.Size(287, 40);
            this.NamesTB.TabIndex = 3;
            // 
            // GiveNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 121);
            this.Controls.Add(this.NamesTB);
            this.Controls.Add(this.NamesLB);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CancelBtn);
            this.Name = "GiveNames";
            this.Text = "GiveNames";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GiveNames_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GiveNames_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label NamesLB;
        private System.Windows.Forms.TextBox NamesTB;
    }
}