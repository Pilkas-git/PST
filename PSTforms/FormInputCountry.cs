using PST;
using System;
using System.Windows.Forms;

namespace PSTforms
{
    public partial class FormInputCountry : Form
    {
        private MainForm PreviousForm;
        public FormInputCountry(MainForm mainform)
        {
            PreviousForm = mainform;
            InitializeComponent();
            cmbSelectLanguageCode.Items.AddRange(Enum.GetNames(typeof(CountryEnums)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramLogic.Country = cmbSelectLanguageCode.SelectedItem.ToString();
            PreviousForm.UpdateValues();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
