using ManagedStackOBot.Framework;
using UnrealSharp;
using UnrealSharp.Attributes;
using UnrealSharp.CoreUObject;
using UnrealSharp.Engine;
using UnrealSharp.UMG;

namespace ManagedStackOBot.MainMenu
{
    [UClass]
    public class AHUD_MainMenu : AHUD
    {
        [UProperty]
        public UUI_MainMenu MyMainMenu { get; set; }

        protected override void BeginPlay()
        {
            base.BeginPlay();
            AddMainMenuWidget();
            PlayMusic();
        }

        private void AddMainMenuWidget()
        {

            MyMainMenu = UGameplayStatics.CreateWidget<UUI_MainMenu>(typeof(UUI_MainMenu), PlayerOwner);
            MyMainMenu.AddToViewport();
            MyMainMenu.SetFocus();
            UnrealSharp.Polyfill.UCSharpFunctionLibrary.SetInputMode_GameAndUI(PlayerOwner, MyMainMenu, EMouseLockMode.DoNotLock, false, false);
            PlayerOwner.ShowMouseCursor = true;
            if (PlayerOwner.ControlledPawn && PlayerOwner.ControlledPawn.IsValid)
            {
                PlayerOwner.ControlledPawn.DisableInput(PlayerOwner);
            }
        }

        /// <summary>
        /// Start the music that is handled in the game instance to have a persitent music between level loads.
        /// </summary>
        private void PlayMusic()
        {
            var gameInstance = World.GameInstance.AsInterface<ICSI_GameInstance>();
            if (gameInstance != null)
            {
                gameInstance.PlayMusic();
            }
        }
    
    }
    [UClass]
    public class UUI_MainMenu : UnrealSharp.UMG.UUserWidget
    {
        //[UProperty(DefaultComponent = true, RootComponent = true)]
        //public UOverlay Overlay { get; set; }

    }
}
