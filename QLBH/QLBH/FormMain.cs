using System.Drawing.Drawing2D;

namespace QLBH
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void mangagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void fManagePerson_Click(object sender, EventArgs e)
        {
            FormQuanLy f = new FormQuanLy();    
            f.MdiParent = this;
            f.Show();
        }
    }
}
