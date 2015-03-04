using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands
{
    public class PostAnswerCommand : AbstractCommand
    {
        public PostAnswerCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            string answerBody = this.Data[1];
       
            if (this.Forum.IsLogged)
            {
                if (!this.Forum.Questions.Any())
                {
                    int id = this.Forum.CurrentUser.Id;
                    IUser author = this.Forum.CurrentUser;

                    this.Forum.Answers.Add(new Answer(id, author, answerBody));
                } else
                {
                    throw new CommandException(Messages.NoQuestionOpened);
                }              
            }
            else
            {
                throw new CommandException(Messages.NotLogged);
            }
        }
    }
}
