using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer.Tables.Drivers
{
    public class clsDriver_DL
    {


        public static void GetDriver(int DriverID,ref DateTime CreateDate,ref int PersonID,ref int CreateByUserID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_Driver.GatDriver, connection);

            command.Parameters.AddWithValue("@Value", DriverID);

            try 
            {
                connection.Open();
                
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CreateDate = (DateTime)reader["CreateDate"];
                        PersonID = (int)reader["PersonID"];
                        CreateByUserID = (int)reader["CreateByUserID"];
                    }
                    else
                        DriverID = -1;

                }


            }
            catch (Exception e)
            {


            }
            finally { connection.Close(); }



        }
        public static bool IsPersonDriver(int PersonID)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_Driver.IsPersonDriver, connection);

            command.Parameters.AddWithValue("@Value", PersonID);
            bool IsDriver = true;
            try
            {
                connection.Open();

                IsDriver = Convert.ToBoolean(command.ExecuteScalar());

            }
            catch (Exception e)
            {


            }
            finally { connection.Close(); }


            return IsDriver;
        }

        public static int GetDriverIDByPersonID(int PersonID)
        {


            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_Driver.GetDriverID, connection);

            command.Parameters.AddWithValue("@Value", PersonID);
            int DriverID = -1;
            try
            {
                connection.Open();

                DriverID = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception e)
            {


            }
            finally { connection.Close(); }


            return DriverID;


        }



        public static DataTable GetDrivers()
        {

            return null;
        }


        public static int GetPersonIDByDriverID(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_Driver.GetPersonID, connection);
            command.Parameters.AddWithValue("@Value", DriverID);
            object PersonID = null;

            try
            {
                connection.Open();

                PersonID = command.ExecuteScalar();

            }
            catch (Exception e) { }
            finally { connection.Close(); }




            return (PersonID == null) ? -1 : Convert.ToInt32(PersonID);
        }




        public static bool IsDriverHaveInternationalLicense(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_Driver.IsDriverHaveInternationalLicense, connection);
            command.Parameters.AddWithValue("@Value", DriverID);

            object IsH = null;

            try
            {
                connection.Open();

                IsH = command.ExecuteScalar();

            }
            catch (Exception e) { }
            finally { connection.Close(); }


            return (IsH == null)?false:(int)IsH == 1 ? true : false;
        }
        public static DataTable GetAllDrivers(string Value = null ,string ColumnName = null)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
                string GetAllDrivers = @"select * from
                               GetAllDrivers()
                               where @Value is null or [" + (@ColumnName != null ? ColumnName:"PersonID") +"] LIKE @Value + '%'";

            SqlCommand command = new SqlCommand(GetAllDrivers, connection);
            DataTable data = new DataTable();

            if (Value == null || ColumnName == null)
            {
                command.Parameters.AddWithValue("@Value", DBNull.Value);
                command.Parameters.AddWithValue("@ColumnName", DBNull.Value);

            }
            else
            {
                command.Parameters.AddWithValue("@Value", Value);
                command.Parameters.AddWithValue("@ColumnName", ColumnName);
            }
            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    data.Load(reader);
                }



            }
            catch (Exception e) { }
            finally { connection.Close(); }


            return data;
        }

    }




}
