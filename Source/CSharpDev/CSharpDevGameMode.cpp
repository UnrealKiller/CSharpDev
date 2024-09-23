// Copyright Epic Games, Inc. All Rights Reserved.

#include "CSharpDevGameMode.h"
#include "CSharpDevCharacter.h"
#include "UObject/ConstructorHelpers.h"

ACSharpDevGameMode::ACSharpDevGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
