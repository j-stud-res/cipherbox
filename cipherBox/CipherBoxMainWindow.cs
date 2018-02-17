using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cipherBox.Tools;

namespace cipherBox
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void ToolsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox s = (ListBox)sender;
            switch((string)s.SelectedItem)
            {
                case "Caeser":
                    this.CurrentlyVisibleMainPanel = this.CaeserPanel;
                    this.CaeserPanel.Visible = true;
                    break;
                default:
                    if (this.CurrentlyVisibleMainPanel != null)
                    {
                        this.CurrentlyVisibleMainPanel.Visible = false;
                    }
                    break;
            }
        }

        private void CaeserUseButton_Click(object sender, EventArgs e)
        {
            new cipherBox.ToolsForms.CaeserForm().Show();
        }
    }
}
