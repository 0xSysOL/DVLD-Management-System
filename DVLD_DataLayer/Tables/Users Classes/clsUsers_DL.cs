using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Data;
namespace DVLD_DataLayer.Tables
{
    public class clsUsers_DL
    { 



        public static bool GetUserByUserName(ref int UserID, ref string Username, string Password, ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_User.QueryIsUserExists, connection);
            command.Parameters.AddWithValue("@username", Username);
            command.Parameters.AddWithValue("@password", Password);


            try
            {
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {

                    UserID = (int)dataReader["UserID"];
                    IsActive = (bool)dataReader["IsActive"];
                    dataReader.Close();
                    return true;
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return false;

        }

        public static DataTable GetAllUsers(string FilterType = "", object Filter = null)
        {

            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_User.GetAllUsers, connection);

            if (clsPeople_DL._Filter(ref command, FilterType, Filter, "Users"))
                command.CommandText = clsQ_User.GetAllUsers;


            try
            {
                connection.Open();


                using (SqlDataReader reader = command.ExecuteReader())
                    data.Load(reader);


            }
            catch (Exception e)
            { }
            finally
            { connection.Close(); }



            return data;

        }

        public static string GetColumnValueByUserID(int UserID, string ColumnName)
        {


            return null;

        }
        public static bool GetUserRecord(int UserID, ref int PersonID,ref string UserName, ref string Password, ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_User.GetOneUser, connection);

            command.Parameters.AddWithValue("@value",UserID);


            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        PersonID = (int)reader["PersonID"];
                        UserName = (string)reader["Username"];
                        Password = (string)reader["Password"];
                        IsActive = (bool)reader["IsActive"];
                        return true;

                    }
                }



            }
            catch (Exception e)
            { }
            finally
            { connection.Close(); }

           



            return false;
        }
        public static bool IsThePersonLinkedTableUsers(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_User.IsPersonConected, connection);
            command.Parameters.AddWithValue("@value", PersonID);
            object result = null;

            try
            {

                connection.Open();
                result = command.ExecuteScalar();




            }
            catch (Exception e)
            { }
            finally
            { connection.Close(); }

            return (result != null) ? true : false;



        }

        public static bool IsUserExists(string Username)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_User.IsUserExists, connection);

            command.Parameters.AddWithValue("@value", Username);
            object Result = null;
            try
            {
                connection.Open();

                Result = command.ExecuteScalar();

            }
            catch (Exception e)
            { }
            finally
            { connection.Close(); }


            return (Result != null) ? true : false;




        }


        private static void AddValue(ref SqlCommand command, int PersonID, string Username, string Password,
            bool IsActive)
        {
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

        }
        public static int AddNewUser(int PersonID, string Username, string Password, bool IsActive)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_User.AddNewUser, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);


            object Result = null;

            try
            {
                connection.Open();

                Result = command.ExecuteScalar();


            }
            catch (Exception e)
            { }
            finally
            { connection.Close(); }


            return (Result != null) ? Convert.ToInt32(Result) : -1;

        }
        public static bool UpdateUser(int UserID, string Username, string Password, bool IsActive)
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_User.UpdateUser, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);


            int Result = -1;

            try
            {
                connection.Open();

                Result = command.ExecuteNonQuery();


            }
            catch (Exception e)
            { }
            finally
            { connection.Close(); }


            return (Result >= 1) ? true : false;

        }

        public static bool DeleteUser(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_User.DeleteUser,connection);

            command.Parameters.AddWithValue("@value", UserID);
            int result = -1;
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
       
            }
            finally
            {
                connection.Close();
            }

            return (result > 0 )? true : false;


        }



    }
}
