using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using utils;

namespace data
{
    public class Database
    {
        public static string connection_string = data.Properties.Settings.Default.connection_string;

        // execute a sql to database but vulnerable to sqlinjections
        public static DataTable ejecuta(string query)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connection_string;
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return dt;
        }

        /* 
        * Execute Parametized Query sending a dictionary
        * from http://codereview.stackexchange.com/questions/56025/passing-parameters-to-a-query
        * this method take string and a dictionary[parameter_name, values] and return
        a dataset with the result of the query 
        */
        /*
        public static DataSet executeQuery(string query, Dictionary<String, object> parameters = null)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connection_string;
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if(parameters != null)
                {
                    // adding parameters to the commans
                    foreach(KeyValuePair<string,object> kvp in parameters)
                    {
                        cmd.Parameters.Add(new SqlParameter(kvp.Key, kvp.Value));
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch(Exception ex)
            {
                ds = null;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return ds;
        }
         * */

        // Using params allows you to call the function with no arguments.
        /* Using this Method to execute query that returns rows
         * Execute Parametized Query sending KeyValuePar array
         * from http://codereview.stackexchange.com/questions/56025/passing-parameters-to-a-query
         * if the params is not set it execute the query whateve
         */
        public static DataSet executeQuery(string query, params KeyValuePair<String, object>[] parameters)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connection_string;
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                // adding parameters to the commands
                foreach (KeyValuePair<string, object> kvp in parameters)
                {
                    cmd.Parameters.Add(new SqlParameter(kvp.Key, kvp.Value));
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                ds = null;
                //throw ex;
                Messages.errorMessage(ex.Message);

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return ds;
        }

        // A variation of the above method
        // use this for querys that not returns rows
        public static string executeNonQuery(string query, params KeyValuePair<String, object>[] parameters)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connection_string;
            DataSet ds = new DataSet();
            string rpta = Configuration.db_ok;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                // adding parameters to the commands
                foreach (KeyValuePair<string, object> kvp in parameters)
                {
                    cmd.Parameters.Add(new SqlParameter(kvp.Key, kvp.Value));
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return rpta;
        }
    }
}
