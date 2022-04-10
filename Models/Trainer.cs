using System;
using System.Collections.Generic;

namespace WebMVC.Models
{
    public class Trainer
    {
        public int TrainerID {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public DateTime EnrollmentDate {get;set;}

        public virtual ICollection<Monkey> Monkeys {get;set;}

    }
}