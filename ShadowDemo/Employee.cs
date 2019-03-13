namespace ShadowDemo {

    internal class Employee {
        public Employee() {
        }

        public Employee(string name, double salary) {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name { get; set; }

        public void RaiseSalary(double percentage) {
            this.Salary += Salary * (percentage / 100);
        }

        public double Salary { get; set; }

        public override string ToString() => $"Employee Name = {this.Name}, Salary = {this.Salary.ToString("C")}";
    }

}
