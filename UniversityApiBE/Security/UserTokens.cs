using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApiBE.Security
{

    // Esta clase permite instanciar un objeto JWT token apra el usuario que se haya logeado con éxito
    internal class UserTokens
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string UserName { get; set; }
        public TimeSpan Validity { get; set; }
        public string RefreshToken { get; set; }
        public string EmailId { get; set; }
        public Guid GuidId { get; set; }
        public DateTime ExpiredTime { get; set; }
    }
}
