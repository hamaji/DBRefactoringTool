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

namespace RefactoringTool
{
    public partial class RecommendUI : Form
    {
        public string constr = "Data Source=NOTEMAIN\\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"; //接続情報を入れる;
        private string tablename;
        private int colCnt;
        private List<string> colNsmeList;
        public RecommendUI(string name)
        {
            tablename = name;
            InitializeComponent();
        }

        private void RecommendUI_Load(object sender, EventArgs e)
        {
            lbltableName.Text = tablename;

            SqlConnection con
            = new SqlConnection();
            con.ConnectionString = constr; //接続情報を入れる
            con.Open();

            //クエリーの生成
            SqlCommand sqlCom = new SqlCommand();

            //クエリー送信先及びトランザクションの指定
            sqlCom.Connection = con;
            //sqlCom.Transaction = this.sqlTran;

            //クエリー文の指定
            sqlCom.CommandText = "SELECT * FROM " + tablename + ";";

            //データテーブルを作成するためのアダプタ
            SqlDataAdapter sqlAda = new SqlDataAdapter();
            sqlAda.SelectCommand = sqlCom;

            DataTable dsgrid = new DataTable();
            dsgrid.Columns.Add("Column", typeof(string));
            dsgrid.Columns.Add("word2vec距離", typeof(string));
            //dsにテーブルデータを代入
            DataTable ds = new DataTable();
            sqlAda.Fill(ds);
            colCnt = ds.Columns.Count;
            colNsmeList = new List<string>();
            //List<String> columnList = new List<string>();
            foreach (DataColumn clm in ds.Columns)
            {
                //columnList.Add(clm.ColumnName);
                //var sim =getSimilarity(tablename, clm.ColumnName);
                var sim = "0";
                string[] row = new string[] { clm.ColumnName, sim };
                dsgrid.Rows.Add(row);
                colNsmeList.Add(clm.ColumnName);
            }
            //dsgrid.Rows[10]["word2vec距離"] = "0.1";

            dataGridView1.DataSource = dsgrid;
            //dataGridView1.Rows[15].DefaultCellStyle.BackColor = Color.Yellow;
        }
    }
}
