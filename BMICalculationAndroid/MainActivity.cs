using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace BMICalculationAndroid
{
    [Activity(Label = "BMICalculationAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button calculateBMI, bmiDetailsButton;
        TextView resultTextView;
        EditText heightEditText, weightEditText;

        float bmi = 20.0f;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            this.calculateBMI = FindViewById<Button>(BMICalculationAndroid.Resource.Id.calculateBMI);
            this.bmiDetailsButton = FindViewById<Button>(BMICalculationAndroid.Resource.Id.showDetailsButton);
            this.resultTextView = FindViewById<TextView>(BMICalculationAndroid.Resource.Id.resultTextView);
            this.heightEditText = FindViewById<EditText>(BMICalculationAndroid.Resource.Id.heightEditText);
            this.weightEditText = FindViewById<EditText>(BMICalculationAndroid.Resource.Id.weightEditText);

            this.calculateBMI.Click += CalculateBMI_Click;
            this.bmiDetailsButton.Click += BmiDetailsButton_Click;
        }

        private void BmiDetailsButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BMIDetailsActivity));
            intent.PutExtra("bmi_value",this.bmi);
            StartActivity(intent);
        }

        private void CalculateBMI_Click(object sender, EventArgs e)
        {
            float height = float.Parse(heightEditText.Text);
            float weight = float.Parse(weightEditText.Text);
            bmi = (weight / (height * height));
            this.resultTextView.Text = bmi.ToString();
        }

       
    }
}

