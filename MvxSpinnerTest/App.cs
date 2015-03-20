using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using MPS_Mobile_Driver.Droid.ViewModels;
using System;

namespace MvxSpinnerTest
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart(new CustomAppStart());
        }
    }

    public class CustomAppStart : MvxNavigatingObject, IMvxAppStart
    {

        public void Start(object hint = null)
        {
            ShowViewModel<TestViewModel>();
        }
    }
}