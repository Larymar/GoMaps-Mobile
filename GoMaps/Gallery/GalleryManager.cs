using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GoMaps.Gallery {
    class GalleryManager : IGalleryManager {
        public IObservable<Uri> GetGalleryImageUri() {
            throw new NotImplementedException();
        }
    }
}