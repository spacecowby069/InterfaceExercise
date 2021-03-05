using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface ICompany : IVehicle
    {
        public string CorpName { get; set; }
        public string Slogan { get; set; }
    }
}
