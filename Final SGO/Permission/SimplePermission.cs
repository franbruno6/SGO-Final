using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SGO.Permission
{
    public class SimplePermission : IPermission
    {
        private string _permissionName;

        public SimplePermission(string permissionName)
        {
            _permissionName = permissionName;
        }

        public bool CheckPermission(string permissionName)
        {
            return _permissionName.Equals(permissionName, StringComparison.OrdinalIgnoreCase);
        }
    }
}
