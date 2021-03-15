using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
           var commands=new List<Command>
           {
               new Command
               {
                   Id=0, 
                   HowTo="How to generate a migration",
                   CommandLine="DotNet EF Migrations Add <Name of Migration>",
                   Platform=".Net Core EF"
               },
                new Command
               {
                   Id=1, 
                   HowTo="How to Run migration",
                   CommandLine="DotNet EF Database update",
                   Platform=".Net Core EF"
               },
                new Command
               {
                   Id=2, 
                   HowTo="List Active migration",
                   CommandLine="DotNet EF Migrations list",
                   Platform=".Net Core EF"
               },
           };
           return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id=0, 
                HowTo="How to generate a migration",
                CommandLine="DotNet EF Migrations Add <Name of Migration>",
                Platform=".Net Core EF"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}