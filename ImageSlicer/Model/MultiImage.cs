using System;
using System.Drawing;
using System.IO;

namespace ImageSlicer.Model
{
    class MultiImage
    {
        private Image baseImage;
        private String title;

        public Image BaseImage => baseImage;
        public String Title => title;

        public MultiImage(Bitmap baseImage)
        {
            this.baseImage = baseImage;
            title = "N\\A";
        }

        public MultiImage(string filePath)
        {
            baseImage = Image.FromFile(filePath);
            title = Path.GetFileNameWithoutExtension(filePath);
        }
    }
}
