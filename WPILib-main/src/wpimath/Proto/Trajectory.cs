// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: trajectory.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WPIMath.Proto {

  /// <summary>Holder for reflection information generated from trajectory.proto</summary>
  public static partial class TrajectoryReflection {

    #region Descriptor
    /// <summary>File descriptor for trajectory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrajectoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChB0cmFqZWN0b3J5LnByb3RvEgl3cGkucHJvdG8aEGdlb21ldHJ5MmQucHJv",
            "dG8iiwEKF1Byb3RvYnVmVHJhamVjdG9yeVN0YXRlEgwKBHRpbWUYASABKAES",
            "EAoIdmVsb2NpdHkYAiABKAESFAoMYWNjZWxlcmF0aW9uGAMgASgBEicKBHBv",
            "c2UYBCABKAsyGS53cGkucHJvdG8uUHJvdG9idWZQb3NlMmQSEQoJY3VydmF0",
            "dXJlGAUgASgBIkgKElByb3RvYnVmVHJhamVjdG9yeRIyCgZzdGF0ZXMYAiAD",
            "KAsyIi53cGkucHJvdG8uUHJvdG9idWZUcmFqZWN0b3J5U3RhdGVCKgoYZWR1",
            "LndwaS5maXJzdC5tYXRoLnByb3RvqgINV1BJTWF0aC5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WPIMath.Proto.Geometry2DReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WPIMath.Proto.ProtobufTrajectoryState), global::WPIMath.Proto.ProtobufTrajectoryState.Parser, new[]{ "Time", "Velocity", "Acceleration", "Pose", "Curvature" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::WPIMath.Proto.ProtobufTrajectory), global::WPIMath.Proto.ProtobufTrajectory.Parser, new[]{ "States" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProtobufTrajectoryState : pb::IMessage<ProtobufTrajectoryState>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProtobufTrajectoryState> _parser = new pb::MessageParser<ProtobufTrajectoryState>(() => new ProtobufTrajectoryState());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProtobufTrajectoryState> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WPIMath.Proto.TrajectoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProtobufTrajectoryState() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProtobufTrajectoryState(ProtobufTrajectoryState other) : this() {
      time_ = other.time_;
      velocity_ = other.velocity_;
      acceleration_ = other.acceleration_;
      pose_ = other.pose_ != null ? other.pose_.Clone() : null;
      curvature_ = other.curvature_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProtobufTrajectoryState Clone() {
      return new ProtobufTrajectoryState(this);
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 1;
    private double time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "velocity" field.</summary>
    public const int VelocityFieldNumber = 2;
    private double velocity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Velocity {
      get { return velocity_; }
      set {
        velocity_ = value;
      }
    }

    /// <summary>Field number for the "acceleration" field.</summary>
    public const int AccelerationFieldNumber = 3;
    private double acceleration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Acceleration {
      get { return acceleration_; }
      set {
        acceleration_ = value;
      }
    }

    /// <summary>Field number for the "pose" field.</summary>
    public const int PoseFieldNumber = 4;
    private global::WPIMath.Proto.ProtobufPose2d pose_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::WPIMath.Proto.ProtobufPose2d Pose {
      get { return pose_; }
      set {
        pose_ = value;
      }
    }

    /// <summary>Field number for the "curvature" field.</summary>
    public const int CurvatureFieldNumber = 5;
    private double curvature_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Curvature {
      get { return curvature_; }
      set {
        curvature_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProtobufTrajectoryState);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProtobufTrajectoryState other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Time, other.Time)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Velocity, other.Velocity)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Acceleration, other.Acceleration)) return false;
      if (!object.Equals(Pose, other.Pose)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Curvature, other.Curvature)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Time != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Time);
      if (Velocity != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Velocity);
      if (Acceleration != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Acceleration);
      if (pose_ != null) hash ^= Pose.GetHashCode();
      if (Curvature != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Curvature);
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
      if (Time != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Time);
      }
      if (Velocity != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Velocity);
      }
      if (Acceleration != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Acceleration);
      }
      if (pose_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Pose);
      }
      if (Curvature != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Curvature);
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
      if (Time != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Time);
      }
      if (Velocity != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Velocity);
      }
      if (Acceleration != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Acceleration);
      }
      if (pose_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Pose);
      }
      if (Curvature != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Curvature);
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
      if (Time != 0D) {
        size += 1 + 8;
      }
      if (Velocity != 0D) {
        size += 1 + 8;
      }
      if (Acceleration != 0D) {
        size += 1 + 8;
      }
      if (pose_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pose);
      }
      if (Curvature != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProtobufTrajectoryState other) {
      if (other == null) {
        return;
      }
      if (other.Time != 0D) {
        Time = other.Time;
      }
      if (other.Velocity != 0D) {
        Velocity = other.Velocity;
      }
      if (other.Acceleration != 0D) {
        Acceleration = other.Acceleration;
      }
      if (other.pose_ != null) {
        if (pose_ == null) {
          Pose = new global::WPIMath.Proto.ProtobufPose2d();
        }
        Pose.MergeFrom(other.Pose);
      }
      if (other.Curvature != 0D) {
        Curvature = other.Curvature;
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
          case 9: {
            Time = input.ReadDouble();
            break;
          }
          case 17: {
            Velocity = input.ReadDouble();
            break;
          }
          case 25: {
            Acceleration = input.ReadDouble();
            break;
          }
          case 34: {
            if (pose_ == null) {
              Pose = new global::WPIMath.Proto.ProtobufPose2d();
            }
            input.ReadMessage(Pose);
            break;
          }
          case 41: {
            Curvature = input.ReadDouble();
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
          case 9: {
            Time = input.ReadDouble();
            break;
          }
          case 17: {
            Velocity = input.ReadDouble();
            break;
          }
          case 25: {
            Acceleration = input.ReadDouble();
            break;
          }
          case 34: {
            if (pose_ == null) {
              Pose = new global::WPIMath.Proto.ProtobufPose2d();
            }
            input.ReadMessage(Pose);
            break;
          }
          case 41: {
            Curvature = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ProtobufTrajectory : pb::IMessage<ProtobufTrajectory>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProtobufTrajectory> _parser = new pb::MessageParser<ProtobufTrajectory>(() => new ProtobufTrajectory());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProtobufTrajectory> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WPIMath.Proto.TrajectoryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProtobufTrajectory() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProtobufTrajectory(ProtobufTrajectory other) : this() {
      states_ = other.states_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProtobufTrajectory Clone() {
      return new ProtobufTrajectory(this);
    }

    /// <summary>Field number for the "states" field.</summary>
    public const int StatesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WPIMath.Proto.ProtobufTrajectoryState> _repeated_states_codec
        = pb::FieldCodec.ForMessage(18, global::WPIMath.Proto.ProtobufTrajectoryState.Parser);
    private readonly pbc::RepeatedField<global::WPIMath.Proto.ProtobufTrajectoryState> states_ = new pbc::RepeatedField<global::WPIMath.Proto.ProtobufTrajectoryState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::WPIMath.Proto.ProtobufTrajectoryState> States {
      get { return states_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProtobufTrajectory);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProtobufTrajectory other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!states_.Equals(other.states_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= states_.GetHashCode();
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
      states_.WriteTo(output, _repeated_states_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      states_.WriteTo(ref output, _repeated_states_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += states_.CalculateSize(_repeated_states_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProtobufTrajectory other) {
      if (other == null) {
        return;
      }
      states_.Add(other.states_);
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
          case 18: {
            states_.AddEntriesFrom(input, _repeated_states_codec);
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
          case 18: {
            states_.AddEntriesFrom(ref input, _repeated_states_codec);
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
