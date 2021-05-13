using System;


namespace ConsoleAppProject.App04
{
    public class SocialNetwork
    {
        private int Choice;
        private int Option;

        NewsFeed news = new NewsFeed();
        
        public void Run()
        {
            PresentChoice();
        }

        public void PresentChoice()
        {
            do
            {
                Console.WriteLine("\n\bSocial Network Menu\b\n");
                Console.WriteLine("1.Post Message");
                Console.WriteLine("2.Post Photo");
                Console.WriteLine("3.Display All Posts By A User");
                Console.WriteLine("4.Display All Posts");
                Console.WriteLine("5.Remove Post");
                Console.WriteLine("6.Like, Unlike or Comment");
                Console.WriteLine("7.Quit");
                Console.Write("\nPlease enter your choice from 1 to 7 > ");
                string value = Console.ReadLine();
                Choice = Convert.ToInt32(value);

                if (Choice == 1)
                {
                    PostMsg();
                }

                if (Choice == 2)
                {
                    PhotoPost();
                }

                if (Choice == 3)
                {
                    FindingUser();
                }

                if (Choice == 4)
                {
                    news.Display();
                }

                if (Choice == 5)
                {
                    FindingUser();
                }

                if (Choice == 6)
                {
                    FindingUser();
                }

            } while (Choice != 7);
            
        }

        public void PostMsg()
        {

            Console.Write("\nWhat is your username? > ");
            string name = Console.ReadLine();  
            Console.Write("\nWhat Message would you like to write > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(name, message);
            news.AddMessagePost(post);

        }

        public void PhotoPost()
        {

            Console.Write("\nWhat is your username? > ");
            string author = Console.ReadLine();
            Console.Write("\nEnter the filename of the desired photo > ");
            string file = Console.ReadLine();
            Console.Write("\nEnter the Caption for the photo > ");
            string caption = Console.ReadLine();

            PhotoPost photo = new PhotoPost(author, file, caption);
            news.AddPhotoPost(photo);

        }

        public void FindingUser()
        {
            if (Choice == 3)
            {
                Console.Write("\nWhich user post would to like to display? > ");
                string userpost = Console.ReadLine();

                news.DisplayUserPost(userpost);

            }

            else if (Choice == 5)
            {
                Console.Write("\nWhich user post would to like to remove? > ");
                string userpost = Console.ReadLine();

                news.RemovePost(userpost);
            }

            else if (Choice == 6)
            {
                Console.Write("\nWhich user post would to like to Interact with? > ");
                string user = Console.ReadLine();

               if (news.UserFinder(user) != null)
                {
                    Post post = news.UserFinder(user);
                    Console.WriteLine("\nWe have successfully located the user post to interact with\n");
                    InteractOptions(post);
                }

            
         
            }

        }

        public void InteractOptions(Post post)
        {
            Console.WriteLine("1.Like the post\n");
            Console.WriteLine("2.Unlike the post\n");
            Console.WriteLine("3.Comment on the post\n");
            Console.Write("Which Options would you like to pick? > ");
            string value = Console.ReadLine();
            Option = Convert.ToInt32(value);


            if (Option == 1)
            {
                post.Like();
                Console.WriteLine("\nLiked!");
            }

            else if (Option == 2)
            {
                post.Unlike();
                Console.WriteLine("\nUnLiked!");
            }

            else if (Option == 3)
            {
                Console.Write("\nLeave a Comment > ");
                string comment = Console.ReadLine();

                post.AddComment(comment);

                Console.WriteLine("\nComment been added");
            }
        }
    }
}
