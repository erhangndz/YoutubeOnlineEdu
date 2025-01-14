using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Configurations
{
    public class JwtTokenOptions
    {
        public string Issuer { get; set; } //api.onlineedu.com
        public string Audience { get; set; } //www.onlineedu.com
        public string Key { get; set; }
        public int ExpireInMinutes { get; set; }
    }
}
