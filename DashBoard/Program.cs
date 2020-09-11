using System;
using DashBoard;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashBoard.Interfaces;

namespace DashBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = Board.GetInstanc();
            IReporter reportManager = new BaseReportManager( board);



        }
    }
}
