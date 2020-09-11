using Bogus;
using DashBoard.Enum;
using DashBoard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard
{
    public class Board
    {
        //public IReporter ReportManager { get; }
        private static Board instance;
        private List<Task> _tasks;
        private Board()
        {
            var faker = new Faker();
            var taskBogus = new Faker<Task>()
                    .RuleFor(r => r.Discription, f => f.Lorem.Paragraph())
                    .RuleFor(r => r.Estimation, f => f.Random.Double(0, 7))
                    .RuleFor(r => r.Id, Guid.NewGuid().ToString())
                    .RuleFor(r => r.Owner, f => new User(f.Person.UserName, f.Person.LastName, f.Person.Avatar))
                    .RuleFor(r => r.Statuse, f => (State)(f.Random.Int(1, 6)))
                    .RuleFor(r => r.Title, f => f.Lorem.Word())
                    .RuleFor(r => r.Type, f => (TaskTypes)(f.Random.Int(1, 5)));



            var tasks = taskBogus.Generate(faker.Random.Number(120, 200));
            _tasks = tasks;


            //TODO:implement generating tasck list
        }
        public static Board GetInstanc()
        {
            if (instance == null)
            {
                instance = new Board();
            }

            return instance;
        }


        public List<Task> Tasks { get { return _tasks; } }
    }
}
