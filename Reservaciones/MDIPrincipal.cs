namespace Reservaciones
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPacientes frm = new frmPacientes();
            frm.ShowDialog();
        }
    }
}