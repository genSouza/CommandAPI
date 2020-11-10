using System.Collections.Generic;
using CommandAPI.Models;
using System.Linq;

namespace CommandAPI.Data
{
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        private readonly CommandContext _context;

        public SqlCommandAPIRepo(CommandContext context)
        {
            _context = context;
        }
        void ICommandAPIRepo.CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        void ICommandAPIRepo.DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Command> ICommandAPIRepo.GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        Command ICommandAPIRepo.GetCommandById(int id)
        {
            return _context.CommandItems.FirstOrDefault(p => p.Id == id);
        }

        bool ICommandAPIRepo.SaveChances()
        {
            throw new System.NotImplementedException();
        }

        void ICommandAPIRepo.UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}