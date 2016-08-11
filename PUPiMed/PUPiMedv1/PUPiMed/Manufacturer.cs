using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections;

namespace PUPiMed
{
    class Manufacturer
    {
        public static bool fillComboBox(MetroComboBox cbManufacturer)
        {
            string strQuery;
            bool retval = false;
            Program.conn.Open();
            strQuery = "SELECT * FROM tblManufacturer;";
            ArrayList alistManuCode = new ArrayList();
            //Create Command
            MySqlCommand cmd = new MySqlCommand(strQuery, Program.conn);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            if (dataReader.Read())
            {
                alistManuCode.Add(dataReader.GetString(0));
                cbManufacturer.Items.Add(dataReader.GetString(1));
                while (dataReader.Read())
                {
                    alistManuCode.Add(dataReader.GetString(0));
                    cbManufacturer.Items.Add(dataReader.GetString(1));
                }
                cbManufacturer.Items.Add("Others...");
            }
            else
            {
                //needs new manufacturer
                retval = true;
            }
            //close Data Reader
            dataReader.Close();

            //close Connection
            Program.conn.Close();

            return retval;
        }
    }
}
