using Npgsql;
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
    public partial class DispTable : Form
    {
        //public static string constr = "Data Source=localhost;Initial Catalog=testDB;Integrated Security=True;Connection Timeout=30"; //接続情報を入れる;
        public static string conn_str = "Server=localhost;Port=5432;User ID=postgres;Database=postgres;Password=2710;Enlist=true";

        private string tablename;
        public DispTable()
        {
            InitializeComponent();
            using (NpgsqlConnection conn = new NpgsqlConnection(conn_str))
            {
                //PostgreSQLへ接続
                conn.Open();
                Console.WriteLine("Connection success!");
                
            }

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //RefactoringTable frm = new RefactoringTable();
            //frm.Show();
            //Form2に送るテキスト
            string sendText = (string)ListTable.CurrentCell.Value;

            //Form2から送られてきたテキストを受け取る。
            //string receiveText = RefactoringTable.ShowMiniForm(sendText);　//Form2を開く

        }

        private void DispTable_Load(object sender, EventArgs e)
        {
            TreeNode treeNodeDummy = new TreeNode("postgres");
            TreeNode[] treeInstance3 = { treeNodeDummy };
            TreeNode treeNodeSQLEXPRESS = new TreeNode("postgres", treeInstance3);
            TreeNode[] treeInstance = { treeNodeSQLEXPRESS };
            TreeNode treeNodeHKHP = new TreeNode("postgresSQL11", treeInstance);
            

            TreeNode[] treeDatabases = { treeNodeHKHP };
            TreeNode treeDatabase = new TreeNode("Servers", treeDatabases);

            //TreeNode treeNodeDrink = new TreeNode("HK-HP");

            TreeNode[] treeNodeRoot = { treeDatabase };
            treeView1.Nodes.AddRange(treeNodeRoot);

            webTableList.Navigate("D:\\work\\RefGraph\\TablelistGraph.html");
            //webBrowser2.Navigate("D:\\work\\RefGraph\\d3jsforceTablelist2.html");

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMoveColumn_Click(object sender, EventArgs e)
        {
            テーブル分析 frm = new テーブル分析(tablename);
            frm.Show();
        }

        private void btnDispTable_Click(object sender, EventArgs e)
        {
            //スキーマ取得
            //System.Data.SqlClient.SqlConnection con
            //= new System.Data.SqlClient.SqlConnection();
            //con.ConnectionString = constr; //接続情報を入れる
            //con.Open();


            //DataTable dt = con.GetSchema("Tables");

            using (NpgsqlConnection conn = new NpgsqlConnection(conn_str))
            {
                //PostgreSQLへ接続
                conn.Open();
                Console.WriteLine("Connection success!");
                DataTable dt = conn.GetSchema("Tables");
            }
        }

        //private int counter = 0;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            テーブル分析 frm = new テーブル分析(tablename);
            frm.Show();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.Level == 3)
            {
                tablename = e.Node.Text;
                if (tablename == "Dummy") return;

                using (NpgsqlConnection conn = new NpgsqlConnection(conn_str))
                {
                    //PostgreSQLへ接続
                    conn.Open();
                    Console.WriteLine("Connection success!");
                    DataTable dt = conn.GetSchema("Tables");

                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM " + e.Node.Text + ";";
                    NpgsqlDataAdapter npgAda = new NpgsqlDataAdapter();

                    npgAda.SelectCommand = cmd;
                    DataTable ds = new DataTable();
                    npgAda.Fill(ds);

                    ListTable.DataSource = ds;
                }

            }
            
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

            if (e.Node.Level == 2 && e.Node.Nodes.Count ==1)
            {
                var st = e.Node.Text;

                using (NpgsqlConnection conn = new NpgsqlConnection(conn_str))
                {
                    //PostgreSQLへ接続
                    conn.Open();
                    Console.WriteLine("Connection success!");
                    DataTable dt = conn.GetSchema("Tables");


                    string[] selectColumns = new string[] { "TABLE_NAME" };
                    DataTable selectTable = dt.DefaultView.ToTable("selectTable", false, selectColumns);
                    DataRow[] datarows = selectTable.Select();

                    //dt.DefaultView()

                    foreach (DataRow datarow in datarows)
                    {
                        TreeNode treeNodeNew = new TreeNode(datarow.Field<string>("TABLE_NAME"));
                        e.Node.Nodes.Add(treeNodeNew);
                    }
                }
                //ListTable.DataSource = selectTable;

                //con.Close();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //RecommendUI frm = new RecommendUI("社員");
            //frm.Show();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            tebleworkspace frm = new tebleworkspace();
            frm.Show();
        }
    }
}
