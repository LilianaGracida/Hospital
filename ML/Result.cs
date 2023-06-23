using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Result
    {
        public bool Correct { get; set; }
        public List<Object> Object { get; set; }
        public List<Object> Objects { get; set; }
        public string ErrorMessage { get; set; }
    }
}
