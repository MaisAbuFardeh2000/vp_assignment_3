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
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ASUS\\Desktop\\project-master\\project-master\\project\\DataBase\\HomeInventoryUsers.accdb";
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
        //    public static void UpdateCommand(Categories category)
        //    {
        //        string UpdateCommand = string.Format("Update Categories set CategoryId = '{1}',CategoryName = '{2}'" +
        //            " where CatID = {0}", category.CatID, category.CategoryId, category.CategoryName);

        //        OleDbCommand command = new OleDbCommand(UpdateCommand, conn);

        //        conn.Open();
        //        command.ExecuteNonQuery();
        //        conn.Close();
        //    }
        //    public static void DeleteCommand(Categories category)
        //    {
        //        string DeleteCommand = string.Format("Delete from Categories where CatID = {0}", category.CatID);
        //        OleDbCommand command = new OleDbCommand(DeleteCommand, conn);
        //        conn.Open();
        //        command.ExecuteNonQuery();
        //        conn.Close();
        //    }
        //    public static DataTable GetAllcommand()
        //    {
        //        string commandText = string.Format("Select * from Categories");

        //        OleDbCommand command = new OleDbCommand(commandText, conn);

        //        OleDbDataAdapter da = new OleDbDataAdapter(command);

        //        DataTable dt = new DataTable();

        //        da.Fill(dt);

        //        return dt;
        //    }

        //}
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.OleDb;

//namespace project.Helper
//{
//    public static class CategoriesDAL
//    {
//        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ASUS\\Desktop\\project-master\\project-master\\project\\DataBase\\HomeInventoryUsers.accdb";
//        private static OleDbConnection conn = new OleDbConnection(connectionString);
//    }
//}
