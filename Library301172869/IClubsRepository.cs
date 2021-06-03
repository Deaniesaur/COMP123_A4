using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library301172869
{
    public interface IClubsRepository
    {
        List<Club> Clubs { get; }

        void AddClub(Club aClub);
        Club GetClub(uint regNumber);
        void LoadClubs(string fileName, string delimiter);
        void SaveClubs(string fileName, string delimiter);
    }
}
