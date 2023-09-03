namespace WindowsFormsApp1
{
    public class User
    {
        private string _name;

        private int _age;

        public User(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int value)
        {
            _age = value;
        }
    }
}