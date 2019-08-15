using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TonerInventory.Models;


namespace TonerInventory.DAL
{
    public class TonerInventoryDataLayer
    {
        public static int InsertNewToner(TonerDetails td)
        {
            int myint=0;
            string query = @"INSERT INTO dbo.TonerInventory(TonerName,QuantityOnHand,ReorderQuantity,NumberOfPrinters,Active) 
                            VALUES (@Param1,@Param2,@Param3,@Param4,@Param5)";
            string constr = ConfigurationManager.ConnectionStrings["PrInv"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query,con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Param1", td.TonerName);
                    cmd.Parameters.AddWithValue("@Param2", td.QuantityOnHand);
                    cmd.Parameters.AddWithValue("@Param3", td.ReorderQuantity);
                    cmd.Parameters.AddWithValue("@Param4", td.NumberOfPrinters);
                    cmd.Parameters.AddWithValue("@Param5", 1);
                    myint = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return myint;
        }
        
      
 }
}