using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        private readonly List<Post> Posts;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            Posts = new List<Post>();
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            Posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
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
