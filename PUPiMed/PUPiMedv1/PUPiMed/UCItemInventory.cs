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
                   " SUM(b.intReceQty) AS 'Quantity',"+
                   " ifnull(c.intBDIDQty, 0) + ifnull(d.intLogDQty, 0) AS 'Consumed'"+
                " from tblItem a INNER JOIN tblrecedetail b on b.strReceItemCode = a.strItemCode"+
                       " LEFT JOIN tbllogsdetail d on a.strItemCode = d.intLogDQty"+
"                        LEFT JOIN tblbranitemdetail c on a.strItemCode = c.strBDIDItemCode"+
                " where boolItemDeleted = 0 "+
                " group by strItemCode;";
            using (Program.conn)
            {
                using (MySqlCommand cmd = new MySqlCommand(strQuery, Program.conn))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        try
                        {
                            sda.Fill(dt);
                            gridItemInventory.DataSource = dt;

                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                        finally
                        {
                            dt.Dispose();
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
