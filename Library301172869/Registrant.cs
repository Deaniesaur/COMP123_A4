using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Library301172869
{
    public abstract class Registrant
    {
        protected Club club;
        public Address Address { get; set; }
        public virtual Club Club {
            get {
                return club;
            }
            set
            {
                club = value;
            }
        }
        public DateTime DateOfBirth { get; set; }
        public uint Id { get; }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }

        public Registrant()
        {
            Id = RegistrationNumberGenerator.GetNext();
        }

        public Registrant(string name, DateTime dateOfBirth,
            Address anAddress, ulong phoneNumber):this()
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = anAddress;
            PhoneNumber = phoneNumber;
        }

        internal Registrant(uint regNumber, string name, DateTime dateOfBirth,
            Address anAddress, ulong phoneNumber):this(name, dateOfBirth, anAddress, phoneNumber)
        {
            Id = regNumber;
        }

        public override string ToString()
        {
            string dateString = DateOfBirth.ToString(
                                            "yyyy-MM-dd h:mm:ss tt",
                                            CultureInfo.InvariantCulture);
            string output =
                $"Name: {Name}\n" +
                "Address:\n" +
                $"\t{Address.Street}\n" +
                $"\t{Address.City}\n" +
                $"\t{Address.Province}\n" +
                $"\t{Address.PostalCode}\n" +
                $"Phone: {PhoneNumber}\n" +
                $"DOB: {dateString}\n" +
                $"Id: {Id}\n" +
                "Club: ";
            if (club != null)
                output += $"{club.Name}";
            else
                output += "not assigned";
            return output;
        }
    }
}
