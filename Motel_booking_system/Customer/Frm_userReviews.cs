using Motel_booking_system.Interfaces;

namespace Motel_booking_system.User
{
    public partial class Frm_userReviews : Form
    {
        private readonly IReviewService _repo;

        public Frm_userReviews(IReviewService repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string review = txt_review.Text;
            if (_repo.Insert(Session.CurrentSession.LoggedInUser.Id, review))
            {
                lbl_status.Text = "Thank you for choosing our motel. Hope to see you soon.";
                lbl_status.ForeColor = Color.Green;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
