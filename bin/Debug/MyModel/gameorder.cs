namespace MyModel
{
    public class gameorder
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
        private string _g;
        public string gamename
        {
            get { return _g; }
            set { _g=value; }
        }
        private int _i;
        public int indexnumber
        {
            get { return _i; }
            set { _i=value; }
        }
        private int _o;
        public int ordernum
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
        private Datetime _m;
        public Datetime modifytime
        {
            get { return _m; }
            set { _m=value; }
        }
        private int _s;
        public int status
        {
            get { return _s; }
            set { _s=value; }
        }
    }
}
