﻿using System;
using FreshMvvm;
using Xamarin.Forms;

namespace ContosoFieldService.PageModels
{
    public class LoginPageModel : FreshBasePageModel
    {
        public LoginPageModel()
        {
        }

        public Command Login
        {
            get
            {
                return new Command(async () => {
                    Helpers.Settings.UserIsLoggedIn = true;
                    await CoreMethods.PopPageModel(true, true);
                });
            }

        }

        public override void Init(object initData)
        {
            base.Init(initData);

            CoreMethods.RemoveFromNavigation();
        }
    }
}