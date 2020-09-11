using DashBoard.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard
{
    public abstract class BaseTask
    {
        public double Estimation { get; set; }
        public TaskTypes Type { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public string Id { get; set; }

        private readonly DateTime _createdDate;

        public DateTime updateDate;
        public abstract void GetInfo();
        public  User Owner { get; set; }
        public readonly User Creator;
        public State Statuse { get; set; }
        public BaseTask()
        {

        }
        public BaseTask(double estimation,TaskTypes type, string title, string discription,User taskCreator, State statuse=State.BackLog)
        {
            Estimation = estimation;
            Type = type;
            Title = title;
            Discription = discription;
            Id = Guid.NewGuid().ToString();
            updateDate = DateTime.Now;
            _createdDate = DateTime.Now;
            Creator = taskCreator;
            Statuse = statuse;

        }



    }
}
