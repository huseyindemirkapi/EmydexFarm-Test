using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    public abstract class Animal : IAnimal
    {

        public string Sound { get; set; }
        public string Escape { get; set; }
        public string Name { get; set; }

        private string _id;
        private int _noOfLegs;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }


        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = value;
            }
        }
        public void Talk()
        {
            Console.WriteLine(Sound);
        }

        public void Run()
        {
            Console.WriteLine(Escape);
        }

    }
}
