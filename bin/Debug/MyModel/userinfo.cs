namespace MyModel
{
    public class userinfo
    {
        private int _i;
        public int id
        {
            get { return _i; }
            set { _i=value; }
        }
        private int _u;
        public int userid
        {
            get { return _u; }
            set { _u=value; }
        }
        private string _t;
        public string token
        {
            get { return _t; }
            set { _t=value; }
        }
        private Datetime _u;
        public Datetime updatetime
        {
            get { return _u; }
            set { _u=value; }
        }
    }
}
