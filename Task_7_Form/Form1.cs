using HttpForm.ViewModels;

namespace HttpForm
{
    public partial class Form1 : Form
    {
        GetUserView getUsers = new GetUserView();
        PostUserView postUser = new PostUserView();
        DelUserView delUser = new DelUserView();

        GetRankView getRank = new GetRankView();
        PostRankView postRank = new PostRankView();
        DelRankView delRank = new DelRankView();

        SearchRankView searchRanks = new SearchRankView();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = getUsers;
            dataGridView2.DataSource = getRank;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            postUser.PostUserMethod();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            delUser.DelUserMethod();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            postRank.PostRankMethod();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            delRank.DelRankMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = searchRanks;
        }
    }
}
