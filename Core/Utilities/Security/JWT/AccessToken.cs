using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken 
    {
        public string Token { get; set; } //json web token değeridir. 
        public DateTime Expiration { get; set; }
    }
}
