﻿using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace Authoor
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnAuth;
        EditText editTextUsername;
        EditText editTextPassword;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnAuth = FindViewById<Button>(Resource.Id.btnAuth);

            editTextUsername = FindViewById<EditText>(Resource.Id.editTextUsername);
            editTextPassword = FindViewById<EditText>(Resource.Id.editTextPassword);

            btnAuth.Click += DoAuthentication;
        }
        private void DoAuthentication(object sender, EventArgs e)
        {
            if (editTextUsername.Text.Equals("bichito") && editTextPassword.Text.Equals("123456"))
            {
                Toast.MakeText(this, "Usuario valido", ToastLength.Short)
                    .Show();
            } else
            {
                Toast.MakeText(this, "Usuario invalido, este telefono se destruira.", 
                    ToastLength.Short)
                    .Show();
            }
            
        }
    }
}