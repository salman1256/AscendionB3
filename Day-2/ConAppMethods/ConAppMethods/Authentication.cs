using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethods
{
    public class Authentication
    {
        public string SignIn(string username, string password)
        {
            string msg;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                msg = "Please provide username and password ";
            }
            else
            {
                if((username=="sam1256")&&(password=="sam@1256@1256"))
                        {
                    msg = "Signin Success!!!";
                }
                else
                {
                    msg = "Sigin Failed !!!";
                }
                
            }
            return msg;
        }
    }
}
