using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ImageSlicer.Model;

namespace ImageSlicer.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        private List<MultiImage> images;

        public DelegateCommand LoadImageCommand { get; private set;}

        public MainWindowViewModel()
        {
            LoadImageCommand = new DelegateCommand(x => LoadImage());
            images = new List<MultiImage>();
        }

        private void LoadImage()
        {
            using (var dialoge = SinglePictureOpenDialoge())
            {
                if (dialoge.ShowDialog() == DialogResult.OK)
                {
                    images.Add(new MultiImage(dialoge.FileName));
                }
            }
        }

        private static OpenFileDialog SinglePictureOpenDialoge()
        {
            return new OpenFileDialog()
            {
                Filter = "Images (.png, .jpg, .bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = false
            };
        }
    }
}
