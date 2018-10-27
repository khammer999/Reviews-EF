using Microsoft.EntityFrameworkCore;
using ReviewSite.Models;

namespace ReviewSite
{
    public class ReviewRepository: Repository<Review>,IReviewRepository
    {

        public ReviewRepository(Context context) : base(context)
        {
            // This ensures our base constructor gets run.
        }


    }
}