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
            this.ListTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoveColumn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(26, 100);
            this.treeView1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(355, 744);
            this.treeView1.TabIndex = 4;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // ListTable
            // 
            this.ListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTable.Location = new System.Drawing.Point(488, 104);
            this.ListTable.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ListTable.Name = "ListTable";
            this.ListTable.RowTemplate.Height = 21;
            this.ListTable.Size = new System.Drawing.Size(947, 726);
            this.ListTable.TabIndex = 5;
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
            this.btnMoveColumn.Location = new System.Drawing.Point(1099, 830);
            this.btnMoveColumn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMoveColumn.Name = "btnMoveColumn";
            this.btnMoveColumn.Size = new System.Drawing.Size(336, 46);
            this.btnMoveColumn.TabIndex = 7;
            this.btnMoveColumn.Text = "テーブル分析";
            this.btnMoveColumn.UseVisualStyleBackColor = true;
            this.btnMoveColumn.Click += new System.EventHandler(this.btnMoveColumn_Click);
            // 
            // DispTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 900);
            this.Controls.Add(this.btnMoveColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListTable);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "DispTable";
            this.Text = "RefactoringTool";
            this.Load += new System.EventHandler(this.DispTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView ListTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoveColumn;
    }
}

