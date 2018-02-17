
namespace cipherBox.ToolsForms
{
    using Tools;
    partial class CaeserForm
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

        private Caeser Caeser = new Caeser();
        private bool inputFieldsState;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CaeserFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.ShiftByNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.ShiftLabel = new System.Windows.Forms.Label();
            this.EncodingTableSelect = new System.Windows.Forms.ComboBox();
            this.LangTableOptionLable = new System.Windows.Forms.Label();
            this.CharsOptionLabel = new System.Windows.Forms.Label();
            this.LangSelect = new System.Windows.Forms.ComboBox();
            this.AlphaAsciSelect = new System.Windows.Forms.ComboBox();
            this.InitialTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BruteForceButton = new System.Windows.Forms.Button();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.CaeserFlowLayoutPanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftByNumUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaeserFlowLayoutPanel
            // 
            this.CaeserFlowLayoutPanel.Controls.Add(this.OptionsPanel);
            this.CaeserFlowLayoutPanel.Controls.Add(this.InitialTextBox);
            this.CaeserFlowLayoutPanel.Controls.Add(this.panel1);
            this.CaeserFlowLayoutPanel.Controls.Add(this.ResultTextBox);
            this.CaeserFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaeserFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CaeserFlowLayoutPanel.Name = "CaeserFlowLayoutPanel";
            this.CaeserFlowLayoutPanel.Size = new System.Drawing.Size(1093, 527);
            this.CaeserFlowLayoutPanel.TabIndex = 1;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Controls.Add(this.ShiftByNumUpDown);
            this.OptionsPanel.Controls.Add(this.ShiftLabel);
            this.OptionsPanel.Controls.Add(this.EncodingTableSelect);
            this.OptionsPanel.Controls.Add(this.LangTableOptionLable);
            this.OptionsPanel.Controls.Add(this.CharsOptionLabel);
            this.OptionsPanel.Controls.Add(this.LangSelect);
            this.OptionsPanel.Controls.Add(this.AlphaAsciSelect);
            this.OptionsPanel.Location = new System.Drawing.Point(3, 3);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(1090, 47);
            this.OptionsPanel.TabIndex = 6;
            // 
            // ShiftByNumUpDown
            // 
            this.ShiftByNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftByNumUpDown.InterceptArrowKeys = false;
            this.ShiftByNumUpDown.Location = new System.Drawing.Point(798, 9);
            this.ShiftByNumUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ShiftByNumUpDown.Name = "ShiftByNumUpDown";
            this.ShiftByNumUpDown.Size = new System.Drawing.Size(86, 24);
            this.ShiftByNumUpDown.TabIndex = 7;
            this.ShiftByNumUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.AutoSize = true;
            this.ShiftLabel.Location = new System.Drawing.Point(756, 12);
            this.ShiftLabel.Name = "ShiftLabel";
            this.ShiftLabel.Size = new System.Drawing.Size(36, 17);
            this.ShiftLabel.TabIndex = 6;
            this.ShiftLabel.Text = "Shift";
            // 
            // EncodingTableSelect
            // 
            this.EncodingTableSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingTableSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncodingTableSelect.FormattingEnabled = true;
            this.EncodingTableSelect.Items.AddRange(new object[] {
            "ASCII",
            "chcp 1251"});
            this.EncodingTableSelect.Location = new System.Drawing.Point(523, 9);
            this.EncodingTableSelect.Name = "EncodingTableSelect";
            this.EncodingTableSelect.Size = new System.Drawing.Size(121, 24);
            this.EncodingTableSelect.TabIndex = 4;
            this.EncodingTableSelect.Visible = false;
            this.EncodingTableSelect.SelectedIndexChanged += new System.EventHandler(this.CaeserModeOption_SelectedIndexChanged);
            // 
            // LangTableOptionLable
            // 
            this.LangTableOptionLable.AutoSize = true;
            this.LangTableOptionLable.Location = new System.Drawing.Point(424, 12);
            this.LangTableOptionLable.Name = "LangTableOptionLable";
            this.LangTableOptionLable.Size = new System.Drawing.Size(72, 17);
            this.LangTableOptionLable.TabIndex = 3;
            this.LangTableOptionLable.Text = "Language";
            this.LangTableOptionLable.Visible = false;
            // 
            // CharsOptionLabel
            // 
            this.CharsOptionLabel.AutoSize = true;
            this.CharsOptionLabel.Location = new System.Drawing.Point(72, 12);
            this.CharsOptionLabel.Name = "CharsOptionLabel";
            this.CharsOptionLabel.Size = new System.Drawing.Size(104, 17);
            this.CharsOptionLabel.TabIndex = 2;
            this.CharsOptionLabel.Text = "Use chars from";
            // 
            // LangSelect
            // 
            this.LangSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LangSelect.FormattingEnabled = true;
            this.LangSelect.Items.AddRange(new object[] {
            "English",
            "Bulgarian"});
            this.LangSelect.Location = new System.Drawing.Point(523, 9);
            this.LangSelect.Name = "LangSelect";
            this.LangSelect.Size = new System.Drawing.Size(121, 24);
            this.LangSelect.TabIndex = 1;
            this.LangSelect.Visible = false;
            this.LangSelect.SelectedIndexChanged += new System.EventHandler(this.CaeserModeOption_SelectedIndexChanged);
            // 
            // AlphaAsciSelect
            // 
            this.AlphaAsciSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlphaAsciSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AlphaAsciSelect.FormattingEnabled = true;
            this.AlphaAsciSelect.Items.AddRange(new object[] {
            "Alphabet",
            "Encoding Table"});
            this.AlphaAsciSelect.Location = new System.Drawing.Point(191, 9);
            this.AlphaAsciSelect.Name = "AlphaAsciSelect";
            this.AlphaAsciSelect.Size = new System.Drawing.Size(121, 24);
            this.AlphaAsciSelect.TabIndex = 0;
            this.AlphaAsciSelect.SelectedIndexChanged += new System.EventHandler(this.AlphaAsciSelect_SelectedIndexChanged);
            // 
            // InitialTextBox
            // 
            this.InitialTextBox.Location = new System.Drawing.Point(3, 56);
            this.InitialTextBox.Multiline = true;
            this.InitialTextBox.Name = "InitialTextBox";
            this.InitialTextBox.Size = new System.Drawing.Size(1090, 131);
            this.InitialTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BruteForceButton);
            this.panel1.Controls.Add(this.EncodeButton);
            this.panel1.Controls.Add(this.DecodeButton);
            this.panel1.Location = new System.Drawing.Point(3, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 47);
            this.panel1.TabIndex = 5;
            // 
            // BruteForceButton
            // 
            this.BruteForceButton.BackColor = System.Drawing.Color.Lime;
            this.BruteForceButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BruteForceButton.Location = new System.Drawing.Point(976, 0);
            this.BruteForceButton.Name = "BruteForceButton";
            this.BruteForceButton.Size = new System.Drawing.Size(114, 47);
            this.BruteForceButton.TabIndex = 4;
            this.BruteForceButton.Text = "Brute Force";
            this.BruteForceButton.UseVisualStyleBackColor = false;
            this.BruteForceButton.Click += new System.EventHandler(this.BruteForceButton_Click);
            // 
            // EncodeButton
            // 
            this.EncodeButton.BackColor = System.Drawing.Color.Lime;
            this.EncodeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.EncodeButton.Location = new System.Drawing.Point(89, 0);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(87, 47);
            this.EncodeButton.TabIndex = 2;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = false;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.BackColor = System.Drawing.Color.Lime;
            this.DecodeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.DecodeButton.Location = new System.Drawing.Point(0, 0);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(89, 47);
            this.DecodeButton.TabIndex = 3;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = false;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(3, 246);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(1090, 131);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "Result";
            // 
            // CaeserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 527);
            this.Controls.Add(this.CaeserFlowLayoutPanel);
            this.Name = "CaeserForm";
            this.Text = "Caeser";
            this.CaeserFlowLayoutPanel.ResumeLayout(false);
            this.CaeserFlowLayoutPanel.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftByNumUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CaeserFlowLayoutPanel;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.ComboBox LangSelect;
        private System.Windows.Forms.ComboBox AlphaAsciSelect;
        private System.Windows.Forms.TextBox InitialTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BruteForceButton;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label CharsOptionLabel;
        private System.Windows.Forms.Label LangTableOptionLable;
        private System.Windows.Forms.ComboBox EncodingTableSelect;
        private System.Windows.Forms.Label ShiftLabel;
        private System.Windows.Forms.NumericUpDown ShiftByNumUpDown;
    }
}