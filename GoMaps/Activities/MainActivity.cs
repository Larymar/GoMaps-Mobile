using Android.App;
using Android.Widget;
using Android.OS;

namespace GoMaps.Activities {
    [Activity(Label = "GoMaps", MainLauncher = true, Icon = "@drawable/ic_launcher")]
    public class MainActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
        }
    }
}

