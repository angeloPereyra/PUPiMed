﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PUPiMed
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new MainForm());

        }

        static string user = "root;";
        static string server = "localhost;";
        static string pass = "root;";
        static string db = "dbmedicalclinic;";

        public static MySqlConnection conn = new MySqlConnection(
            "server= "+server+
            "user id ="+user+
            "password="+pass+
            "database="+db
        );

        public static bool ExecuteQuery(string query)
        {
            bool retval = false;
            try
            {
                Program.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    retval = true;
                }
                else
                {
                    retval = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Program.conn.Close();
            }

            return retval;
        }

        public static string getPrevCode (string query)
        {
            string retval = String.Empty;
            try {
                Program.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, Program.conn))
                {
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        //Read the data and store them in the list
                        if (dataReader.Read())
                        {
                            retval = dataReader.GetString(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Program.conn.Close();
            }

            return retval;
        }
    }
}
