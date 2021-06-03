using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library301172869
{
    public class ClubsManager : IClubsRepository
    {
        public List<Club> Clubs { get; } = new List<Club>();

        public void AddClub(Club aClub)
        {
            Clubs.Add(aClub);
        }

        private string formatRecord(Club aClub, string delimiter)
        {
            Address address = aClub.ClubAddress;
            string[] clubDetails = {
                aClub.ClubNumber.ToString(),
                aClub.Name,
                address.Street,
                address.City,
                address.Province,
                address.PostalCode,
                aClub.PhoneNumber.ToString()
            };

            return String.Join(delimiter, clubDetails);
        }

        public Club GetClub(uint regNumber)
        {
            Club club = null;
            foreach(Club c in Clubs){
                if(c.ClubNumber == regNumber){
                    club = c;
                    break;
                }
            }

            return club;
        }

        public void LoadClubs(string fileName, string delimiter)
        {
            FileStream file = default;
            StreamReader reader = default;
            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(file);
                string record;

                while ((record = reader.ReadLine()) != null)
                {
                    try{
                        Club club = processClubRecord(record, delimiter);
                        Clubs.Add(club);
                    }catch(Exception recordEx){
                        Console.WriteLine("Invalid club record. " 
                            + recordEx.Message + ":\n\t" + record);
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
                if(file != null) file.Close();
            }
        }

        private Club processClubRecord(string aRecord, string delimiter)
        {
            uint clubNumber;
            ulong phoneNumber;

            string[] fields = aRecord.Split(new string[] {delimiter}, StringSplitOptions.None);

            if(fields.Length != 7)
                throw new Exception("Not enough fields");

            try{
                clubNumber = Convert.ToUInt32(fields[0]);
            }catch(Exception ex){
                throw new Exception("Club number is not valid");
            }
            
            if(fields[1] == null || fields[1]  == "")
                throw new Exception("Invalid club name");

            try{
                phoneNumber = Convert.ToUInt32(fields[6]);
            }catch(Exception ex){
                throw new Exception("Phone number wrong format");
            }
            
            Club club = GetClub(clubNumber);

            if(club != null)
                throw new Exception("Club with the registration number already exists");
            
            Address address = new Address {
                Street = fields[2],
                City = fields[3],
                Province = fields[4],
                PostalCode = fields[5]
            };

            club = new Club(clubNumber, fields[1],
                address, Convert.ToUInt32(fields[6]));

            return club;
        }

        public void SaveClubs(string fileName, string delimiter)
        {
            FileStream file = default;
            StreamWriter writer = default;

            try
            {
                file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(file);

                Clubs.ForEach((Club club) => {
                    writer.WriteLine(formatRecord(club, delimiter));
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
