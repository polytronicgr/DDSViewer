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
    static class ddsIO
    {
        public static void saveFile(Bitmap image, string path)
        {
            string ext = Path.GetExtension(path);
            try
            {
                switch (ext)
                {
                    case ".bmp":
                        image.Save(path, ImageFormat.Bmp);
                        break;
                    case ".jpg":
                    case ".jpeg":
                        image.Save(path, ImageFormat.Jpeg);
                        break;
                    case ".png":
                        image.Save(path, ImageFormat.Png);
                        break;
                    case ".emf":
                        image.Save(path, ImageFormat.Emf);
                        break;
                    case ".exif":
                        image.Save(path, ImageFormat.Exif);
                        break;
                    case ".gif":
                        image.Save(path, ImageFormat.Gif);
                        break;
                    case ".ico":
                        image.Save(path, ImageFormat.Icon);
                        break;
                    case ".tiff":
                        image.Save(path, ImageFormat.Tiff);
                        break;
                    case ".wmf":
                        image.Save(path, ImageFormat.Wmf);
                        break;
                    default:
                        util.error("Invalid file type.");
                        break;
                }
            }
            catch (Exception ex)
            {
                util.error("Error saving file.\n" + ex.Message + '\n' + ex.StackTrace);
            }
        }

        public static S16.Drawing.DDSImage loadFile(string path)
        {
            S16.Drawing.DDSImage img = null;
            try
            {
                using (FileStream fs = File.OpenRead(path))
                {
                    try
                    {
                        img = new S16.Drawing.DDSImage(fs);
                    }
                    catch (S16.Drawing.InvalidFileHeaderException e)
                    {
                        util.error("Invalid File Header.\n" + e.Message);
                    }
                    catch (S16.Drawing.NotADDSImageException e)
                    {
                        util.error("Not a valid .dds file.\n" + e.Message);
                    }
                    catch (S16.Drawing.UnknownFileFormatException e)
                    {
                        util.error("Unknown file format.\n" + e.Message);
                    }
                    catch (Exception e)
                    {
                        util.error("Unknown exception.\n" + e.Message + '\n' + e.StackTrace);
                    }
                }
            }
            catch (Exception e)
            {
                util.error("Error reading file.\n" + e.Message + '\n' + e.StackTrace);
            }
            return img;
        }
    }

    public static class util
    {
        public static DialogResult error(string s)
        {
            return MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult warning(string s)
        {
            return MessageBox.Show(s, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult info(string s)
        {
            return MessageBox.Show(s, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
