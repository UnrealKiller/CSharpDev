using Script.CoreUObject;
using Script.Engine;
using Script.GameBasic;

namespace Script.Game
{
    class CSharpMain
    {
        public static void Main()
        {
            EventManager.Get().AddListener("InitByGameInstance", (UGameInstance Instance) =>
            {
                TimerManager.Get().Initialize(Instance);
            });

            EventManager.Get().AddListener("InitByMainLevel", (UWorld World) =>
            {
                UIManager.Get().Initialize(World);
                InputManager.Get().Initialize(UGameplayStatics.GetPlayerController(World, 0));
                GMManager.Get().Show();
            });

        }
    }

}