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
                Name = "Shrek",
                Number = "403 225 9987",
                Location = "Swamp"

            });

            contactList.Add(new Contact()
            {
                Name = "Donald Trump",
                Number = "587 999 0492",
                Location = "725 5th Ave, New York, NY 10022, USA",

            });

            contactList.Add(new Contact()
            {
                Name = "Kim Jong Un",
                Number = "403 888 9999",
                Location = "Pyongyang, North Korea",

            });

            contactList.Add(new Contact()
            {
                Name = "Barrack Obama",
                Number = "587 000 2223",
                Location = "1600 Pennsylvania Ave NW, Washington, DC 20500, USA",

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
            var cell = tableView.DequeueReusableCell("Contact") as ContactTableViewCell;

            var data = contactList[indexPath.Row];

            cell.ContactData = data;

            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "DetailsSegue")
            {
                var navigationController = segue.DestinationViewController as DetailsViewController;

                if (navigationController !=null)
                {
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var selectedData = contactList[rowPath.Row];
                    navigationController.selectedContact = selectedData;
                }
            }
                

            base.PrepareForSegue(segue, sender);
        }

    }

    public class Contact
    {
        public string Name;
        public string Number;
        public string Location;
        public string ImagePath;
    }
}