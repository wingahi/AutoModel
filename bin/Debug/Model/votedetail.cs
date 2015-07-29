namespace Model
{
    public class votedetail
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
        private int _u;
        public int userid
        {
            get { return _u; }
            set { _u=value; }
        }
        private int _s;
        public int score
        {
            get { return _s; }
            set { _s=value; }
        }
        private Datetime _v;
        public Datetime votetime
        {
            get { return _v; }
            set { _v=value; }
        }
    }
}
