using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixingApp.Entities
{
    public class Cfid
    {
        public Error Error { get; set; }
        public string Token { get; set; }
        public string Version { get; set; }
        public string ClientVersion { get; set; }
        public Boolean Running { get; set; }
    }
    public class Error
    {
        public string Type { get; set; }
        public string Message { get; set; }
    }
}
