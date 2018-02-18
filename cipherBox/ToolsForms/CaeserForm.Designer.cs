
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
            this.LanguageLable = new System.Windows.Forms.Label();
            this.LangSelect = new System.Windows.Forms.ComboBox();
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
            this.CaeserFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CaeserFlowLayoutPanel.Name = "CaeserFlowLayoutPanel";
            this.CaeserFlowLayoutPanel.Size = new System.Drawing.Size(820, 428);
            this.CaeserFlowLayoutPanel.TabIndex = 1;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Controls.Add(this.ShiftByNumUpDown);
            this.OptionsPanel.Controls.Add(this.ShiftLabel);
            this.OptionsPanel.Controls.Add(this.LanguageLable);
            this.OptionsPanel.Controls.Add(this.LangSelect);
            this.OptionsPanel.Location = new System.Drawing.Point(2, 2);
            this.OptionsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(818, 38);
            this.OptionsPanel.TabIndex = 6;
            // 
            // ShiftByNumUpDown
            // 
            this.ShiftByNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftByNumUpDown.InterceptArrowKeys = false;
            this.ShiftByNumUpDown.Location = new System.Drawing.Point(497, 7);
            this.ShiftByNumUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.ShiftByNumUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ShiftByNumUpDown.Name = "ShiftByNumUpDown";
            this.ShiftByNumUpDown.Size = new System.Drawing.Size(64, 21);
            this.ShiftByNumUpDown.TabIndex = 7;
            this.ShiftByNumUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ShiftByNumUpDown.ValueChanged += new System.EventHandler(this.ShiftByNumUpDown_ValueChanged);
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.AutoSize = true;
            this.ShiftLabel.Location = new System.Drawing.Point(441, 11);
            this.ShiftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShiftLabel.Name = "ShiftLabel";
            this.ShiftLabel.Size = new System.Drawing.Size(28, 13);
            this.ShiftLabel.TabIndex = 6;
            this.ShiftLabel.Text = "Shift";
            // 
            // LanguageLable
            // 
            this.LanguageLable.AutoSize = true;
            this.LanguageLable.Location = new System.Drawing.Point(143, 10);
            this.LanguageLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LanguageLable.Name = "LanguageLable";
            this.LanguageLable.Size = new System.Drawing.Size(55, 13);
            this.LanguageLable.TabIndex = 3;
            this.LanguageLable.Text = "Language";
            this.LanguageLable.Visible = false;
            // 
            // LangSelect
            // 
            this.LangSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LangSelect.FormattingEnabled = true;
            this.LangSelect.Items.AddRange(new object[] {
            "English",
            "Bulgarian"});
            this.LangSelect.Location = new System.Drawing.Point(213, 7);
            this.LangSelect.Margin = new System.Windows.Forms.Padding(2);
            this.LangSelect.Name = "LangSelect";
            this.LangSelect.Size = new System.Drawing.Size(92, 21);
            this.LangSelect.TabIndex = 1;
            this.LangSelect.SelectedIndexChanged += new System.EventHandler(this.LangSelect_SelectedIndexChanged);
            // 
            // InitialTextBox
            // 
            this.InitialTextBox.Location = new System.Drawing.Point(2, 44);
            this.InitialTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.InitialTextBox.Multiline = true;
            this.InitialTextBox.Name = "InitialTextBox";
            this.InitialTextBox.Size = new System.Drawing.Size(818, 147);
            this.InitialTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BruteForceButton);
            this.panel1.Controls.Add(this.EncodeButton);
            this.panel1.Controls.Add(this.DecodeButton);
            this.panel1.Location = new System.Drawing.Point(2, 195);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 38);
            this.panel1.TabIndex = 5;
            // 
            // BruteForceButton
            // 
            this.BruteForceButton.BackColor = System.Drawing.Color.Lime;
            this.BruteForceButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BruteForceButton.Location = new System.Drawing.Point(732, 0);
            this.BruteForceButton.Margin = new System.Windows.Forms.Padding(2);
            this.BruteForceButton.Name = "BruteForceButton";
            this.BruteForceButton.Size = new System.Drawing.Size(86, 38);
            this.BruteForceButton.TabIndex = 4;
            this.BruteForceButton.Text = "Brute Force";
            this.BruteForceButton.UseVisualStyleBackColor = false;
            this.BruteForceButton.Click += new System.EventHandler(this.BruteForceButton_Click);
            // 
            // EncodeButton
            // 
            this.EncodeButton.BackColor = System.Drawing.Color.Lime;
            this.EncodeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.EncodeButton.Location = new System.Drawing.Point(67, 0);
            this.EncodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(65, 38);
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
            this.DecodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(67, 38);
            this.DecodeButton.TabIndex = 3;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = false;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(2, 237);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(818, 162);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "Result";
            // 
            // CaeserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 428);
            this.Controls.Add(this.CaeserFlowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox InitialTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BruteForceButton;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label LanguageLable;
        private System.Windows.Forms.Label ShiftLabel;
        private System.Windows.Forms.NumericUpDown ShiftByNumUpDown;
    }
}