using System;
using System.Collections.Generic;
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
    }




}
