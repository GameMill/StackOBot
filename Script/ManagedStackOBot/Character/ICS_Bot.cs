using UnrealSharp.Attributes;
using UnrealSharp.CoreUObject;

namespace ManagedStackOBot.Character
{
    [UInterface]
    public interface ICS_Bot : IInterface
    {
        [UFunction(FunctionFlags.BlueprintEvent)]
        public bool RecieveDamage(FVector AttactDirection, float KnockbackStrength, float InvFramesTime);

        [UFunction(FunctionFlags.BlueprintEvent)]
        public void ResetJetpack();
    }
}