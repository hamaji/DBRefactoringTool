using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace RefactoringTool
{
    public partial class tebleworkspace : Form
    {
        private List<tablelist> _tasks;
        public tebleworkspace()
        {
            InitializeComponent();

            webBrowser1.Navigate("D:\\work\\RefGraph\\TablelistGraph2.html");

            using (NpgsqlConnection conn = new NpgsqlConnection(DispTable.conn_str))
            {

                conn.Open();

                DataTable dt = conn.GetSchema("Tables");
                string[] selectColumns = new string[] { "TABLE_NAME" };
                DataTable selectTable = dt.DefaultView.ToTable("selectTable", false, selectColumns);
                DataRow[] datarows = selectTable.Select();

                foreach (DataRow datarow in datarows)
                {
                    _tasks = new List<tablelist>();

                    string tablename = datarow.Field<string>("TABLE_NAME");
                    dsTablelist.Rows.Add(true, tablename);
                    cmdTablelist.Items.Add(tablename);

                }
            }
            
        }

        public class tablelist
        {
            public bool 選択 { get; set; }

            public string テーブル名 { get; set; }

        }
    }
}
