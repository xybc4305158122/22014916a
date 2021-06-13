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
        private readonly List<MessagePost> messages;
        private readonly List<PhotoPost> photos;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            messages = new List<MessagePost>();
            photos = new List<PhotoPost>();
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            messages.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            photos.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (MessagePost message in messages)
            {
                message.Display();
                Console.WriteLine();   // empty line between posts
            }

            // display all photos
            foreach (PhotoPost photo in photos)
            {
                photo.Display();
                Console.WriteLine();   // empty line between posts
            }
        }

        public void FindUser(string user)
        {
            foreach (MessagePost message in messages)
            {
                if (message.Username == user)
                {
                    message.Display();
                    Console.WriteLine();   // empty line between posts
                }
            }    

            foreach (PhotoPost photo in photos)
            {
                if (photo.Username == user)
                {
                    photo.Display();
                    Console.WriteLine();   // empty line between posts
                }
            }
        }

        public void FindID(int id)
        {
            int counter = 0;

            foreach (MessagePost message in messages)
            {
                if (message.ID == id)
                {
                    messages.Remove(message);
                    Console.WriteLine("Your post has been removed ");
                    return;
                    counter++;
                }
            }

            foreach (PhotoPost photo in photos)
            {
                if (photo.ID == id)
                {
                    photos.Remove(photo);
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

        public MessagePost FindMessagePost(int id)
        {
            foreach (MessagePost message in messages)
            {
                if (id == message.ID)
                {
                    return message;
                }
            }
            return null;
        }

        public PhotoPost FindPhotoPost(int id)
        {
            foreach (PhotoPost photo in photos)
            {
                if (id == photo.ID)
                {
                    return photo;
                }
            }
            return null; 
        }
    }

}
