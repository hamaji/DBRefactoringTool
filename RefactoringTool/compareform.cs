using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace RefactoringTool
{
    public partial class compareform : Form
    {
        public compareform()
        {
            InitializeComponent();
            webTablelist.Navigate("D:\\work\\RefGraph\\TablelistGraph2.html");
            webColumnNameToColumn.Navigate("D:\\work\\RefGraph\\ColmunNameToColmun2.html");
            webColumnNameToColumn2.Navigate("D:\\work\\RefGraph\\ColmunNameToColmun3.html");
            using (NpgsqlConnection conn = new NpgsqlConnection(DispTable.conn_str))
            {

                conn.Open();

                DataTable dt = conn.GetSchema("Tables");
                string[] selectColumns = new string[] { "TABLE_NAME" };
                DataTable selectTable = dt.DefaultView.ToTable("selectTable", false, selectColumns);
                DataRow[] datarows = selectTable.Select();

                foreach (DataRow datarow in datarows)
                {
                    List<tebleworkspace.tablelist> _tasks = new List<tebleworkspace.tablelist>();

                    string tablename = datarow.Field<string>("TABLE_NAME");
                    dsTablelist.Rows.Add(true, tablename);
                    cmdTablelist1.Items.Add(tablename);
                    cmdTablelist2.Items.Add(tablename);

                }

                cmdTablelist1.SelectedIndex = 0;
                cmdTablelist2.SelectedIndex = 1;
                dispTableSchema(conn,"予約");
                dispTableSchema2(conn, "電子会議投稿");
            }
        }

        private void dispTableSchema(NpgsqlConnection con, string tablename)
        {
            // データアダプタオブジェクトの作成
            var adapter = new NpgsqlDataAdapter("SELECT COLUMN_NAME ,  DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tablename + "' ORDER BY TABLE_NAME, ORDINAL_POSITION", con);

            // データセットオブジェクトの作成
            var dsSchema = new DataSet();

            // 抽出したデータをデータセットに格納
            adapter.Fill(dsSchema);

            // DataGridViewのデータソースにデータセットのテーブルをバインド
            this.dgSchema.DataSource = dsSchema.Tables[0];

        }

        private void dispTableSchema2(NpgsqlConnection con, string tablename)
        {
            // データアダプタオブジェクトの作成
            var adapter = new NpgsqlDataAdapter("SELECT COLUMN_NAME ,  DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tablename + "' ORDER BY TABLE_NAME, ORDINAL_POSITION", con);

            // データセットオブジェクトの作成
            var dsSchema = new DataSet();

            // 抽出したデータをデータセットに格納
            adapter.Fill(dsSchema);

            // DataGridViewのデータソースにデータセットのテーブルをバインド
            this.dgSchema2.DataSource = dsSchema.Tables[0];

        }
    }
}
