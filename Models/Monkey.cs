using System;
using System.Collections.Generic;

namespace WebMVC.Models
{
    public class Monkey
    {
        public int MonkeyID {get;set;}
        public int TrainerID {get;set;}
        public string Name {get;set;}
        public string Species {get;set;}
        public int Age {get;set;}

        public virtual Trainer Trainer {get;set;}

    }
}