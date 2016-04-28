using System;

using UIKit;

namespace HexToRGB
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.convertButton.TouchUpInside += ConvertButton_TouchUpInside;
        }

        private void ConvertButton_TouchUpInside(object sender, EventArgs e)
        {
            string hexValue = this.hexValueTextField.Text;
            string redHexValue = hexValue.Substring(0, 2);
            string greenHexValue = hexValue.Substring(2, 2);
            string blueHexValue = hexValue.Substring(4, 2);

            

            int redValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
            int greenValue = int.Parse(greenHexValue, System.Globalization.NumberStyles.HexNumber);
            int blueValue = int.Parse(blueHexValue, System.Globalization.NumberStyles.HexNumber);

            this.redLabel.Text = redValue.ToString();
            this.greenLabel.Text = greenValue.ToString();
            this.blueLabel.Text = blueValue.ToString();

            this.colorView.BackgroundColor = UIColor.FromRGB(redValue, greenValue, blueValue);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}