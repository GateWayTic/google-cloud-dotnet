// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/unmanaged_container_model.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/unmanaged_container_model.proto</summary>
  public static partial class UnmanagedContainerModelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/unmanaged_container_model.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnmanagedContainerModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS91bm1hbmFnZWRfY29udGFp",
            "bmVyX21vZGVsLnByb3RvEhpnb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MRof",
            "Z29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxomZ29vZ2xlL2Nsb3Vk",
            "L2FpcGxhdGZvcm0vdjEvbW9kZWwucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8iwwEKF1VubWFuYWdlZENvbnRhaW5lck1vZGVsEhQKDGFy",
            "dGlmYWN0X3VyaRgBIAEoCRJFChBwcmVkaWN0X3NjaGVtYXRhGAIgASgLMisu",
            "Z29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuUHJlZGljdFNjaGVtYXRhEksK",
            "DmNvbnRhaW5lcl9zcGVjGAMgASgLMi4uZ29vZ2xlLmNsb3VkLmFpcGxhdGZv",
            "cm0udjEuTW9kZWxDb250YWluZXJTcGVjQgPgQQRC4AEKHmNvbS5nb29nbGUu",
            "Y2xvdWQuYWlwbGF0Zm9ybS52MUIcVW5tYW5hZ2VkQ29udGFpbmVyTW9kZWxQ",
            "cm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Nsb3VkL2FpcGxhdGZvcm0vdjE7YWlwbGF0Zm9ybaoCGkdvb2dsZS5DbG91",
            "ZC5BSVBsYXRmb3JtLlYxygIaR29vZ2xlXENsb3VkXEFJUGxhdGZvcm1cVjHq",
            "Ah1Hb29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.ModelReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.UnmanagedContainerModel), global::Google.Cloud.AIPlatform.V1.UnmanagedContainerModel.Parser, new[]{ "ArtifactUri", "PredictSchemata", "ContainerSpec" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Contains model information necessary to perform batch prediction without
  /// requiring a full model import.
  /// </summary>
  public sealed partial class UnmanagedContainerModel : pb::IMessage<UnmanagedContainerModel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UnmanagedContainerModel> _parser = new pb::MessageParser<UnmanagedContainerModel>(() => new UnmanagedContainerModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UnmanagedContainerModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.UnmanagedContainerModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnmanagedContainerModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnmanagedContainerModel(UnmanagedContainerModel other) : this() {
      artifactUri_ = other.artifactUri_;
      predictSchemata_ = other.predictSchemata_ != null ? other.predictSchemata_.Clone() : null;
      containerSpec_ = other.containerSpec_ != null ? other.containerSpec_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnmanagedContainerModel Clone() {
      return new UnmanagedContainerModel(this);
    }

    /// <summary>Field number for the "artifact_uri" field.</summary>
    public const int ArtifactUriFieldNumber = 1;
    private string artifactUri_ = "";
    /// <summary>
    /// The path to the directory containing the Model artifact and any of its
    /// supporting files.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ArtifactUri {
      get { return artifactUri_; }
      set {
        artifactUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "predict_schemata" field.</summary>
    public const int PredictSchemataFieldNumber = 2;
    private global::Google.Cloud.AIPlatform.V1.PredictSchemata predictSchemata_;
    /// <summary>
    /// Contains the schemata used in Model's predictions and explanations
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.PredictSchemata PredictSchemata {
      get { return predictSchemata_; }
      set {
        predictSchemata_ = value;
      }
    }

    /// <summary>Field number for the "container_spec" field.</summary>
    public const int ContainerSpecFieldNumber = 3;
    private global::Google.Cloud.AIPlatform.V1.ModelContainerSpec containerSpec_;
    /// <summary>
    /// Input only. The specification of the container that is to be used when deploying
    /// this Model.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.ModelContainerSpec ContainerSpec {
      get { return containerSpec_; }
      set {
        containerSpec_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UnmanagedContainerModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UnmanagedContainerModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ArtifactUri != other.ArtifactUri) return false;
      if (!object.Equals(PredictSchemata, other.PredictSchemata)) return false;
      if (!object.Equals(ContainerSpec, other.ContainerSpec)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ArtifactUri.Length != 0) hash ^= ArtifactUri.GetHashCode();
      if (predictSchemata_ != null) hash ^= PredictSchemata.GetHashCode();
      if (containerSpec_ != null) hash ^= ContainerSpec.GetHashCode();
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
      if (ArtifactUri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ArtifactUri);
      }
      if (predictSchemata_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PredictSchemata);
      }
      if (containerSpec_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ContainerSpec);
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
      if (ArtifactUri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ArtifactUri);
      }
      if (predictSchemata_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PredictSchemata);
      }
      if (containerSpec_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ContainerSpec);
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
      if (ArtifactUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ArtifactUri);
      }
      if (predictSchemata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PredictSchemata);
      }
      if (containerSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContainerSpec);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UnmanagedContainerModel other) {
      if (other == null) {
        return;
      }
      if (other.ArtifactUri.Length != 0) {
        ArtifactUri = other.ArtifactUri;
      }
      if (other.predictSchemata_ != null) {
        if (predictSchemata_ == null) {
          PredictSchemata = new global::Google.Cloud.AIPlatform.V1.PredictSchemata();
        }
        PredictSchemata.MergeFrom(other.PredictSchemata);
      }
      if (other.containerSpec_ != null) {
        if (containerSpec_ == null) {
          ContainerSpec = new global::Google.Cloud.AIPlatform.V1.ModelContainerSpec();
        }
        ContainerSpec.MergeFrom(other.ContainerSpec);
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
            ArtifactUri = input.ReadString();
            break;
          }
          case 18: {
            if (predictSchemata_ == null) {
              PredictSchemata = new global::Google.Cloud.AIPlatform.V1.PredictSchemata();
            }
            input.ReadMessage(PredictSchemata);
            break;
          }
          case 26: {
            if (containerSpec_ == null) {
              ContainerSpec = new global::Google.Cloud.AIPlatform.V1.ModelContainerSpec();
            }
            input.ReadMessage(ContainerSpec);
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
            ArtifactUri = input.ReadString();
            break;
          }
          case 18: {
            if (predictSchemata_ == null) {
              PredictSchemata = new global::Google.Cloud.AIPlatform.V1.PredictSchemata();
            }
            input.ReadMessage(PredictSchemata);
            break;
          }
          case 26: {
            if (containerSpec_ == null) {
              ContainerSpec = new global::Google.Cloud.AIPlatform.V1.ModelContainerSpec();
            }
            input.ReadMessage(ContainerSpec);
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