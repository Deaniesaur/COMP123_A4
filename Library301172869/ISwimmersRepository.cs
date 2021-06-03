using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library301172869
{
    public interface ISwimmersRepository
    {
        IClubsRepository ClubsManager { get; set; }
        List<Swimmer> Swimmers { get; }

        void AddSwimmer(Swimmer aSwimmer);
        Swimmer GetSwimmer(uint regNumber);
        void LoadSwimmers(string fileName, string delimiter);
        void SaveSwimmers(string fileName, string delimiter);
    }
}
