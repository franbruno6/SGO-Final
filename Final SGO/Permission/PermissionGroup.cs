using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SGO.Permission
{
    public class PermissionGroup : IPermission
    {
        private List<IPermission> _permissions = new List<IPermission>();

        public void AddPermission(IPermission permission)
        {
            _permissions.Add(permission);
        }

        public bool CheckPermission(string permissionName)
        {
            return _permissions.Any(permission => permission.CheckPermission(permissionName));
        }
    }
}
