// Fill out your copyright notice in the Description page of Project Settings.


#include "Blueprint/WidgetBlueprintLibrary.h"
#include "CSharpFunctionLibrary.h"

void UCSharpFunctionLibrary::SetInputMode_GameAndUI(APlayerController* PlayerController, UWidget* InWidgetToFocus, EMouseLockMode InMouseLockMode, bool bHideCursorDuringCapture, const bool bFlushInput /* = false */)
{
	UWidgetBlueprintLibrary::SetInputMode_GameAndUIEx(PlayerController, InWidgetToFocus, InMouseLockMode, bHideCursorDuringCapture, bFlushInput);
}
