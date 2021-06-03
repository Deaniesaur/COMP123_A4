using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//301178024
namespace Library301172869
{
    public class Club
    {
        private Coach coach;
        public Address ClubAddress { get; set; }
        public uint ClubNumber { get; private set; }
        public Coach Coach {
            get
            {
                return coach;
            }
            set
            {
                if (value.Club != null)
                    throw new Exception("Coach is registered with a different club");

                if(coach != null)
                    coach.Club = null;

                value.Club = this;
                coach = value;
            }
        }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }
        public List<Registrant> Swimmers { get; } = new List<Registrant>();

        public Club()
        {
            ClubNumber = RegistrationNumberGenerator.GetNext();
        }

        public Club(string name, Address anAddress, ulong phoneNumber):this()
        {
            Name = name;
            ClubAddress = anAddress;
            PhoneNumber = phoneNumber;
        }

        internal Club(uint regNumber, string name,
            Address anAddress,ulong phoneNumber):this(name, anAddress, phoneNumber)
        {
            ClubNumber = regNumber;
        }

        public void AddSwimmer(Registrant registrant)
        {
            if (registrant.Club == null)
            {
                Swimmers.Add(registrant);
                registrant.Club = this;
            }
            else
            {
                throw new Exception($"Swimmer is already assigned to {registrant.Club.Name}");
            }
            
        }

        public override string ToString()
        {
            string swimmersStr = "Swimmers:";
            Swimmers.ForEach((Registrant swimmer) =>
            {
                swimmersStr += "\n\t" + swimmer.Name;
            });

            string output =
                $"Name: {Name}\n" +
                "Address:\n" +
                $"\t{ClubAddress.Street}\n" +
                $"\t{ClubAddress.City}\n" +
                $"\t{ClubAddress.Province}\n" +
                $"\t{ClubAddress.PostalCode}\n" +
                $"Phone: {PhoneNumber}\n" +
                $"Reg number: {ClubNumber}\n" +
                $"{swimmersStr}\n" +
                "Coach:";

            if (coach == null)
                output += "Not assigned";
            else
                output += coach.Name;
            return output;
        }
    }
}
