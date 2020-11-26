using PST;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PSTforms
{
    public partial class MainForm : Form
    {
        private ProgramLogic _programLogic;
        public MainForm()
        {
            InitializeComponent();
            _programLogic = new ProgramLogic();
            lblCountry.Text = $"Current Country: {ProgramLogic.Country}";
            cmbSelectSource.SelectedItem = string.Empty;
            if (_programLogic.ConnectionSuccess())
            {
                MessageBox.Show("Connection to NewsAPI successfull");
            }
            else
            {
                MessageBox.Show("Connection to NewsAPI failed. Please check your internet conneciton");
                Application.Exit();
                Environment.Exit(0);
            }
        }

        private void btnChangeLanguage_Click(object sender, EventArgs e)
        {
            new FormInputLanguage(this).Show();
        }

        private void btnChangeCountry_Click(object sender, EventArgs e)
        {
            new FormInputCountry(this).Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SetupSearch();
            List<Article> headlines;
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                headlines = _programLogic.Search("a").Articles;
            }
            else
            {
                headlines = _programLogic.Search(tbSearch.Text).Articles;
            }
            headlines = headlines ?? new List<Article>();
            foreach (var headline in headlines)
            {
                lBox.Items.Add(headline);
            }
        }

        public void UpdateValues()
        {
            lblCountry.Text = $"Current Country: {ProgramLogic.Country}";
        }

        private void btnHeadlines_Click(object sender, EventArgs e)
        {
            SetupSearch();
            List<Article> headlines;
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                headlines = _programLogic.GetTopHeadlines().Articles;
            }
            else
            {
                headlines = _programLogic.GetTopHeadlines(tbSearch.Text).Articles;
            }
            headlines = headlines ?? new List<Article>();
            foreach (var headline in headlines)
            {
                lBox.Items.Add(headline);
            }
        }

        private void SetupSearch()
        {
            lBox.Items.Clear();
            ProgramLogic.Source = cmbSelectSource.Text.ToString();
        }

        private void btnSources_Click(object sender, EventArgs e)
        {
            lBox.Items.Clear();
            cmbSelectSource.Items.Clear();
            var sources = _programLogic.GetSources().Sources;
            foreach (var source in sources)
            {
                lBox.Items.Add(source);
                cmbSelectSource.Items.Add(source);
            }
            cmbSelectSource.Items.Add(string.Empty);
        }

        private void DoubleClickListItem(object sender, EventArgs e)
        {
            var selectedItem = lBox.SelectedItem;
            var sb = new StringBuilder();
            foreach (var propertyInfo in selectedItem.GetType().GetProperties())
            {
                sb.Append(propertyInfo.Name);
                sb.Append(": ");
                sb.Append(propertyInfo.GetValue(selectedItem));
                sb.Append("\r\n");
            }
            var newDialog = new Form2(sb.ToString());
            newDialog.ShowDialog();
        }
    }
}
