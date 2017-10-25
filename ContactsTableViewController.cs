using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace ContactList
{
    public partial class ContactsTableViewController : UITableViewController
    {
        List<Contact> contactList;

        public ContactsTableViewController(IntPtr handle) : base(handle)
        {
            contactList = new List<Contact>();

            contactList.Add(new Contact()
            {
                Name = "abc",
                Number = "123",
                Location = "abc"

            });

            contactList.Add(new Contact()
            {
                Name = "abc",
                Number = "123",
                Location = "abc",

            });

            contactList.Add(new Contact()
            {
                Name = "abc",
                Number = "123",
                Location = "abc",

            });

            contactList.Add(new Contact()
            {
                Name = "abc",
                Number = "123",
                Location = "abc",

            });

        }


        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return contactList.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Contact");

            var data = contactList[indexPath.Row];

            cell.TextLabel.Text = data.Name;

            return cell;
        }
    }

    public class Contact
    {
        public string Name;
        public string Number;
        public string Location;
    }
}