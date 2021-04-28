
namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddDataButton = new System.Windows.Forms.Button();
            this.DisplayBooks = new System.Windows.Forms.Button();
            this.SearchBooksByName = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.AuthorName = new System.Windows.Forms.ColumnHeader();
            this.BookName = new System.Windows.Forms.ColumnHeader();
            this.DisplayAuthors = new System.Windows.Forms.Button();
            this.SearchAuthorByName = new System.Windows.Forms.Button();
            this.Authortextbox = new System.Windows.Forms.TextBox();
            this.Booktextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddDataButton
            // 
            this.AddDataButton.Location = new System.Drawing.Point(345, 386);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(112, 34);
            this.AddDataButton.TabIndex = 0;
            this.AddDataButton.Text = "Add Data";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // DisplayBooks
            // 
            this.DisplayBooks.Location = new System.Drawing.Point(636, 172);
            this.DisplayBooks.Name = "DisplayBooks";
            this.DisplayBooks.Size = new System.Drawing.Size(112, 34);
            this.DisplayBooks.TabIndex = 2;
            this.DisplayBooks.Text = "Books";
            this.DisplayBooks.UseVisualStyleBackColor = true;
            this.DisplayBooks.Click += new System.EventHandler(this.DisplayBooks_Click);
            // 
            // SearchBooksByName
            // 
            this.SearchBooksByName.Location = new System.Drawing.Point(636, 212);
            this.SearchBooksByName.Name = "SearchBooksByName";
            this.SearchBooksByName.Size = new System.Drawing.Size(112, 34);
            this.SearchBooksByName.TabIndex = 4;
            this.SearchBooksByName.Text = "SearchByName";
            this.SearchBooksByName.UseVisualStyleBackColor = true;
            this.SearchBooksByName.Click += new System.EventHandler(this.SearchBooksByName_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.AuthorName,
            this.BookName});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(3, 29);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(613, 276);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // AuthorName
            // 
            this.AuthorName.Width = 200;
            // 
            // BookName
            // 
            this.BookName.Width = 200;
            // 
            // DisplayAuthors
            // 
            this.DisplayAuthors.Location = new System.Drawing.Point(636, 29);
            this.DisplayAuthors.Name = "DisplayAuthors";
            this.DisplayAuthors.Size = new System.Drawing.Size(112, 34);
            this.DisplayAuthors.TabIndex = 6;
            this.DisplayAuthors.Text = "Authors";
            this.DisplayAuthors.UseVisualStyleBackColor = true;
            this.DisplayAuthors.Click += new System.EventHandler(this.DisplayAuthors_Click);
            // 
            // SearchAuthorByName
            // 
            this.SearchAuthorByName.Location = new System.Drawing.Point(636, 69);
            this.SearchAuthorByName.Name = "SearchAuthorByName";
            this.SearchAuthorByName.Size = new System.Drawing.Size(112, 34);
            this.SearchAuthorByName.TabIndex = 7;
            this.SearchAuthorByName.Text = "SearchByName";
            this.SearchAuthorByName.UseVisualStyleBackColor = true;
            this.SearchAuthorByName.Click += new System.EventHandler(this.SearchAuthorByName_Click);
            // 
            // Authortextbox
            // 
            this.Authortextbox.Location = new System.Drawing.Point(622, 109);
            this.Authortextbox.Name = "Authortextbox";
            this.Authortextbox.Size = new System.Drawing.Size(150, 31);
            this.Authortextbox.TabIndex = 8;
            // 
            // Booktextbox
            // 
            this.Booktextbox.Location = new System.Drawing.Point(622, 252);
            this.Booktextbox.Name = "Booktextbox";
            this.Booktextbox.Size = new System.Drawing.Size(150, 31);
            this.Booktextbox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Booktextbox);
            this.Controls.Add(this.Authortextbox);
            this.Controls.Add(this.SearchAuthorByName);
            this.Controls.Add(this.DisplayAuthors);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.SearchBooksByName);
            this.Controls.Add(this.DisplayBooks);
            this.Controls.Add(this.AddDataButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.Button DisplayBooks;
        private System.Windows.Forms.Button SearchBooksByName;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader AuthorName;
        private System.Windows.Forms.ColumnHeader BookName;
        private System.Windows.Forms.Button DisplayAuthors;
        private System.Windows.Forms.Button SearchAuthorByName;
        private System.Windows.Forms.TextBox Authortextbox;
        private System.Windows.Forms.TextBox Booktextbox;
    }
}

