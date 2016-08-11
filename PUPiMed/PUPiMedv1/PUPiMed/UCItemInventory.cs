using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class UCItemInventory : UserControl
    {
        public UCItemInventory()
        {
            InitializeComponent();
            updateTable();
        }
        
        public void updateTable()
        {
            string strQuery = 
                "select a.strItemCode AS 'Item Code', "+
                   " a.strItemName AS 'Item Name',"+
                   " SUM(b.intAcqDQty) AS 'Quantity',"+
                   " ifnull(c.intBDIDQty, 0) + ifnull(d.intLogDQty, 0) AS 'Consumed'"+
                " from tblItem a INNER JOIN tblacqudetail b on b.strAcqDItemCode = a.strItemCode"+
                       " LEFT JOIN tbllogsdetail d on a.strItemCode = d.intLogDQty"+
"                        LEFT JOIN tblbranchdistributionitemdetail c on a.strItemCode = c.strBDIDItemCode"+
                " where boolItemDeleted = 0 "+
                " group by strItemCode;";
            using (Program.conn)
            {
                using (MySqlCommand cmd = new MySqlCommand(strQuery, Program.conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            if (dt != null)
                            {
                                sda.Fill(dt);
                                gridItemInventory.DataSource = dt;
                            }
                            else
                            {
                            }

                        }
                    }
                }
            }
        }

        private void ReceiveInventory_Click(object sender, EventArgs e)
        {
            new FormReceiveInventory().Show();
        }
    }
}
