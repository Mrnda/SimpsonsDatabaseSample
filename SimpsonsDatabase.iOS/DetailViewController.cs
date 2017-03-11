using System;
using SimpsonsDatabase.Models;
using UIKit;

namespace SimpsonsDatabase.iOS
{
	public partial class DetailViewController : UIViewController
	{
		public CharacterModel DetailItem { get; set; }

		protected DetailViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public void SetDetailItem(CharacterModel newDetailItem)
		{
			if (DetailItem != newDetailItem)
			{
				DetailItem = newDetailItem;

				// Update the view
				ConfigureView();
			}
		}

		void ConfigureView()
		{
			// Update the user interface for the detail item
			if (IsViewLoaded && DetailItem != null)
			{
				FirstNameLabel.Text = DetailItem.FirstName;
				LastNameLabel.Text = DetailItem.LastName;
				AgeLabel.Text = DetailItem.Age.ToString();
				DescriptionTextView.Text = DetailItem.Description;
				string gender = "";
				switch (DetailItem.Gender)
				{
					case Gender.Male:
						gender = "Male";
						break;
					case Gender.Female:
						gender = "Female";
						break;
					case Gender.Unknown:
						gender = "Unknown";
						break;
				}
				GenderLabel.Text = gender;
			}
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			ConfigureView();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

