using PST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSTforms
{
    public partial class FormInputLanguage : Form
    {
        private MainForm PreviousForm;
        public FormInputLanguage(MainForm mainform)
        {
            PreviousForm = mainform;
            InitializeComponent();
            cmbSelectLanguageCode.Items.AddRange(Enum.GetNames(typeof(LanguageEnums)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PreviousForm.UpdateValues();
            Close();
        }
    }
}
