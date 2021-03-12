using System;
using System.Windows.Forms;
using TekManager.Code.Connection;
using TekManager.DataService;

namespace TekManager.Forms
{
    public partial class AddBlog : Form
    {
        private readonly DataServiceHelper _serviceHelper;
        private readonly Action _refresh;
        public AddBlog(Action refresh)
        {
            InitializeComponent();
            _serviceHelper = new DataServiceHelper();
            _refresh = refresh;
        }

        private void AddBlog_Load(object sender, EventArgs e)
        {
            DateTimeTextBox.Text = DateTime.UtcNow.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ContentTextBox.Text == String.Empty ||
                TitleTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please enter details before saving blog post");
                return;
            }

            DateTime dateTime;
            try
            {
                dateTime = DateTime.Parse(DateTimeTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to parse Date time, ensure it is in the correct format");
                return;
            }



            var blogPostSqlModel = new BlogPostSqlModel() { Content = ContentTextBox.Text, DateTime = dateTime, Title = TitleTextBox.Text};

            _serviceHelper.SaveBlogPost(blogPostSqlModel)
                .Match(onSuccess: rows =>
                {
                    if (rows == 0)
                    {
                        MessageBox.Show("No rows were updated!");
                    }
                    else
                    {
                        _refresh();
                        Close();
                    }
                }, onFailure: error =>
                {
                    MessageBox.Show($"Error:{Environment.NewLine}{error}");
                });
        }
    }
}
