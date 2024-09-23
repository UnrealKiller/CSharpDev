using Script.CoreUObject;
using Script.Engine;
using Script.GameBasic;

namespace Script.Game.ThirdPerson.Maps
{
	[Override]
	public partial class ThirdPersonMap_C
	{
		private ThirdPersonMap_C()
		{
		}

		[Override]
		public override void ReceiveBeginPlay()
		{
			base.ReceiveBeginPlay();
            EventManager.Get().Dispatch("InitByMainLevel", this);
		}

		[Override]
		public override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			base.ReceiveEndPlay(EndPlayReason);
		}
	}
}