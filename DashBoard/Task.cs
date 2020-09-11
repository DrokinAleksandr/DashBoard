using DashBoard.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard
{
    public class Task : BaseTask
    {
        public Task()
        {

        }
        public Task(double estimation, TaskTypes type, string title, string discription, User taskCreator, State Statuse = State.BackLog) : base(estimation, type, title, discription, taskCreator)
        {

        }
        public override void GetInfo()
        {
            Console.WriteLine("Task");
        }

    }
}
