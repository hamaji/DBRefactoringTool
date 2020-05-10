namespace RefactoringTool
{
    partial class DispTable
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoveColumn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ListTable = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webTableList = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.treeView1.Location = new System.Drawing.Point(26, 100);
            this.treeView1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(419, 859);
            this.treeView1.TabIndex = 4;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "テーブル一覧";
            // 
            // btnMoveColumn
            // 
            this.btnMoveColumn.Location = new System.Drawing.Point(790, 1266);
            this.btnMoveColumn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMoveColumn.Name = "btnMoveColumn";
            this.btnMoveColumn.Size = new System.Drawing.Size(336, 46);
            this.btnMoveColumn.TabIndex = 7;
            this.btnMoveColumn.Text = "カラムワークスペース";
            this.btnMoveColumn.UseVisualStyleBackColor = true;
            this.btnMoveColumn.Click += new System.EventHandler(this.btnMoveColumn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(473, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1376, 1136);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListTable);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1360, 1089);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "テーブルデータ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ListTable
            // 
            this.ListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTable.Location = new System.Drawing.Point(6, 24);
            this.ListTable.Name = "ListTable";
            this.ListTable.RowHeadersWidth = 82;
            this.ListTable.RowTemplate.Height = 33;
            this.ListTable.Size = new System.Drawing.Size(1320, 1019);
            this.ListTable.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webTableList);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1492, 1089);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "テーブルグラフ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webTableList
            // 
            this.webTableList.Location = new System.Drawing.Point(6, 6);
            this.webTableList.MinimumSize = new System.Drawing.Size(20, 20);
            this.webTableList.Name = "webTableList";
            this.webTableList.Size = new System.Drawing.Size(1483, 1080);
            this.webTableList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1249, 1261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "テーブルワークスペース";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // DispTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 1101);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnMoveColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "DispTable";
            this.Text = "RefactoringTool";
            this.Load += new System.EventHandler(this.DispTable_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoveColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView ListTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webTableList;
        private System.Windows.Forms.Button button1;
    }
}

