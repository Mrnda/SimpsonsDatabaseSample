using System;
using System.Collections.Generic;

using Foundation;
using SimpsonsDatabase.Data.Repositories.Mock;
using SimpsonsDatabase.iOS.DataSources;
using SimpsonsDatabase.Models;
using UIKit;

namespace SimpsonsDatabase.iOS
{
	public partial class MasterViewController : UITableViewController
	{
		DataSource dataSource;

		protected MasterViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Title = "Simpsons Database";

			TableView.Source = dataSource = new DataSource(this);
			var repository = new MockSimpsonsRepository();
			dataSource.Objects.AddRange(repository.GetAllSimpsons());
			TableView.ReloadData();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "showDetail")
			{
				var indexPath = TableView.IndexPathForSelectedRow;
				var item = dataSource.Objects[indexPath.Row];

				((DetailViewController)segue.DestinationViewController).SetDetailItem(item);
			}
		}


	}
}
