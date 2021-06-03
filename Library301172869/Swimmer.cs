using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library301172869
{
    public class Swimmer:Registrant
    {
        public override Club Club
        {
            get
            {
                return club;
            }
            set
            {
                if (club != null)
                    throw new Exception("Swimmer is registered with a different club");

                if (!value.Swimmers.Contains(this))
                    value.AddSwimmer(this);
                else
                    club = value;
            }
        }

        public Swimmer() : base()
        {

        }

        public Swimmer(string name, DateTime dateOfBirth, Address anAddress,
            ulong phoneNumber):base(name, dateOfBirth, anAddress, phoneNumber)
        {

        }

        internal Swimmer(uint regNumber, string name, DateTime dateOfBirth, Address anAddress,
            ulong phoneNumber) : base(regNumber, name, dateOfBirth, anAddress, phoneNumber)
        {

        }
    }
}
