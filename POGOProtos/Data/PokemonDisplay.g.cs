// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/PokemonDisplay.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/PokemonDisplay.proto</summary>
  public static partial class PokemonDisplayReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/PokemonDisplay.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonDisplayReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRQT0dPUHJvdG9zL0RhdGEvUG9rZW1vbkRpc3BsYXkucHJvdG8SD1BPR09Q",
            "cm90b3MuRGF0YRoeUE9HT1Byb3Rvcy9FbnVtcy9Db3N0dW1lLnByb3RvGhtQ",
            "T0dPUHJvdG9zL0VudW1zL0Zvcm0ucHJvdG8aHVBPR09Qcm90b3MvRW51bXMv",
            "R2VuZGVyLnByb3RvIpsBCg5Qb2tlbW9uRGlzcGxheRIqCgdjb3N0dW1lGAEg",
            "ASgOMhkuUE9HT1Byb3Rvcy5FbnVtcy5Db3N0dW1lEigKBmdlbmRlchgCIAEo",
            "DjIYLlBPR09Qcm90b3MuRW51bXMuR2VuZGVyEg0KBXNoaW55GAMgASgIEiQK",
            "BGZvcm0YBCABKA4yFi5QT0dPUHJvdG9zLkVudW1zLkZvcm1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.CostumeReflection.Descriptor, global::POGOProtos.Enums.FormReflection.Descriptor, global::POGOProtos.Enums.GenderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.PokemonDisplay), global::POGOProtos.Data.PokemonDisplay.Parser, new[]{ "Costume", "Gender", "Shiny", "Form" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PokemonDisplay : pb::IMessage<PokemonDisplay> {
    private static readonly pb::MessageParser<PokemonDisplay> _parser = new pb::MessageParser<PokemonDisplay>(() => new PokemonDisplay());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PokemonDisplay> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.PokemonDisplayReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokemonDisplay() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokemonDisplay(PokemonDisplay other) : this() {
      costume_ = other.costume_;
      gender_ = other.gender_;
      shiny_ = other.shiny_;
      form_ = other.form_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokemonDisplay Clone() {
      return new PokemonDisplay(this);
    }

    /// <summary>Field number for the "costume" field.</summary>
    public const int CostumeFieldNumber = 1;
    private global::POGOProtos.Enums.Costume costume_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.Costume Costume {
      get { return costume_; }
      set {
        costume_ = value;
      }
    }

    /// <summary>Field number for the "gender" field.</summary>
    public const int GenderFieldNumber = 2;
    private global::POGOProtos.Enums.Gender gender_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.Gender Gender {
      get { return gender_; }
      set {
        gender_ = value;
      }
    }

    /// <summary>Field number for the "shiny" field.</summary>
    public const int ShinyFieldNumber = 3;
    private bool shiny_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Shiny {
      get { return shiny_; }
      set {
        shiny_ = value;
      }
    }

    /// <summary>Field number for the "form" field.</summary>
    public const int FormFieldNumber = 4;
    private global::POGOProtos.Enums.Form form_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.Form Form {
      get { return form_; }
      set {
        form_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PokemonDisplay);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PokemonDisplay other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Costume != other.Costume) return false;
      if (Gender != other.Gender) return false;
      if (Shiny != other.Shiny) return false;
      if (Form != other.Form) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Costume != 0) hash ^= Costume.GetHashCode();
      if (Gender != 0) hash ^= Gender.GetHashCode();
      if (Shiny != false) hash ^= Shiny.GetHashCode();
      if (Form != 0) hash ^= Form.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Costume != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Costume);
      }
      if (Gender != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Gender);
      }
      if (Shiny != false) {
        output.WriteRawTag(24);
        output.WriteBool(Shiny);
      }
      if (Form != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Form);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Costume != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Costume);
      }
      if (Gender != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Gender);
      }
      if (Shiny != false) {
        size += 1 + 1;
      }
      if (Form != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Form);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PokemonDisplay other) {
      if (other == null) {
        return;
      }
      if (other.Costume != 0) {
        Costume = other.Costume;
      }
      if (other.Gender != 0) {
        Gender = other.Gender;
      }
      if (other.Shiny != false) {
        Shiny = other.Shiny;
      }
      if (other.Form != 0) {
        Form = other.Form;
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
            costume_ = (global::POGOProtos.Enums.Costume) input.ReadEnum();
            break;
          }
          case 16: {
            gender_ = (global::POGOProtos.Enums.Gender) input.ReadEnum();
            break;
          }
          case 24: {
            Shiny = input.ReadBool();
            break;
          }
          case 32: {
            form_ = (global::POGOProtos.Enums.Form) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
