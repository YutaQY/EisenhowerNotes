namespace EisenhowerNotes
{
    public partial class EisenhowerNotes : Form
    {
        public EisenhowerNotes()
        {
            InitializeComponent();

        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TEST");
            AddNote note = new AddNote();
            TextBox textBox = new TextBox();
            note.Name = textBox.Text;

        }
    }
}