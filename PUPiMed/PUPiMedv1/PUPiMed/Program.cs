using MetroFramework;
using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
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

        static string user   = "root;";
        static string server = "localhost;";
        static string pass   = "root;";
        static string db     = "dbmedicalclinic;";

        public static MySqlConnection conn = new MySqlConnection(
            "server= "  +server+
            "user id =" +user+
            "password=" +pass+
            "database=" +db
        );

        public static bool ExecuteQuery(string query)
        {
            bool result = false;
            try
            {
                Program.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                Program.conn.Close();
            }

            return result;
        }

        public static string getPrevCode (string query)
        {
            string prev = null;
            try {
                Program.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, Program.conn))
                {
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        //Read the data and store them in the list
                        if (dataReader.Read())
                        {
                            prev = dataReader.GetString(0);
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

            return prev;
        }

        public static string getNextCode(string prev)
        {
            //@"^[\w\-\s]+$"       ----alphanumeric and space
            //Regex.IsMatch(strCode, "^(?=.*?[0-9])(?=.*?[A-Za-z])[a-zA-Z0-9_-]+$")  --must be alphanumeric
            //prev = Regex.Replace(prev, @"[^\w\-]", "");
            if(Regex.IsMatch(prev, "^(?=.*?[0-9])(?=.*?[A-Za-z])[a-zA-Z0-9_-]+$"))
            {
                string original = prev;
                string num = string.Empty;
                prev = reverse(prev);

                //Get Numeric Values to be incremented
                char p = '\0', c;
                bool numFound = false;
                for (int i = 0; i < prev.Length; i++)
                {
                    c = prev[i];
                    if (Char.IsDigit(c))
                    {
                        numFound = true;
                        num += c;
                    }
                    else
                    {
                        if (Char.IsNumber(p))
                            break;
                    }
                    p = c;
                }
                if (!numFound)
                    num = "000";
                num = reverse(num);

                //increment
                ulong nextInt = ulong.Parse(num);
                ++nextInt;

                //For zeros
                string newInt = nextInt.ToString();
                newInt = reverse(newInt);
                if (newInt.Length != num.Length)
                {
                    int i = 0;
                    int diff = num.Length - newInt.Length;
                    while (i < diff)
                    {
                        newInt += "0";
                        ++i;
                    }
                }
                newInt = reverse(newInt);

                //place on original string
                string nextCode = String.Empty;
                if (numFound)
                {
                    //replace only the last occurence
                    int loc = original.LastIndexOf(num);
                    nextCode = original.Remove(loc, num.Length).Insert(loc, newInt);
                    return nextCode;
                }
            }
            
            return null;
        }

        public static string reverse(string str)
        {
            char[] rev = str.ToCharArray();
            Array.Reverse(rev);
            return new String(rev); ;
        }

    }
}
