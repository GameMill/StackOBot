using UnrealSharp.Attributes;
using UnrealSharp.Engine;
using UnrealSharp.Niagara;

namespace ManagedStackOBot.Props
{
    [UClass]
    public class ACS_LampostPlatform : AActor
    {
        #region Components

        [UProperty(DefaultComponent = true, RootComponent = true)]
        public UStaticMeshComponent LampostBase { get; set; }

        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(LampostBase))]
        public UStaticMeshComponent LampostPlatform { get; set; }

        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(LampostPlatform))]
        public USpotLightComponent SpotLight { get; set; }

        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(LampostPlatform))]
        public UNiagaraComponent Niagara { get; set; }

        [UProperty(DefaultComponent = true, AttachmentComponent = nameof(LampostBase))]
        public UPhysicsConstraintComponent PhysicsConstraint { get; set; }

        #endregion

        public override void ConstructionScript()
        {
            base.ConstructionScript();
            PhysicsConstraint.SetConstrainedComponents(LampostBase, "", LampostPlatform, "");
        }
    }
}
