namespace RefactoringTool
{
    partial class tebleworkspace
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
            this.components = new System.ComponentModel.Container();
            this.dsTablelist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdTablelist = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tablelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablelistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsTablelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelistBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsTablelist
            // 
            this.dsTablelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTablelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dsTablelist.Location = new System.Drawing.Point(57, 192);
            this.dsTablelist.Name = "dsTablelist";
            this.dsTablelist.RowTemplate.Height = 33;
            this.dsTablelist.Size = new System.Drawing.Size(509, 934);
            this.dsTablelist.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "選択";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "テーブル名";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(85, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(435, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "テーブルワークスペース";
            // 
            // cmdTablelist
            // 
            this.cmdTablelist.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdTablelist.FormattingEnabled = true;
            this.cmdTablelist.Location = new System.Drawing.Point(620, 196);
            this.cmdTablelist.Name = "cmdTablelist";
            this.cmdTablelist.Size = new System.Drawing.Size(306, 45);
            this.cmdTablelist.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(620, 285);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1356, 982);
            this.webBrowser1.TabIndex = 3;
            // 
            // tablelistBindingSource
            // 
            this.tablelistBindingSource.DataSource = typeof(RefactoringTool.tebleworkspace.tablelist);
            // 
            // tablelistBindingSource1
            // 
            this.tablelistBindingSource1.DataSource = typeof(RefactoringTool.tebleworkspace.tablelist);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1332, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "追加";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(987, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "追加テーブル";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(980, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "新規テーブル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(613, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "起点テーブル";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1760, 1293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "再描画";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tebleworkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 1415);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.cmdTablelist);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dsTablelist);
            this.Name = "tebleworkspace";
            this.Text = "tebleworkspace";
            ((System.ComponentModel.ISupportInitialize)(this.dsTablelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelistBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsTablelist;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmdTablelist;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.BindingSource tablelistBindingSource;
        private System.Windows.Forms.BindingSource tablelistBindingSource1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}