using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using vp_assignment.Entity;

namespace vp_assignment.DAL
{
    public static class ItemsDAL
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ASUS\\Desktop\\Database21.accdb";
        private static OleDbConnection conn = new OleDbConnection(connectionString);

        public static void InsertCommand(Items item)
        {
            string commandText = string.Format("Insert into Items(ItemName,Category,price)" +
                "values('{0}','{1}','{2}')", item.ItemName, item.Category, item.price);
            OleDbCommand command = new OleDbCommand(commandText, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateCommand(Items item)
        {
            string UpdateCommand = string.Format("Update Items set ItemName = '{1}',Category = '{2}',price='{3}'" +
                " where itemId = {0}", item.itemId, item.ItemName, item.Category ,item.price);

            OleDbCommand command = new OleDbCommand(UpdateCommand, conn);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteCommand(Items item)
        {
            string DeleteCommand = string.Format("Delete from Items where itemId = {0}", item.itemId);
            OleDbCommand command = new OleDbCommand(DeleteCommand, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable GetAllcommand()
        {
            string commandText = string.Format("Select * from Items");

            OleDbCommand command = new OleDbCommand(commandText, conn);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
       
    }
}
