using ManagedStackOBot.SaveGame;
using UnrealSharp;
using UnrealSharp.Attributes;
using UnrealSharp.CoreUObject;

namespace ManagedStackOBot.Framework
{
    [UInterface]
    public interface ICSI_GameInstance : IInterface
    {
        [UFunction(FunctionFlags.BlueprintEvent)]
        public void UpdateCoins(int Change);

        [UFunction(FunctionFlags.BlueprintEvent)]
        public int GetCoins();

        [UFunction(FunctionFlags.BlueprintEvent)]
        public void SaveGame();

        [UFunction(FunctionFlags.BlueprintEvent)]
        public void RemoveCollectableFromSaveGame(FCollectableObjectData CollectableData);

        [UFunction(FunctionFlags.BlueprintEvent)]
        public void InitSaveGame();

        [UFunction(FunctionFlags.BlueprintEvent)]
        public void ResetSaveGame();

        [UFunction(FunctionFlags.BlueprintEvent)]
        public void PlayMusic();

        [UFunction(FunctionFlags.BlueprintEvent)]
        public void AsyncSave();

        [UFunction(FunctionFlags.BlueprintEvent)]
        public void ToggleLoadingScreen(bool Enable);

        [UFunction(FunctionFlags.BlueprintEvent)]
        public void OpenLevel(string TargetLevel);

        [UFunction(FunctionFlags.BlueprintEvent)]
        public void Quit();

    }
}