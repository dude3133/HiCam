using HiCam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCam.ViewModels
{
	public class MainPageViewModel
	{
		private ICameraService _service;

		public MainPageViewModel(ICameraService service)
		{
			_service = service;
		}
	}
}
