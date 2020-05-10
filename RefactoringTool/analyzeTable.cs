using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using RDotNet;
using System.Drawing;
using Npgsql;

namespace RefactoringTool
{
    public partial class テーブル分析 : Form
    {
        private string url = "https://api.apitore.com/api/8/word2vec-neologd-jawiki/similarity?access_token=b15f2e8b-8986-46cb-8c73-36e76a483c51&word1=%E4%BC%9A%E7%A4%BE&word2=%E4%BA%88%E7%AE%97";
        private string tablename;
        private int colCnt;
        private List<string> colNsmeList;
        DataTable dsgrid2;

        private List<tablelist> _tasks;

        public テーブル分析(string name)
        {
            tablename = name;
            InitializeComponent();
        }


        private void ColumnNameClustering_Load(object sender, EventArgs e)
        {
            lblTableName.Text = tablename;

            using (NpgsqlConnection conn = new NpgsqlConnection(DispTable.conn_str))
            {
                conn.Open();

                //スキーマ表示
                dispTableSchema(conn);

                //dispTableColumn(conn);

                //dispColumn_Column(conn);


                //string[] row2 = new string[] { "0", "1" };
                //dsgridbetCol.Rows.Add(row2);
                //dsgridColdis.DataSource = dsgridbetCol;

                //Nullclustering();
                //dsgrid2 = new DataTable();
                //dsgrid2.Columns.Add("移行Column", typeof(string));
                //dsgrid2.Columns.Add("距離", typeof(string));
                //dataGridView2.DataSource = dsgrid2;

                webtableNameToColumn.Navigate("D:\\work\\RefGraph\\tableNameToColmun.html");
                webColumnNameToColumn.Navigate("D:\\work\\RefGraph\\ColmunNameToColmun.html");
                webtableColumnMerge.Navigate("D:\\work\\RefGraph\\ColmunTableMerge.html");

                DataTable dt = conn.GetSchema("Tables");
                string[] selectColumns = new string[] { "TABLE_NAME" };
                DataTable selectTable = dt.DefaultView.ToTable("selectTable", false, selectColumns);
                DataRow[] datarows = selectTable.Select();


                foreach (DataRow datarow in datarows)
                {
                    _tasks = new List<tablelist>();

                    string tablename = datarow.Field<string>("TABLE_NAME");
                    dsTablelist.Rows.Add(false, tablename);

                }
                DataTable dt2 = conn.GetSchema("Columns");
                //dgSchema.DataSource = dt2;

            }

        }



        static String ENDPOINT = "https://api.apitore.com/api/8/word2vec-neologd-jawiki/similarity";
        static String ACCESS_TOKEN = "b15f2e8b-8986-46cb-8c73-36e76a483c51";

        //public void getSim(string word2)
        //{
        //    String url = ENDPOINT + "?access_token=" + ACCESS_TOKEN + "&word1=社員&word2=" + word2;
        //    //params.put("word1", "ポメラニアン");
        //    //params.put("word2", "ゴールデンレトリバー");
        //    //String url = UrlFormatter.format(ENDPOINT, params);

        //    // HTTPアクセス
        //    var req = WebRequest.Create(url);
        //    req.Headers.Add("Accept-Language:ja,en-us;q=0.7,en;q=0.3");
        //    var res = req.GetResponse();

        //    Encoding enc = Encoding.GetEncoding("UTF-8");
        //    Stream st = res.GetResponseStream();
        //    StreamReader sr = new StreamReader(st, enc);
        //    string xml = sr.ReadToEnd();
        //}

        public string getSimilarity(string word1, string word2)
        {
            String url = ENDPOINT + "?access_token=" + ACCESS_TOKEN + "&word1=" + word1 + "&word2=" + word2;
            //params.put("word1", "ポメラニアン");
            //params.put("word2", "ゴールデンレトリバー");
            //String url = UrlFormatter.format(ENDPOINT, params);

            // HTTPアクセス
            var req = WebRequest.Create(url);
            req.Headers.Add("Accept-Language:ja,en-us;q=0.7,en;q=0.3");
            var res = req.GetResponse();

            Encoding enc = Encoding.GetEncoding("UTF-8");
            //Stream st = res.GetResponseStream();

            //StreamReader sr = new StreamReader(st, enc);
            //string xml = sr.ReadToEnd();

            // レスポンス(JSON)をオブジェクトに変換
            ServiceResult info;
            using (res)
            {
                using (var resStream = res.GetResponseStream())
                {
                    var serializer = new DataContractJsonSerializer(typeof(ServiceResult));
                    info = (ServiceResult)serializer.ReadObject(resStream);
                }
            }

            return info.similarity;
        }

        private string Nullclustering()
        {
            //CSV作成
            using (NpgsqlConnection conn = new NpgsqlConnection(DispTable.conn_str))
            {
                
                //クエリーの生成
                NpgsqlCommand sqlCom = new NpgsqlCommand();

                //クエリー送信先及びトランザクションの指定
                sqlCom.Connection = conn;
                //sqlCom.Transaction = this.sqlTran;
                var str = "case " + colNsmeList[0] + " when null then 0 else 1 end AS " + colNsmeList[0];
                //カラム作成
                for (int k = 1; k < colCnt; k++)
                {
                    str += ",case when " + colNsmeList[k] + " is null then 0 else 1 end AS " + colNsmeList[k];
                }
                //クエリー文の指定
                sqlCom.CommandText = "SELECT " + str + " FROM " + tablename + ";";

                //データテーブルを作成するためのアダプタ
                NpgsqlDataAdapter sqlAda = new NpgsqlDataAdapter();
                sqlAda.SelectCommand = sqlCom;

                DataTable dsNull = new DataTable();
                sqlAda.Fill(dsNull);
            }
            //dataGridNULLCluster.DataSource = dsNull;

            //ConvertDataTableToCsv(dsNull, "c:/work/datasnull.csv", true);
            //Rの前準備
            var envPath = Environment.GetEnvironmentVariable("PATH");
            var rBinPath = @"C:\Program Files\R\R-3.4.2\bin\x64";
            Environment.SetEnvironmentVariable("PATH", envPath + Path.PathSeparator + rBinPath);
            //using (REngine engine = REngine.CreateInstance("RDotNet"))
            //{
            //    engine.Initialize();

            //    double[] xs, ys;
            //    CreateNoisedSine(out xs, out ys);

            //    NumericVector x = engine.CreateNumericVector(xs);
            //    engine.SetSymbol("x", x);
            //    NumericVector y = engine.CreateNumericVector(ys);
            //    engine.SetSymbol("y", y);

            //    GenericVector response = engine.Evaluate("smooth.spline(x, y, df=5, all.knots=TRUE)").AsList();
            //    NumericVector smoothed = response["y"].AsNumeric();
            //}
            int i = 0;
            REngine.SetEnvironmentVariables();
            REngine engine = REngine.GetInstance();

            engine.Initialize();

            engine.Evaluate("setwd('c:/work')");
            engine.Evaluate("getwd()").AsCharacter();
            engine.Evaluate("y <- read.csv('datasnull.csv')");
            engine.Evaluate("y").AsCharacter();
            engine.Evaluate("km =kmeans(y,2)");
            CharacterVector text = engine.Evaluate("km$cluster").AsCharacter();

            CharacterVector table = engine.Evaluate("table(km$cluster)").AsCharacter();

            string mins;
            if (int.Parse(table[0]) < int.Parse(table[1]))
            {
                mins = "1";
            }
            else
            {
                mins = "2";
            }
            foreach (string t in text)
            {
                //richTextBox1.Text += colNsmeList[i] + "　" + t + " ";

                if (t == mins)
                {
                    //dataGridNULLCluster.Columns[i].DefaultCellStyle.ForeColor = Color.Red;
                }
                i++;
            }
            CharacterVector ret = engine.Evaluate("table(km$cluster)").AsCharacter();
            //richTextBox1.Text += "\nクラスタ1  要素数　" + table[0] + " クラスタ2　要素数" + table[1] + "\n";
            engine.Dispose();
            return null;
        }



        [DataContract]
        public class ServiceResult
        {

            [DataMember]
            public string log { get; set; }
            [DataMember]
            public string startTime { get; set; }
            [DataMember]
            public string endTime { get; set; }
            [DataMember]
            public string processTime { get; set; }
            [DataMember]
            public string word1 { get; set; }
            [DataMember]
            public string word2 { get; set; }
            [DataMember]
            public string similarity { get; set; }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Nullclustering();
        }

        /// <summary>
        /// DataTableの内容をCSVファイルに保存する
        /// </summary>
        /// <param name="dt">CSVに変換するDataTable</param>
        /// <param name="csvPath">保存先のCSVファイルのパス</param>
        /// <param name="writeHeader">ヘッダを書き込む時はtrue。</param>
        public void ConvertDataTableToCsv(
            DataTable dt, string csvPath, bool writeHeader)
        {
            //CSVファイルに書き込むときに使うEncoding
            System.Text.Encoding enc =
                System.Text.Encoding.GetEncoding("Shift_JIS");

            //書き込むファイルを開く
            System.IO.StreamWriter sr =
                new System.IO.StreamWriter(csvPath, false, enc);

            int colCount = dt.Columns.Count;
            int lastColIndex = colCount - 1;

            //ヘッダを書き込む
            if (writeHeader)
            {
                for (int i = 0; i < colCount; i++)
                {
                    //ヘッダの取得
                    string field = dt.Columns[i].Caption;
                    //"で囲む
                    field = EncloseDoubleQuotesIfNeed(field);
                    //フィールドを書き込む
                    sr.Write(field);
                    //カンマを書き込む
                    if (lastColIndex > i)
                    {
                        sr.Write(',');
                    }
                }
                //改行する
                sr.Write("\r\n");
            }

            //レコードを書き込む
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < colCount; i++)
                {
                    //フィールドの取得
                    string field = row[i].ToString();
                    //"で囲む
                    field = EncloseDoubleQuotesIfNeed(field);
                    //フィールドを書き込む
                    sr.Write(field);
                    //カンマを書き込む
                    if (lastColIndex > i)
                    {
                        sr.Write(',');
                    }
                }
                //改行する
                sr.Write("\r\n");
            }

            //閉じる
            sr.Close();
        }

        /// <summary>
        /// 必要ならば、文字列をダブルクォートで囲む
        /// </summary>
        private string EncloseDoubleQuotesIfNeed(string field)
        {
            if (NeedEncloseDoubleQuotes(field))
            {
                return EncloseDoubleQuotes(field);
            }
            return field;
        }

        /// <summary>
        /// 文字列をダブルクォートで囲む
        /// </summary>
        private string EncloseDoubleQuotes(string field)
        {
            if (field.IndexOf('"') > -1)
            {
                //"を""とする
                field = field.Replace("\"", "\"\"");
            }
            return "\"" + field + "\"";
        }

        /// <summary>
        /// 文字列をダブルクォートで囲む必要があるか調べる
        /// </summary>
        private bool NeedEncloseDoubleQuotes(string field)
        {
            return field.IndexOf('"') > -1 ||
                field.IndexOf(',') > -1 ||
                field.IndexOf('\r') > -1 ||
                field.IndexOf('\n') > -1 ||
                field.StartsWith(" ") ||
                field.StartsWith("\t") ||
                field.EndsWith(" ") ||
                field.EndsWith("\t");
        }


        private void dispTableSchema(NpgsqlConnection con)
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

        private void dispTableColumn(NpgsqlConnection con)
        {
            // データアダプタオブジェクトの作成
            var adapter = new NpgsqlDataAdapter("SELECT *  FROM テーブルカラム名距離", con);

            // データセットオブジェクトの作成
            var dsSchema = new DataSet();

            // 抽出したデータをデータセットに格納
            adapter.Fill(dsSchema);

            // DataGridViewのデータソースにデータセットのテーブルをバインド
            this.dgTableColumn.DataSource = dsSchema.Tables[0];

        }

        private void dispColumn_Column(NpgsqlConnection con)
        {
            // データアダプタオブジェクトの作成
            var adapter = new NpgsqlDataAdapter("SELECT *  FROM カラム間距離", con);

            // データセットオブジェクトの作成
            var dsSchema = new DataSet();

            // 抽出したデータをデータセットに格納
            adapter.Fill(dsSchema);

            // DataGridViewのデータソースにデータセットのテーブルをバインド
            this.dgColumn_Column.DataSource = dsSchema.Tables[0];

        }

        private void btnInit_Click(object sender, EventArgs e)
        {

        }

        public class tablelist
        {
            public bool 選択 { get; set; }

            public string テーブル名 { get; set; }

        }

        private void Btnhikaku_Click(object sender, EventArgs e)
        {
            compareform frm = new compareform();
            frm.Show();
        }
    }
}
