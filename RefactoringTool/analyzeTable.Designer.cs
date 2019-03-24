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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.dgTableSchema = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgColumn_Column = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.tabC1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableColumn)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableSchema)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgColumn_Column)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabC1
            // 
            this.tabC1.Controls.Add(this.tabPage1);
            this.tabC1.Controls.Add(this.tabPage4);
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
            this.tabPage4.Controls.Add(this.webBrowser1);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage4.Size = new System.Drawing.Size(946, 955);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "colunm graph";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(35, 42);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(43, 40);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(966, 856);
            this.webBrowser1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3068, 72);
            this.textBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 31);
            this.textBox2.TabIndex = 13;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(52, 33);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(110, 24);
            this.lblTableName.TabIndex = 14;
            this.lblTableName.Text = "テーブル名";
            // 
            // dgTableSchema
            // 
            this.dgTableSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTableSchema.Location = new System.Drawing.Point(56, 196);
            this.dgTableSchema.Name = "dgTableSchema";
            this.dgTableSchema.RowHeadersVisible = false;
            this.dgTableSchema.RowTemplate.Height = 33;
            this.dgTableSchema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgTableSchema.Size = new System.Drawing.Size(446, 731);
            this.dgTableSchema.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "テーブルスキーマ";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(337, 136);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(165, 37);
            this.btnInit.TabIndex = 17;
            this.btnInit.Text = "初期化";
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
            this.tabPage3.Controls.Add(this.webBrowser2);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage3.Size = new System.Drawing.Size(946, 955);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "colunm graph";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(7, 21);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(43, 40);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(925, 922);
            this.webBrowser2.TabIndex = 0;
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
            // テーブル分析
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3004, 1542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTableSchema);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tabC1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "テーブル分析";
            this.Text = "AnalysisTable";
            this.Load += new System.EventHandler(this.ColumnNameClustering_Load);
            this.tabC1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTableColumn)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTableSchema)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgColumn_Column)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabC1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.DataGridView dgTableSchema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTableColumn;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgColumn_Column;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.WebBrowser webBrowser3;
    }
}