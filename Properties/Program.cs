namespace Properties
{
    class student
    {
        private int _stdId;
        private string _fName;
        private string _lName;

        public int stdId
        {
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Id cannot be zero or negative");
                }
                else
                {
                    _stdId = value;
                }
            }
            get { return this._stdId; }
        }
        public string fName
        {
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter your name: ");
                }
                else
                {
                    _fName = value;
                }
            }
            get { return this._fName; }
        }
        public string lName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter your name: ");
                }
                else
                {
                    _lName = value;
                }
            }
            get { return this._lName; }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            student student = new student();
            student.stdId = 0365;
            student.fName = "Asim";
            student.lName = "Hameed";
            Console.WriteLine( student.stdId);
            Console.WriteLine("Your name is {0}",student.fName);
            Console.WriteLine("Your name is {0}", student.lName);

        }
    }
}