using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class UCItemLibrary : UserControl
    {
        public UCItemLibrary()
        {
            InitializeComponent();
            updateTable();
        }

        public void updateTable()
        {
            using (Program.conn)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT STRITEMCODE AS 'ITEM CODE'," +
                                "CASE WHEN INTITEMTYPE = 1 THEN 'MEDICINE' WHEN INTITEMTYPE = 2 THEN 'SUPPLY' ELSE 'EQUIPMENT' END AS TYPE," +
                                "STRITEMNAME AS NAME, STRITEMGENERIC AS 'GENERIC NAME', STRITEMMANUCODE AS MANUFACTURER," +
                                "INTITEMMIN AS MIN, INTITEMMAX AS MAX FROM TBLITEM WHERE BOOLITEMDELETED = FALSE;"
                                 , Program.conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            if (dt != null)
                            {
                                sda.Fill(dt);
                                gridItemLibrary.DataSource = dt;
                            }
                            else
                            {
                                 }

                        }
                    }
                }
            }
        }
    }
}
