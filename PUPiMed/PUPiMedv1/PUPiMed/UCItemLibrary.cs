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
                using (MySqlCommand cmd = new MySqlCommand(
                                "SELECT CASE WHEN INTITEMTYPE = 1 THEN 'Medicine' WHEN INTITEMTYPE = 2 THEN 'Supply' ELSE 'Equipment' END AS Type," +
                                "strItemCode AS 'Item Code', strItemName AS Medicine, strItemGeneric AS 'Generic Name', b.strManuName AS Manufacturer, intItemMin as Min, intItemMax as Max FROM tblItem, tblManufacturer b WHERE (boolItemDeleted=0 AND strItemManuCode=b.strManuCode);"
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
