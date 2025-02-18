using MambaUser.Models;

namespace MambaUser.Data
{
    public class SeedData
    {
        private readonly AppDbContext _context;
        public SeedData(AppDbContext context)
        {
            _context = context;
        }

        public void AddUsers()
        {
            if (_context.Users == null)
            {


                var User1 = new LoginUser
                {
                    UserName = "Kishan singh",
                    IsActive = true,
                    CreatedBy = 1,
                    ModifiedBy = 1,
                    CreatedDate = DateTime.Today,
                    ModifiedDate = DateTime.Today,
                    Phone = 124567893,
                    Email = "Kishansingh223311@gmail.com",
                    Password = "Kishan(23)",
                };
                _context.Users.Add(User1);
                _context.SaveChanges();

                var user2 = new LoginUser
                {
                    UserName = "Udaybhan",
                    Email = "uday1993@gmail.com",
                    CreatedBy = 1,
                    ModifiedBy = 1,
                    CreatedDate = DateTime.Today,
                    ModifiedDate = DateTime.Now,
                    Password = "Uday123",
                    Phone = 321654987,
                    IsActive = false
                };

                _context.Users.Add(user2);
                _context.SaveChanges();

                var user3 = new LoginUser
                {
                    UserName = "Gautam sonar",
                    CreatedBy = 1,
                    ModifiedBy = 1,
                    CreatedDate = DateTime.Today,
                    ModifiedDate = DateTime.Today,
                    Email = "Buddha@gmail.com",
                    IsActive = true,
                    Phone = 7778884445,
                    Password = "GautamOnPeace"
                };
                _context.Users.Add(user3);
                _context.SaveChanges();
            }
        }

        public void AddAdmin()
        {
            var Admin2 = new Admin
            {
                Name = "Harkirat",
                Password = "Kirat#534$",

            };
            var Admin3 = new Admin
            {
                Name = "ShriKaranhanda",
                Password = "GithubvDay365of2025",

            };
            _context.Add(Admin2);
            //_context.SaveChanges();
            _context.Add(Admin3);
            _context.SaveChanges();
        }

        public void AddBooks()
        {
            var book1 = new books
            {
                Name = "Rich Dad Poor dad",
                Author = "Unknown",
                Category = Category.non_fictional,
                CreatedBy = 1,
                Modifiedby = 1,
                CreatedDate = DateTime.Today,
                ModifiedDate = DateTime.Today,
                Description = "Great motivational, inspirational book for understanding finnancial growth and case studies",
                IsActive = true,
                Price = 199.50
            };

            var book2 = new books
            {
                Name = "Atomic habits",
                Author = "Rick",
                Category = Category.other,
                CreatedBy = 1,
                Modifiedby = 1,
                CreatedDate = DateTime.Today,
                ModifiedDate = DateTime.Today,
                Description = "Talks about the habit of successful people an dmotivates to make your life better",
                IsActive = true,
                Price = 124.99
            };

            var book3 = new books
            {
                Name = "Eat that frog",
                Author = "we'll let ytou know",
                Category = Category.other,
                CreatedBy = 1,
                Modifiedby = 1,
                CreatedDate = DateTime.Today,
                ModifiedDate = DateTime.Today,
                Description ="book to manage time and make it productive at the end of the day ",
                IsActive = true,
                Price = 249.00
            };
_context.Add(book1);
_context.Add(book2);
_context.Add(book3);
_context.SaveChanges();

        }
    }
}