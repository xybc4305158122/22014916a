using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    class SocialNetworkMain
    {
        public int PostID = 0;

        NewsFeed news = new NewsFeed();
        public void Run()
        {
            DisplayMenu();
        }

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Social Network ");

            string[] choices =
            {
              "Post Message", "Post Photo", "Display All Posts By A User", "Display All Posts", "Remove Post",
                "Add Like, Unlike or comment " , "Quit"
            };

            int exit = 0;

            do
            {
                Console.WriteLine("\nSocial Network Menu \n");
                int choice = ConsoleHelper.SelectChoice(choices);

                if (choice == 1)
                {
                    PostMessage();
                }
                else if (choice == 2)
                {
                    PostPhoto();
                }
                else if (choice == 3)
                {
                    FindUserPosts();
                }
                else if (choice == 4)
                {
                    news.Display();
                }
                else if (choice == 5)
                {
                    RemovePost();
                }
                else if (choice == 6)
                {
                    AddLikeComment();
                }
                else if (choice == 7)
                {
                    exit = 1;
                }
            }
            while (exit != 1);
        }

        public void PostMessage()
        {
            int id = PostID++;

            Console.WriteLine("\nWhat is your name ");
            string name = Console.ReadLine();

            Console.WriteLine("\nWhat message would you like to post");
            string message = Console.ReadLine();
            Console.WriteLine();

            MessagePost post = new MessagePost(id, name,message);
            news.AddMessagePost(post);
        }

        public void PostPhoto()
        {
            int id = PostID++;

            Console.WriteLine("\nPlease enter the author name ");
            string authorname = Console.ReadLine();

            Console.WriteLine("\nInsert filename of your photo ");
            string filename = Console.ReadLine();

            Console.WriteLine("\nPlease write a caption for your photo ");
            string caption = Console.ReadLine();

            PhotoPost photo = new PhotoPost(id,authorname, filename, caption);
            news.AddPhotoPost(photo);
        }

        public void FindUserPosts()
        {
            Console.WriteLine("\nWhich users posts would you like to find ");
            string user = Console.ReadLine();

            news.FindUser(user);
        }

        public void RemovePost()
        {
            Console.WriteLine("\nWhat is the ID of the post you would like to remove ");
            int choice = Convert.ToInt32(Console.ReadLine());

            news.FindID(choice);
        }

        public void AddLikeComment()
        {
            Console.WriteLine("\nSearch post by the ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (news.FindMessagePost(id) != null)
            {
                MessagePost message = news.FindMessagePost(id);
                MenuChoices(message,null);
            }
            else if (news.FindPhotoPost(id) != null)
            {
                PhotoPost post = news.FindPhotoPost(id);
                MenuChoices(null, post);
            }
            else
            {
                Console.WriteLine("Post against this ID is not available ");
            }
        }

        public void MenuChoices(MessagePost message, PhotoPost post)
        {
            Console.WriteLine("\nWhat would you like to do");
            string[] choices = { "\nLike this post", "Unlike this post", "Comment on this post"};

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                if (message != null)
                {
                    message.Like();
                }
                else
                {
                    post.Like();
                }

                Console.WriteLine("\nYour action has been recorded ");
            }
            else if (choice == 2)
            {
                if (message != null)
                {
                    message.Unlike();
                }
                else
                {
                    post.Unlike();
                }

                Console.WriteLine("\nYour action has been recorded ");
            }
            else if (choice == 3)
            {
                Console.WriteLine("What comment would you like to add to this post ");
                string comment = Console.ReadLine();
                if (message != null)
                {
                    message.AddComment(comment);
                }
                else
                {
                    post.AddComment(comment);
                }

                Console.WriteLine("\nYour action has been recorded ");
            }
        }
    } 
}
