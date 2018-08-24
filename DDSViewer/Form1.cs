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
    public partial class Form1 : Form
    {
        string[] files;
        int curFileIndex;
        S16.Drawing.DDSImage curImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void ready()
        {
            mainStatusLabel.Text = "Ready";
        }

        private void beginLoad(string path)
        {
            Cursor.Current = Cursors.WaitCursor;
            mainStatusLabel.Text = "Loading " + Path.GetFileName(path);
            Application.DoEvents();
        }

        private void endLoad(string path)
        {
            Cursor.Current = Cursors.Default;
            mainStatusLabel.Text = Path.GetFileName(path);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = System.IO.Directory.GetFiles(Path.GetDirectoryName(mainOpenFileDialog.FileName), "*.dds");
                curFileIndex = Array.IndexOf(files, mainOpenFileDialog.FileName);
                beginLoad(files[curFileIndex]);
                curImage = ddsIO.loadFile(files[curFileIndex]);
                pictureBoxMain.Image = curImage.BitmapImage;
                endLoad(files[curFileIndex]);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curImage != null && mainSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                mainStatusLabel.Text = "Saving " + Path.GetFileName(mainSaveFileDialog.FileName);
                Application.DoEvents();
                ddsIO.saveFile(curImage.BitmapImage, mainSaveFileDialog.FileName);
                Cursor.Current = Cursors.Default;
                mainStatusLabel.Text = Path.GetFileName(files[curFileIndex]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainOpenFileDialog.SupportMultiDottedExtensions = true;
            mainOpenFileDialog.Filter = "DDS file (*.dds)|*.dds";

            mainSaveFileDialog.Filter = "Bitmap|*.bmp|Joint Photographic Experts Group|*.jpg;*.jpeg|Portable Network Graphics|*.png|Enhanced Metafile|*.emf|Exchangeable Image File|*.exif|Graphics Interchange Format|*.gif|Windows icon image|*.ico|Tagged Image File Format|*.tiff|Windows metafile|*.wmf";
            mainSaveFileDialog.AddExtension = true;
            ready();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files != null && curFileIndex < files.Length - 1)
            {
                ++curFileIndex;
                beginLoad(files[curFileIndex]);
                curImage = ddsIO.loadFile(files[curFileIndex]);
                pictureBoxMain.Image = curImage.BitmapImage;
                endLoad(files[curFileIndex]);
            }
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (files != null && curFileIndex > 0)
            {
                --curFileIndex;
                beginLoad(files[curFileIndex]);
                curImage = ddsIO.loadFile(files[curFileIndex]);
                pictureBoxMain.Image = curImage.BitmapImage;
                endLoad(files[curFileIndex]);
            }
        }

        private void batchConvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            batchConvert bc = new batchConvert();
            bc.ShowDialog();
        }

        private void imageInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curImage != null)
                MessageBox.Show("Width: " + curImage.BitmapImage.Width.ToString() + "\nHeight: " + curImage.BitmapImage.Height.ToString());
        }
    }
}
