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
            this.InitializeForm();
        }

        private void LangSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (ComboBox)sender;
            switch((string)s.SelectedItem)
            {
                case "English":
                    this.Caeser.InstanceLang = Tools.Caeser.Lang.ENG;
                    break;
                case "Bulgarian":
                    this.Caeser.InstanceLang = Tools.Caeser.Lang.BG;
                    break;
            }
        }

        private void InitializeForm()
        {
            this.LangSelect.SelectedIndex = 0;

        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            string text = this.InitialTextBox.Text;
            this.ResultTextBox.Text = this.Caeser.Decode(text);
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            string text = this.InitialTextBox.Text;
            this.ResultTextBox.Text = this.Caeser.Encode(text);
        }

        private void BruteForceButton_Click(object sender, EventArgs e)
        {
            string text = this.InitialTextBox.Text;
            var result = this.Caeser.BruteForce(text);
            this.ResultTextBox.Text = string.Join(Environment.NewLine, result);
        }

        private void ShiftByNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            var s = (NumericUpDown)sender;
            this.Caeser.Shift = (UInt16)s.Value;
        }
    }
}
