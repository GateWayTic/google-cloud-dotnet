// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/routing/v2/transit_preferences.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.Routing.V2 {

  /// <summary>Holder for reflection information generated from google/maps/routing/v2/transit_preferences.proto</summary>
  public static partial class TransitPreferencesReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/routing/v2/transit_preferences.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TransitPreferencesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvbWFwcy9yb3V0aW5nL3YyL3RyYW5zaXRfcHJlZmVyZW5jZXMu",
            "cHJvdG8SFmdvb2dsZS5tYXBzLnJvdXRpbmcudjIitAMKElRyYW5zaXRQcmVm",
            "ZXJlbmNlcxJaChRhbGxvd2VkX3RyYXZlbF9tb2RlcxgBIAMoDjI8Lmdvb2ds",
            "ZS5tYXBzLnJvdXRpbmcudjIuVHJhbnNpdFByZWZlcmVuY2VzLlRyYW5zaXRU",
            "cmF2ZWxNb2RlEl8KEnJvdXRpbmdfcHJlZmVyZW5jZRgCIAEoDjJDLmdvb2ds",
            "ZS5tYXBzLnJvdXRpbmcudjIuVHJhbnNpdFByZWZlcmVuY2VzLlRyYW5zaXRS",
            "b3V0aW5nUHJlZmVyZW5jZSJyChFUcmFuc2l0VHJhdmVsTW9kZRIjCh9UUkFO",
            "U0lUX1RSQVZFTF9NT0RFX1VOU1BFQ0lGSUVEEAASBwoDQlVTEAESCgoGU1VC",
            "V0FZEAISCQoFVFJBSU4QAxIOCgpMSUdIVF9SQUlMEAQSCAoEUkFJTBAFIm0K",
            "GFRyYW5zaXRSb3V0aW5nUHJlZmVyZW5jZRIqCiZUUkFOU0lUX1JPVVRJTkdf",
            "UFJFRkVSRU5DRV9VTlNQRUNJRklFRBAAEhAKDExFU1NfV0FMS0lORxABEhMK",
            "D0ZFV0VSX1RSQU5TRkVSUxACQswBChpjb20uZ29vZ2xlLm1hcHMucm91dGlu",
            "Zy52MkIXVHJhbnNpdFByZWZlcmVuY2VzUHJvdG9QAVo6Y2xvdWQuZ29vZ2xl",
            "LmNvbS9nby9tYXBzL3JvdXRpbmcvYXBpdjIvcm91dGluZ3BiO3JvdXRpbmdw",
            "YvgBAaICBUdNUlYyqgIWR29vZ2xlLk1hcHMuUm91dGluZy5WMsoCFkdvb2ds",
            "ZVxNYXBzXFJvdXRpbmdcVjLqAhlHb29nbGU6Ok1hcHM6OlJvdXRpbmc6OlYy",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.Routing.V2.TransitPreferences), global::Google.Maps.Routing.V2.TransitPreferences.Parser, new[]{ "AllowedTravelModes", "RoutingPreference" }, null, new[]{ typeof(global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitTravelMode), typeof(global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitRoutingPreference) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Preferences for `TRANSIT` based routes that influence the route that is
  /// returned.
  /// </summary>
  public sealed partial class TransitPreferences : pb::IMessage<TransitPreferences>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TransitPreferences> _parser = new pb::MessageParser<TransitPreferences>(() => new TransitPreferences());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TransitPreferences> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.Routing.V2.TransitPreferencesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TransitPreferences() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TransitPreferences(TransitPreferences other) : this() {
      allowedTravelModes_ = other.allowedTravelModes_.Clone();
      routingPreference_ = other.routingPreference_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TransitPreferences Clone() {
      return new TransitPreferences(this);
    }

    /// <summary>Field number for the "allowed_travel_modes" field.</summary>
    public const int AllowedTravelModesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitTravelMode> _repeated_allowedTravelModes_codec
        = pb::FieldCodec.ForEnum(10, x => (int) x, x => (global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitTravelMode) x);
    private readonly pbc::RepeatedField<global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitTravelMode> allowedTravelModes_ = new pbc::RepeatedField<global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitTravelMode>();
    /// <summary>
    /// A set of travel modes to use when getting a `TRANSIT` route. Defaults to
    /// all supported modes of travel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitTravelMode> AllowedTravelModes {
      get { return allowedTravelModes_; }
    }

    /// <summary>Field number for the "routing_preference" field.</summary>
    public const int RoutingPreferenceFieldNumber = 2;
    private global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitRoutingPreference routingPreference_ = global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitRoutingPreference.Unspecified;
    /// <summary>
    /// A routing preference that, when specified, influences the `TRANSIT` route
    /// returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitRoutingPreference RoutingPreference {
      get { return routingPreference_; }
      set {
        routingPreference_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TransitPreferences);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TransitPreferences other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!allowedTravelModes_.Equals(other.allowedTravelModes_)) return false;
      if (RoutingPreference != other.RoutingPreference) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= allowedTravelModes_.GetHashCode();
      if (RoutingPreference != global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitRoutingPreference.Unspecified) hash ^= RoutingPreference.GetHashCode();
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
      allowedTravelModes_.WriteTo(output, _repeated_allowedTravelModes_codec);
      if (RoutingPreference != global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitRoutingPreference.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) RoutingPreference);
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
      allowedTravelModes_.WriteTo(ref output, _repeated_allowedTravelModes_codec);
      if (RoutingPreference != global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitRoutingPreference.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) RoutingPreference);
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
      size += allowedTravelModes_.CalculateSize(_repeated_allowedTravelModes_codec);
      if (RoutingPreference != global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitRoutingPreference.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RoutingPreference);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TransitPreferences other) {
      if (other == null) {
        return;
      }
      allowedTravelModes_.Add(other.allowedTravelModes_);
      if (other.RoutingPreference != global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitRoutingPreference.Unspecified) {
        RoutingPreference = other.RoutingPreference;
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
          case 10:
          case 8: {
            allowedTravelModes_.AddEntriesFrom(input, _repeated_allowedTravelModes_codec);
            break;
          }
          case 16: {
            RoutingPreference = (global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitRoutingPreference) input.ReadEnum();
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
          case 10:
          case 8: {
            allowedTravelModes_.AddEntriesFrom(ref input, _repeated_allowedTravelModes_codec);
            break;
          }
          case 16: {
            RoutingPreference = (global::Google.Maps.Routing.V2.TransitPreferences.Types.TransitRoutingPreference) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TransitPreferences message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// A set of values used to specify the mode of transit.
      /// </summary>
      public enum TransitTravelMode {
        /// <summary>
        /// No transit travel mode specified.
        /// </summary>
        [pbr::OriginalName("TRANSIT_TRAVEL_MODE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Travel by bus.
        /// </summary>
        [pbr::OriginalName("BUS")] Bus = 1,
        /// <summary>
        /// Travel by subway.
        /// </summary>
        [pbr::OriginalName("SUBWAY")] Subway = 2,
        /// <summary>
        /// Travel by train.
        /// </summary>
        [pbr::OriginalName("TRAIN")] Train = 3,
        /// <summary>
        /// Travel by light rail or tram.
        /// </summary>
        [pbr::OriginalName("LIGHT_RAIL")] LightRail = 4,
        /// <summary>
        /// Travel by rail. This is equivalent to a combination of `SUBWAY`, `TRAIN`,
        /// and `LIGHT_RAIL`.
        /// </summary>
        [pbr::OriginalName("RAIL")] Rail = 5,
      }

      /// <summary>
      /// Specifies routing preferences for transit routes.
      /// </summary>
      public enum TransitRoutingPreference {
        /// <summary>
        /// No preference specified.
        /// </summary>
        [pbr::OriginalName("TRANSIT_ROUTING_PREFERENCE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Indicates that the calculated route should prefer limited amounts of
        /// walking.
        /// </summary>
        [pbr::OriginalName("LESS_WALKING")] LessWalking = 1,
        /// <summary>
        /// Indicates that the calculated route should prefer a limited number of
        /// transfers.
        /// </summary>
        [pbr::OriginalName("FEWER_TRANSFERS")] FewerTransfers = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
