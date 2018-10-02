// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: U_FileChunk.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Nanomite.MessageBroker {

  /// <summary>Holder for reflection information generated from U_FileChunk.proto</summary>
  public static partial class UFileChunkReflection {

    #region Descriptor
    /// <summary>File descriptor for U_FileChunk.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UFileChunkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFVX0ZpbGVDaHVuay5wcm90bxIWTmFub21pdGUuTWVzc2FnZUJyb2tlciKB",
            "AQoLVV9GaWxlQ2h1bmsSDwoHVmVyc2lvbhgBIAEoCRIKCgJJZBgCIAEoCRIR",
            "CglDcmVhdGVkRFQYAyABKAkSEgoKTW9kaWZpZWREVBgEIAEoCRIOCgZGaWxl",
            "SWQYBSABKAkSDQoFSW5kZXgYBiABKAUSDwoHQ29udGVudBgHIAEoDEIrCg9p",
            "by5ncnBjLm1lc3NhZ2VCEE1lc3NhZ2VEYXRhUHJvdG9QAaICA0hMV2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Nanomite.MessageBroker.U_FileChunk), global::Nanomite.MessageBroker.U_FileChunk.Parser, new[]{ "Version", "Id", "CreatedDT", "ModifiedDT", "FileId", "Index", "Content" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class U_FileChunk : pb::IMessage<U_FileChunk> {
    private static readonly pb::MessageParser<U_FileChunk> _parser = new pb::MessageParser<U_FileChunk>(() => new U_FileChunk());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<U_FileChunk> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Nanomite.MessageBroker.UFileChunkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public U_FileChunk() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public U_FileChunk(U_FileChunk other) : this() {
      version_ = other.version_;
      id_ = other.id_;
      createdDT_ = other.createdDT_;
      modifiedDT_ = other.modifiedDT_;
      fileId_ = other.fileId_;
      index_ = other.index_;
      content_ = other.content_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public U_FileChunk Clone() {
      return new U_FileChunk(this);
    }

    /// <summary>Field number for the "Version" field.</summary>
    public const int VersionFieldNumber = 1;
    private string version_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CreatedDT" field.</summary>
    public const int CreatedDTFieldNumber = 3;
    private string createdDT_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CreatedDT {
      get { return createdDT_; }
      set {
        createdDT_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ModifiedDT" field.</summary>
    public const int ModifiedDTFieldNumber = 4;
    private string modifiedDT_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ModifiedDT {
      get { return modifiedDT_; }
      set {
        modifiedDT_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "FileId" field.</summary>
    public const int FileIdFieldNumber = 5;
    private string fileId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FileId {
      get { return fileId_; }
      set {
        fileId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Index" field.</summary>
    public const int IndexFieldNumber = 6;
    private int index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "Content" field.</summary>
    public const int ContentFieldNumber = 7;
    private pb::ByteString content_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as U_FileChunk);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(U_FileChunk other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (Id != other.Id) return false;
      if (CreatedDT != other.CreatedDT) return false;
      if (ModifiedDT != other.ModifiedDT) return false;
      if (FileId != other.FileId) return false;
      if (Index != other.Index) return false;
      if (Content != other.Content) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (CreatedDT.Length != 0) hash ^= CreatedDT.GetHashCode();
      if (ModifiedDT.Length != 0) hash ^= ModifiedDT.GetHashCode();
      if (FileId.Length != 0) hash ^= FileId.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Version.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Version);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (CreatedDT.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CreatedDT);
      }
      if (ModifiedDT.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ModifiedDT);
      }
      if (FileId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(FileId);
      }
      if (Index != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Index);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(58);
        output.WriteBytes(Content);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (CreatedDT.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CreatedDT);
      }
      if (ModifiedDT.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ModifiedDT);
      }
      if (FileId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FileId);
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Content);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(U_FileChunk other) {
      if (other == null) {
        return;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.CreatedDT.Length != 0) {
        CreatedDT = other.CreatedDT;
      }
      if (other.ModifiedDT.Length != 0) {
        ModifiedDT = other.ModifiedDT;
      }
      if (other.FileId.Length != 0) {
        FileId = other.FileId;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Version = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            CreatedDT = input.ReadString();
            break;
          }
          case 34: {
            ModifiedDT = input.ReadString();
            break;
          }
          case 42: {
            FileId = input.ReadString();
            break;
          }
          case 48: {
            Index = input.ReadInt32();
            break;
          }
          case 58: {
            Content = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
