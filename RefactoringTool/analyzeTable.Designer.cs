namespace RefactoringTool
{
    partial class テーブル分析
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabC1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgTableColumn = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.webtableNameToColumn = new System.Windows.Forms.WebBrowser();
            this.スキーマ変更 = new System.Windows.Forms.TabPage();
            this.dgSchema = new System.Windows.Forms.DataGridView();
            this.lblTableName = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgColumn_Column = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webColumnNameToColumn = new System.Windows.Forms.WebBrowser();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label4 = new System.Windows.Forms.Label();
            this.dsTablelist = new System.Windows.Forms.DataGridView();
            this.選択 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.テーブル名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.webtableColumnMerge = new System.Windows.Forms.WebBrowser();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnhikaku = new System.Windows.Forms.Button();
            this.tabC1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableColumn)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.スキーマ変更.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchema)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgColumn_Column)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTablelist)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabC1
            // 
            this.tabC1.Controls.Add(this.tabPage1);
            this.tabC1.Controls.Add(this.tabPage4);
            this.tabC1.Controls.Add(this.スキーマ変更);
            this.tabC1.Location = new System.Drawing.Point(591, 186);
            this.tabC1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabC1.Name = "tabC1";
            this.tabC1.SelectedIndex = 0;
            this.tabC1.Size = new System.Drawing.Size(962, 1002);
            this.tabC1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgTableColumn);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage1.Size = new System.Drawing.Size(946, 955);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tableName result";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgTableColumn
            // 
            this.dgTableColumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTableColumn.Location = new System.Drawing.Point(8, 32);
            this.dgTableColumn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgTableColumn.Name = "dgTableColumn";
            this.dgTableColumn.RowHeadersVisible = false;
            this.dgTableColumn.RowTemplate.Height = 21;
            this.dgTableColumn.Size = new System.Drawing.Size(969, 776);
            this.dgTableColumn.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.webtableNameToColumn);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage4.Size = new System.Drawing.Size(946, 955);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "colunm graph";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // webtableNameToColumn
            // 
            this.webtableNameToColumn.Location = new System.Drawing.Point(35, 42);
            this.webtableNameToColumn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.webtableNameToColumn.MinimumSize = new System.Drawing.Size(43, 40);
            this.webtableNameToColumn.Name = "webtableNameToColumn";
            this.webtableNameToColumn.Size = new System.Drawing.Size(966, 856);
            this.webtableNameToColumn.TabIndex = 0;
            // 
            // スキーマ変更
            // 
            this.スキーマ変更.Controls.Add(this.dgSchema);
            this.スキーマ変更.Location = new System.Drawing.Point(8, 39);
            this.スキーマ変更.Name = "スキーマ変更";
            this.スキーマ変更.Padding = new System.Windows.Forms.Padding(3);
            this.スキーマ変更.Size = new System.Drawing.Size(946, 955);
            this.スキーマ変更.TabIndex = 4;
            this.スキーマ変更.Text = "スキーマ変更";
            this.スキーマ変更.UseVisualStyleBackColor = true;
            // 
            // dgSchema
            // 
            this.dgSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSchema.Location = new System.Drawing.Point(28, 43);
            this.dgSchema.Name = "dgSchema";
            this.dgSchema.RowTemplate.Height = 33;
            this.dgSchema.Size = new System.Drawing.Size(906, 894);
            this.dgSchema.TabIndex = 0;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(52, 172);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(134, 24);
            this.lblTableName.TabIndex = 14;
            this.lblTableName.Text = "表示テーブル";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(2779, 1222);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(165, 62);
            this.btnInit.TabIndex = 17;
            this.btnInit.Text = "変更初期化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "テーブルカラム分析";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(1581, 186);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 1002);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgColumn_Column);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage2.Size = new System.Drawing.Size(946, 955);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tableName result";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgColumn_Column
            // 
            this.dgColumn_Column.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgColumn_Column.Location = new System.Drawing.Point(8, 32);
            this.dgColumn_Column.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgColumn_Column.Name = "dgColumn_Column";
            this.dgColumn_Column.RowHeadersVisible = false;
            this.dgColumn_Column.RowTemplate.Height = 21;
            this.dgColumn_Column.Size = new System.Drawing.Size(969, 776);
            this.dgColumn_Column.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webColumnNameToColumn);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage3.Size = new System.Drawing.Size(946, 955);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "colunm graph";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webColumnNameToColumn
            // 
            this.webColumnNameToColumn.Location = new System.Drawing.Point(7, 21);
            this.webColumnNameToColumn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.webColumnNameToColumn.MinimumSize = new System.Drawing.Size(43, 40);
            this.webColumnNameToColumn.Name = "webColumnNameToColumn";
            this.webColumnNameToColumn.Size = new System.Drawing.Size(925, 922);
            this.webColumnNameToColumn.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.webBrowser3);
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(946, 955);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(11, 16);
            this.webBrowser3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(43, 40);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(925, 922);
            this.webBrowser3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1585, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "カラムーカラム分析";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2587, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "カラムテーブル結合";
            // 
            // dsTablelist
            // 
            this.dsTablelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTablelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.選択,
            this.テーブル名});
            this.dsTablelist.Location = new System.Drawing.Point(46, 225);
            this.dsTablelist.Name = "dsTablelist";
            this.dsTablelist.RowHeadersVisible = false;
            this.dsTablelist.RowTemplate.Height = 33;
            this.dsTablelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dsTablelist.Size = new System.Drawing.Size(446, 907);
            this.dsTablelist.TabIndex = 22;
            // 
            // 選択
            // 
            this.選択.HeaderText = "選択";
            this.選択.Name = "選択";
            // 
            // テーブル名
            // 
            this.テーブル名.HeaderText = "テーブル名";
            this.テーブル名.Name = "テーブル名";
            this.テーブル名.Width = 300;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(2583, 196);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(962, 1002);
            this.tabControl2.TabIndex = 23;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView2);
            this.tabPage6.Location = new System.Drawing.Point(8, 39);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage6.Size = new System.Drawing.Size(946, 955);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "tableName result";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 32);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 21;
            this.dataGridView2.Size = new System.Drawing.Size(969, 776);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.webtableColumnMerge);
            this.tabPage7.Location = new System.Drawing.Point(8, 39);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage7.Size = new System.Drawing.Size(946, 955);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "colunm graph";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // webtableColumnMerge
            // 
            this.webtableColumnMerge.Location = new System.Drawing.Point(7, 21);
            this.webtableColumnMerge.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.webtableColumnMerge.MinimumSize = new System.Drawing.Size(43, 40);
            this.webtableColumnMerge.Name = "webtableColumnMerge";
            this.webtableColumnMerge.Size = new System.Drawing.Size(925, 922);
            this.webtableColumnMerge.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(49, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 37);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "カラムワークスペース";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3044, 1222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 62);
            this.button1.TabIndex = 25;
            this.button1.Text = "スキーマ変更反映";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3316, 1222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 72);
            this.button2.TabIndex = 26;
            this.button2.Text = "再描画";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnhikaku
            // 
            this.btnhikaku.Location = new System.Drawing.Point(46, 1180);
            this.btnhikaku.Name = "btnhikaku";
            this.btnhikaku.Size = new System.Drawing.Size(445, 56);
            this.btnhikaku.TabIndex = 27;
            this.btnhikaku.Text = "カラムワークスペースワークスペース比較";
            this.btnhikaku.UseVisualStyleBackColor = true;
            this.btnhikaku.Click += new System.EventHandler(this.Btnhikaku_Click);
            // 
            // テーブル分析
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3610, 1542);
            this.Controls.Add(this.btnhikaku);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.dsTablelist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.tabC1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "テーブル分析";
            this.Text = "AnalysisTable";
            this.Load += new System.EventHandler(this.ColumnNameClustering_Load);
            this.tabC1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTableColumn)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.スキーマ変更.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSchema)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgColumn_Column)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTablelist)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabC1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.WebBrowser webtableNameToColumn;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.DataGridView dgTableColumn;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgColumn_Column;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webColumnNameToColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.WebBrowser webtableColumnMerge;
        private System.Windows.Forms.DataGridView dsTablelist;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 選択;
        private System.Windows.Forms.DataGridViewTextBoxColumn テーブル名;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage スキーマ変更;
        private System.Windows.Forms.DataGridView dgSchema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnhikaku;
    }
}