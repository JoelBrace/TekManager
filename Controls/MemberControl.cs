﻿using System;
using System.Drawing;
using System.Windows.Forms;
using TekManager.Code.Connection;

namespace TekManager.Controls
{
    public partial class MemberControl : UserControl
    {
        public MemberControl()
        {
            InitializeComponent();
        }

        private void MemberControl_Load(object sender, EventArgs e)
        {
            membersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            membersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            chId.Width = 30;
            chEmail.Width = 150;
        }

        private void DisplayMembers(string term, int count)
        {
            membersListView.Items.Clear();
            var serviceHelper = new DataServiceHelper();
            serviceHelper.GetMembersByEmailOrId(term, count)
                .Match(onSuccess: members =>
                {
                    foreach (var member in members)
                    {
                        var row = new string[] { member.Id.ToString(), member.Email, member.Status, member.Name, member.Password };
                        var lvi = new ListViewItem(row) { Tag = member };

                        membersListView.Items.Add(lvi);
                    }
                }, onFailure: error =>
                {
                    MessageBox.Show($"Error: {Environment.NewLine}{error}");
                });
        }

        private void RefreshMembers()
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


            DisplayMembers(SearchTextBox.Text, count);
        }

        private void MemberSearchButton_Click(object sender, EventArgs e)
        {
            RefreshMembers();
        }
    }
}
