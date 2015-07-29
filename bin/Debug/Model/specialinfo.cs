namespace Model
{
    public class specialinfo
    {
        private int _i;
        public int id
        {
            get { return _i; }
            set { _i=value; }
        }
        private int _s;
        public int specialid
        {
            get { return _s; }
            set { _s=value; }
        }
        private int _r;
        public int resid
        {
            get { return _r; }
            set { _r=value; }
        }
        private int _a;
        public int articleid
        {
            get { return _a; }
            set { _a=value; }
        }
        private int _c;
        public int channelid
        {
            get { return _c; }
            set { _c=value; }
        }
        private Datetime _a;
        public Datetime addtime
        {
            get { return _a; }
            set { _a=value; }
        }
    }
}
