using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace todaysWorks
{
    public partial class DeleteAddress : System.Web.UI.Page
    {
        Int32 AddressNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            AddressNo = Convert.ToInt32(Session["AddressNo"]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnYes_Click_Click(object sender, EventArgs e)
        {
            //CREATE SOME INSTANCE OF TH ADDRESS BOOK
            ClsAddressCollection AddressBook = new ClsAddressCollection();
            //Find the record to delete
            AddressBook.ThisAddress.Find(AddressNo);
            //delete the record
            AddressBook.Delete();
            //redirect back to the main page
            Response.Redirect("AddressList.aspx");
        }
    }
}