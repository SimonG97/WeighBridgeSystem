using System;
using System.IO;
using System.Windows.Forms;

namespace equiscale
{
    public class Helper
    {
        public static void ClearFormControls(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Text = string.Empty;
                }
                
            }
        }
        public static void ReadOnly(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Enabled = false;
                }

            }
        }
        public static void Open(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Enabled = true;
                }

            }
        }
        //Backup database
        public static void BackUpDb(string filePath, string srcFileName, string destFileName) {
            var srcfile = Path.Combine(filePath, srcFileName);
            var destfile = Path.Combine(filePath,destFileName);
            if (File.Exists(destfile)) {
                File.Delete(destfile);
                }
                    
            File.Copy(srcfile, destfile);
        }

        //Restore database
        public static void RestoreDB(string filePath, string srcFilename, string destFileName, bool IsCopy = false)
        {
            var srcfile = Path.Combine(filePath, srcFilename);
            var destfile = Path.Combine(filePath, destFileName);

            if (File.Exists(destfile)) File.Delete(destfile);
            if (IsCopy)
                BackUpDb(filePath, srcFilename, destFileName);
            else
                File.Move(srcfile, destfile);
        }
    }
}