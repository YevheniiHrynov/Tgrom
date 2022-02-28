using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telegrom
{
    public partial class TelegromForm : Form
    {
        public Model Model;

        public TelegromForm()
        {
            this.InitializeComponent();
            Model = new Model();
        }

        private void btnAccManager_Click(object sender, EventArgs e)
        {
            new AuthForm(this).Show();
            base.Hide();
        }

        private void btnSpammer_Click(object sender, EventArgs e)
        {
            new SpammerForm(this).Show();
            base.Hide();
        }
    }
}
