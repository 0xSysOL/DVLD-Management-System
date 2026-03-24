using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
 

namespace DVLD_DataLayer
{
    #region People
    public class clsPeople_DL
    {

      
        internal static bool _Filter(ref SqlCommand command, string FilterColumn, object Value,string ModeType = "")
        {
            if (FilterColumn != "" && ModeType == "")
            {
                command.CommandText = clsQ_People.GetAllPeople + $" where [{FilterColumn}]  like @ColumnValue + '%' ";
                command.Parameters.AddWithValue("@ColumnValue", Value);
                return false;
            }
            else if(ModeType == "Users" && FilterColumn != "")
            {
                command.CommandText = clsQ_User.GetAllUsers + $" where [{FilterColumn}]  like @ColumnValue + '%' ";
                command.Parameters.AddWithValue("@ColumnValue", Value);
                return false;
            }

           return true;

        }
       
        public static DataTable GetAllPeople(string FilterColumn = "",object Value = null) 
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("", connection);


            if (_Filter(ref command, FilterColumn, Value))
                command.CommandText = clsQ_People.GetAllPeople;
           

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader()) 
                table.Load(reader);

                

                }
            catch (Exception e) 
            {
            }
            finally 
            {
                connection.Close();
            }



            return table;
        }


        public static DataTable GetPersonByID(int ID) 
        {
            if (ID == -1) return null;

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(clsQ_People.GetOnePerson + "Where PersonID = @ID",connection);
            command.Parameters.AddWithValue("@ID",ID); ;
            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);

                }
            }
            catch (Exception e)  
            {
            }
            finally
            {
                connection.Close();
            }

            return table;

        }

        public static  bool IsNationalNoExists(string NationalNo) 
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_People.FindNationalNo,connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            object result = null;
            try
            {
                connection.Open();

                 result = command.ExecuteScalar();

            }
            catch(Exception e) 
            {
            }
            finally 
            {
                connection.Close();
            } 



            return result != null ? true : false;

        }

        public static DataTable GetPersonByNationalNo(string NationalNo)
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_People.GetPersonByNationalNo, connection);
            command.Parameters.AddWithValue("@value", NationalNo);
            DataTable data = new DataTable();

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                        data.Load(reader);
                }
               

            }
            catch (Exception e) 
            {
            }
            finally
            {
                connection.Close();
            }



            return data;

        }

        public static int AddNewPerson
        #region Parameters
            (
    string FirstName,
    string SecondName,
    string ThirdName,
    string LastName,
    string NationalNo,
    short Gendor,
    string Phone,
    string Email,
    string Address,
    DateTime DateOfBirth,
    int CountryID,
    string ImagePath
            )
        #endregion end Parameters
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);

            SqlCommand command = new SqlCommand(clsQ_People.AddPerson, connection);
            object Result = null;

            command.Parameters.AddWithValue("@FN", FirstName);
            command.Parameters.AddWithValue("@SN", SecondName);
            command.Parameters.AddWithValue("@TN", ThirdName);
            command.Parameters.AddWithValue("@LN", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Nationality", CountryID);

            if (Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            if (ImagePath!= null)
            command.Parameters.AddWithValue("@ImagePath", (ImagePath));
            else
            command.Parameters.AddWithValue("@ImagePath", (DBNull.Value));

            try
            {
                connection.Open();
                Result = command.ExecuteScalar();

            }
            catch(Exception e) 
            {
                
               
            }
            finally 
            {
                connection.Close();
            }

            return Convert.ToInt32(Result);

        }
        

        public static int UpdatePerson
        #region Parameters
            (
      int PersonID,
    string FirstName,
    string SecondName,
    string ThirdName,
    string LastName,
    short Gendor,
    string Phone,
    string Email,
    string Address,
    DateTime DateOfBirth,
    int CountryID,
    string ImagePath
            )
        #endregion end Parameters 
        {
            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_People.UpdatePerson, connection);
            int RowChanged = -1;
            command.Parameters.AddWithValue("@FN", FirstName);
            command.Parameters.AddWithValue("@SN", SecondName);
            command.Parameters.AddWithValue("@TN", ThirdName);
            command.Parameters.AddWithValue("@LN", LastName);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@PhNumber", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DOB", DateOfBirth);
            command.Parameters.AddWithValue("@Na_ID", CountryID);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            if (Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            if (ImagePath != null)
                command.Parameters.AddWithValue("@Key", (ImagePath));
            else
                command.Parameters.AddWithValue("@Key", (DBNull.Value));

            try
            {
                connection.Open();

                 RowChanged = command.ExecuteNonQuery();


            }
            catch(Exception e) 
            { }
            finally
            {
                connection.Close();
            }


            return RowChanged;
        }






        public static string GetImagePath(int ID) 
        {



            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_People.GetImagePath, connection);
            command.Parameters.AddWithValue("@PersonID", ID);
            object result = null;
            try
            {
                connection.Open();
                 result = command.ExecuteScalar();


            }
            catch (SqlException e)
            {
            
            }
            finally
            {

                connection.Close();
            }



            return result.ToString();

        }

        public static int DeletePerson(int ID) 
        {

            SqlConnection connection = new SqlConnection(clsSetting_DL.ConnectionString);
            SqlCommand command = new SqlCommand(clsQ_People.DeletePerson, connection);
            command.Parameters.AddWithValue("@value",ID); 
            
            int Result = 0;
            try
            {
                connection.Open();
                Result = command.ExecuteNonQuery();
               

            }catch(SqlException e) 
            {
                return e.Number;
            }
            finally 
            {

                connection.Close();
            }



            return -1;

        }

        


    }
    #endregion 





}
