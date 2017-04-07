using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System;

namespace Genric_Service
{
    [BeforeCode("Number of Documents")]
    public sealed class DatabaseHandler :DBConnectionManager, IDatabaseHandler
    {
        #region MemberVariable

        //private bool OpenDbConnection
        //{
        //    get
        //    {
        //        try
        //        {
        //            sqlConnection.Open();
        //            return true;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }
        //}

        //private bool CloseDbConnection
        //{
        //    get
        //    {
        //        try
        //        {
        //            sqlConnection.Close();
        //            return true;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }
        //}
        #endregion
        #region constructor
        public DatabaseHandler()
        {

        }
        #endregion

        #region Interface Method
        
        public List<T> GetData<T>()
        {
            var objList = new List<T>();
            try
            {
                DBConnectionManager abc = new DBConnectionManager();
                
                var obj = (T)Activator.CreateInstance(typeof(T));
                var b = obj.GetType().GetProperties();
                string tablename = obj.GetType().GetProperty("Table_Name").GetValue(obj, null).ToString();
                using (DBConnectionManager connection = new DBConnectionManager())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM " + tablename);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            var xyz = (T)Activator.CreateInstance(typeof(T));

                            foreach (var a in xyz.GetType().GetProperties().Where(t => t.Name != "Table_Name"))
                            {
                                xyz.GetType().GetProperty(a.Name).SetValue(xyz, sqlDataReader[a.Name]);
                            }
                            objList.Add(xyz);
                        }
                    }

                }
               
            }
            catch (Exception EX)
            {
                throw EX;
            }
            finally
            {
                
            }
            return objList;

        }

        public bool InsertData(dynamic DataModel, string memberName = "")
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateData(dynamic DataModel, string memberName = "")
        {
            try
            {
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool DeleteData(int Id, string memberName = "")
        {
            try
            {
                return true;

            }
            catch
            {
                return false;
            }
        }

        #endregion
        #region Private Methods
       
        #endregion
    }
}