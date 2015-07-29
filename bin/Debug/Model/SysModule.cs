namespace Model
{
    public class SysModule
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id=value; }
        }
        private int parentId;
        public int ParentId
        {
            get { return parentId; }
            set { parentId=value; }
        }
        private string moduleName;
        public string ModuleName
        {
            get { return moduleName; }
            set { moduleName=value; }
        }
        private string url;
        public string Url
        {
            get { return url; }
            set { url=value; }
        }
        private string params;
        public string Params
        {
            get { return params; }
            set { params=value; }
        }
        private object commonVail;
        public object CommonVail
        {
            get { return commonVail; }
            set { commonVail=value; }
        }
        private object public;
        public object Public
        {
            get { return public; }
            set { public=value; }
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status=value; }
        }
        private string admin;
        public string Admin
        {
            get { return admin; }
            set { admin=value; }
        }
        private Datetime addtime;
        public Datetime Addtime
        {
            get { return addtime; }
            set { addtime=value; }
        }
        private Datetime updateTime;
        public Datetime UpdateTime
        {
            get { return updateTime; }
            set { updateTime=value; }
        }
        private string updateAdmin;
        public string UpdateAdmin
        {
            get { return updateAdmin; }
            set { updateAdmin=value; }
        }
    }
}
