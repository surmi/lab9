using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    class Output
    {

        static public void ShowDialogBox(String s)
        {
            MessageBox.Show(s);
        }

        static public void SaveToFile(String s)
        {
            StreamWriter sw = null;
            try
            {
                using (sw = File.AppendText("results.txt"))
                {
                    sw.WriteLine(s);
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
