using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;
using ConsoleForum.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands
{
    public class PostQuestionCommand : AbstractCommand
    {
        public PostQuestionCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            string questionTitle = this.Data[1];
            string questionBody = this.Data[2];           

            if (this.Forum.IsLogged)
            {
                int id = this.Forum.CurrentUser.Id;
                IUser author = this.Forum.CurrentUser;

                this.Forum.Questions.Add(new Question(id, author, questionBody, questionTitle));
            } else
            {
                throw new CommandException(Messages.NotLogged);
            }
        }
    }
}
