using UnrealSharp.Attributes;
using UnrealSharp.Engine;

namespace ManagedStackOBot.PCG
{
    [UClass]
    public class APCG_CS_FenceSpline : AActor
    {
        #region Components
        [UProperty(DefaultComponent = true)]
        public USplineComponent FenceSpline { get; set; }

        // TODO: Add PCG components here when it available in UnrealSharp
        #endregion
    }
}
