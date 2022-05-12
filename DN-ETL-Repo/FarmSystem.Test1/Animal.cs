using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    public class Animal
    {
        //Newly created base class to be inherited from other animals

        private string _id;
        private int _noOfLegs;

        public Animal(int numberOfLegs)
        {
            //I create a new GUID every time the constructor is called, automating that process and removing the need for a user to do it manually elsewhere
            this._id = Guid.NewGuid().ToString();
            this._noOfLegs = numberOfLegs;
        }

        public string Id
        {
            get { return _id; }
           //No need to set Id for animal
        }

        public virtual int NoOfLegs
        {
            get { return _noOfLegs; }
        }

        public virtual void Talk()
        {
            //Leaving a base method in case further testing was needed
            Console.WriteLine("This animal can't talk");
        }

        public virtual void Run()
        {
            //Leaving a base method in case further testing was needed
            Console.WriteLine("This animal can't run");
        }
    }
}
