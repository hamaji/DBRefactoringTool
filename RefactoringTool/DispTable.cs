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
        public string constr = "Data Source=HK-HP\\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"; //接続情報を入れる;
        private string tablename;
        public DispTable()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //RefactoringTable frm = new RefactoringTable();
            //frm.Show();
            //Form2に送るテキスト
            string sendText = (string)ListTable.CurrentCell.Value;

            //Form2から送られてきたテキストを受け取る。
            string receiveText = RefactoringTable.ShowMiniForm(sendText);　//Form2を開く

        }

        private void DispTable_Load(object sender, EventArgs e)
        {
            TreeNode treeNodeDummy = new TreeNode("Dummy");
            TreeNode[] treeInstance3 = { treeNodeDummy };
            TreeNode treeNodeSQLEXPRESS = new TreeNode("SQLEXPRESS", treeInstance3);
            TreeNode[] treeInstance = { treeNodeSQLEXPRESS };
            TreeNode treeNodeHKHP = new TreeNode("HK-HP", treeInstance);
            

            TreeNode[] treeDatabases = { treeNodeHKHP };
            TreeNode treeDatabase = new TreeNode("データベース", treeDatabases);

            //TreeNode treeNodeDrink = new TreeNode("HK-HP");

            TreeNode[] treeNodeRoot = { treeDatabase };
            treeView1.Nodes.AddRange(treeNodeRoot);

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
            System.Data.SqlClient.SqlConnection con
            = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = constr; //接続情報を入れる
            con.Open();


            DataTable dt = con.GetSchema("Tables");

            //foreach (DataRow row in dt.Rows)
            {

                //ListTable.DataSource = dt;
            }


            con.Close();
        }

        //private int counter = 0;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (counter > 0)
            //{
            //    if (e.Node.Level == 2)
            //    {
            //        var st = e.Node.Text;
            //        TreeNode treeNodeNew =
            //          new TreeNode("追加" + counter.ToString());
            //        //e.Node.Nodes.Add(treeNodeNew);

            //        System.Data.SqlClient.SqlConnection con= new System.Data.SqlClient.SqlConnection();
            //        con.ConnectionString = constr; //接続情報を入れる
            //        con.Open();
                    
            //        DataTable dt = con.GetSchema("Tables");
            //        string[] selectColumns = new string[] { "TABLE_NAME" };
            //        DataTable selectTable = dt.DefaultView.ToTable("selectTable", false, selectColumns);
            //        //dt.DefaultView()
            //        //ListTable.DataSource = selectTable;
                    
            //        con.Close();
            //    }
            //}
            //counter++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            テーブル分析 frm = new テーブル分析("社員");
            frm.Show();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.Level == 3)
            {
                tablename = e.Node.Text;
                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-3G3RB41\\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"; //接続情報を入れる
                con.Open();
                //クエリーの生成
                SqlCommand sqlCom = new SqlCommand();

                //クエリー送信先及びトランザクションの指定
                sqlCom.Connection = con;
                //sqlCom.Transaction = this.sqlTran;

                //クエリー文の指定
                sqlCom.CommandText = "SELECT * FROM " + e.Node.Text +";";

                //データテーブルを作成するためのアダプタ
                SqlDataAdapter sqlAda = new SqlDataAdapter();
                sqlAda.SelectCommand = sqlCom;
                DataTable ds = new DataTable();
                sqlAda.Fill(ds);

                ListTable.DataSource = ds;

                con.Close();
            }
            
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

            if (e.Node.Level == 2 && e.Node.Nodes.Count ==1)
            {
                var st = e.Node.Text;

                //e.Node.Nodes.Add(treeNodeNew);

                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-3G3RB41\\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"; //接続情報を入れる
                con.Open();

                DataTable dt = con.GetSchema("Tables");
                string[] selectColumns = new string[] { "TABLE_NAME" };
                DataTable selectTable = dt.DefaultView.ToTable("selectTable", false, selectColumns);
                DataRow[] datarows = selectTable.Select();
                //dt.DefaultView()

                foreach (DataRow datarow in datarows)
                {
                    TreeNode treeNodeNew = new TreeNode(datarow.Field<string>("TABLE_NAME"));
                    e.Node.Nodes.Add(treeNodeNew);
                }
                //ListTable.DataSource = selectTable;

                con.Close();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RecommendUI frm = new RecommendUI("社員");
            frm.Show();
        }
    }
}
