// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateDCOptions : TLUpdateBase 
	{
		public TLVector<TLDcOption> DCOptions { get; set; }

		public TLUpdateDCOptions() { }
		public TLUpdateDCOptions(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateDCOptions; } }

		public override void Read(TLBinaryReader from)
		{
			DCOptions = TLFactory.Read<TLVector<TLDcOption>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(DCOptions);
		}
	}
}