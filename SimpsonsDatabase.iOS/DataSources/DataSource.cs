using System;
using System.Collections.Generic;
using Foundation;
using SimpsonsDatabase.Models;
using UIKit;

namespace SimpsonsDatabase.iOS.DataSources
{
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
