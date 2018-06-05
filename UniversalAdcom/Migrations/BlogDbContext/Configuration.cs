namespace UniversalAdcom.Migrations.BlogDbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UniversalAdcom.Models.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations/BlogDbContext";
        }

        protected override void Seed(UniversalAdcom.Models.BlogDbContext context)
        {
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat1", Name = "Lorem", UrlSeo = "Lorem", Description = "Lorem Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat2", Name = "Duis", UrlSeo = "Duis", Description = "Duis Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat3", Name = "Nulla", UrlSeo = "Nulla", Description = "Nulla Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat4", Name = "Ipsum", UrlSeo = "Ipsum", Description = "Ipsum Category" });

            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "1",
                Title = "Lorem",
                Body = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using Content here, content here, making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text and a search for lorem ipsum will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose injected humour and the like",
                ShortDescription = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using ",
                PostedOn = DateTime.Now,
                Meta = "Lorem",
                UrlSeo = "Lorem",
                Published = true
            });
            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "2",
                Title = "Duis",
                Body = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using Content here, content here, making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text and a search for lorem ipsum will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose injected humour and the like",
                ShortDescription = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using ",
                PostedOn = DateTime.Now,
                Meta = "Duis",
                UrlSeo = "Duis",
                Published = true
            });
            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "3",
                Title = "Nulla",
                Body = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using Content here, content here, making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text and a search for lorem ipsum will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose injected humour and the like",
                ShortDescription = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using ",
                PostedOn = DateTime.Now,
                Meta = "Nulla",
                UrlSeo = "Nulla",
                Published = true
            });
            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "4",
                Title = "Ipsum",
                Body = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using Content here, content here, making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text and a search for lorem ipsum will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose injected humour and the like",
                ShortDescription = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using ",
                PostedOn = DateTime.Now,
                Meta = "Ipsum",
                UrlSeo = "Ipsum",
                Published = true
            });

            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "1", CategoryId = "cat1" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "2", CategoryId = "cat2" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "3", CategoryId = "cat3" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "4", CategoryId = "cat4" });

            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 1, PostId = "1", VideoSiteName = "YouTube", VideoUrl = "https://www.youtube.com/embed/9m9oO84Q2fk", VideoThumbnail = "http://i3.ytimg.com/vi/9m9oO84Q2fk/maxresdefault.jpg", });
            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 2, PostId = "2", VideoSiteName = "YouTube", VideoUrl = "https://www.youtube.com/embed/9m9oO84Q2fk", VideoThumbnail = "http://i3.ytimg.com/vi/9m9oO84Q2fk/maxresdefault.jpg", });
            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 3, PostId = "3", VideoSiteName = "YouTube", VideoUrl = "https://www.youtube.com/embed/9m9oO84Q2fk", VideoThumbnail = "http://i3.ytimg.com/vi/9m9oO84Q2fk/maxresdefault.jpg", });
            context.PostVideos.AddOrUpdate(new Models.PostVideo { Id = 4, PostId = "4", VideoSiteName = "YouTube", VideoUrl = "https://www.youtube.com/embed/9m9oO84Q2fk", VideoThumbnail = "http://i3.ytimg.com/vi/9m9oO84Q2fk/maxresdefault.jpg", });
            }
    }
}
