using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YtsSharpApi.Models
{

    public class RootObject
    {
        public string status { get; set; }
        public string status_message { get; set; }
        public Data data { get; set; }
        public Meta __invalid_name__meta { get; set; }
    }
}
