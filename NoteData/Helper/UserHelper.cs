using Note.DAL.Models;

namespace Note.DAL.Helper
{
    public static class UserHelper
    {
        public static void AddStaticUser()
        {
            var context = new NoteContext();
            var vlad = new User()
            {
                Name = "Vlad",
                Email = "nenchin2001@gmail.com",
                Password = "1234",
                notes = new List<Models.Note>()
                {
                    new Models.Note()
                    {
                        Title = "Life",
                        Content = "My life is good as good as me"
                    },
                    new Models.Note()
                    {
                        Title = "Love",
                        Content = "What is love?" +
                                  "Baby, don't hurt me" +
                                  "Don't hurt me, no more" +
                                  "Baby, don't hurt me" +
                                  "Don't hurt me, no more" +
                                  "What is love? Yeah"
                    }

                }

            };
            var andrey = new User()
            {
                Name = "Andrey",
                Email = "freq2401@gmail.com",
                Password = "1234",
                notes = new List<Models.Note>()
                {
                    new Models.Note()
                    {
                        Title = "Life",
                        Content = "My life is bad as bad as me"
                    },
                    new Models.Note()
                    {
                        Title = "Space ",
                        Content = "Space is the boundless three-dimensional extent in which objects and events have relative position and direction."
                    }

                }

            };
            context.Add(vlad);
            context.Add(andrey);
            context.SaveChanges();
            
        }
    }
}
