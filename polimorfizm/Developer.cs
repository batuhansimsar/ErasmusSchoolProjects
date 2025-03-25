namespace EmployeeManagement
{
    public class Developer : Employee
    {
        private int _numberOfTechnologies;

        public int NumberOfTechnologies
        {
            get { return _numberOfTechnologies; }
            set { _numberOfTechnologies = value; }
        }

        public Developer() : base()
        {
        }

        public Developer(int id, string name, int age, string gender, decimal salary, int technologies)
            : base(id, name, age, gender, salary)
        {
            NumberOfTechnologies = technologies;
        }

        public override void IncreaseSalary(decimal amount)
        {
            base.IncreaseSalary(amount + (NumberOfTechnologies * 250));
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Position: Developer, Technologies: {NumberOfTechnologies}";
        }
    }
} 