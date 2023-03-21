using Aspose.Zip;
using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zipFile
{
    public class ReadZipFile
    {
        
        public void AddFolderToZipFile(String FolderPath)
        {
            using (FileStream zipFile = File.Open("compressFodlder.zip", FileMode.Create))
            {
                using (Aspose.Zip.Archive archive = new Aspose.Zip.Archive())
                {
                    // Folder to be Zipped
                    DirectoryInfo corpus = new DirectoryInfo(FolderPath);
                    archive.CreateEntries(corpus);
                    // Create ZIP archive
                    archive.Save(zipFile);
                }
            }
        }

    }
}
