using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.ResponceCLasses
{
    public partial class RespocneUser
    {
        public RespocneUser(string userName, string userPass)
        {
            userName = UserName;
            userPass = UserPass;
        }

        public string UserName { get; set; }
        public  string UserPass { get; set; }
    }
}
