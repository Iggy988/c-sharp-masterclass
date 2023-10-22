using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsPlanetStats.UserInteraction;
public interface IPlanetsStatsUserInteractor
{
    void Show(IEnumerable<Planet> planets);
    string? ChooseStaticticsToBeShown(
        IEnumerable<string> propertiesThatCanBeChosen);
    void ShowMessage(string message);
}