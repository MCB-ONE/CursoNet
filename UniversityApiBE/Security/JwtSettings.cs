using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApiBE.Security
{
    public class JwtSettings
    {

		public bool ValidateIssuerSigningKey { get; set; }
		public string  IssuerSigningKey { get; set; } = String.Empty;

		public bool ValidateIssuer { get; set; }
		public string?  ValidIssuer { get; set; }

		public bool ValidateAudience { get; set; }
		public string? ValidAudience { get; set; }

		public bool RequireExpirationTime { get; set; }
		public bool ValidateLifetime { get; set; }
			

	}
}
