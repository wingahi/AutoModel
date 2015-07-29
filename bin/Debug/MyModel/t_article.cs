namespace MyModel
{
    public class t_article
    {
        private long id;
        public long Id
        {
            get { return id; }
            set { id=value; }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title=value; }
        }
        private string pubaddtime;
        public string Pubaddtime
        {
            get { return pubaddtime; }
            set { pubaddtime=value; }
        }
        private int maxSlrAId;
        public int MaxSlrAId
        {
            get { return maxSlrAId; }
            set { maxSlrAId=value; }
        }
        private Datetime graptime;
        public Datetime Graptime
        {
            get { return graptime; }
            set { graptime=value; }
        }
        private double similary;
        public double Similary
        {
            get { return similary; }
            set { similary=value; }
        }
        private Datetime addtime;
        public Datetime Addtime
        {
            get { return addtime; }
            set { addtime=value; }
        }
        private Datetime p_Time;
        public Datetime P_Time
        {
            get { return p_Time; }
            set { p_Time=value; }
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status=value; }
        }
        private string p_UserName;
        public string P_UserName
        {
            get { return p_UserName; }
            set { p_UserName=value; }
        }
        private int netid;
        public int Netid
        {
            get { return netid; }
            set { netid=value; }
        }
        private int _a;
        public int articleId
        {
            get { return _a; }
            set { _a=value; }
        }
        private object isDel;
        public object IsDel
        {
            get { return isDel; }
            set { isDel=value; }
        }
        private Datetime delTime;
        public Datetime DelTime
        {
            get { return delTime; }
            set { delTime=value; }
        }
    }
}
