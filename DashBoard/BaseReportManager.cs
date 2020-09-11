using DashBoard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard
{
    public class BaseReportManager : IReporter
    {
        private List<Task> _tasks;
        public BaseReportManager(Board board)
        {
            _tasks = board.Tasks;

        }
        public List<Task> GetAll()
        {
          return _tasks;
        }
        public List<Task> GetFromEstimateRange(double startEstimation = 0, double finishEstimation = double.MaxValue)
        {
          return _tasks.Where(task => task.Estimation >= startEstimation && task.Estimation <= finishEstimation).ToList();
          
        }
    }

}
