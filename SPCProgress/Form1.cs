namespace SPCProgress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void qwert(string sqerty)
        {
            quickSearchTextBox.Text = sqerty;
        }

        private void quickSearchTextBox_Enter(object sender, EventArgs e)
        {
            if (quickSearchTextBox.Text == "ФИО пациента")
            {
                quickSearchTextBox.Text = string.Empty;
                quickSearchTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void quickSearchTextBox_Leave(object sender, EventArgs e)
        {
            if (quickSearchTextBox.Text == string.Empty)
            {
                quickSearchTextBox.Text = "ФИО пациента";
                quickSearchTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.Owner = this;
            addPatientForm.ShowDialog();
        }

        private void generatePatientButton_Click(object sender, EventArgs e)
        {

        }

        private void generateVisitButton_Click(object sender, EventArgs e)
        {

        }

        private void bigGenerateButton_Click(object sender, EventArgs e)
        {

        }

        private void clearDBButton_Click(object sender, EventArgs e)
        {

        }
    }
}