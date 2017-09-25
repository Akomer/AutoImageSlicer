using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ImageSlicer.Model;
using System.Drawing;
using System.Collections.ObjectModel;

namespace ImageSlicer.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        private List<MultiImage> images;

        public DelegateCommand LoadImageCommand { get; private set;}
        public ObservableCollection<MultiImage> Images => new ObservableCollection<MultiImage>(images);

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
                    AddMultiImage(new MultiImage(dialoge.FileName));
                }
            }
        }

        private void AddMultiImage(MultiImage mi)
        {
            images.Add(mi);
            OnPropertyChanges(nameof(images));
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
