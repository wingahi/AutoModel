namespace Model
{
    public class worklog
    {
        private int _i;
        public int id
        {
            get { return _i; }
            set { _i=value; }
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
        private Datetime _d;
        public Datetime daytime
        {
            get { return _d; }
            set { _d=value; }
        }
        private string _u;
        public string username
        {
            get { return _u; }
            set { _u=value; }
        }
        private string _r;
        public string rizhi
        {
            get { return _r; }
            set { _r=value; }
        }
        private string _y;
        public string yuce
        {
            get { return _y; }
            set { _y=value; }
        }
        private string _j;
        public string jishi
        {
            get { return _j; }
            set { _j=value; }
        }
    }
}
