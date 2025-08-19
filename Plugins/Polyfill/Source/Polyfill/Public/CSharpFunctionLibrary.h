// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "Components/Widget.h"
#include "CSharpFunctionLibrary.generated.h"

/**
 * 
 */
UCLASS()
class POLYFILL_API UCSharpFunctionLibrary : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()
	
public:
	/** 
	 * Converts a UE4 FString to a C# string.
	 * @param UE4String The UE4 FString to convert.
	 * @return The converted C# string.
	 */
	UFUNCTION(BlueprintCallable, Category = "CSharp|Conversion")
	static void SetInputMode_GameAndUI(APlayerController* PlayerController, UWidget* InWidgetToFocus, EMouseLockMode InMouseLockMode, bool bHideCursorDuringCapture, const bool bFlushInput /* = false */);
};
