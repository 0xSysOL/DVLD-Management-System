using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataLayer.Tables.Application_Classes.Test_Types
{
    public class clsManageTestTypes_DL
    {
        public static DataTable GetTestsTypes()
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQManage_Test_Types.GetTestTypes, connection);
            DataTable data = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                data.Load(dataReader);

            }
            catch (Exception e) { }

            finally
            {
                connection.Close();
            }



            return data;
        }

        public static int GetTestTypeByID(int ID, ref string Title, ref string Description, ref decimal Fees)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQManage_Test_Types.GetOneRecord, connection);

            command.Parameters.AddWithValue("@value", ID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Title = (string)reader["Title"];
                    Description = (string)reader["Description"];
                    Fees = (decimal)reader["Fees"];

                    return ID;

                }

            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();

            }



            return -1;
        }

        public static bool UpdateTestTypesType(int ID, string Title, string Description, decimal Fees)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);

            SqlCommand command = new SqlCommand(clsQManage_Test_Types.UpdateRecord, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
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
