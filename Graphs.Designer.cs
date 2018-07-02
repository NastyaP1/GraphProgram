namespace FirstGraphsProgram
{
    partial class Graphs
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddAnEdgeRBtn = new System.Windows.Forms.RadioButton();
            this.FindANodeBtn = new System.Windows.Forms.Button();
            this.AddANewNodeRBtn = new System.Windows.Forms.RadioButton();
            this.ChooseGB = new System.Windows.Forms.GroupBox();
            this.ChooseFriendRBtn = new System.Windows.Forms.RadioButton();
            this.ClearTwoNodesRBtn = new System.Windows.Forms.RadioButton();
            this.ChooseTwoNodesRBtn = new System.Windows.Forms.RadioButton();
            this.GetN1TB = new System.Windows.Forms.TextBox();
            this.GetN2TB = new System.Windows.Forms.TextBox();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.SaveFileBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteEdgeBtn = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.DeleteNodeBtn = new System.Windows.Forms.Button();
            this.ToolsGB = new System.Windows.Forms.GroupBox();
            this.FindAGroupBtn = new System.Windows.Forms.Button();
            this.GamiltonBtn = new System.Windows.Forms.Button();
            this.ChooseGB.SuspendLayout();
            this.ToolsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddAnEdgeRBtn
            // 
            this.AddAnEdgeRBtn.AutoSize = true;
            this.AddAnEdgeRBtn.Location = new System.Drawing.Point(6, 65);
            this.AddAnEdgeRBtn.Name = "AddAnEdgeRBtn";
            this.AddAnEdgeRBtn.Size = new System.Drawing.Size(165, 29);
            this.AddAnEdgeRBtn.TabIndex = 0;
            this.AddAnEdgeRBtn.TabStop = true;
            this.AddAnEdgeRBtn.Text = "Add an edge";
            this.AddAnEdgeRBtn.UseVisualStyleBackColor = true;
            // 
            // FindANodeBtn
            // 
            this.FindANodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FindANodeBtn.ForeColor = System.Drawing.Color.White;
            this.FindANodeBtn.Location = new System.Drawing.Point(747, 20);
            this.FindANodeBtn.Name = "FindANodeBtn";
            this.FindANodeBtn.Size = new System.Drawing.Size(143, 59);
            this.FindANodeBtn.TabIndex = 2;
            this.FindANodeBtn.Text = "Find a node";
            this.FindANodeBtn.UseVisualStyleBackColor = false;
            this.FindANodeBtn.Click += new System.EventHandler(this.FindANodeBtn_Click);
            // 
            // AddANewNodeRBtn
            // 
            this.AddANewNodeRBtn.AutoSize = true;
            this.AddANewNodeRBtn.Location = new System.Drawing.Point(6, 30);
            this.AddANewNodeRBtn.Name = "AddANewNodeRBtn";
            this.AddANewNodeRBtn.Size = new System.Drawing.Size(165, 29);
            this.AddANewNodeRBtn.TabIndex = 3;
            this.AddANewNodeRBtn.TabStop = true;
            this.AddANewNodeRBtn.Text = "Add an node";
            this.AddANewNodeRBtn.UseVisualStyleBackColor = true;
            // 
            // ChooseGB
            // 
            this.ChooseGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ChooseGB.Controls.Add(this.ChooseFriendRBtn);
            this.ChooseGB.Controls.Add(this.ClearTwoNodesRBtn);
            this.ChooseGB.Controls.Add(this.ChooseTwoNodesRBtn);
            this.ChooseGB.Controls.Add(this.AddANewNodeRBtn);
            this.ChooseGB.Controls.Add(this.AddAnEdgeRBtn);
            this.ChooseGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChooseGB.Location = new System.Drawing.Point(15, 20);
            this.ChooseGB.Name = "ChooseGB";
            this.ChooseGB.Size = new System.Drawing.Size(560, 158);
            this.ChooseGB.TabIndex = 4;
            this.ChooseGB.TabStop = false;
            this.ChooseGB.Text = "Choose";
            // 
            // ChooseFriendRBtn
            // 
            this.ChooseFriendRBtn.AutoSize = true;
            this.ChooseFriendRBtn.Location = new System.Drawing.Point(356, 65);
            this.ChooseFriendRBtn.Name = "ChooseFriendRBtn";
            this.ChooseFriendRBtn.Size = new System.Drawing.Size(188, 29);
            this.ChooseFriendRBtn.TabIndex = 9;
            this.ChooseFriendRBtn.TabStop = true;
            this.ChooseFriendRBtn.Text = "Choose friends";
            this.ChooseFriendRBtn.UseVisualStyleBackColor = true;
            // 
            // ClearTwoNodesRBtn
            // 
            this.ClearTwoNodesRBtn.AutoSize = true;
            this.ClearTwoNodesRBtn.Location = new System.Drawing.Point(177, 30);
            this.ClearTwoNodesRBtn.Name = "ClearTwoNodesRBtn";
            this.ClearTwoNodesRBtn.Size = new System.Drawing.Size(159, 29);
            this.ClearTwoNodesRBtn.TabIndex = 7;
            this.ClearTwoNodesRBtn.TabStop = true;
            this.ClearTwoNodesRBtn.Text = "Clear nodes";
            this.ClearTwoNodesRBtn.UseVisualStyleBackColor = true;
            // 
            // ChooseTwoNodesRBtn
            // 
            this.ChooseTwoNodesRBtn.AutoSize = true;
            this.ChooseTwoNodesRBtn.Location = new System.Drawing.Point(356, 30);
            this.ChooseTwoNodesRBtn.Name = "ChooseTwoNodesRBtn";
            this.ChooseTwoNodesRBtn.Size = new System.Drawing.Size(182, 29);
            this.ChooseTwoNodesRBtn.TabIndex = 5;
            this.ChooseTwoNodesRBtn.TabStop = true;
            this.ChooseTwoNodesRBtn.Text = "Choose nodes";
            this.ChooseTwoNodesRBtn.UseVisualStyleBackColor = true;
            // 
            // GetN1TB
            // 
            this.GetN1TB.Location = new System.Drawing.Point(1042, 77);
            this.GetN1TB.Multiline = true;
            this.GetN1TB.Name = "GetN1TB";
            this.GetN1TB.Size = new System.Drawing.Size(71, 67);
            this.GetN1TB.TabIndex = 5;
            this.GetN1TB.Text = "1";
            // 
            // GetN2TB
            // 
            this.GetN2TB.Location = new System.Drawing.Point(1135, 77);
            this.GetN2TB.Multiline = true;
            this.GetN2TB.Name = "GetN2TB";
            this.GetN2TB.Size = new System.Drawing.Size(66, 67);
            this.GetN2TB.TabIndex = 6;
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OpenFileBtn.ForeColor = System.Drawing.Color.White;
            this.OpenFileBtn.Location = new System.Drawing.Point(589, 85);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(139, 59);
            this.OpenFileBtn.TabIndex = 7;
            this.OpenFileBtn.Text = "Open file";
            this.OpenFileBtn.UseVisualStyleBackColor = false;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SaveFileBtn.ForeColor = System.Drawing.Color.White;
            this.SaveFileBtn.Location = new System.Drawing.Point(589, 20);
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(139, 59);
            this.SaveFileBtn.TabIndex = 8;
            this.SaveFileBtn.Text = "Save to file";
            this.SaveFileBtn.UseVisualStyleBackColor = false;
            this.SaveFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(1274, 157);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(143, 59);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click_1);
            // 
            // DeleteEdgeBtn
            // 
            this.DeleteEdgeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteEdgeBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteEdgeBtn.Location = new System.Drawing.Point(1285, 85);
            this.DeleteEdgeBtn.Name = "DeleteEdgeBtn";
            this.DeleteEdgeBtn.Size = new System.Drawing.Size(117, 66);
            this.DeleteEdgeBtn.TabIndex = 10;
            this.DeleteEdgeBtn.Text = "Delete an edge";
            this.DeleteEdgeBtn.UseVisualStyleBackColor = false;
            this.DeleteEdgeBtn.Click += new System.EventHandler(this.DeleteEdgeBtn_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // DeleteNodeBtn
            // 
            this.DeleteNodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteNodeBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteNodeBtn.Location = new System.Drawing.Point(1285, 20);
            this.DeleteNodeBtn.Name = "DeleteNodeBtn";
            this.DeleteNodeBtn.Size = new System.Drawing.Size(117, 66);
            this.DeleteNodeBtn.TabIndex = 11;
            this.DeleteNodeBtn.Text = "Delete an node";
            this.DeleteNodeBtn.UseVisualStyleBackColor = false;
            this.DeleteNodeBtn.Click += new System.EventHandler(this.DeleteNodeBtn_Click);
            // 
            // ToolsGB
            // 
            this.ToolsGB.Controls.Add(this.FindAGroupBtn);
            this.ToolsGB.Controls.Add(this.GamiltonBtn);
            this.ToolsGB.Controls.Add(this.ChooseGB);
            this.ToolsGB.Controls.Add(this.DeleteNodeBtn);
            this.ToolsGB.Controls.Add(this.SaveFileBtn);
            this.ToolsGB.Controls.Add(this.DeleteEdgeBtn);
            this.ToolsGB.Controls.Add(this.OpenFileBtn);
            this.ToolsGB.Controls.Add(this.GetN2TB);
            this.ToolsGB.Controls.Add(this.ClearBtn);
            this.ToolsGB.Controls.Add(this.GetN1TB);
            this.ToolsGB.Controls.Add(this.FindANodeBtn);
            this.ToolsGB.Location = new System.Drawing.Point(4, 2);
            this.ToolsGB.Name = "ToolsGB";
            this.ToolsGB.Size = new System.Drawing.Size(1494, 216);
            this.ToolsGB.TabIndex = 12;
            this.ToolsGB.TabStop = false;
            // 
            // FindAGroupBtn
            // 
            this.FindAGroupBtn.Location = new System.Drawing.Point(890, 129);
            this.FindAGroupBtn.Name = "FindAGroupBtn";
            this.FindAGroupBtn.Size = new System.Drawing.Size(133, 78);
            this.FindAGroupBtn.TabIndex = 13;
            this.FindAGroupBtn.Text = "Find a group";
            this.FindAGroupBtn.UseVisualStyleBackColor = true;
            this.FindAGroupBtn.Click += new System.EventHandler(this.FindAGroupBtn_Click);
            // 
            // GamiltonBtn
            // 
            this.GamiltonBtn.Location = new System.Drawing.Point(725, 129);
            this.GamiltonBtn.Name = "GamiltonBtn";
            this.GamiltonBtn.Size = new System.Drawing.Size(149, 78);
            this.GamiltonBtn.TabIndex = 13;
            this.GamiltonBtn.Text = "Find a way";
            this.GamiltonBtn.UseVisualStyleBackColor = true;
            this.GamiltonBtn.Click += new System.EventHandler(this.GamiltonBtn_Click);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 607);
            this.Controls.Add(this.ToolsGB);
            this.Name = "Graphs";
            this.Text = "Graphs";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Graphs_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Graphs_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Graphs_MouseUp);
            this.ChooseGB.ResumeLayout(false);
            this.ChooseGB.PerformLayout();
            this.ToolsGB.ResumeLayout(false);
            this.ToolsGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton AddAnEdgeRBtn;
        private System.Windows.Forms.Button FindANodeBtn;
        private System.Windows.Forms.RadioButton AddANewNodeRBtn;
        private System.Windows.Forms.GroupBox ChooseGB;
        private System.Windows.Forms.TextBox GetN1TB;
        private System.Windows.Forms.TextBox GetN2TB;
        private System.Windows.Forms.RadioButton ClearTwoNodesRBtn;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Button SaveFileBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteEdgeBtn;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button DeleteNodeBtn;
        private System.Windows.Forms.RadioButton ChooseFriendRBtn;
        private System.Windows.Forms.GroupBox ToolsGB;
        private System.Windows.Forms.Button GamiltonBtn;
        private System.Windows.Forms.Button FindAGroupBtn;
        private System.Windows.Forms.RadioButton ChooseTwoNodesRBtn;
    }
}

