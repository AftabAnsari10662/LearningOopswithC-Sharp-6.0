namespace DelegatesAndEvents
{
    public class Employee
    {
        public Employee()
        {
            _Name = "No Name";
        }

        public int Id { get; set; }

        string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                if (_Name != value)
                {
                    NameChanged(_Name, value);
                }
                _Name = value;
            }

        }

        public event NameChangedDelegate NameChanged;
    }
}
