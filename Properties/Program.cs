namespace Properties
{
    class student
    {
        private int _stdId;
        private string _fName;
        private string _lName;
        private int _subTotal = 100;

        public int subTotal
        {
            get { return this._subTotal; }
        }
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
        public int CNIC { get; private set; }
        public student(string fname,string lname,int cnic)
        {
            fname = fname.ToLower();
            lname = lname.ToLower();
            CNIC = cnic;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            student student = new student("Ali","Hameed",32304);
            Console.WriteLine(student.CNIC);
            student.stdId = 0365;
            student.fName = "Asim";
            student.lName = "Hameed";
            Console.WriteLine( student.stdId);
            Console.WriteLine("Your name is {0}",student.fName);
            Console.WriteLine("Your Father name is {0}", student.lName);
            Console.WriteLine("Total marks are {0}", student.subTotal);

        }
    }
}