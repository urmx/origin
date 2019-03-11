using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioOrder.Entities
{
    class HoursContract
    {
        //properties
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //construtores
        public HoursContract()
        {

        }

        public HoursContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        //Funções(métodos)
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
