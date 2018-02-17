namespace cipherBox
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ToolsListBox = new System.Windows.Forms.ListBox();
            this.ToolsLable = new System.Windows.Forms.Label();
            this.CaeserPanel = new System.Windows.Forms.Panel();
            this.CaeserUseButton = new System.Windows.Forms.Button();
            this.CaeserHeaderLinkLable = new System.Windows.Forms.LinkLabel();
            this.CaeserDescriptionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CaeserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ToolsListBox);
            this.splitContainer1.Panel1.Controls.Add(this.ToolsLable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.CaeserPanel);
            this.splitContainer1.Size = new System.Drawing.Size(901, 522);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // ToolsListBox
            // 
            this.ToolsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsListBox.FormattingEnabled = true;
            this.ToolsListBox.ItemHeight = 20;
            this.ToolsListBox.Items.AddRange(new object[] {
            "Caeser",
            "Bill"});
            this.ToolsListBox.Location = new System.Drawing.Point(0, 24);
            this.ToolsListBox.Name = "ToolsListBox";
            this.ToolsListBox.Size = new System.Drawing.Size(300, 498);
            this.ToolsListBox.TabIndex = 1;
            this.ToolsListBox.SelectedIndexChanged += new System.EventHandler(this.ToolsListBox_SelectedIndexChanged);
            // 
            // ToolsLable
            // 
            this.ToolsLable.BackColor = System.Drawing.Color.Lime;
            this.ToolsLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ToolsLable.Location = new System.Drawing.Point(0, 0);
            this.ToolsLable.Name = "ToolsLable";
            this.ToolsLable.Size = new System.Drawing.Size(300, 24);
            this.ToolsLable.TabIndex = 0;
            this.ToolsLable.Text = "Tools";
            this.ToolsLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CaeserPanel
            // 
            this.CaeserPanel.Controls.Add(this.CaeserUseButton);
            this.CaeserPanel.Controls.Add(this.CaeserHeaderLinkLable);
            this.CaeserPanel.Controls.Add(this.CaeserDescriptionTextBox);
            this.CaeserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaeserPanel.Location = new System.Drawing.Point(0, 0);
            this.CaeserPanel.Name = "CaeserPanel";
            this.CaeserPanel.Size = new System.Drawing.Size(597, 522);
            this.CaeserPanel.TabIndex = 0;
            this.CaeserPanel.Visible = false;
            // 
            // CaeserUseButton
            // 
            this.CaeserUseButton.Location = new System.Drawing.Point(456, 467);
            this.CaeserUseButton.Name = "CaeserUseButton";
            this.CaeserUseButton.Size = new System.Drawing.Size(129, 43);
            this.CaeserUseButton.TabIndex = 2;
            this.CaeserUseButton.Text = "Use Tool";
            this.CaeserUseButton.UseVisualStyleBackColor = true;
            this.CaeserUseButton.Click += new System.EventHandler(this.CaeserUseButton_Click);
            // 
            // CaeserHeaderLinkLable
            // 
            this.CaeserHeaderLinkLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaeserHeaderLinkLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaeserHeaderLinkLable.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.CaeserHeaderLinkLable.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CaeserHeaderLinkLable.Location = new System.Drawing.Point(0, 0);
            this.CaeserHeaderLinkLable.Name = "CaeserHeaderLinkLable";
            this.CaeserHeaderLinkLable.Size = new System.Drawing.Size(597, 59);
            this.CaeserHeaderLinkLable.TabIndex = 1;
            this.CaeserHeaderLinkLable.TabStop = true;
            this.CaeserHeaderLinkLable.Text = "Caeser Cipher";
            this.CaeserHeaderLinkLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CaeserDescriptionTextBox
            // 
            this.CaeserDescriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CaeserDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaeserDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CaeserDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaeserDescriptionTextBox.Location = new System.Drawing.Point(10, 166);
            this.CaeserDescriptionTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.CaeserDescriptionTextBox.Multiline = true;
            this.CaeserDescriptionTextBox.Name = "CaeserDescriptionTextBox";
            this.CaeserDescriptionTextBox.ReadOnly = true;
            this.CaeserDescriptionTextBox.Size = new System.Drawing.Size(575, 183);
            this.CaeserDescriptionTextBox.TabIndex = 0;
            this.CaeserDescriptionTextBox.Text = resources.GetString("CaeserDescriptionTextBox.Text");
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 522);
            this.Controls.Add(this.splitContainer1);
            this.Name = "mainWindow";
            this.Text = "Cipher Box";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CaeserPanel.ResumeLayout(false);
            this.CaeserPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ToolsLable;
        //Caeser Panel Data
        private System.Windows.Forms.Panel CaeserPanel;
        private System.Windows.Forms.Button CaeserUseButton;
        private System.Windows.Forms.LinkLabel CaeserHeaderLinkLable;
        private System.Windows.Forms.TextBox CaeserDescriptionTextBox;
        private System.Windows.Forms.ListBox ToolsListBox;


        private System.Windows.Forms.Panel CurrentlyVisibleMainPanel;
    }
}

