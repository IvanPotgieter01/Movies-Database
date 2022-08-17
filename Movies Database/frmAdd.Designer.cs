namespace Movies_Database
{
    partial class frmAdd
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbMovieDirector = new System.Windows.Forms.TextBox();
            this.tbMovieRating = new System.Windows.Forms.TextBox();
            this.tbMovieYear = new System.Windows.Forms.TextBox();
            this.tbMovieName = new System.Windows.Forms.TextBox();
            this.lblMdirector = new System.Windows.Forms.Label();
            this.lblMrating = new System.Windows.Forms.Label();
            this.lblMyear = new System.Windows.Forms.Label();
            this.lblMname = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(56, 212);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(197, 48);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert Movie";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbMovieDirector
            // 
            this.tbMovieDirector.Location = new System.Drawing.Point(161, 66);
            this.tbMovieDirector.Name = "tbMovieDirector";
            this.tbMovieDirector.Size = new System.Drawing.Size(103, 20);
            this.tbMovieDirector.TabIndex = 16;
            // 
            // tbMovieRating
            // 
            this.tbMovieRating.Location = new System.Drawing.Point(161, 107);
            this.tbMovieRating.Name = "tbMovieRating";
            this.tbMovieRating.Size = new System.Drawing.Size(103, 20);
            this.tbMovieRating.TabIndex = 15;
            // 
            // tbMovieYear
            // 
            this.tbMovieYear.Location = new System.Drawing.Point(161, 145);
            this.tbMovieYear.Name = "tbMovieYear";
            this.tbMovieYear.Size = new System.Drawing.Size(103, 20);
            this.tbMovieYear.TabIndex = 14;
            // 
            // tbMovieName
            // 
            this.tbMovieName.Location = new System.Drawing.Point(161, 27);
            this.tbMovieName.Name = "tbMovieName";
            this.tbMovieName.Size = new System.Drawing.Size(103, 20);
            this.tbMovieName.TabIndex = 13;
            // 
            // lblMdirector
            // 
            this.lblMdirector.AutoSize = true;
            this.lblMdirector.Location = new System.Drawing.Point(48, 69);
            this.lblMdirector.Name = "lblMdirector";
            this.lblMdirector.Size = new System.Drawing.Size(77, 13);
            this.lblMdirector.TabIndex = 12;
            this.lblMdirector.Text = "Movie director:";
            // 
            // lblMrating
            // 
            this.lblMrating.AutoSize = true;
            this.lblMrating.Location = new System.Drawing.Point(48, 110);
            this.lblMrating.Name = "lblMrating";
            this.lblMrating.Size = new System.Drawing.Size(68, 13);
            this.lblMrating.TabIndex = 11;
            this.lblMrating.Text = "Movie rating:";
            // 
            // lblMyear
            // 
            this.lblMyear.AutoSize = true;
            this.lblMyear.Location = new System.Drawing.Point(48, 152);
            this.lblMyear.Name = "lblMyear";
            this.lblMyear.Size = new System.Drawing.Size(62, 13);
            this.lblMyear.TabIndex = 10;
            this.lblMyear.Text = "Movie year:";
            // 
            // lblMname
            // 
            this.lblMname.AutoSize = true;
            this.lblMname.Location = new System.Drawing.Point(48, 34);
            this.lblMname.Name = "lblMname";
            this.lblMname.Size = new System.Drawing.Size(68, 13);
            this.lblMname.TabIndex = 9;
            this.lblMname.Text = "Movie name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 307);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbMovieDirector);
            this.Controls.Add(this.tbMovieRating);
            this.Controls.Add(this.tbMovieYear);
            this.Controls.Add(this.tbMovieName);
            this.Controls.Add(this.lblMdirector);
            this.Controls.Add(this.lblMrating);
            this.Controls.Add(this.lblMyear);
            this.Controls.Add(this.lblMname);
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbMovieDirector;
        private System.Windows.Forms.TextBox tbMovieRating;
        private System.Windows.Forms.TextBox tbMovieYear;
        private System.Windows.Forms.TextBox tbMovieName;
        private System.Windows.Forms.Label lblMdirector;
        private System.Windows.Forms.Label lblMrating;
        private System.Windows.Forms.Label lblMyear;
        private System.Windows.Forms.Label lblMname;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}