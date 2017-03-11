using System;
using System.Collections.Generic;

using Foundation;
using SimpsonsDatabase.Data.Repositories.Mock;
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

		class DataSource : UITableViewSource
		{
			static readonly NSString CellIdentifier = new NSString("Cell");
			readonly List<CharacterModel> objects = new List<CharacterModel>();
			readonly MasterViewController controller;

			public DataSource(MasterViewController controller)
			{
				this.controller = controller;
			}

			public List<CharacterModel> Objects
			{
				get { return objects; }
			}

			// Customize the number of sections in the table view.
			public override nint NumberOfSections(UITableView tableView)
			{
				return 1;
			}

			public override nint RowsInSection(UITableView tableview, nint section)
			{
				return objects.Count;
			}

			// Customize the appearance of table view cells.
			public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell(CellIdentifier, indexPath);

				cell.TextLabel.Text = objects[indexPath.Row].FullName;

				return cell;
			}

		}
	}
}
