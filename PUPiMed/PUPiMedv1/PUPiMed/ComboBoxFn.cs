using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections;

namespace PUPiMed
{
    class ComboBoxFn
    {
        public bool fillComboBox(MetroComboBox comboBox, string strQuery, out ArrayList alistCode)
        {
            comboBox.Items.Clear();
            alistCode = new ArrayList();
            bool retval = true;
            try
            {
                Program.conn.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(strQuery, Program.conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader  = cmd.ExecuteReader();

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
                    dataReader.Close();
                }
                else
                {
                    //needs new manufacturer
                    comboBox.Items.Add("");
                    alistCode.Add("");
                    retval = false;

                }
                comboBox.SelectedIndex = 0;
            }catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(null, ex.Message.ToString());
            }
            finally
            {
                //close Connection
                Program.conn.Close();
            }
            return retval;
        }
    }
}
