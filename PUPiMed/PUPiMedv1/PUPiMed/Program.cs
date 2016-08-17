using MetroFramework;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Reflection;
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

            /*string sql;
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "PUPiMed.Resources.database.txt";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                sql = reader.ReadToEnd();
            }

            if (!Program.ExecuteQuery(sql))
            {
                MessageBox.Show("Failed to load sql file.");
            }

            Console.ReadLine();
            

            while (Console.ReadKey().KeyChar != 'x')
            {
                Console.Write("Enter code: ");
                string x= Console.ReadLine();
                Console.WriteLine(getNextCode(x)==null?"Invalid Code.":getNextCode(x));
            }
                
            Console.ReadLine();
            */
        }

        public static void login()
        {
            user = Login.getUser();  //"admin;";
            pass = Login.getPass();

            Console.WriteLine("server= " + server +
            "user id =" + user +
            ";password=" + pass +
            ";database=" + db);

            conn.Open();
        }
        
        static string server = "localhost;";
        static string user = "admin;";
        static string pass = "admin;";
        static string db     = "dbmedicalclinic;";

        public static MySqlConnection conn = new MySqlConnection(
            "server= "  +server+
            "user id =" +user+
            ";password=" +pass+
            ";database=" +db
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
                MessageBox.Show("[ExeQ]\t"+ex.Message.ToString());
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
            //string must be alphanumeric (atleast 1 number and 1 character)
            //accepting alphanumeric character, underscore and dash
            //returns null if false
            if (Regex.IsMatch(prev, "^(?=.*?[0-9])(?=.*?[A-Za-z])[a-zA-Z0-9_-]+$"))
            {
                string original = prev;
                string num = string.Empty;
                //reverse the string bc we only need to increment the rightmost collection of numbers in the string 
                prev = reverse(prev);

                //Get Numeric Values to be incremented
                char p = '\0', c;
                //p will contain the previous character
                //c will contain the current character
                for (int i = 0; i < prev.Length; i++)
                {
                    c = prev[i];
                    if (Char.IsDigit(c))
                    {
                        num += c;
                    }
                    else
                    {
                        //if current characteris not a digit, 
                        //check if the previous one is, then break
                        //that means we already found our num string
                        if (Char.IsDigit(p))
                            break;
                    }
                    p = c;
                }
                //reverse the num string to get the original value
                num = reverse(num);

                //increment
                ulong nextInt = ulong.Parse(num);  //ulong so u could store numbers upto 18446744073709551615 
                ++nextInt;  

                //For zeros ex: (0001) 
                string newInt = nextInt.ToString();
                //reverese so u could just add zeroes at the end of the real nos
                newInt = reverse(newInt);
                if (newInt.Length < num.Length)
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

                //replace only the last occurence
                //bc ex: prev: aaa000sss000, might result to aaa001sss001
                int loc = original.LastIndexOf(num);
                nextCode = original.Remove(loc, num.Length).Insert(loc, newInt);
                return nextCode;
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
