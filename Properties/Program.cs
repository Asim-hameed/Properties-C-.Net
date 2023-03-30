namespace Properties
{
    //class student
    //{
    //    private int _stdId;
    //    private string _fName;
    //    private string _lName;
    //    private int _subTotal = 100;

    //    public int subTotal
    //    {
    //        get { return this._subTotal; }
    //    }
    //    public int stdId
    //    {
    //        set 
    //        {
    //            if (value <= 0)
    //            {
    //                Console.WriteLine("Id cannot be zero or negative");
    //            }
    //            else
    //            {
    //                _stdId = value;
    //            }
    //        }
    //        get { return this._stdId; }
    //    }
    //    public string fName
    //    {
    //        set 
    //        {
    //            if (string.IsNullOrEmpty(value))
    //            {
    //                Console.WriteLine("Please enter your name: ");
    //            }
    //            else
    //            {
    //                _fName = value;
    //            }
    //        }
    //        get { return this._fName; }
    //    }
    //    public string lName
    //    {
    //        set
    //        {
    //            if (string.IsNullOrEmpty(value))
    //            {
    //                Console.WriteLine("Please enter your name: ");
    //            }
    //            else
    //            {
    //                _lName = value;
    //            }
    //        }
    //        get { return this._lName; }

    //    }
    //    public int CNIC { get; private set; }
    //    public student(string fname,string lname,int cnic)
    //    {
    //        fname = fname.ToLower();
    //        lname = lname.ToLower();
    //        CNIC = cnic;
    //    }
    //}

    //STATIC PROPERTY Start
    class univeristy
    {
        static string _universityName;
        static string _departmentName;

        public static string universityName 
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You cannot enter null or empty value is university name");
                }
                else
                {
                    _universityName = value;
                }
            }
            get
            {
                return _universityName;
            }
        }
        public static string departmentName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You cannot enter null or empty value is university name");
                }
                else
                {
                    _departmentName = value;
                }
            }
            get
            {
                return _departmentName;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            //student student = new student("Ali","Hameed",32304);
            //Console.WriteLine(student.CNIC);
            //student.stdId = 0365;
            //student.fName = "Asim";
            //student.lName = "Hameed";
            //Console.WriteLine( student.stdId);
            //Console.WriteLine("Your name is {0}",student.fName);
            //Console.WriteLine("Your Father name is {0}", student.lName);
            //Console.WriteLine("Total marks are {0}", student.subTotal);

        
            univeristy univeristy = new univeristy();
            univeristy.universityName = "FAST";
            univeristy.departmentName = "CS";
            Console.WriteLine("University name is {0}", univeristy.universityName);
            Console.WriteLine("Department name is {0}", univeristy.departmentName);
        }
    }
}