using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARU
{
    public partial class СlarificationForm : Form
    {
        int numberOfOrder;
        public СlarificationForm(int numberOfOrder)
        {
            InitializeComponent();
            this.numberOfOrder = numberOfOrder;
        }


        private void СlarificationForm_Load(object sender, EventArgs e)
        {
            txtClarificationOrder.Text += "Хэр";
        }
    }
}
