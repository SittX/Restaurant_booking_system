using Restaurant_booking_system.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_booking_system.User
{
    public partial class Frm_userReviews : Form
    {
        private readonly IReviewsRepository _repo;

        public Frm_userReviews(IReviewsRepository repo )
        {
            InitializeComponent();
            _repo = repo;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string review = txt_review.Text;
            if(_repo.Insert(Session.Session.LoggedInUser.Id, DateTime.Now, review))
            {
                lbl_status.Text = "Thank you for choosing our motel. Hope to see you soon.";
                lbl_status.ForeColor = Color.Green;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }
    }
}
