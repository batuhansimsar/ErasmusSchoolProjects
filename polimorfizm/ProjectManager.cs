namespace EmployeeManagement
{
    public class ProjectManager : Employee
    {
        private int _numberOfProjects;

        public int NumberOfProjects
        {
            get { return _numberOfProjects; }
            set { _numberOfProjects = value; }
        }

        public ProjectManager() : base()
        {
        }

        public ProjectManager(int id, string name, int age, string gender, decimal salary, int projects)
            : base(id, name, age, gender, salary)
        {
            NumberOfProjects = projects;
        }

        public override void IncreaseSalary(decimal amount)
        {
            base.IncreaseSalary(amount + (NumberOfProjects * 300));
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Position: Project Manager, Projects: {NumberOfProjects}";
        }
    }
} 