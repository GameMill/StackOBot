using UnrealSharp.Attributes;
using UnrealSharp.Engine;

namespace ManagedStackOBot.MainMenu
{
    [UClass]
    public class ACS_MainMenuPlayer : APawn
    {
        #region Components

        [UProperty(DefaultComponent = true, RootComponent = true)]
        public USceneComponent DefaultSceneRoot { get; set; }

        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(DefaultSceneRoot))]
        public UCameraComponent Camera { get; set; }

        #endregion
    }
}
