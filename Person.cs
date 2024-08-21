
namespace ClassPracticeOf18August
{
    internal class Person
    {
        public string Name;
        public string Surname;
        private int _age;

        public int Age 
        {
            get 
            {
                return _age;
            } set
            {
                if (value < 0)
                {
                    value = -1 * value;
                }
                if (value >0 && value < 200)
                {
                    _age = value;
                }
            }
        }
    }
}
