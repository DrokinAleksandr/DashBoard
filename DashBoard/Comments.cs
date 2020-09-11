using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard
{
    class Comment
    {
        public string Id { get; set; }
        public readonly string TaskId;
        public readonly string AuthorId;

        public string CommentsText { get; set; }

        private readonly DateTime _createdDate;
        public DateTime updateDate;

        public Comment(string taskid,string authorid, string comment)
        {
            Id = Guid.NewGuid().ToString();
            TaskId = taskid;
            AuthorId = authorid;
            CommentsText = comment;
            _createdDate = DateTime.Now;
            updateDate = DateTime.Now;
        }


    }
}
