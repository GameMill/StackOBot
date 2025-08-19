using UnrealSharp.Attributes;
using UnrealSharp.Engine;

namespace ManagedStackOBot.MainMenu
{
    [UClass]
    public class AGM_MainMenu : AGameModeBase
    {
        public AGM_MainMenu()
        {
            HUDClass = typeof(AHUD_MainMenu);
        }
    }
}
