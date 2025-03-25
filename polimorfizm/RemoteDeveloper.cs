namespace EmployeeManagement
{
    public class RemoteDeveloper : Developer
    {
        private int _distance;

        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        public RemoteDeveloper() : base()
        {
        }

        public RemoteDeveloper(int id, string name, int age, string gender, decimal salary, int technologies, int distance)
            : base(id, name, age, gender, salary, technologies)
        {
            Distance = distance;
        }

        public override void IncreaseSalary(decimal amount)
        {
            base.IncreaseSalary(amount + (Distance * 5));
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Remote Distance: {Distance}km";
        }
    }
} 