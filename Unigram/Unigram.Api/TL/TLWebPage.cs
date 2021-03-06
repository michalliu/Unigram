// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLWebPage : TLWebPageBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Type = (1 << 0),
			SiteName = (1 << 1),
			Title = (1 << 2),
			Description = (1 << 3),
			Photo = (1 << 4),
			EmbedUrl = (1 << 5),
			EmbedType = (1 << 5),
			EmbedWidth = (1 << 6),
			EmbedHeight = (1 << 6),
			Duration = (1 << 7),
			Author = (1 << 8),
			Document = (1 << 9),
			CachedPage = (1 << 10),
		}

		public bool HasType { get { return Flags.HasFlag(Flag.Type); } set { Flags = value ? (Flags | Flag.Type) : (Flags & ~Flag.Type); } }
		public bool HasSiteName { get { return Flags.HasFlag(Flag.SiteName); } set { Flags = value ? (Flags | Flag.SiteName) : (Flags & ~Flag.SiteName); } }
		public bool HasTitle { get { return Flags.HasFlag(Flag.Title); } set { Flags = value ? (Flags | Flag.Title) : (Flags & ~Flag.Title); } }
		public bool HasDescription { get { return Flags.HasFlag(Flag.Description); } set { Flags = value ? (Flags | Flag.Description) : (Flags & ~Flag.Description); } }
		public bool HasPhoto { get { return Flags.HasFlag(Flag.Photo); } set { Flags = value ? (Flags | Flag.Photo) : (Flags & ~Flag.Photo); } }
		public bool HasEmbedUrl { get { return Flags.HasFlag(Flag.EmbedUrl); } set { Flags = value ? (Flags | Flag.EmbedUrl) : (Flags & ~Flag.EmbedUrl); } }
		public bool HasEmbedType { get { return Flags.HasFlag(Flag.EmbedType); } set { Flags = value ? (Flags | Flag.EmbedType) : (Flags & ~Flag.EmbedType); } }
		public bool HasEmbedWidth { get { return Flags.HasFlag(Flag.EmbedWidth); } set { Flags = value ? (Flags | Flag.EmbedWidth) : (Flags & ~Flag.EmbedWidth); } }
		public bool HasEmbedHeight { get { return Flags.HasFlag(Flag.EmbedHeight); } set { Flags = value ? (Flags | Flag.EmbedHeight) : (Flags & ~Flag.EmbedHeight); } }
		public bool HasDuration { get { return Flags.HasFlag(Flag.Duration); } set { Flags = value ? (Flags | Flag.Duration) : (Flags & ~Flag.Duration); } }
		public bool HasAuthor { get { return Flags.HasFlag(Flag.Author); } set { Flags = value ? (Flags | Flag.Author) : (Flags & ~Flag.Author); } }
		public bool HasDocument { get { return Flags.HasFlag(Flag.Document); } set { Flags = value ? (Flags | Flag.Document) : (Flags & ~Flag.Document); } }
		public bool HasCachedPage { get { return Flags.HasFlag(Flag.CachedPage); } set { Flags = value ? (Flags | Flag.CachedPage) : (Flags & ~Flag.CachedPage); } }

		public Flag Flags { get; set; }
		public String Url { get; set; }
		public String DisplayUrl { get; set; }
		public Int32 Hash { get; set; }
		public String Type { get; set; }
		public String SiteName { get; set; }
		public String Title { get; set; }
		public String Description { get; set; }
		public TLPhotoBase Photo { get; set; }
		public String EmbedUrl { get; set; }
		public String EmbedType { get; set; }
		public Int32? EmbedWidth { get; set; }
		public Int32? EmbedHeight { get; set; }
		public Int32? Duration { get; set; }
		public String Author { get; set; }
		public TLDocumentBase Document { get; set; }
		public TLPageBase CachedPage { get; set; }

		public TLWebPage() { }
		public TLWebPage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.WebPage; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Id = from.ReadInt64();
			Url = from.ReadString();
			DisplayUrl = from.ReadString();
			Hash = from.ReadInt32();
			if (HasType) Type = from.ReadString();
			if (HasSiteName) SiteName = from.ReadString();
			if (HasTitle) Title = from.ReadString();
			if (HasDescription) Description = from.ReadString();
			if (HasPhoto) Photo = TLFactory.Read<TLPhotoBase>(from);
			if (HasEmbedUrl) EmbedUrl = from.ReadString();
			if (HasEmbedType) EmbedType = from.ReadString();
			if (HasEmbedWidth) EmbedWidth = from.ReadInt32();
			if (HasEmbedHeight) EmbedHeight = from.ReadInt32();
			if (HasDuration) Duration = from.ReadInt32();
			if (HasAuthor) Author = from.ReadString();
			if (HasDocument) Document = TLFactory.Read<TLDocumentBase>(from);
			if (HasCachedPage) CachedPage = TLFactory.Read<TLPageBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x5F07B4BC);
			to.Write((Int32)Flags);
			to.Write(Id);
			to.Write(Url);
			to.Write(DisplayUrl);
			to.Write(Hash);
			if (HasType) to.Write(Type);
			if (HasSiteName) to.Write(SiteName);
			if (HasTitle) to.Write(Title);
			if (HasDescription) to.Write(Description);
			if (HasPhoto) to.WriteObject(Photo);
			if (HasEmbedUrl) to.Write(EmbedUrl);
			if (HasEmbedType) to.Write(EmbedType);
			if (HasEmbedWidth) to.Write(EmbedWidth.Value);
			if (HasEmbedHeight) to.Write(EmbedHeight.Value);
			if (HasDuration) to.Write(Duration.Value);
			if (HasAuthor) to.Write(Author);
			if (HasDocument) to.WriteObject(Document);
			if (HasCachedPage) to.WriteObject(CachedPage);
		}

		private void UpdateFlags()
		{
			HasType = Type != null;
			HasSiteName = SiteName != null;
			HasTitle = Title != null;
			HasDescription = Description != null;
			HasPhoto = Photo != null;
			HasEmbedUrl = EmbedUrl != null;
			HasEmbedType = EmbedType != null;
			HasEmbedWidth = EmbedWidth != null;
			HasEmbedHeight = EmbedHeight != null;
			HasDuration = Duration != null;
			HasAuthor = Author != null;
			HasDocument = Document != null;
			HasCachedPage = CachedPage != null;
		}
	}
}