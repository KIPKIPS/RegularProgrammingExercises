namespace 冒泡排序扩展
{
    public class Employee
    {
        public string Name { get; private set; }
        public int Salary { get; private set; }

        public Employee(string name,int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public static bool Compare(Employee e1, Employee e2)
        {
            if (e1.Salary > e2.Salary) return true;//按照薪水来排序,每个属性都要写一遍
            else return false;
        }

        public override string ToString()
        {
            return Name +"\t"+ Salary;
        }
    }
}