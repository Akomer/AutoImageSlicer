using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ImageSlicer.Model
{
    class MultiImage
    {
        private Bitmap baseImage;

        public MultiImage(Bitmap baseImage)
        {
            this.baseImage = baseImage;
        }
    }
}
