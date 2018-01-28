﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System.IO;
using scoreboard_dlouhodobka.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(FileHelper))]
namespace scoreboard_dlouhodobka.Droid
{
    class FileHelper 
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }

    }
}