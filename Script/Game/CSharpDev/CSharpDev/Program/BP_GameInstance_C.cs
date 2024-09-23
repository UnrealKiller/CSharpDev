using Script.CoreUObject;
using Script.Engine;
using Script.GameBasic;
using System;

namespace Script.Game.CSharpDev.Program
{
	[Override]
	public partial class BP_GameInstance_C
	{

		private BP_GameInstance_C()
		{
			CSharpMain.Main();
		}

		[Override]
		public override void ReceiveInit()
		{
			base.ReceiveInit();
			EventManager.Get().Dispatch("InitByGameInstance", this);
        }

		[Override]
		public override void ReceiveShutdown()
		{
			base.ReceiveShutdown();
		}
	}
}