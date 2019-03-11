using ExercicioOrder.Entities.Enums;
using System.Collections.Generic;

namespace ExercicioOrder.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public  WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        //composição
        public Department Department { get; set; }
        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();


        //constructors
        public Worker()
        {

        }
        //sempre que tiver associação para muitos não é incluída no construtor ex : List HoursContract não foi incluída no construtor
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //métodos
        public void AddContract(HoursContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HoursContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach(HoursContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
