using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace Rater.iOS
{
    public partial class LocationController : UIViewController
    {
        public LocationController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			// load states
			var pickerViewModel = new PickerModel(new List<string> { "Connecticut", "New York", "California" });
			this.StatePicker.Model = pickerViewModel;

			base.ViewDidLoad();
		}
    }
}