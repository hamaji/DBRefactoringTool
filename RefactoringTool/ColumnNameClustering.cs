using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Xml.Serialization;

namespace RefactoringTool
{
    public partial class テーブル分析 : Form
    {
        public テーブル分析()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //スキーマ取得
            SqlConnection con
            = new SqlConnection();
            con.ConnectionString = "Data Source=HK-HP\\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"; //接続情報を入れる
            con.Open();

            DataTable dt = con.GetSchema("Tables");

            var dtColumns = con.GetSchema("Columns");


            String[] str = { null, null, "listings_in_Amsterdam" };
            var sColumns = con.GetSchema("Columns", str);
            var dview = new DataView(sColumns);
            dataGridView1.DataSource = dview;


            con.Close();
        }

        private void ColumnNameClustering_Load(object sender, EventArgs e)
        {
            //スキーマ取得
            SqlConnection con
            = new SqlConnection();
            con.ConnectionString = "Data Source=HK-HP\\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"; //接続情報を入れる
            con.Open();

            //クエリーの生成
            SqlCommand sqlCom = new SqlCommand();

            //クエリー送信先及びトランザクションの指定
            sqlCom.Connection = con;
            //sqlCom.Transaction = this.sqlTran;

            //クエリー文の指定
            sqlCom.CommandText = "SELECT * FROM 社員;";

            //データテーブルを作成するためのアダプタ
            SqlDataAdapter sqlAda = new SqlDataAdapter();
            sqlAda.SelectCommand = sqlCom;

            DataTable dsgrid = new DataTable();
            dsgrid.Columns.Add("Column", typeof(string));
            dsgrid.Columns.Add("Jasccard距離", typeof(string));
            //dsにテーブルデータを代入
            DataTable ds = new DataTable();
            sqlAda.Fill(ds);
            List<String> columnList = new List<string>();
            foreach (DataColumn clm in ds.Columns)
            {
                columnList.Add(clm.ColumnName);
                getSim(clm.ColumnName);
                string[] row = new string[] { clm.ColumnName, "1.3" };
                dsgrid.Rows.Add(row);
            }
            //dsgrid.Rows[15]["DISTANCE"] = "2.0";

            dataGridView1.DataSource = dsgrid;
            //dataGridView1.Rows[15].DefaultCellStyle.BackColor = Color.Yellow;
            
        }

        

            static String ENDPOINT = "https://api.apitore.com/api/8/word2vec-neologd-jawiki/similarity";
            static String ACCESS_TOKEN = "cab33c5e-815a-40f7-8725-2341f562e0cc";

            public void getSim(string word2)
            {
                String url = ENDPOINT + "?access_token=" + ACCESS_TOKEN + "&word1=社員&word2="+word2;
                //params.put("word1", "ポメラニアン");
                //params.put("word2", "ゴールデンレトリバー");
                //String url = UrlFormatter.format(ENDPOINT, params);

                // HTTPアクセス
                var req = WebRequest.Create(url);
                req.Headers.Add("Accept-Language:ja,en-us;q=0.7,en;q=0.3");
                var res = req.GetResponse();

                Encoding enc = Encoding.GetEncoding("UTF-8");
                Stream st = res.GetResponseStream();
                StreamReader sr = new StreamReader(st, enc);
                string xml = sr.ReadToEnd();
            }
        }
}
