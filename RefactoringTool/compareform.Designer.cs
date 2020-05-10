namespace RefactoringTool
{
    partial class compareform
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.webColumnNameToColumn = new System.Windows.Forms.WebBrowser();
            this.cmdTablelist1 = new System.Windows.Forms.ComboBox();
            this.cmdTablelist2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgSchema = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgSchema2 = new System.Windows.Forms.DataGridView();
            this.webColumnNameToColumn2 = new System.Windows.Forms.WebBrowser();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.webTablelist = new System.Windows.Forms.WebBrowser();
            this.dsTablelist = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchema)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchema2)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTablelist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(39, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(473, 37);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "カラムワークスペース比較";
            // 
            // webColumnNameToColumn
            // 
            this.webColumnNameToColumn.Location = new System.Drawing.Point(0, 3);
            this.webColumnNameToColumn.MinimumSize = new System.Drawing.Size(20, 20);
            this.webColumnNameToColumn.Name = "webColumnNameToColumn";
            this.webColumnNameToColumn.Size = new System.Drawing.Size(989, 945);
            this.webColumnNameToColumn.TabIndex = 26;
            // 
            // cmdTablelist1
            // 
            this.cmdTablelist1.FormattingEnabled = true;
            this.cmdTablelist1.Location = new System.Drawing.Point(57, 133);
            this.cmdTablelist1.Name = "cmdTablelist1";
            this.cmdTablelist1.Size = new System.Drawing.Size(272, 32);
            this.cmdTablelist1.TabIndex = 28;
            // 
            // cmdTablelist2
            // 
            this.cmdTablelist2.FormattingEnabled = true;
            this.cmdTablelist2.Location = new System.Drawing.Point(1232, 133);
            this.cmdTablelist2.Name = "cmdTablelist2";
            this.cmdTablelist2.Size = new System.Drawing.Size(272, 32);
            this.cmdTablelist2.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1086, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 80);
            this.button1.TabIndex = 32;
            this.button1.Text = "⇒";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1086, 716);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 88);
            this.button2.TabIndex = 33;
            this.button2.Text = "⇐";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1893, 1209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 79);
            this.button3.TabIndex = 34;
            this.button3.Text = "更新";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(48, 186);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 1001);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webColumnNameToColumn);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1005, 954);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "グラフ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgSchema);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1005, 954);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "スキーマ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgSchema
            // 
            this.dgSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSchema.Location = new System.Drawing.Point(6, 7);
            this.dgSchema.Name = "dgSchema";
            this.dgSchema.RowTemplate.Height = 33;
            this.dgSchema.Size = new System.Drawing.Size(978, 926);
            this.dgSchema.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(1197, 204);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(984, 983);
            this.tabControl2.TabIndex = 36;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webColumnNameToColumn2);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(968, 936);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "グラフ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgSchema2);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(968, 936);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "スキーマ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgSchema2
            // 
            this.dgSchema2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSchema2.Location = new System.Drawing.Point(6, 7);
            this.dgSchema2.Name = "dgSchema2";
            this.dgSchema2.RowTemplate.Height = 33;
            this.dgSchema2.Size = new System.Drawing.Size(941, 913);
            this.dgSchema2.TabIndex = 0;
            // 
            // webColumnNameToColumn2
            // 
            this.webColumnNameToColumn2.Location = new System.Drawing.Point(12, 24);
            this.webColumnNameToColumn2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webColumnNameToColumn2.Name = "webColumnNameToColumn2";
            this.webColumnNameToColumn2.Size = new System.Drawing.Size(950, 906);
            this.webColumnNameToColumn2.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1619, 1209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 79);
            this.button4.TabIndex = 37;
            this.button4.Text = "再計算";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1350, 1209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 79);
            this.button5.TabIndex = 38;
            this.button5.Text = "初期化";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(2215, 214);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(984, 983);
            this.tabControl3.TabIndex = 39;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.webTablelist);
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(968, 936);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "グラフ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dsTablelist);
            this.tabPage6.Location = new System.Drawing.Point(8, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(968, 936);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "スキーマ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // webTablelist
            // 
            this.webTablelist.Location = new System.Drawing.Point(127, 101);
            this.webTablelist.MinimumSize = new System.Drawing.Size(20, 20);
            this.webTablelist.Name = "webTablelist";
            this.webTablelist.Size = new System.Drawing.Size(835, 823);
            this.webTablelist.TabIndex = 31;
            // 
            // dsTablelist
            // 
            this.dsTablelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTablelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dsTablelist.Location = new System.Drawing.Point(261, 31);
            this.dsTablelist.Name = "dsTablelist";
            this.dsTablelist.RowHeadersVisible = false;
            this.dsTablelist.RowTemplate.Height = 33;
            this.dsTablelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dsTablelist.Size = new System.Drawing.Size(446, 874);
            this.dsTablelist.TabIndex = 32;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "選択";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "テーブル名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // compareform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3614, 1437);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdTablelist2);
            this.Controls.Add(this.cmdTablelist1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl1);
            this.Name = "compareform";
            this.Text = "compareform";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSchema)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSchema2)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsTablelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.WebBrowser webColumnNameToColumn;
        private System.Windows.Forms.ComboBox cmdTablelist1;
        private System.Windows.Forms.ComboBox cmdTablelist2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgSchema;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webColumnNameToColumn2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgSchema2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.WebBrowser webTablelist;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dsTablelist;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}