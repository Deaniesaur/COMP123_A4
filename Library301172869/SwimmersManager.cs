using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Library301172869
{
    public class SwimmersManager : ISwimmersRepository
    {
        public IClubsRepository ClubsManager { get; set; }
        public List<Swimmer> Swimmers { get; } = new List<Swimmer>();

        public SwimmersManager(IClubsRepository manager)
        {
            ClubsManager = manager;
        }

        public void AddSwimmer(Swimmer aSwimmer)
        {
            Swimmers.Add(aSwimmer);
            Club swimmerClub = aSwimmer.Club;
            if (swimmerClub != null && ClubsManager.GetClub(swimmerClub.ClubNumber) == null)
            {
                ClubsManager.AddClub(swimmerClub);
            }
        }

        private string formatRecord(Registrant aSwimmer, string delimiter)
        {
            Address address = aSwimmer.Address;
            string dateString = aSwimmer.DateOfBirth.ToString(
                                            "yyyy-MM-dd h:mm:ss tt",
                                            CultureInfo.InvariantCulture);
            string[] swimmerDetails = {
                aSwimmer.Id.ToString(),
                aSwimmer.Name,
                dateString,
                address.Street,
                address.City,
                address.Province,
                address.PostalCode,
                aSwimmer.PhoneNumber.ToString(),
                ""
            };

            Club club = aSwimmer.Club;
            swimmerDetails[8] = (club == null) ? "" : club.ClubNumber.ToString();

            return String.Join(delimiter, swimmerDetails);
        }

        public Swimmer GetSwimmer(uint regNumber)
        {
            foreach(Swimmer swimmer in Swimmers)
            {
                if (swimmer.Id == regNumber)
                    return swimmer;
            }
            return null;
        }

        public void LoadSwimmers(string fileName, string delimiter)
        {
            FileStream swimmersIn = default;
            StreamReader reader = default;
            try
            {
                swimmersIn = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(swimmersIn);
                string record;
                while((record = reader.ReadLine()) != null)
                {
                    try{
                        Swimmer swimmer = processSwimmerRecord(record, delimiter);
                        Swimmers.Add(swimmer);
                    }catch(Exception recordException){
                        Console.WriteLine("Invalid swimmer record. " + 
                            recordException.Message + ":\n\t" + record);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(reader != null) reader.Close();
                if(swimmersIn != null) swimmersIn.Close();
            }
        }

        private Swimmer processSwimmerRecord(string aRecord, string delimiter)
        {
            uint swimmerNumber;
            uint clubNumber;
            ulong phoneNumber;
            DateTime birthDate;

            string[] data = aRecord.Split(new string[] {delimiter}, StringSplitOptions.None);
            
            if(data.Length != 9)
                throw new Exception("Not enough fields");

            try{
                swimmerNumber = Convert.ToUInt32(data[0]);
            }catch(Exception ex){
                throw new Exception("Invalid registration number");
            }

            if(data[1] == null || data[1] == "")
                throw new Exception("Invalid swimmer name");

            try{
                birthDate = DateTime.Parse(data[2]);
            }catch(Exception ex){
                throw new Exception("Birth date is invalid");
            }

            try{
                phoneNumber = Convert.ToUInt64(data[7]);
            }catch(Exception ex){
                throw new Exception("Phone number wrong format");
            }

            if(GetSwimmer(swimmerNumber) != null)
                throw new Exception("Swimmer with the registration number already exists");

            Address address = new Address(data[3], data[4], data[5], data[6]);

            Swimmer swimmer = new Swimmer(
                swimmerNumber,
                data[1],
                DateTime.Parse(data[2]),
                address,
                phoneNumber
            );

            if(data[8] != null && data[8] != ""){
                try{
                    clubNumber = Convert.ToUInt32(data[8]);
                    Club club = ClubsManager.GetClub(clubNumber);
                    if( club == null)
                        throw new Exception("Club affiliation exists but not valid");
                    club.AddSwimmer(swimmer);
                }catch(Exception ex){
                    throw new Exception("Invalid club number");
                }
            }

            return swimmer;
        }

        public void SaveSwimmers(string fileName, string delimiter)
        {
            FileStream file = default;
            StreamWriter writer = default;

            try
            {
                file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(file);

                Swimmers.ForEach((Swimmer swimmer) => {
                    writer.WriteLine(formatRecord(swimmer, delimiter));
                });
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(writer != null) writer.Close();
                if(file != null) file.Close();
            }
        }
    }
}
