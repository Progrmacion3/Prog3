namespace Common
{
    public abstract class Base
    {
        protected Base()
        {
        }

        protected Base(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public string VerToString
        {
            get { return ToString(); }
        }
    }
}
