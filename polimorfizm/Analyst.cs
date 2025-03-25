namespace EmployeeManagement
{
    public class Analyst : Employee
    {
        private int _numberOfClients;

        public int NumberOfClients
        {
            get { return _numberOfClients; }
            set { _numberOfClients = value; }
        }

        public Analyst() : base()
        {
        }

        public Analyst(int id, string name, int age, string gender, decimal salary, int clients)
            : base(id, name, age, gender, salary)
        {
            NumberOfClients = clients;
        }

        public override void IncreaseSalary(decimal amount)
        {
            base.IncreaseSalary(amount + (NumberOfClients * 200));
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Position: Analyst, Clients: {NumberOfClients}";
        }
    }
} 