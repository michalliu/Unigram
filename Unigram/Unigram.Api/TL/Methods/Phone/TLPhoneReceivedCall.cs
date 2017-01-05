// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Phone
{
	/// <summary>
	/// RCP method phone.receivedCall
	/// </summary>
	public partial class TLPhoneReceivedCall : TLObject
	{
		public TLInputPhoneCall Peer { get; set; }

		public TLPhoneReceivedCall() { }
		public TLPhoneReceivedCall(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PhoneReceivedCall; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Peer = TLFactory.Read<TLInputPhoneCall>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x17D54F61);
			to.WriteObject(Peer, cache);
			if (cache) WriteToCache(to);
		}
	}
}