using System;
using System.Drawing;
using System.IO;

namespace ImageSlicer.Model
{
    class MultiImage
    {
        private Image baseImage;
        private String title;
        private string path;

        public Image BaseImage => baseImage;
        public String Title => title;
        public string FullPath => path;

        public MultiImage(Bitmap baseImage)
        {
            this.baseImage = baseImage;
            title = "N\\A";
        }

        public MultiImage(string filePath)
        {
            baseImage = Image.FromFile(filePath);
            path = filePath;
            title = Path.GetFileNameWithoutExtension(filePath);
        }
    }
}
