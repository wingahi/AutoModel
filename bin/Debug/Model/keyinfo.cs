namespace Model
{
    public class keyinfo
    {
        private int _i;
        public int id
        {
            get { return _i; }
            set { _i=value; }
        }
        private int _n;
        public int netid
        {
            get { return _n; }
            set { _n=value; }
        }
        private string _n;
        public string name
        {
            get { return _n; }
            set { _n=value; }
        }
        private int _a;
        public int articleid
        {
            get { return _a; }
            set { _a=value; }
        }
        private int _o;
        public int orderid
        {
            get { return _o; }
            set { _o=value; }
        }
        private Datetime _a;
        public Datetime addtime
        {
            get { return _a; }
            set { _a=value; }
        }
        private Datetime _u;
        public Datetime updatetime
        {
            get { return _u; }
            set { _u=value; }
        }
    }
}
