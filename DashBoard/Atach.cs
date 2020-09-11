using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard
{
    class Atach
    {
        public string Name{ get; set; }
        public string Link { get; set; }

        private readonly DateTime _createdDate;

        public DateTime updateDate;
        public string Id { get; set; }
        public readonly string UserId;
        public readonly string TaskId;
        public Atach(string name,string link,string userId, string taskId)
        {
            Name = name;
            Link = link;
            UserId = userId;
            TaskId = taskId;
            Id = Guid.NewGuid().ToString();
            updateDate = DateTime.Now;
            _createdDate = DateTime.Now;






        }

    }
}
