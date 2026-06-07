using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataLayer.Tables.Detained
{
    public class clsDetained_DL
    {

        public static void GetDetain
            (int LicenseID, ref int DetainID, ref DateTime DetainDate, ref string UserName, ref decimal FineFees)
        {

            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                SqlCommand command = new SqlCommand(clsQ_Detained.GetDetain, connection);

                command.Parameters.AddWithValue("@Value", LicenseID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        DetainID = (int)reader["DetainID"];
                        DetainDate = (DateTime)reader["DetainDate"];
                        UserName = (string)reader["Username"];
                        FineFees = (decimal)reader["FineFees"];

                    }
                }
                catch (Exception e) { }

            }


        }



        public static int GetDetainIDByLicense(int LicenseID)
        {

            int DetainID = -1;
            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                SqlCommand command = new SqlCommand(clsQ_Detained.GetDetainID, connection);

                command.Parameters.AddWithValue("@LicenseID", LicenseID);

                try
                {
                    connection.Open();
                     DetainID = (int)command.ExecuteScalar();

                
                }
                catch (Exception e) { }

            }

            return DetainID;


        }



        public static DataTable GetDetainedList(object Value = null, string ColumnName = null)
        {

            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                SqlCommand command = new SqlCommand(clsQ_Detained.GetDetainedList, connection);

                command.Parameters.AddWithValue("@Value", Value == null ? DBNull.Value : Value);
                if (string.IsNullOrEmpty(ColumnName))
                    command.Parameters.AddWithValue("@ColumnName", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@ColumnName", ColumnName);


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        data.Load(reader);

                }
                catch (Exception e) { }
            }


            return data;



        }

        public static bool IsLicenseDetain(int LicenseID)
        {
            bool IsDetain = false;
            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                SqlCommand command = new SqlCommand(clsQ_Detained.IsDetain, connection);

                command.Parameters.AddWithValue("@LicenseID", LicenseID);


                try
                {
                    connection.Open();

                    IsDetain = command.ExecuteScalar() != null ? true : false;

                }
                catch (Exception e)
                {

                }


            }
            return IsDetain;

        }
        public static bool IsDetainReleased(int LicenseID)
        {

           return IsLicenseDetain(LicenseID);
        }


        public static bool AddNewDetain(Structures_DL.clsDetainLicense clsDetain)
        {


            using (SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString))
            {
                SqlCommand command = new SqlCommand(clsQ_Detained.AddNewDetain, connection);

                connection.Open();

                command.Parameters.AddWithValue("@LicenseID", clsDetain.LicenseID);
                command.Parameters.AddWithValue("@CreatedByUserID", clsDetain.CreatedByUserID);
                command.Parameters.AddWithValue("@FineFees", clsDetain.FineFees);
                command.Parameters.AddWithValue("@DetainDate", clsDetain.DetainDate);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    clsDetain.DetainID = Convert.ToInt32(command.ExecuteScalar());
                    return true;
                }
                catch (Exception e)
                {

                }


            }





            return false;
        }


    }


}
