namespace Movies_Database
{
    partial class Form1
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
            this.tcMovies = new System.Windows.Forms.TabControl();
            this.tpView = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.lblYearScroll = new System.Windows.Forms.Label();
            this.lboxMovies = new System.Windows.Forms.ListBox();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.hScrollYear = new System.Windows.Forms.HScrollBar();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tcMovies.SuspendLayout();
            this.tpView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.tpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMovies
            // 
            this.tcMovies.Controls.Add(this.tpView);
            this.tcMovies.Controls.Add(this.tpSearch);
            this.tcMovies.Location = new System.Drawing.Point(21, 15);
            this.tcMovies.Name = "tcMovies";
            this.tcMovies.SelectedIndex = 0;
            this.tcMovies.Size = new System.Drawing.Size(759, 420);
            this.tcMovies.TabIndex = 1;
            // 
            // tpView
            // 
            this.tpView.Controls.Add(this.btnInsert);
            this.tpView.Controls.Add(this.btnDelete);
            this.tpView.Controls.Add(this.dataGridViewMovies);
            this.tpView.Controls.Add(this.cbMovie);
            this.tpView.Location = new System.Drawing.Point(4, 22);
            this.tpView.Name = "tpView";
            this.tpView.Padding = new System.Windows.Forms.Padding(3);
            this.tpView.Size = new System.Drawing.Size(751, 394);
            this.tpView.TabIndex = 0;
            this.tpView.Text = "View Movies";
            this.tpView.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(600, 143);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(600, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(7, 13);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.Size = new System.Drawing.Size(580, 264);
            this.dataGridViewMovies.TabIndex = 2;
            // 
            // cbMovie
            // 
            this.cbMovie.FormattingEnabled = true;
            this.cbMovie.Location = new System.Drawing.Point(600, 36);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(121, 21);
            this.cbMovie.TabIndex = 1;
            this.cbMovie.SelectedIndexChanged += new System.EventHandler(this.cbMovie_SelectedIndexChanged);
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.lblYearScroll);
            this.tpSearch.Controls.Add(this.lboxMovies);
            this.tpSearch.Controls.Add(this.cbRating);
            this.tpSearch.Controls.Add(this.hScrollYear);
            this.tpSearch.Controls.Add(this.tbName);
            this.tpSearch.Controls.Add(this.lblYear);
            this.tpSearch.Controls.Add(this.lblRating);
            this.tpSearch.Controls.Add(this.lblName);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(751, 394);
            this.tpSearch.TabIndex = 1;
            this.tpSearch.Text = "Search Movies";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // lblYearScroll
            // 
            this.lblYearScroll.AutoSize = true;
            this.lblYearScroll.Location = new System.Drawing.Point(312, 74);
            this.lblYearScroll.Name = "lblYearScroll";
            this.lblYearScroll.Size = new System.Drawing.Size(29, 13);
            this.lblYearScroll.TabIndex = 7;
            this.lblYearScroll.Text = "Year";
            // 
            // lboxMovies
            // 
            this.lboxMovies.FormattingEnabled = true;
            this.lboxMovies.Location = new System.Drawing.Point(57, 198);
            this.lboxMovies.Name = "lboxMovies";
            this.lboxMovies.Size = new System.Drawing.Size(588, 160);
            this.lboxMovies.TabIndex = 6;
            // 
            // cbRating
            // 
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbRating.Location = new System.Drawing.Point(152, 110);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(157, 21);
            this.cbRating.TabIndex = 5;
            this.cbRating.SelectedIndexChanged += new System.EventHandler(this.cbRating_SelectedIndexChanged);
            // 
            // hScrollYear
            // 
            this.hScrollYear.LargeChange = 1;
            this.hScrollYear.Location = new System.Drawing.Point(152, 70);
            this.hScrollYear.Name = "hScrollYear";
            this.hScrollYear.Size = new System.Drawing.Size(157, 17);
            this.hScrollYear.TabIndex = 4;
            this.hScrollYear.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollYear_Scroll);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(152, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(157, 20);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(34, 74);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(81, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Search by year:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(34, 115);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(87, 13);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "Search by rating:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Search by name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcMovies);
            this.Name = "Form1";
            this.Text = "Movies Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMovies.ResumeLayout(false);
            this.tpView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMovies;
        private System.Windows.Forms.TabPage tpView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.ComboBox cbMovie;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.Label lblYearScroll;
        private System.Windows.Forms.ListBox lboxMovies;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.HScrollBar hScrollYear;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblName;
    }
}

