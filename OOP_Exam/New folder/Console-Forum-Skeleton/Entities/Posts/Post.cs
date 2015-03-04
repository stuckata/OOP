using ConsoleForum.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities.Posts
{
    public class Post : IPost
    {
        private int id;
        private IUser author;
        private string body;

        public Post(int id, IUser author, string body)
        {
            this.Id = id;
            this.Author = author;
            this.Body = body;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public IUser Author
        {
            get
            {
                return this.author;
            }
            set
            {
                this.author = value;
            }
        }

        public string Body
        {
            get
            {
                return this.body;
            }
            set
            {
                this.body = value;
            }
        }
    }
}
