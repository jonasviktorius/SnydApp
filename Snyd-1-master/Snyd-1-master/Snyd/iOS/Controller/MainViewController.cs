using System;

using UIKit;

namespace Snyd.iOS
{
	public partial class MainViewController : UIViewController
	{
		public MainViewController() : base("MainViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			RollDices.TouchDown += (object sender, EventArgs e) => 
			{
				RollDicesOutput.Text = "4";
			};

			// Perform any additional setup after loading the view, typically from a nib.
		}




		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

