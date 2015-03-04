using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands
{
    public class OpenQuestionCommand : AbstractCommand
    {
        public OpenQuestionCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            var questions = this.Forum.Questions;
            int questionId = int.Parse(this.Data[1]);

            if (!questions.Any(q => q.Id == questionId))
            {
                Question question = (Question)questions.Where(q => q.Id == questionId);
                Console.WriteLine(question);
                if (question.Answers.Any() && question.Answers != null)
                {
                    List<Answer> answers = (List<Answer>)question.Answers;
                    answers.OrderBy(a => a.HasBestAnswer);

                    foreach (var answer in answers)
                    {
                        Console.WriteLine(answer);
                    }
                }
            } else
            {
                throw new CommandException(Messages.NoQuestion);
            }
        }
    }
}
