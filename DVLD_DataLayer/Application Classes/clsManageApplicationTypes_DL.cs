using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer.Application_Classes
{
    public class clsManageApplicationTypes_DL
    {


        public static DataTable GetManageApplicationType()
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQManage_Application_Types.GetApplicationTypes, connection);
            DataTable data = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                data.Load(dataReader);

            }catch(Exception e) { }

            finally
            {
                connection.Close();
            }
               


            return data;
        }

        public static int GetManageAppTypeByID(int ID,ref string Title,ref decimal Fees)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQManage_Application_Types.GetOneRecord, connection);

            command.Parameters.AddWithValue("@value", ID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    Title = (string)reader["ApplicationTypeTitle"];
                    Fees = (decimal)reader["ApplicationFees"];
                    return ID;

                }

            }
            catch (Exception e) 
            {
                connection.Close();
            }



            return -1;
        }
    
        public static bool UpdateApplicationType(int ID,string Title,decimal Fees)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQManage_Application_Types.UpdateRecord, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);
            int result = 0;
            try
            {
                connection.Open();

                result = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();

            }



            return (result > 0) ? true : false;

        }
    }
}
