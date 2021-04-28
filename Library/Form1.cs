using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;
using DataAccessLayer;
using BusinessLogic;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                var readCsv = new CsvDAL();
                var toDB = new ImportToDB();
                var getFile = new OpenFileDialog();
                var file = string.Empty;
                var bookDAL = new BookDAL();
                var authorDAL = new AuthorDAL();
                getFile.Title = "Select the File";
                getFile.ShowDialog();
                file = getFile.FileName;
                //todo: pe base entity posib de a accesa prin indexer ex(din author.name=... in author["name"]=...)(reflection)
                //todo: reading despre mvp,mvc pentru angular(modelview-viewmodel),tutorialul de la anuglar.io 
                var data = readCsv.Read(file);
                toDB.InsertIntoDB(data, bookDAL, authorDAL);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void DisplayAuthors_Click(object sender, EventArgs e)
        {
            try
            {
                listView.Clear();
                var authorDAL = new AuthorDAL();
                var authors = authorDAL.GetAuthors();
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("AuthorName");

                foreach (var author in authors)
                {
                    ListViewItem lvi = new ListViewItem(author.id.ToString());
                    lvi.SubItems.Add(author.authorName.Remove(author.authorName.Length - 1));
                    //lvi.SubItems.Add(author.id.ToString());

                    listView.Items.Add(lvi);

                }
                listView.Columns[0].Width = -1;
                listView.Columns[1].Width = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayBooks_Click(object sender, EventArgs e)
        {
            try
            {
                listView.Clear();
                var bookDAL = new BookDAL();
                var books = bookDAL.GetBooks();
                var authorName = string.Empty;
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("BookName");
                listView.Columns.Add("AuthorName");
                foreach (var book in books)
                {
                    ListViewItem lvi = new ListViewItem(book.id.ToString());
                    //lvi.SubItems.Add(book.id.ToString());
                    lvi.SubItems.Add(book.bookName);

                    var authorDAL = new AuthorDAL();
                    var authors = authorDAL.GetAuthors();

                    foreach (var author in authors)
                    {

                        if (author.id == book.authorId)
                        {
                            authorName = author.authorName;
                            break;
                        }
                    }
                    lvi.SubItems.Add(authorName.Remove(authorName.Length - 1));
                    listView.Items.Add(lvi);
                    listView.Columns[0].Width = -1;
                    listView.Columns[1].Width = -1;
                    listView.Columns[2].Width = -1;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void SearchAuthorByName_Click(object sender, EventArgs e)
        {
            try
            {
                listView.Clear();
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("AuthorName");
                var authorName = Authortextbox.Text;
                var authorDAL = new AuthorDAL();
                var author = authorDAL.SearchAuthorByName(authorName);
                var listViewItem = new ListViewItem(author.id.ToString());
                listViewItem.SubItems.Add(author.authorName);

                listView.Items.Add(listViewItem);
                listView.Columns[0].Width = -1;
                listView.Columns[1].Width = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchBooksByName_Click(object sender, EventArgs e)
        {
            try
            {
                listView.Clear();
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("BookName");
                listView.Columns.Add("AuthorName");
                var bookName = Booktextbox.Text;
                var bookDAL = new BookDAL();
                var book = bookDAL.SearchBookByName(bookName);
                var listViewItem = new ListViewItem(book.id.ToString());
                listViewItem.SubItems.Add(book.bookName);
                var authorDAL = new AuthorDAL();
                var authors = authorDAL.GetAuthors();
                var authorName = "";
                foreach (var author in authors)
                {

                    if (author.id == book.authorId)
                    {
                        authorName = author.authorName;
                        break;
                    }
                }
                listViewItem.SubItems.Add(authorName);
                listView.Items.Add(listViewItem);
                listView.Columns[0].Width = -1;
                listView.Columns[1].Width = -1;
                listView.Columns[2].Width = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        
    }
}
