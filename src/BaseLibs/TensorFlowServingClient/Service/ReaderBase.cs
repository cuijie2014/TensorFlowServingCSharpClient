// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow/core/framework/reader_base.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/framework/reader_base.proto</summary>
  public static partial class ReaderBaseReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/framework/reader_base.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReaderBaseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cit0ZW5zb3JmbG93L2NvcmUvZnJhbWV3b3JrL3JlYWRlcl9iYXNlLnByb3Rv",
            "Egp0ZW5zb3JmbG93InIKD1JlYWRlckJhc2VTdGF0ZRIUCgx3b3JrX3N0YXJ0",
            "ZWQYASABKAMSFQoNd29ya19maW5pc2hlZBgCIAEoAxIcChRudW1fcmVjb3Jk",
            "c19wcm9kdWNlZBgDIAEoAxIUCgxjdXJyZW50X3dvcmsYBCABKAxCMQoYb3Jn",
            "LnRlbnNvcmZsb3cuZnJhbWV3b3JrQhBSZWFkZXJCYXNlUHJvdG9zUAH4AQFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.ReaderBaseState), global::Tensorflow.ReaderBaseState.Parser, new[]{ "WorkStarted", "WorkFinished", "NumRecordsProduced", "CurrentWork" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// For serializing and restoring the state of ReaderBase, see
  /// reader_base.h for details.
  /// </summary>
  public sealed partial class ReaderBaseState : pb::IMessage<ReaderBaseState> {
    private static readonly pb::MessageParser<ReaderBaseState> _parser = new pb::MessageParser<ReaderBaseState>(() => new ReaderBaseState());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReaderBaseState> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.ReaderBaseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReaderBaseState() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReaderBaseState(ReaderBaseState other) : this() {
      workStarted_ = other.workStarted_;
      workFinished_ = other.workFinished_;
      numRecordsProduced_ = other.numRecordsProduced_;
      currentWork_ = other.currentWork_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReaderBaseState Clone() {
      return new ReaderBaseState(this);
    }

    /// <summary>Field number for the "work_started" field.</summary>
    public const int WorkStartedFieldNumber = 1;
    private long workStarted_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long WorkStarted {
      get { return workStarted_; }
      set {
        workStarted_ = value;
      }
    }

    /// <summary>Field number for the "work_finished" field.</summary>
    public const int WorkFinishedFieldNumber = 2;
    private long workFinished_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long WorkFinished {
      get { return workFinished_; }
      set {
        workFinished_ = value;
      }
    }

    /// <summary>Field number for the "num_records_produced" field.</summary>
    public const int NumRecordsProducedFieldNumber = 3;
    private long numRecordsProduced_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NumRecordsProduced {
      get { return numRecordsProduced_; }
      set {
        numRecordsProduced_ = value;
      }
    }

    /// <summary>Field number for the "current_work" field.</summary>
    public const int CurrentWorkFieldNumber = 4;
    private pb::ByteString currentWork_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString CurrentWork {
      get { return currentWork_; }
      set {
        currentWork_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReaderBaseState);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReaderBaseState other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WorkStarted != other.WorkStarted) return false;
      if (WorkFinished != other.WorkFinished) return false;
      if (NumRecordsProduced != other.NumRecordsProduced) return false;
      if (CurrentWork != other.CurrentWork) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (WorkStarted != 0L) hash ^= WorkStarted.GetHashCode();
      if (WorkFinished != 0L) hash ^= WorkFinished.GetHashCode();
      if (NumRecordsProduced != 0L) hash ^= NumRecordsProduced.GetHashCode();
      if (CurrentWork.Length != 0) hash ^= CurrentWork.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (WorkStarted != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(WorkStarted);
      }
      if (WorkFinished != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(WorkFinished);
      }
      if (NumRecordsProduced != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(NumRecordsProduced);
      }
      if (CurrentWork.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(CurrentWork);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (WorkStarted != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(WorkStarted);
      }
      if (WorkFinished != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(WorkFinished);
      }
      if (NumRecordsProduced != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NumRecordsProduced);
      }
      if (CurrentWork.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(CurrentWork);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReaderBaseState other) {
      if (other == null) {
        return;
      }
      if (other.WorkStarted != 0L) {
        WorkStarted = other.WorkStarted;
      }
      if (other.WorkFinished != 0L) {
        WorkFinished = other.WorkFinished;
      }
      if (other.NumRecordsProduced != 0L) {
        NumRecordsProduced = other.NumRecordsProduced;
      }
      if (other.CurrentWork.Length != 0) {
        CurrentWork = other.CurrentWork;
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
          case 8: {
            WorkStarted = input.ReadInt64();
            break;
          }
          case 16: {
            WorkFinished = input.ReadInt64();
            break;
          }
          case 24: {
            NumRecordsProduced = input.ReadInt64();
            break;
          }
          case 34: {
            CurrentWork = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
