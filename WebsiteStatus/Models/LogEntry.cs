using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteStatus.Models
{
    public class LogEntry
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
