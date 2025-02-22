// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/file.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/file.proto</summary>
  public static partial class FileReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/file.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FileReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEvZmlsZS5wcm90bxIe",
            "Z29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYxInMKBEZpbGUSDAoEcGF0",
            "aBgBIAEoCRIMCgRzaXplGAIgASgDEg4KBnNoYTI1NhgDIAEoCRITCgtoYXNo",
            "ZWRfc2l6ZRgEIAEoAxIYChBwYXJ0aWFsbHlfaGFzaGVkGAUgASgIEhAKCGNv",
            "bnRlbnRzGAYgASgJQuMBCiJjb20uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2Vu",
            "dGVyLnYxQglGaWxlUHJvdG9QAVpKY2xvdWQuZ29vZ2xlLmNvbS9nby9zZWN1",
            "cml0eWNlbnRlci9hcGl2MS9zZWN1cml0eWNlbnRlcnBiO3NlY3VyaXR5Y2Vu",
            "dGVycGKqAh5Hb29nbGUuQ2xvdWQuU2VjdXJpdHlDZW50ZXIuVjHKAh5Hb29n",
            "bGVcQ2xvdWRcU2VjdXJpdHlDZW50ZXJcVjHqAiFHb29nbGU6OkNsb3VkOjpT",
            "ZWN1cml0eUNlbnRlcjo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.File), global::Google.Cloud.SecurityCenter.V1.File.Parser, new[]{ "Path", "Size", "Sha256", "HashedSize", "PartiallyHashed", "Contents" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// File information about the related binary/library used by an executable, or
  /// the script used by a script interpreter
  /// </summary>
  public sealed partial class File : pb::IMessage<File>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<File> _parser = new pb::MessageParser<File>(() => new File());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<File> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.FileReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public File() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public File(File other) : this() {
      path_ = other.path_;
      size_ = other.size_;
      sha256_ = other.sha256_;
      hashedSize_ = other.hashedSize_;
      partiallyHashed_ = other.partiallyHashed_;
      contents_ = other.contents_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public File Clone() {
      return new File(this);
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 1;
    private string path_ = "";
    /// <summary>
    /// Absolute path of the file as a JSON encoded string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Path {
      get { return path_; }
      set {
        path_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 2;
    private long size_;
    /// <summary>
    /// Size of the file in bytes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    /// <summary>Field number for the "sha256" field.</summary>
    public const int Sha256FieldNumber = 3;
    private string sha256_ = "";
    /// <summary>
    /// SHA256 hash of the first hashed_size bytes of the file encoded as a
    /// hex string.  If hashed_size == size, sha256 represents the SHA256 hash
    /// of the entire file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Sha256 {
      get { return sha256_; }
      set {
        sha256_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hashed_size" field.</summary>
    public const int HashedSizeFieldNumber = 4;
    private long hashedSize_;
    /// <summary>
    /// The length in bytes of the file prefix that was hashed.  If
    /// hashed_size == size, any hashes reported represent the entire
    /// file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long HashedSize {
      get { return hashedSize_; }
      set {
        hashedSize_ = value;
      }
    }

    /// <summary>Field number for the "partially_hashed" field.</summary>
    public const int PartiallyHashedFieldNumber = 5;
    private bool partiallyHashed_;
    /// <summary>
    /// True when the hash covers only a prefix of the file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PartiallyHashed {
      get { return partiallyHashed_; }
      set {
        partiallyHashed_ = value;
      }
    }

    /// <summary>Field number for the "contents" field.</summary>
    public const int ContentsFieldNumber = 6;
    private string contents_ = "";
    /// <summary>
    /// Prefix of the file contents as a JSON-encoded string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Contents {
      get { return contents_; }
      set {
        contents_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as File);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(File other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Path != other.Path) return false;
      if (Size != other.Size) return false;
      if (Sha256 != other.Sha256) return false;
      if (HashedSize != other.HashedSize) return false;
      if (PartiallyHashed != other.PartiallyHashed) return false;
      if (Contents != other.Contents) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Path.Length != 0) hash ^= Path.GetHashCode();
      if (Size != 0L) hash ^= Size.GetHashCode();
      if (Sha256.Length != 0) hash ^= Sha256.GetHashCode();
      if (HashedSize != 0L) hash ^= HashedSize.GetHashCode();
      if (PartiallyHashed != false) hash ^= PartiallyHashed.GetHashCode();
      if (Contents.Length != 0) hash ^= Contents.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Path.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Path);
      }
      if (Size != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Size);
      }
      if (Sha256.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Sha256);
      }
      if (HashedSize != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(HashedSize);
      }
      if (PartiallyHashed != false) {
        output.WriteRawTag(40);
        output.WriteBool(PartiallyHashed);
      }
      if (Contents.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Contents);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Path.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Path);
      }
      if (Size != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Size);
      }
      if (Sha256.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Sha256);
      }
      if (HashedSize != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(HashedSize);
      }
      if (PartiallyHashed != false) {
        output.WriteRawTag(40);
        output.WriteBool(PartiallyHashed);
      }
      if (Contents.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Contents);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Path.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path);
      }
      if (Size != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Size);
      }
      if (Sha256.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sha256);
      }
      if (HashedSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(HashedSize);
      }
      if (PartiallyHashed != false) {
        size += 1 + 1;
      }
      if (Contents.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Contents);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(File other) {
      if (other == null) {
        return;
      }
      if (other.Path.Length != 0) {
        Path = other.Path;
      }
      if (other.Size != 0L) {
        Size = other.Size;
      }
      if (other.Sha256.Length != 0) {
        Sha256 = other.Sha256;
      }
      if (other.HashedSize != 0L) {
        HashedSize = other.HashedSize;
      }
      if (other.PartiallyHashed != false) {
        PartiallyHashed = other.PartiallyHashed;
      }
      if (other.Contents.Length != 0) {
        Contents = other.Contents;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Path = input.ReadString();
            break;
          }
          case 16: {
            Size = input.ReadInt64();
            break;
          }
          case 26: {
            Sha256 = input.ReadString();
            break;
          }
          case 32: {
            HashedSize = input.ReadInt64();
            break;
          }
          case 40: {
            PartiallyHashed = input.ReadBool();
            break;
          }
          case 50: {
            Contents = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Path = input.ReadString();
            break;
          }
          case 16: {
            Size = input.ReadInt64();
            break;
          }
          case 26: {
            Sha256 = input.ReadString();
            break;
          }
          case 32: {
            HashedSize = input.ReadInt64();
            break;
          }
          case 40: {
            PartiallyHashed = input.ReadBool();
            break;
          }
          case 50: {
            Contents = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
