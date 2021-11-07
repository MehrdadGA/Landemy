using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Landemy.App_Source.Shared
{
    public class MyFile
    {
        public static void CopyFile (string strPath1, string strPath2)
        {
            if (File.Exists(strPath2))
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete(strPath2);
            }
            File.Copy(strPath1, strPath2);
        }

        public static void DeleteFile(string strPath1)
        {
            if (File.Exists(strPath1))
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete(strPath1);
            }
            File.Delete(strPath1);
        }
    }
}
