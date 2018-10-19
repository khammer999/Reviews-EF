using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class ReviewRepositoryTests
    {


        [Fact]
        public void GetAll_Returns_3_Reviews()
        {
            var underTest = new ReviewRepository();
            var result = underTest.GetAll();

            Assert.Equal(3,result.Count); 
        }

        [Fact]
        public void Get_Id_Returns_Review_Title_from_Index()
        {
            var underTest = new ReviewRepository();
            var result = underTest.FindOneReviewById(1);

            Assert.Equal("War And Peace", result.Title);

        }
        [Fact]
        public void Get_Id_Returns_Review_Id_from_Index()
        {
            var underTest = new ReviewRepository();
            var result = underTest.FindOneReviewById(2);
    
            Assert.Equal(456, result.Id);

        }


    }
}
