﻿namespace FA.JustBlog.Data.Migrations
{
    using FA.JustBlog.Models.Common;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FA.JustBlog.Data.JustBlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FA.JustBlog.Data.JustBlogDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var categories = new Category[]
            {
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Armand Fintano",
                    UrlSlug =   "travel",
                    Description ="Travel Blog",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Oscar Cardozo",
                    UrlSlug =   "recipe",
                    Description ="Recipe Blog",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Grizzy",
                    UrlSlug =   "tips",
                    Description ="Tips Blog",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Bernwood",
                    UrlSlug =   "life-style",
                    Description ="Life Style Blog",
                    IsDeleted = false
                }
            };

            var tag1 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Camel",
                UrlSlug = "travel",
                Description = "Travel Tag",
                IsDeleted = false
            };

            var tag2 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Xahara",
                UrlSlug = "food",
                Description = "food Tag",
                IsDeleted = false
            };

            var tag3 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Futre",
                UrlSlug = "recipe",
                Description = "recipe Tag",
                IsDeleted = false
            };

            var tag4 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Figo",
                UrlSlug = "tips",
                Description = "tips Tag",
                IsDeleted = false
            };

            var tag5 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Germany",
                UrlSlug = "study",
                Description = "study Tag",
                IsDeleted = false
            };

            var tag6 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Gasperini",
                UrlSlug = "life-style",
                Description = "life style Tag",
                IsDeleted = false
            };

            var tag7 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Scroll",
                UrlSlug = "setup",
                Description = "setup Tag",
                IsDeleted = false
            };

            var posts = new List<Post>
            {
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 01",
                    UrlSlug = "post-01",
                    ShortDescription = "This is Post 01",
                    ImageUrl = "blog-1.jpg",
                    PostContent = "Content post 01",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[0].Name),
                    Tags = new List<Tag>{tag1, tag2,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 02",
                    UrlSlug = "post-02",
                    ShortDescription = "This is Post 02",
                    ImageUrl = "blog-2.jpg",
                    PostContent = "Content post 02",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[3].Name),
                    Tags = new List<Tag>{tag1, tag4,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 03",
                    UrlSlug = "post-03",
                    ShortDescription = "This is Post 03",
                    ImageUrl = "blog-3.jpg",
                    PostContent = "Content post 03",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[1].Name),
                    Tags = new List<Tag>{tag5, tag2,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 04",
                    UrlSlug = "post-04",
                    ShortDescription = "This is Post 04",
                    ImageUrl = "blog-4.jpg",
                    PostContent = "Content post 04",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[2].Name),
                    Tags = new List<Tag>{tag1, tag5,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 05",
                    UrlSlug = "post-05",
                    ShortDescription = "This is Post 05",
                    ImageUrl = "blog-5.jpg",
                    PostContent = "Content post 05",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[1].Name),
                    Tags = new List<Tag>{tag2,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 06",
                    UrlSlug = "post-06",
                    ShortDescription = "This is Post 06",
                    ImageUrl = "blog-6.jpg",
                    PostContent = "Content post 06",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[0].Name),
                    Tags = new List<Tag>{tag6,tag3}
                }
            };
            context.Categories.AddRange(categories);
            context.Posts.AddRange(posts);
            context.SaveChanges();
        }
    }
}