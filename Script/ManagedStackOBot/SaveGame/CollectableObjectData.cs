using UnrealSharp;
using UnrealSharp.Attributes;
using UnrealSharp.CoreUObject;
using UnrealSharp.Engine;

namespace ManagedStackOBot.SaveGame
{
    [UStruct]
    public struct FCollectableObjectData
    {
        [UProperty(PropertyFlags.BlueprintReadWrite)]
        public TSoftClassPtr<AActor> ActorClass;

        [UProperty(PropertyFlags.BlueprintReadWrite)]
        public FTransform Transform;
    }
}