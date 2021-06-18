using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    class SocialNetworkMain
    {
        /// <summary>
        /// My Global variables for my class.
        /// </summary>
        public int PostID = 0;

        /// <summary>
        /// The news feed object.
        /// </summary>
        NewsFeed news = new NewsFeed();

        /// <summary>
        /// The run method consisting of other methods.
        /// </summary>
        public void Run()
        {
            DisplayMenu();
        }

        /// <summary>
        /// The display man for my class consisting of choices of what to do
        /// in the social network.
        /// </summary>
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

        /// <summary>
        /// The post message function to add a message to the social 
        /// network. 
        /// </summary>
        public void PostMessage()
        {
            int id = PostID++;

            Console.WriteLine("\nWhat is your name ");
            string name = Console.ReadLine();

            Console.WriteLine("\nWhat message would you like to post");
            string message = Console.ReadLine();
            Console.WriteLine();

            MessagePost post = new MessagePost(name,message);
            news.AddMessagePost(post);
        }

        /// <summary>
        /// This function is to post a photo to the social network.
        /// </summary>
        public void PostPhoto()
        {
            int id = PostID++;

            Console.WriteLine("\nPlease enter the author name ");
            string authorname = Console.ReadLine();

            Console.WriteLine("\nInsert filename of your photo ");
            string filename = Console.ReadLine();

            Console.WriteLine("\nPlease write a caption for your photo ");
            string caption = Console.ReadLine();

            PhotoPost photo = new PhotoPost(authorname,filename, caption);
            news.AddPhotoPost(photo);
        }

        /// <summary>
        /// This method will find a users posts by entering in the 
        /// the users name.
        /// </summary>
        public void FindUserPosts()
        {
            Console.WriteLine("\nWhich users posts would you like to find ");
            string user = Console.ReadLine();

            news.FindUser(user);
        }

        /// <summary>
        /// This method will remove the post from a social network.
        /// </summary>
        public void RemovePost()
        {
            Console.WriteLine("\nWhat is the ID of the post you would like to remove ");
            int choice = Convert.ToInt32(Console.ReadLine());

            news.FindID(choice);
        }

        /// <summary>
        /// This method will add a like to the certain posts.
        /// You will need to search the post by the Post ID.
        /// </summary>
        public void AddLikeComment()
        {
            Console.WriteLine("\nSearch post by the ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (news.FindPost(id) != null)
            {
                Post post = news.FindPost(id);
                MenuChoices(post);
            }
            else
            {
                Console.WriteLine("Post against this ID is not available ");
            }
        }

        /// <summary>
        /// Menu Choices of what to do once you have selected the comment option.
        /// </summary>
        /// <param name="post"></param>
        public void MenuChoices(Post post)
        {
            Console.WriteLine("\nWhat would you like to do");
            string[] choices = { "Like this post", "Unlike this post", "Comment on this post"};

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                post.Like();
                Console.WriteLine("\nYour action has been recorded ");
            }
            else if (choice == 2)
            {
                post.Unlike();
                Console.WriteLine("\nYour action has been recorded ");
            }
            else if (choice == 3)
            {
                Console.WriteLine("What comment would you like to add to this post ");
                string comment = Console.ReadLine();

                post.AddComment(comment);

                Console.WriteLine("\nYour action has been recorded ");
            }
        }
    } 
}
