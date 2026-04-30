using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataLayer.Tables.License_Class
{
    public class clsLicenseClass_DL
    {

        public static DataTable GetAllClass()
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_LicenseClass.GetAllClasses, connection);
            DataTable data = new DataTable();


            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                { data.Load(reader); }

            }
            catch (Exception e)
            { }
            finally
            {
                connection.Close();
            }
            return data;
        }
        public static void GetClassByName(ref int ID, string ClassName, ref string ClassDescription,
            ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_LicenseClass.GetOneRecord, connection);

            command.Parameters.AddWithValue("@Value", ClassName);
            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ID = (int)reader["LicenseClassID"];
                        ClassDescription = (string)reader["ClassDescription"];
                        MinimumAllowedAge = (byte)reader["MinmumAllowedAge"];
                        DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                        ClassFees = (decimal)reader["ClassFees"];
                    }
                }

            }
            catch (Exception e)
            { }
            finally
            {
                connection.Close();
            }


        }


    }
}
