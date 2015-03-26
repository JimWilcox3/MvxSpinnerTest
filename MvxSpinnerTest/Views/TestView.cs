// TestView.cs
// This example is provided "as-is" licensed using the Microsoft Public License (Ms-PL)
// MvvmCross is a product of  (c) Copyright Cirrious Ltd. http://www.cirrious.comusing System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Views;
using MvxSpinnerTest;

namespace MPS_Mobile_Driver.Droid.Views
{
    [Activity(Label = "Test View")]
    public class TestView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TestView);

            // Create your application here
        }
    }
}