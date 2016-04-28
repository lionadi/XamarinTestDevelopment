// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HexToRGB
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel blueLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView colorView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton convertButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel greenLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField hexValueTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel redLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (blueLabel != null) {
				blueLabel.Dispose ();
				blueLabel = null;
			}
			if (colorView != null) {
				colorView.Dispose ();
				colorView = null;
			}
			if (convertButton != null) {
				convertButton.Dispose ();
				convertButton = null;
			}
			if (greenLabel != null) {
				greenLabel.Dispose ();
				greenLabel = null;
			}
			if (hexValueTextField != null) {
				hexValueTextField.Dispose ();
				hexValueTextField = null;
			}
			if (redLabel != null) {
				redLabel.Dispose ();
				redLabel = null;
			}
		}
	}
}
