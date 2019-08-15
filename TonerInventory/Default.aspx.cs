using System;
using TonerInventory.BAL;
using TonerInventory.DAL;
using TonerInventory.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TonerInventory
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (InsertNewToner()>0)
            {
                Msglabel.Text = "Great";
            }
            else
            {
                Msglabel.Text = "not so great";
            }
        }

        protected int InsertNewToner()
        {
            var ti = new Models.TonerDetails();
            ti.NumberOfPrinters = Misc.ConvertStringToShort(NoPrinters.Text.ToString());
            ti.TonerName = TonerNameTextBox.Text;
            ti.QuantityOnHand = Misc.ConvertStringToShort(QoHTextBox.Text);
            ti.ReorderQuantity = Misc.ConvertStringToShort(ReQty.Text);
           return TonerInventoryDataLayer.InsertNewToner(ti);

        }
    }
}