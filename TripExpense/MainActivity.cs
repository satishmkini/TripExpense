using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Java.Security;
using System;
using Xamarin.Auth;

namespace TripExpense
{
    [Activity(Label = "TripExpense", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += fb;
            
            // Set our view from the "main" layout resource
            // 
        }

        private void fb(object sender, EventArgs e)
        {
            var auth = new OAuth2Authenticator(
    clientId: "1423283181029991",
    scope: "",
    authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
    redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html"));
         }        
};
}
    


