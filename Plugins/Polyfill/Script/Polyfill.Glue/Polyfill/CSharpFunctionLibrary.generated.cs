using UnrealSharp.Attributes;
using UnrealSharp.Core.Attributes;
using UnrealSharp.Interop;
using UnrealSharp.Core.Marshallers;

namespace UnrealSharp.Polyfill;

[UClass, GeneratedType("CSharpFunctionLibrary", "UnrealSharp.Polyfill.CSharpFunctionLibrary")]
public partial class UCSharpFunctionLibrary : UnrealSharp.Engine.UBlueprintFunctionLibrary
{
    static readonly IntPtr NativeClassPtr;
    static UCSharpFunctionLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName(typeof(UCSharpFunctionLibrary).GetAssemblyName(), "UnrealSharp.Polyfill", "CSharpFunctionLibrary");
        SetInputMode_GameAndUI_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetInputMode_GameAndUI");
        SetInputMode_GameAndUI_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetInputMode_GameAndUI_NativeFunction);
        SetInputMode_GameAndUI_PlayerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetInputMode_GameAndUI_NativeFunction, "PlayerController");
        SetInputMode_GameAndUI_InWidgetToFocus_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetInputMode_GameAndUI_NativeFunction, "InWidgetToFocus");
        SetInputMode_GameAndUI_InMouseLockMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetInputMode_GameAndUI_NativeFunction, "InMouseLockMode");
        SetInputMode_GameAndUI_bHideCursorDuringCapture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetInputMode_GameAndUI_NativeFunction, "bHideCursorDuringCapture");
        SetInputMode_GameAndUI_bFlushInput_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetInputMode_GameAndUI_NativeFunction, "bFlushInput");
    }
    // SetInputMode_GameAndUI
    static IntPtr SetInputMode_GameAndUI_NativeFunction;
    static int SetInputMode_GameAndUI_ParamsSize;
    static int SetInputMode_GameAndUI_PlayerController_Offset;
    static int SetInputMode_GameAndUI_InWidgetToFocus_Offset;
    static int SetInputMode_GameAndUI_InMouseLockMode_Offset;
    static int SetInputMode_GameAndUI_bHideCursorDuringCapture_Offset;
    static int SetInputMode_GameAndUI_bFlushInput_Offset;
    
    /// <summary>
    /// = false
    /// </summary>
    [UFunction, GeneratedType("SetInputMode_GameAndUI", "UnrealSharp.Polyfill.SetInputMode_GameAndUI")]
    public static void SetInputMode_GameAndUI(UnrealSharp.Engine.APlayerController playerController, UnrealSharp.UMG.UWidget widgetToFocus, UnrealSharp.Engine.EMouseLockMode mouseLockMode, bool hideCursorDuringCapture, bool flushInput)
    {
        unsafe
        {
            byte* paramsBufferAllocation = stackalloc byte[SetInputMode_GameAndUI_ParamsSize];
            nint paramsBuffer = (nint) paramsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.APlayerController>.ToNative(IntPtr.Add(paramsBuffer, SetInputMode_GameAndUI_PlayerController_Offset), 0, playerController);
            ObjectMarshaller<UnrealSharp.UMG.UWidget>.ToNative(IntPtr.Add(paramsBuffer, SetInputMode_GameAndUI_InWidgetToFocus_Offset), 0, widgetToFocus);
            EnumMarshaller<UnrealSharp.Engine.EMouseLockMode>.ToNative(IntPtr.Add(paramsBuffer, SetInputMode_GameAndUI_InMouseLockMode_Offset), 0, mouseLockMode);
            BoolMarshaller.ToNative(IntPtr.Add(paramsBuffer, SetInputMode_GameAndUI_bHideCursorDuringCapture_Offset), 0, hideCursorDuringCapture);
            BoolMarshaller.ToNative(IntPtr.Add(paramsBuffer, SetInputMode_GameAndUI_bFlushInput_Offset), 0, flushInput);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetInputMode_GameAndUI_NativeFunction, paramsBuffer, IntPtr.Zero);
            
        }
    }
    
    
}