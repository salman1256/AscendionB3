namespace ConAppMethodParameters
{
    public class Salary

    {
       public void BonusCalc(double salary,out double bonus)
        {
            if(salary>=10000)
            {
                bonus = salary * 0.10;
            }
            else
            {
                bonus = salary * 0.20;
            }
        }
        public double TotalSalary(params double [] salaries)
        {
            double total = 0;
            foreach (var salary in salaries)
            {
                total += salary;
            }
            
            return total;

        }
    }
}
