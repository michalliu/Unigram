// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Help
{
	/// <summary>
	/// RCP method help.getInviteText.
	/// Returns <see cref="Telegram.Api.TL.TLHelpInviteText"/>
	/// </summary>
	public partial class TLHelpGetInviteText : TLObject
	{
		public TLHelpGetInviteText() { }
		public TLHelpGetInviteText(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.HelpGetInviteText; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0x4D392343);
		}
	}
}