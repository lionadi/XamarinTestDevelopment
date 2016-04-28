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

namespace BMICalculationAndroid
{
    [Activity(Label = "BMIDetailsActivity")]
    public class BMIDetailsActivity : Activity
    {
        TextView detailTextView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.BMIDetails);
            this.detailTextView = FindViewById<TextView>(BMICalculationAndroid.Resource.Id.BMItextView);

            var bmi = Intent.Extras.GetFloat("bmi_value");
            this.EvaluateBMI(bmi);
        }

        void EvaluateBMI(float bmi)
        {
            String result = String.Empty;

            if (bmi <= 16)
                result = "very low";
            else if (bmi < 18.5)
                result = "low";
            else if (bmi < 25)
                result = "normal";
            else if (bmi < 30)
                result = "high";
            else 
                result = "too high";

            this.detailTextView.Text = result;
        }
    }
}