// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/deploy/v1/log_enums.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Deploy.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/deploy/v1/log_enums.proto</summary>
  public static partial class LogEnumsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/deploy/v1/log_enums.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogEnumsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvY2xvdWQvZGVwbG95L3YxL2xvZ19lbnVtcy5wcm90bxIWZ29v",
            "Z2xlLmNsb3VkLmRlcGxveS52MSpiCgRUeXBlEhQKEFRZUEVfVU5TUEVDSUZJ",
            "RUQQABIkCiBUWVBFX1BVQlNVQl9OT1RJRklDQVRJT05fRkFJTFVSRRABEh4K",
            "GlRZUEVfUkVOREVSX1NUQVRVRVNfQ0hBTkdFEAJCawoaY29tLmdvb2dsZS5j",
            "bG91ZC5kZXBsb3kudjFCDUxvZ0VudW1zUHJvdG9QAVo8Z29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9kZXBsb3kvdjE7ZGVw",
            "bG95YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.Deploy.V1.Type), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Type indicates the type of the log entry and can be used as a filter.
  /// </summary>
  public enum Type {
    /// <summary>
    /// Type is unspecified.
    /// </summary>
    [pbr::OriginalName("TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// A Pub/Sub notification failed to be sent.
    /// </summary>
    [pbr::OriginalName("TYPE_PUBSUB_NOTIFICATION_FAILURE")] PubsubNotificationFailure = 1,
    /// <summary>
    /// Release render status changed notification.
    /// </summary>
    [pbr::OriginalName("TYPE_RENDER_STATUES_CHANGE")] RenderStatuesChange = 2,
  }

  #endregion

}

#endregion Designer generated code