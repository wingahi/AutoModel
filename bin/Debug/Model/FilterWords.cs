namespace Model
{
    public class FilterWords
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id=value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name=value; }
        }
        private string replaces;
        public string Replaces
        {
            get { return replaces; }
            set { replaces=value; }
        }
        private object isDel;
        public object IsDel
        {
            get { return isDel; }
            set { isDel=value; }
        }
        private string addUserName;
        public string AddUserName
        {
            get { return addUserName; }
            set { addUserName=value; }
        }
        private Datetime addtime;
        public Datetime Addtime
        {
            get { return addtime; }
            set { addtime=value; }
        }
        private string delUserName;
        public string DelUserName
        {
            get { return delUserName; }
            set { delUserName=value; }
        }
        private Datetime updateTime;
        public Datetime UpdateTime
        {
            get { return updateTime; }
            set { updateTime=value; }
        }
        private string upUserName;
        public string UpUserName
        {
            get { return upUserName; }
            set { upUserName=value; }
        }
    }
}
