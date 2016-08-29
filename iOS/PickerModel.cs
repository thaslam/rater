using System;
using System.Collections.Generic;
using UIKit;

namespace Rater.iOS
{
	public class PickerChangedEventArgs
	{
		public string SelectedValue { get; set; }
	}

	public class PickerModel : UIPickerViewModel
	{
		private readonly IList<string> values;

		public event EventHandler<PickerChangedEventArgs> PickerChanged;

		public PickerModel(IList<string> values)
		{
			this.values = values;
		}

		public override nint GetComponentCount(UIPickerView pickerView)
		{
			return 1;
		}

		public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
		{
			return values.Count;
		}

		public override string GetTitle(UIPickerView pickerView, nint row, nint component)
		{
			return values[(int)row];
		}

		public override void Selected(UIPickerView pickerView, nint row, nint component)
		{
			if (this.PickerChanged != null)
			{
				this.PickerChanged(this, new PickerChangedEventArgs { SelectedValue = values[(int)row] });
			}
		}
	}
}

