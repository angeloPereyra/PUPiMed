using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections;

namespace PUPiMed
{
    class Manufacturer
    {
        public bool fillComboBox(MetroComboBox comboBox, string strQuery, out ArrayList alistCode)
        {
            comboBox.Items.Clear();

            alistCode = new ArrayList();
            bool retval = true;
            Program.conn.Open();
            //Create Command
            MySqlCommand cmd = new MySqlCommand(strQuery, Program.conn);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            if (dataReader.Read())
            {
                alistCode.Add(dataReader.GetString(0));
                comboBox.Items.Add(dataReader.GetString(1));
                while (dataReader.Read())
                {
                    alistCode.Add(dataReader.GetString(0));
                    comboBox.Items.Add(dataReader.GetString(1));
                }
                //comboBox.Items.Add("Others...");
            }
            else
            {
                //needs new manufacturer
                comboBox.Items.Add("");
                retval = false;

            }
            comboBox.SelectedIndex = 0;
            //close Data Reader
            dataReader.Close();

            //close Connection
            Program.conn.Close();

            return retval;
        }
    }
}
