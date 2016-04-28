using System;
using Foundation;
using UIKit;

namespace BMICalculator
{
    public partial class ViewController : UIViewController
    {
        private float bmi = 21.5f;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            this.calculateButton.TouchUpInside += CalculateButton_TouchUpInside;
        }

        private void CalculateButton_TouchUpInside(object sender, EventArgs e)
        {
            var height = float.Parse(this.heightTextField.Text);
            var weight = float.Parse(this.weightTextField.Text);
            this.bmi = weight / (height * height);
            this.BMILabel.Text = bmi.ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);

            this.View.EndEditing(true);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var detailViewController = segue.DestinationViewController as BMIDetailsViewController2;
            if(detailViewController != null)
            {
                detailViewController.bmi = this.bmi;
            }
        }

        
    }
}