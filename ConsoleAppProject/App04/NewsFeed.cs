using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This is the news feed class for my project of a social network.
    /// Version 1.0
    ///<AbdulSalam> 
    public class NewsFeed
    {
        /// <summary>
        /// This is the Posts arraylist.
        /// </summary>
        private readonly List<Post> Posts;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            Posts = new List<Post>();
        }

        /// <summary>
        /// Add a text post to the news feed.
        /// </summary>
        /// <param name="message"></param>
        public void AddMessagePost(MessagePost message)
        {
            Posts.Add(message);
        }

        /// <summary>
        /// Add a photo post to the news feed.
        /// </summary>
        /// <param name="photo"></param>
        public void AddPhotoPost(PhotoPost photo)
        {
            Posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post Post in Posts)
            {
                Post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }

        /// <summary>
        /// This function is to find a post by the users name.
        /// </summary>
        /// <param name="user"></param>
        public void FindUser(string user)
        {
            int counter = 0;

            foreach (Post Post in Posts)
            {
                if (Post.Username == user)
                {
                    Post.Display();
                    Console.WriteLine();   // empty line between posts
                    counter++;
                }
            }
             if (counter == 0)
             {
                Console.WriteLine("\nNo such user exists in the current context ");
             }
        }

        /// <summary>
        /// This function will find a post by using the ID.
        /// </summary>
        /// <param name="id"></param>
        public void FindID(int id)
        {
            int counter = 0;

            foreach (Post Post in Posts)
            {
                if (Post.PostID == id)
                {
                    Posts.Remove(Post);
                    Console.WriteLine("Your post has been removed ");
                    return;
                    counter++;
                }
            }

            if (counter < 1)
            {
                Console.WriteLine("No such ID of a post exists ");
            }
        }

        /// <summary>
        /// This function will find a post by the ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Post FindPost(int id)
        {
            foreach (Post post in Posts)
            {
                if (id == post.PostID)
                {
                    return post;
                }
            }
            return null;
        }
    }

}
