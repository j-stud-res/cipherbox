using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cipherBox.ToolsForms
{
    public partial class CaeserForm : Form
    {
        public CaeserForm()
        {
            InitializeComponent();
            this.EnableInputFields(false);
        }

        private void AlphaAsciSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox s = (ComboBox)sender;
            if ((string)s.SelectedItem == "Alphabet")
            {
                this.LangTableOptionLable.Text = "Language: ";
                this.Caeser.InstanceMode = Tools.Caeser.Mode.LANG;
                this.EncodingTableSelect.Visible = false;
                this.LangSelect.Visible = true;
                this.LangSelect.SelectedIndex = 0;
            } else
            {
                this.LangTableOptionLable.Text = "Table: ";
                this.Caeser.InstanceMode = Tools.Caeser.Mode.TABLE;
                this.LangSelect.Visible = false;
                this.EncodingTableSelect.Visible = true;
                this.EncodingTableSelect.SelectedIndex = 0;
            }
            this.LangTableOptionLable.Visible = true;
            if (!this.inputFieldsState)
            {
                this.EnableInputFields(true);
            }
        }

        private void CaeserModeOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (ComboBox)sender;
            switch((string)s.SelectedItem)
            {
                case "English":
                    this.Caeser.InstanceModeOption = Tools.Caeser.ModeOption.ENG;
                    break;
                case "Bulgarian":
                    this.Caeser.InstanceModeOption = Tools.Caeser.ModeOption.BG;
                    break;
                case "ASCII":
                    this.Caeser.InstanceModeOption = Tools.Caeser.ModeOption.ASCII;
                    break;
                case "chcp 1251":
                    this.Caeser.InstanceModeOption = Tools.Caeser.ModeOption.CHCP1251;
                    break;
            }
        }

        private void EnableInputFields(bool state)
        {
            this.EncodeButton.Enabled = state;
            this.DecodeButton.Enabled = state;
            this.BruteForceButton.Enabled = state;
            this.InitialTextBox.Enabled = state;
            this.ResultTextBox.Enabled = state;
            this.inputFieldsState = state;

        }

        private void SetCaeserShift()
        {
            this.Caeser.Shift = (int)this.ShiftByNumUpDown.Value;
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            this.SetCaeserShift();
            string text = this.InitialTextBox.Text;
            this.ResultTextBox.Text = this.Caeser.Decode(text);
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            this.SetCaeserShift();
            string text = this.InitialTextBox.Text;
            this.ResultTextBox.Text = this.Caeser.Encode(text);
        }

        private void BruteForceButton_Click(object sender, EventArgs e)
        {
            this.SetCaeserShift();
            string text = this.InitialTextBox.Text;
            var result = this.Caeser.BruteForce(text);
            // do something to show results;
        }
    }
}
