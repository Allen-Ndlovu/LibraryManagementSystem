using LibraryManagementSystem.Database;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        private DatabaseHelper _dbHelper;

        public MainForm()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Populate the listbox with book titles from the database
            var books = _dbHelper.GetBooks();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book);
            }
        }
    }
}
