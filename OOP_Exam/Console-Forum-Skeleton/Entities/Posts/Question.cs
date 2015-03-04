using ConsoleForum.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities.Posts
{
    public class Question : Post, IQuestion
    {
        private string title;

        public Question(int id, IUser author, string body, string title)
            : base(id, author, body)
        {
            this.Title = title;
        }

        public IList<IAnswer> Answers { get; set; }

        public string Title
        {
            get
            {
               return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string questionId = String.Format("[ Question ID: {0} ]", this.Id);
            result.AppendLine(questionId);
            string questionAuthor = String.Format("Posted by: {0}", this.Author);
            result.AppendLine(questionAuthor);
            string questionTitle = String.Format("Question Title: {0}", this.Title);
            result.AppendLine(questionTitle);
            string questionBody = String.Format("Question Body: {0}", this.Body);
            result.AppendLine(questionBody);
            string separator = "====================";
            result.AppendLine(separator);

            return result.ToString();
        }
    }
}
