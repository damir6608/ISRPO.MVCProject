using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISRPO.MVCProject.Models
{
    public class Students
    {
        public List<int> Height { get; set; }

        public string answer { get; set; }

        public bool IsDescending(List<int> arr)
        {
            for (int i = 1; i < arr.Count; i++)
                if (arr[i] > arr[i - 1]) return false;
            return true;
        }
    }
}
