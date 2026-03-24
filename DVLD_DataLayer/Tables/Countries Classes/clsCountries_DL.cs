using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataLayer
{
    public class clsCountries_DL
    {

        public static DataTable GetCountries() 
        { 
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            DataTable data = new DataTable();

            SqlCommand command = new SqlCommand(clsQ_Countries.GetAll, connection);

            
            try 
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    data.Load(reader);
                

            }
            catch
            (Exception e)
            { 
            }
            finally 
            {
                connection.Close();
            }



            return data;
        }

        public static int GetCountryID_ByName(string CountryName) 
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_Countries.GetCountryID_ByCountryName, connection);
            int ID = -1;

            command.Parameters.AddWithValue("@CountryName", CountryName);
            try { 
            
             connection.Open();
                ID = (int)command.ExecuteScalar();

            }
            catch (Exception e)
            {
               

            }
            finally
            {
                connection.Close();
            }
            return ID;


        }
    }
}
