using Android.App;
using Android.Widget;
using Android.OS;

namespace TipCalculator
{
  [Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
  public class MainActivity : Activity
  {
    private const double tipPercent = 0.15;
    protected override void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);

      // Set our view from the "main" layout resource
      SetContentView(Resource.Layout.Main);

      ((Button)FindViewById(Resource.Id.calculateButton)).Click += (s, e) =>
      {

        if (!double.TryParse(((EditText)FindViewById(Resource.Id.inputBill)).Text, out var balance))
        {
          balance = 0;
        }
        var tip = balance * tipPercent;
        var total = balance + tip;


        ((TextView)FindViewById(Resource.Id.outputTip)).Text = tip.ToString();
        ((TextView)FindViewById(Resource.Id.outputTotal)).Text = total.ToString();
      };
    }
  }
}

