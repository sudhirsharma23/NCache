//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GetTagResponse.proto
// Note: requires additional types generated from: Commands/Value.proto
// Note: requires additional types generated from: KeyValuePackageResponse.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetTagResponse")]
  public partial class GetTagResponse : global::ProtoBuf.IExtensible
  {
    public GetTagResponse() {}
    

    private Alachisoft.NCache.Common.Protobuf.KeyValuePackageResponse _keyValuePackage = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"keyValuePackage", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.KeyValuePackageResponse keyValuePackage
    {
      get { return _keyValuePackage; }
      set { _keyValuePackage = value; }
    }

    private int _commandID = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"commandID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int commandID
    {
      get { return _commandID; }
      set { _commandID = value; }
    }

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }

    private int _numberOfChuncks = (int)1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"numberOfChuncks", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int numberOfChuncks
    {
      get { return _numberOfChuncks; }
      set { _numberOfChuncks = value; }
    }

    private int _sequenceId = (int)1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"sequenceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int sequenceId
    {
      get { return _sequenceId; }
      set { _sequenceId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}