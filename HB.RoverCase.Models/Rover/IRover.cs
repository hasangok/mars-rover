using System.Collections.Generic;

namespace HB.RoverCase.Models
{
    public interface IRover
    {
        void SetCommands(List<ICommand> commands);
        void ExecuteCommands();
        ILocation GetLocation();
        IPlateau GetPlateau();
    }
}
