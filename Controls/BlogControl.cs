using System;
using System.Drawing;
using System.Windows.Forms;
using TekManager.Code.Connection;
using TekManager.DataService;
using TekManager.Forms;

namespace TekManager.Controls
{
    public partial class BlogControl : UserControl
    {
        public BlogControl()
        {
            InitializeComponent();
        }

        private void BlogControl_Load(object sender, EventArgs e)
        {
            blogsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            blogsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            chDateTime.Width = 120;
            chTitle.Width = 100;
        }

        private void BlogSearchButton_Click(object sender, EventArgs e)
        {
            RefreshBlogs();
        }

        public void RefreshBlogs()
        {
            var count = 0;
            try
            {
                count = Int32.Parse(CountTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error retrieving count. Make sure it is a number.");
                return;
            }


            DisplayBlogs(SearchTextBox.Text, count);
        }

        public void DisplayBlogs(string term, int count)
        {
            blogsListView.Items.Clear();
            var serviceHelper = new DataServiceHelper();
            serviceHelper.GetBlogsByTitleOrContent(term, count)
                .Match(onSuccess: blogs =>
                {
                    foreach (var blog in blogs)
                    {
                        var row = new string[] { blog.Id.ToString(), blog.DateTime.ToString(), blog.Title, blog.Content };
                        var lvi = new ListViewItem(row) { Tag = blog };


                        blogsListView.Items.Add(lvi);
                    }
                }, onFailure: error =>
                {
                    MessageBox.Show($"Error: {Environment.NewLine}{error}");
                });
        }

        private void newPostButton_Click(object sender, EventArgs e)
        {
            var newBlogPostPopup = new AddBlog(RefreshBlogs);
            newBlogPostPopup.Show(this);
        }

        private void deleteBlogPostButton_Click(object sender, EventArgs e)
        {
            var selectedItem = (BlogPostSqlModel)blogsListView.SelectedItems[0].Tag;

            if (MessageBox.Show($"Are you sure you want to delete {selectedItem.Title}?",
                    "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No) return;

            new DataServiceHelper().DeleteBlogPost(selectedItem.Id)
                .Match(rows =>
                {
                    if (rows == 0)
                    {
                        MessageBox.Show("No rows were updated");
                    }
                    else
                    {
                        RefreshBlogs();
                    }
                }, error =>
                {
                    MessageBox.Show($"Error deleting blog.{Environment.NewLine}{error}");
                });


        }
    }
}
