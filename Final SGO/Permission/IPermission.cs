using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SGO.Permission
{
    public interface IPermission
    {
        bool CheckPermission(string permissionName);
    }
}
