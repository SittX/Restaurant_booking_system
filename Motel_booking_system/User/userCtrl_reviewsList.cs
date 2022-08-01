using Motel_booking_system.Interfaces;

namespace Motel_booking_system.User
{
    public partial class userCtrl_reviewsList : UserControl
    {
        private readonly IReviewService _reviewService;

        public userCtrl_reviewsList(IReviewService reviewService)
        {
            InitializeComponent();
            _reviewService = reviewService;
        }

        private void userCtrl_reviewsList_Load(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void LoadReviews()
        {
            var dt = _reviewService.GetAll();

            foreach (var review in dt)
            {
                var reviewItem = new userCtrl_reviewItem();
                reviewItem.Username = review["username"].ToString();
                reviewItem.Review = review["review"].ToString();

                AddToFlowLayoutPanel(reviewItem);
            }
        }

        private void AddToFlowLayoutPanel(userCtrl_reviewItem reviewItem)
        {
            if (flowLayoutPanel_reviews.Controls.Count < 0)
            {
                flowLayoutPanel_reviews.Controls.Clear();
            }
            else
            {
                flowLayoutPanel_reviews.Controls.Add(reviewItem);
            }
        }
    }
}
