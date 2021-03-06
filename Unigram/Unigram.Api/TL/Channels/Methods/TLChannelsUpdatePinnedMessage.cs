// <auto-generated/>
using System;

namespace Telegram.Api.TL.Channels.Methods
{
	/// <summary>
	/// RCP method channels.updatePinnedMessage.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLChannelsUpdatePinnedMessage : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Silent = (1 << 0),
		}

		public bool IsSilent { get { return Flags.HasFlag(Flag.Silent); } set { Flags = value ? (Flags | Flag.Silent) : (Flags & ~Flag.Silent); } }

		public Flag Flags { get; set; }
		public TLInputChannelBase Channel { get; set; }
		public Int32 Id { get; set; }

		public TLChannelsUpdatePinnedMessage() { }
		public TLChannelsUpdatePinnedMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsUpdatePinnedMessage; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA72DED52);
			to.Write((Int32)Flags);
			to.WriteObject(Channel);
			to.Write(Id);
		}
	}
}