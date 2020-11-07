using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{

    public class MockCommandAPIRepo : ICommandAPIRepo
    {
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
            var commands = new List<Command> {
                new Command {
                    Id=0, HowTo="How to generate a migration",
      CommandLine="dotnet ef migrations add <Name of Migration>",
      Platform=".Net Core EF"},
      new Command{
      Id=1, HowTo="Run Migrations",
      CommandLine="dotnet ef database update",
      Platform=".Net Core EF"},
    new Command{
      Id=2, HowTo="List active migrations",
      CommandLine="dotnet ef migrations list",
      Platform=".Net Core EF"}
                };
            return commands;

        }


        Command ICommandAPIRepo.GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "How to generate a migration",
                CommandLine = "dotnet ef migrations add <Name of Migration>",
                Platform = ".Net Core EF"
            };
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