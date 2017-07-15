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
using HiCam.Services;
using Xamarin.Forms;
using HiCam.Droid.Services;

[assembly: Dependency(typeof(CameraService))]
namespace HiCam.Droid.Services
{
	public class CameraService : ICameraService
	{
		public void GetPhoto()
		{
			throw new NotImplementedException();
		}
	}
}