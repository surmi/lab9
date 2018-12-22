using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        //public delegate void ReturnResult(string text);
        //ReturnResult showResults;
        Action<String> showResults;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dialogCheckBox.Checked && !goButton.Enabled)
            {
                goButton.Enabled = true;
                showResults += Output.ShowDialogBox;

            }
            else if (dialogCheckBox.Checked)
            {
                showResults += Output.ShowDialogBox;
            }
            else if (!dialogCheckBox.Checked && goButton.Enabled)
            {
                if(!fileCHeckBox.Checked)
                {
                    goButton.Enabled = false;
                }
                showResults -= Output.ShowDialogBox;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showResults("string");
        }

        private void fileCHeckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(fileCHeckBox.Checked && !goButton.Enabled)
            {
                goButton.Enabled = true;
                showResults += Output.SaveToFile;
            }
            else if (fileCHeckBox.Checked)
            {
                showResults += Output.SaveToFile;
            }
            else if(!fileCHeckBox.Checked && goButton.Enabled)
            {
                if(!dialogCheckBox.Checked)
                {
                    goButton.Enabled = false;
                }
                showResults -= Output.SaveToFile;
            }

        }
    }
}
