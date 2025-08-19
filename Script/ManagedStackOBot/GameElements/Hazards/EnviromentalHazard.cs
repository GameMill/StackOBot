using ManagedStackOBot.Character;
using UnrealSharp.Attributes;
using UnrealSharp.CoreUObject;
using UnrealSharp.Engine;
using UnrealSharp.Niagara;

namespace ManagedStackOBot.GameElements.Hazards
{
    /** 
     * <summary>
     * This is a Parent Class - All children wil share the code below. Ideal for updating maion logic such as which tags. Some paramaters are exposed so each child can have seperate control.
     * </summary>
     */
    [UClass]
    public class ACS_EnviromentalHazard : AActor
    {
        #region Components
        [UProperty(DefaultComponent = true, RootComponent = true)]
        public USceneComponent DefaultSceneRoot { get; set; }

        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(DefaultSceneRoot))]
        public UNiagaraComponent Niagara { get; set; }

        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(Niagara))]
        public USphereComponent Sphere { get; set; }

        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(DefaultSceneRoot))]
        public UStaticMeshComponent StaticMesh { get; set; }
        #endregion

        #region Properties
        [UProperty(PropertyFlags.BlueprintReadWrite)]
        public float KnockbackStrength { get; set; }

        [UProperty(PropertyFlags.BlueprintReadWrite)]
        public float InvFramesTime { get; set; }
        #endregion

        public ACS_EnviromentalHazard()
        {
            KnockbackStrength = 2000f;
            InvFramesTime = 1f;
            StaticMesh!.OnComponentBeginOverlap += OnComponentBeginOverlap_Sphere;
        }

        [UFunction]
        private void OnComponentBeginOverlap_Sphere(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex, bool fromSweep, FHitResult sweepResult)
        {
            ICS_Bot? Bot = otherActor.AsInterface<ICS_Bot>();
            if(Bot != null)
            {
                Bot.RecieveDamage(Sphere.WorldLocation, KnockbackStrength, InvFramesTime);
            }
        }

    }
}
