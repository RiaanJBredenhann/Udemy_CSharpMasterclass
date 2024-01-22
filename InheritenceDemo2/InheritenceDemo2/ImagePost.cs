using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceDemo2
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        // empty method calls the base constructor - the base being Post
        public ImagePost() { }

        public ImagePost(string title, bool isPublic, string sendByUsername, string imageUrl)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
            this.ImageURL = imageUrl;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} - by {this.SendByUsername}");
        }
    }
}
