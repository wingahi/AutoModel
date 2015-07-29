namespace MyModel
{
    public class SysRolePermission
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id=value; }
        }
        private int permissionId;
        public int PermissionId
        {
            get { return permissionId; }
            set { permissionId=value; }
        }
        private int roleId;
        public int RoleId
        {
            get { return roleId; }
            set { roleId=value; }
        }
    }
}
