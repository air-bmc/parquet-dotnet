/**
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Parquet.Thrift
{

  /// <summary>
  /// Statistics per row group and per page
  /// All fields are optional.
  /// </summary>
  class Statistics : TBase
  {
    private byte[] _max;
    private byte[] _min;
    private long _null_count;
    private long _distinct_count;

    /// <summary>
    /// min and max value of the column, encoded in PLAIN encoding
    /// </summary>
    public byte[] Max
    {
      get
      {
        return _max;
      }
      set
      {
        __isset.max = true;
        this._max = value;
      }
    }

    public byte[] Min
    {
      get
      {
        return _min;
      }
      set
      {
        __isset.min = true;
        this._min = value;
      }
    }

    /// <summary>
    /// count of null value in the column
    /// </summary>
    public long Null_count
    {
      get
      {
        return _null_count;
      }
      set
      {
        __isset.null_count = true;
        this._null_count = value;
      }
    }

    /// <summary>
    /// count of distinct values occurring
    /// </summary>
    public long Distinct_count
    {
      get
      {
        return _distinct_count;
      }
      set
      {
        __isset.distinct_count = true;
        this._distinct_count = value;
      }
    }


    public Isset __isset;
    
    
    
    public struct Isset {
      public bool max;
      public bool min;
      public bool null_count;
      public bool distinct_count;
    }

    public Statistics() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Max = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Min = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I64) {
                Null_count = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I64) {
                Distinct_count = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("Statistics");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Max != null && __isset.max) {
          field.Name = "max";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Max);
          oprot.WriteFieldEnd();
        }
        if (Min != null && __isset.min) {
          field.Name = "min";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Min);
          oprot.WriteFieldEnd();
        }
        if (__isset.null_count) {
          field.Name = "null_count";
          field.Type = TType.I64;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Null_count);
          oprot.WriteFieldEnd();
        }
        if (__isset.distinct_count) {
          field.Name = "distinct_count";
          field.Type = TType.I64;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Distinct_count);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("Statistics(");
      bool __first = true;
      if (Max != null && __isset.max) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Max: ");
        __sb.Append(Max);
      }
      if (Min != null && __isset.min) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Min: ");
        __sb.Append(Min);
      }
      if (__isset.null_count) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Null_count: ");
        __sb.Append(Null_count);
      }
      if (__isset.distinct_count) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Distinct_count: ");
        __sb.Append(Distinct_count);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
