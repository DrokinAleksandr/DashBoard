using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string Image { get; set; }
        public string Id{get;set;}

        //private readonly DateTime _createdDate;
        //public DateTime updateDate;
        public User()
        {

        }
        public User(string firstN,string lsatN,string image)
        {
            firstName = firstN;
            lastName = lsatN;
            Image = image;
            Id = Guid.NewGuid().ToString();

        }

    }





}
