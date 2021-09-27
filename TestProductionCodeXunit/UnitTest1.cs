using System;
using System.Collections.Generic;
using Moq;
using SDM.Compulsory1.Core.Models;
using SDM.Compulsory1.Domain.IRepositories;
using SDM.Compulsory1.Domain.Services;
using SDM.Compulsory1.Infrastructure.Repositories;
using Xunit;

namespace TestProductionCodeXunit
{
    public class UnitTest1
    {
        [Fact]
        public void TestForNumberOfReviews()
        {
            //Arrange
            Mock<IReviewRepository> m = new Mock<IReviewRepository>();

            Review[] returnValue =
            {
                new Review() { Reviewer = 1, Grade = 2, Movie = 1, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 2, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 3, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 4, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 5, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 6, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 2, Grade = 2, Movie = 7, ReviewDate = DateTime.Now }
            };
            m.Setup(m => m.GetAll()).Returns(() => returnValue);

            ReviewService mService = new ReviewService(m.Object);

            //Act
            int actualResult = mService.GetNumberOfReviewsFromReviewer(1);

            //Assert
            m.Verify(m => m.GetAll(), Times.Once);

            Assert.True(actualResult == 6);

        }


        // GetAverageRateFromReviewer()
        [Fact]
        public void TestForAverageRateFromReviewer()
        {
            //Arrange
            Mock<IReviewRepository> m = new Mock<IReviewRepository>();

            Review[] returnValue =
            {
                new Review() { Reviewer = 1, Grade = 2, Movie = 1, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 2, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 3, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 4, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 5, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 6, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now }
            };
            m.Setup(m => m.GetAll()).Returns(() => returnValue);

            ReviewService mService = new ReviewService(m.Object);

            //Act
            double actualResult = mService.GetAverageRateFromReviewer(1);

            //Assert
            m.Verify(m => m.GetAll(), Times.Once);

            Assert.True(actualResult == 2);
        }

        // GetNumberOfRatesByReviewer

        [Fact]
        public void TestForNumberOfRatesFromReviewer()
        {
            //Arrange
            Mock<IReviewRepository> m = new Mock<IReviewRepository>();

            Review[] returnValue =
            {
                new Review() { Reviewer = 1, Grade = 2, Movie = 1, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 2, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 3, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 4, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 5, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 6, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now }
            };
            m.Setup(m => m.GetAll()).Returns(() => returnValue);

            ReviewService mService = new ReviewService(m.Object);

            //Act
            double actualResult = mService.GetNumberOfRatesByReviewer(1, 2);

            //Assert
            m.Verify(m => m.GetAll(), Times.Once);

            Assert.True(actualResult == 7);
        }


        // GetNumberOfReviews

        [Fact]
        public void GetNumberOfReviews()
        {
            //Arrange
            Mock<IReviewRepository> m = new Mock<IReviewRepository>();

            Review[] returnValue =
            {
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now }
            };
            m.Setup(m => m.GetAll()).Returns(() => returnValue);

            ReviewService mService = new ReviewService(m.Object);

            //Act
            double actualResult = mService.GetNumberOfReviews(7);

            //Assert
            m.Verify(m => m.GetAll(), Times.Once);

            Assert.True(actualResult == 7);
        }

        // GetAverageRateOfMovie

        [Fact]
        public void GetAverageRateOfMovie()
        {
            //Arrange
            Mock<IReviewRepository> m = new Mock<IReviewRepository>();

            Review[] returnValue =
            {
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now }
            };
            m.Setup(m => m.GetAll()).Returns(() => returnValue);

            ReviewService mService = new ReviewService(m.Object);

            //Act
            double actualResult = mService.GetAverageRateOfMovie(7);

            //Assert
            m.Verify(m => m.GetAll(), Times.Once);

            Assert.True(actualResult == 2);
        }

        // GetNumberOfRates

        [Fact]
        public void GetNumberOfRates()
        {
            //Arrange
            Mock<IReviewRepository> m = new Mock<IReviewRepository>();

            Review[] returnValue =
            {
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now },
                new Review() { Reviewer = 1, Grade = 2, Movie = 7, ReviewDate = DateTime.Now }
            };
            m.Setup(m => m.GetAll()).Returns(() => returnValue);

            ReviewService mService = new ReviewService(m.Object);

            //Act
            int actualResult = mService.GetNumberOfRates(7, 2);

            //Assert
            m.Verify(m => m.GetAll(), Times.Once);

            Assert.True(actualResult == 7);
        }

        // GetMoviesWithHighestNumberOfTopRates

        [Fact]
        public void GetMoviesWithHighestNumberOfTopRates()
        {
            throw new System.NotImplementedException();
        }

        // GetMostProductiveReviewers

        [Fact]
        public void GetMostProductiveReviewers()
        {

            throw new System.NotImplementedException();
        }

        [Fact]
        public void TestForTopNMoviesBasedOnAverageRating()
        {
            Mock<IReviewRepository> mock = new Mock<IReviewRepository>();

            ReviewService mService = new ReviewService(mock.Object);

            Review[] returnValue =
            {
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 2, Grade = 5 },
                new Review { Movie = 2, Grade = 4 },
                new Review { Movie = 3, Grade = 3 },
                new Review { Movie = 3, Grade = 3 },
                new Review { Movie = 4, Grade = 2 },
                new Review { Movie = 4, Grade = 2 },
                new Review { Movie = 5, Grade = 2 },
                new Review { Movie = 5, Grade = 1 },
                new Review { Movie = 5, Grade = 1 },
                new Review { Movie = 6, Grade = 1 },
                new Review { Movie = 6, Grade = 1 }
            };

            mock.Setup(m => m.GetAll()).Returns(() => returnValue);

            List<int> actualResult = mService.GetTopRatedMovies(5);

            mock.Verify(m => m.GetAll(), Times.Once);

            Assert.Collection(actualResult,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item)
            );
        }

        [Fact]
        public void TestForTopNMoviesBasedOnAverageRatingWithLessThan1N()
        {
            Mock<IReviewRepository> mock = new Mock<IReviewRepository>();

            ReviewService mService = new ReviewService(mock.Object);

            Review[] returnValue =
            {
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 2, Grade = 5 },
                new Review { Movie = 2, Grade = 4 },
                new Review { Movie = 3, Grade = 3 },
                new Review { Movie = 3, Grade = 3 },
                new Review { Movie = 4, Grade = 2 },
                new Review { Movie = 4, Grade = 2 },
                new Review { Movie = 5, Grade = 2 },
                new Review { Movie = 5, Grade = 1 },
                new Review { Movie = 5, Grade = 1 },
                new Review { Movie = 6, Grade = 1 },
                new Review { Movie = 6, Grade = 1 }
            };

            mock.Setup(m => m.GetAll()).Returns(() => returnValue);

            var ex = Assert.Throws<ArgumentException>(() => mService.GetTopRatedMovies(0));

            Assert.Equal("Param needs to be 1 or above.", ex.Message);
        }

        [Fact]
        public void TestForTopNMoviesBasedOnAverageRatingWithAboveUpperBound()
        {
            Mock<IReviewRepository> mock = new Mock<IReviewRepository>();

            ReviewService mService = new ReviewService(mock.Object);

            Review[] returnValue =
            {
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 1, Grade = 5 },
                new Review { Movie = 2, Grade = 5 },
                new Review { Movie = 2, Grade = 4 },
                new Review { Movie = 3, Grade = 3 },
                new Review { Movie = 3, Grade = 3 },
                new Review { Movie = 4, Grade = 2 },
                new Review { Movie = 4, Grade = 2 },
                new Review { Movie = 5, Grade = 2 },
                new Review { Movie = 5, Grade = 1 },
                new Review { Movie = 5, Grade = 1 },
                new Review { Movie = 6, Grade = 1 },
                new Review { Movie = 6, Grade = 1 }
            };

            mock.Setup(m => m.GetAll()).Returns(() => returnValue);

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => mService.GetTopRatedMovies(7));

            Assert.Equal(
                "Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')",
                ex.Message);
        }

        [Fact]
        public void TestForTopMovieByReviewer()
        {
            Mock<IReviewRepository> mock = new Mock<IReviewRepository>();

            ReviewService mService = new ReviewService(mock.Object);

            Review[] returnValue =
            {
                new Review { Reviewer = 1, Movie = 1, Grade = 1, ReviewDate = DateTime.Now.AddDays(-200) },
                new Review { Reviewer = 1, Movie = 2, Grade = 5, ReviewDate = DateTime.Now.AddDays(-100) },
                new Review { Reviewer = 1, Movie = 3, Grade = 2, ReviewDate = DateTime.Now.AddDays(-150) },
                new Review { Reviewer = 2, Movie = 1, Grade = 5, ReviewDate = DateTime.Now.AddDays(-20) },
                new Review { Reviewer = 1, Movie = 4, Grade = 2, ReviewDate = DateTime.Now.AddDays(-80) },
                new Review { Reviewer = 3, Movie = 1, Grade = 1, ReviewDate = DateTime.Now.AddDays(-90) }
            };

            mock.Setup(m => m.GetAll()).Returns(() => returnValue);

            List<int> actualResult = mService.GetTopMoviesByReviewer(1);

            mock.Verify(m => m.GetAll(), Times.Once);

            Assert.True(actualResult.Count == 4);
            Assert.Collection(actualResult,
                item => Assert.Equal(2, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(1, item)
            );
        }

        [Fact]
        public void TestForTopMovieByReviewerIfReviewerDoesNotExist()
        {
            Mock<IReviewRepository> mock = new Mock<IReviewRepository>();

            ReviewService mService = new ReviewService(mock.Object);

            Review[] returnValue =
            {
                new Review { Reviewer = 1, Movie = 1, Grade = 1, ReviewDate = DateTime.Now.AddDays(-200) },
                new Review { Reviewer = 1, Movie = 2, Grade = 5, ReviewDate = DateTime.Now.AddDays(-100) },
                new Review { Reviewer = 1, Movie = 3, Grade = 2, ReviewDate = DateTime.Now.AddDays(-150) },
                new Review { Reviewer = 2, Movie = 1, Grade = 5, ReviewDate = DateTime.Now.AddDays(-20) },
                new Review { Reviewer = 1, Movie = 4, Grade = 2, ReviewDate = DateTime.Now.AddDays(-80) },
                new Review { Reviewer = 3, Movie = 1, Grade = 1, ReviewDate = DateTime.Now.AddDays(-90) }
            };

            mock.Setup(m => m.GetAll()).Returns(() => returnValue);

            var ex = Assert.Throws<ArgumentException>(() => mService.GetTopMoviesByReviewer(0));

            Assert.Equal("Reviewer With id does not exist", ex.Message);
        }

        [Fact]
        public void TestForReviewersOnGivenMovie()
        {
            Mock<IReviewRepository> mock = new Mock<IReviewRepository>();

            ReviewService mService = new ReviewService(mock.Object);

            Review[] returnValue =
            {
                new Review { Reviewer = 1, Movie = 1, Grade = 5, ReviewDate = DateTime.Now },
                new Review { Reviewer = 2, Movie = 1, Grade = 4, ReviewDate = DateTime.Now.AddDays(-1) },
                new Review { Reviewer = 3, Movie = 1, Grade = 4, ReviewDate = DateTime.Now.AddDays(-2) },
                new Review { Reviewer = 3, Movie = 2, Grade = 4, ReviewDate = DateTime.Now.AddDays(-2) }
            };

            mock.Setup(m => m.GetAll()).Returns(() => returnValue);

            List<int> actualResult = mService.GetReviewersByMovie(1);

            mock.Verify(m => m.GetAll(), Times.Once);

            Assert.True(actualResult.Count == 3);
            Assert.Collection(actualResult,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item)
            );
        }

        [Fact]
        public void TestForReviewersOnGivenMovieIfMovieDoesNotExist()
        {
            Mock<IReviewRepository> mock = new Mock<IReviewRepository>();

            ReviewService mService = new ReviewService(mock.Object);

            Review[] returnValue =
            {
                new Review { Reviewer = 1, Movie = 1 },
                new Review { Reviewer = 3, Movie = 1 },
                new Review { Reviewer = 2, Movie = 2 }
            };

            mock.Setup(m => m.GetAll()).Returns(() => returnValue);

            var ex = Assert.Throws<ArgumentException>(() => mService.GetReviewersByMovie(0));

            Assert.Equal("Movie With id does not exist", ex.Message);
        }
    }
}