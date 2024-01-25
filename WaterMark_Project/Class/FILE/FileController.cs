using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using WaterMark_Project.Class.GLOBAL;
namespace WaterMark_Project.Class.FILE
{
    class FileController
    {
        internal static void GetFileName(String _path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(_path);
                FileInfo[] dirArr = di.GetFiles();
                foreach (FileInfo file in dirArr)
                {
                    GlobalVariable.ListFile.Add(file.Name);
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
