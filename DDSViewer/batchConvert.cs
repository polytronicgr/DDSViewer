using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace DDSViewer
{
    public partial class batchConvert : Form
    {
        string srcDir = "";
        string dstDir = "";
        public batchConvert()
        {
            InitializeComponent();
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            mainFolderBrowserDialog.Description = "Select the source directory";
            mainFolderBrowserDialog.ShowNewFolderButton = false;
            if (mainFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                srcDir = mainFolderBrowserDialog.SelectedPath;
                txtSrc.Text = srcDir;
            }
        }

        private void btnDst_Click(object sender, EventArgs e)
        {
            mainFolderBrowserDialog.Description = "Select the destination directory";
            mainFolderBrowserDialog.ShowNewFolderButton = true;
            if (mainFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                dstDir = mainFolderBrowserDialog.SelectedPath;
                txtDst.Text = dstDir;
            }
        }

        private void batchConvert_Load(object sender, EventArgs e)
        {
            string[] extentions = {".bmp",".jpg",".png",".emf",".exif",".gif",".ico",".tiff",".wmf"};
            cmbExt.Items.AddRange(extentions);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (srcDir != "" && dstDir != "" && cmbExt.SelectedIndex != -1)
            {
                string[] files = getFiles(srcDir, dstDir, "*.dds", (int)nRecursionDepth.Value);
                string ext = cmbExt.GetItemText(cmbExt.SelectedItem);
                mainProgressBar.Maximum = files.Length;
                mainProgressBar.Visible = true;
                foreach (string f in files)
                {
                    string op = Path.GetDirectoryName(f);
                    string p = dstDir + op.Substring(srcDir.Length, op.Length - srcDir.Length);
                    string newFileName = p + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(f) + ext;
                    try
                    {
                        Directory.CreateDirectory(p);
                        S16.Drawing.DDSImage img = ddsIO.loadFile(f);
                        ddsIO.saveFile(img.BitmapImage, newFileName);
                    }
                    catch (Exception ex)
                    {
                            util.error("Error converting file: " + f + '\n' + ex.Message + '\n' + ex.StackTrace);
                    }
                    //MessageBox.Show(dstDir + p.Substring(srcDir.Length, p.Length - srcDir.Length));
                   // Directory.CreateDirectory(dstDir + p.Substring(srcDir.Length,p.Length-srcDir.Length));
                    mainProgressBar.PerformStep();
                }
                util.info("Done converting!");
                this.Close();
            }
            else
            {
                util.info("Must fill in all forms.");
            }
        }


        private string[] getFiles(string src, string dst, string ext, int depth)
        {
            List<string> fileLst = new List<string>();

            foreach (string directory in Directory.EnumerateDirectories(src))
            {
                if (depth > 0)
                {
                    fileLst.AddRange(getFiles(directory, dst, ext, depth - 1));
                }
            }

            fileLst.AddRange(Directory.EnumerateFiles(src,ext));
            //Directory.CreateDirectory(dst + src.Substring(root.Length,src.Length-root.Length)+;

            return fileLst.ToArray();
        }
    }
}
