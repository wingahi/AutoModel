namespace Model
{
    public class admin
    {
        private int _i;
        public int id
        {
            get { return _i; }
            set { _i=value; }
        }
        private string _u;
        public string username
        {
            get { return _u; }
            set { _u=value; }
        }
        private string _p;
        public string password
        {
            get { return _p; }
            set { _p=value; }
        }
    }
}
