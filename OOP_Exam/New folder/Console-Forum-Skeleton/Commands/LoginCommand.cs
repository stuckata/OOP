using ConsoleForum.Contracts;
using ConsoleForum.Entities.Users;
using ConsoleForum.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands
{
    class LoginCommand : AbstractCommand
    {
        public LoginCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            var users = this.Forum.Users;
            string username = this.Data[1];
            string password = PasswordUtility.Hash(this.Data[2]);

            if (this.Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }

            if (users.Any(u => u.Username == username && u.Password == password))
            {
                this.Forum.CurrentUser = users.Single(u => u.Username == username && u.Password == password);
                this.Forum.Output.AppendLine(
                string.Format(Messages.LoginSuccess, username, users.Last().Id)
                );
            }
            else
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }      
        }
    }
}
