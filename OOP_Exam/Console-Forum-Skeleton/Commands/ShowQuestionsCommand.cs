using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands
{
    public class ShowQuestionsCommand : AbstractCommand
    {
        public ShowQuestionsCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            var questions = this.Forum.Questions;

            if (!questions.Any())
            {
                throw new CommandException(Messages.NoQuestions);
            }
            else
            {
                foreach (var question in questions)
                {
                    Console.WriteLine(question);
                    if (!question.Answers.Any())
                    {
                        Console.WriteLine("No Answers");
                    }
                    else
                    {
                        List<Answer> answers = (List<Answer>)question.Answers;
                        answers.OrderBy(a => a.HasBestAnswer);

                        foreach (var answer in answers)
                        {
                            Console.WriteLine(answer);
                        }
                    }
                }
            }  
        }
    }
}
