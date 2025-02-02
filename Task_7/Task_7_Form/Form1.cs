using HttpForm.ViewModels;

namespace HttpForm
{
    public partial class Form1 : Form
    {
        GetUserView getUsers = new GetUserView();
        PostUserView postUser = new PostUserView();
        DelUserView delUser = new DelUserView();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getUsers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = postUser;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = delUser;
        }



    }
}
