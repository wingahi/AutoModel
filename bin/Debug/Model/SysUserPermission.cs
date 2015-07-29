namespace Model
{
    public class SysUserPermission
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
        private int userId;
        public int UserId
        {
            get { return userId; }
            set { userId=value; }
        }
        private object forbiden;
        public object Forbiden
        {
            get { return forbiden; }
            set { forbiden=value; }
        }
    }
}
