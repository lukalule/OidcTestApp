using ImageGallery.Model;
using System.Collections.Generic;

namespace MyClient.ViewModels
{
    public class GalleryIndexViewModel
    {
        public IEnumerable<Image> Images { get; private set; }
            = new List<Image>();

        public GalleryIndexViewModel(List<Image> images)
        {
           Images = images;
        }
    }
}
