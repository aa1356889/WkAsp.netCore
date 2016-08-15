using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceImp
{
    public class UserManage:SysManage.IUserManage
    {
        public UserManage()
        {
        }

        public string Test()
        {
            return "为实现了接口方法";
        }
    }
}
