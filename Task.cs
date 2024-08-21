

namespace ClassPracticeOf18August
{
  class Student
    {
        //public int no 
        //{
        //    get
        //    {
                
        //    }
        //    set
        //    {

        //    }
        //}
        public string fullName { get; set; }

		private string _groupNo;

		public string groupNo
		{
			get 
            { 
                return _groupNo; 
            }
			set 
            {
                if (value.Length == 4 && char.IsLetter(value[0]))
                {
                    _groupNo = value;
                }
            }
		}

        public Student()
        {
            int count = 1;
        }

    }
}
