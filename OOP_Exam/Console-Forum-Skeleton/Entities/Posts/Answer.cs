using ConsoleForum.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities.Posts
{
    public class Answer : Post, IAnswer
    {
        private bool hasBestAnswer;

        public Answer(int id, IUser author, string body)
            : base (id, author, body)
        {
            this.HasBestAnswer = false;
        }

        public bool HasBestAnswer
        {
            get
            {
                return this.hasBestAnswer;
            }
            set
            {
                this.hasBestAnswer = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string bestAnswerSeparator = "********************";

            if (this.HasBestAnswer)
            {
                result.AppendLine(bestAnswerSeparator);
            }

            string answerId = String.Format("[ Answer ID: {0} ]", this.Id);
            result.AppendLine(answerId);
            string answerAuthor = String.Format("Posted by: {0}", this.Author);
            result.AppendLine(answerAuthor);
            string answerBody = String.Format("Answer Body: {0}", this.Body);
            result.AppendLine(answerBody);
            string separator = "--------------------";
            result.AppendLine(separator);

            if (this.HasBestAnswer)
            {
                result.AppendLine(bestAnswerSeparator);
            }

            return result.ToString();
        }
    }
}
