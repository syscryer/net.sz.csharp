
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

      // Option: observable (OnPropertyChanged) enabled
    
    // Generated from: protogentemp.proto
      namespace Net.Sz.Game.MMOGame.GameMessages.Login
      {
    
    
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ProtoGLSMessage")]
    
    public class ProtoGLSMessage : global::ProtoBuf.IExtensible
    , global::System.ComponentModel.INotifyPropertyChanged
    {
    public ProtoGLSMessage() {}
    
    
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqUpdateServerInfoMessage")]
    
    public class ReqUpdateServerInfoMessage : global::ProtoBuf.IExtensible
    , global::System.ComponentModel.INotifyPropertyChanged
    {
    public ReqUpdateServerInfoMessage() {}
    
    private Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls _msgID
      = Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls.ReqUpdateServerInfo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msgID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
      [global::System.ComponentModel.DefaultValue(Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls.ReqUpdateServerInfo)]
    
    public Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls msgID
    {
    get { return _msgID; }
    set { _msgID = value; 
      OnPropertyChanged(@"msgID");
    }
    }
    private int _ZoneID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ZoneID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ZoneID
    {
    get { return _ZoneID; }
    set { _ZoneID = value; 
      OnPropertyChanged(@"ZoneID");
    }
    }
    private int _ServerID;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ServerID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ServerID
    {
    get { return _ServerID; }
    set { _ServerID = value; 
      OnPropertyChanged(@"ServerID");
    }
    }
    private int _Connects;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Connects", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Connects
    {
    get { return _Connects; }
    set { _Connects = value; 
      OnPropertyChanged(@"Connects");
    }
    }
      public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
      protected virtual void OnPropertyChanged(string propertyName)
      { if(PropertyChanged != null) PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName)); }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResUpdateServerInfoMessage")]
    
    public class ResUpdateServerInfoMessage : global::ProtoBuf.IExtensible
    , global::System.ComponentModel.INotifyPropertyChanged
    {
    public ResUpdateServerInfoMessage() {}
    
    private Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls _msgID
      = Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls.ResUpdateServerInfo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msgID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
      [global::System.ComponentModel.DefaultValue(Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls.ResUpdateServerInfo)]
    
    public Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls msgID
    {
    get { return _msgID; }
    set { _msgID = value; 
      OnPropertyChanged(@"msgID");
    }
    }
    private string _Serverinfo;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Serverinfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Serverinfo
    {
    get { return _Serverinfo; }
    set { _Serverinfo = value; 
      OnPropertyChanged(@"Serverinfo");
    }
    }
      public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
      protected virtual void OnPropertyChanged(string propertyName)
      { if(PropertyChanged != null) PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName)); }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqUpdateTokensMessage")]
    
    public class ReqUpdateTokensMessage : global::ProtoBuf.IExtensible
    , global::System.ComponentModel.INotifyPropertyChanged
    {
    public ReqUpdateTokensMessage() {}
    
    private Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls _msgID
      = Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls.ReqUpdateTokens;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msgID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
      [global::System.ComponentModel.DefaultValue(Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls.ReqUpdateTokens)]
    
    public Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls msgID
    {
    get { return _msgID; }
    set { _msgID = value; 
      OnPropertyChanged(@"msgID");
    }
    }
    private int _ZoneID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ZoneID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ZoneID
    {
    get { return _ZoneID; }
    set { _ZoneID = value; 
      OnPropertyChanged(@"ZoneID");
    }
    }
    private int _ServerID;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ServerID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ServerID
    {
    get { return _ServerID; }
    set { _ServerID = value; 
      OnPropertyChanged(@"ServerID");
    }
    }
    private readonly global::System.Collections.Generic.List<string> _Tokens = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(4, Name=@"Tokens", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> Tokens
    {
    get { return _Tokens; }
    }
  
      public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
      protected virtual void OnPropertyChanged(string propertyName)
      { if(PropertyChanged != null) PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName)); }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqCheckTokensMessage")]
    
    public class ReqCheckTokensMessage : global::ProtoBuf.IExtensible
    , global::System.ComponentModel.INotifyPropertyChanged
    {
    public ReqCheckTokensMessage() {}
    
    private Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls _msgID
      = Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls.ReqCheckTokens;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msgID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
      [global::System.ComponentModel.DefaultValue(Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls.ReqCheckTokens)]
    
    public Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls msgID
    {
    get { return _msgID; }
    set { _msgID = value; 
      OnPropertyChanged(@"msgID");
    }
    }
    private int _ZoneID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ZoneID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ZoneID
    {
    get { return _ZoneID; }
    set { _ZoneID = value; 
      OnPropertyChanged(@"ZoneID");
    }
    }
    private int _ServerID;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ServerID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ServerID
    {
    get { return _ServerID; }
    set { _ServerID = value; 
      OnPropertyChanged(@"ServerID");
    }
    }
    private string _Token;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Token
    {
    get { return _Token; }
    set { _Token = value; 
      OnPropertyChanged(@"Token");
    }
    }
      public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
      protected virtual void OnPropertyChanged(string propertyName)
      { if(PropertyChanged != null) PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName)); }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResCheckTokensMessage")]
    
    public class ResCheckTokensMessage : global::ProtoBuf.IExtensible
    , global::System.ComponentModel.INotifyPropertyChanged
    {
    public ResCheckTokensMessage() {}
    
    private Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls _msgID
      = Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls.ResCheckTokens;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msgID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
      [global::System.ComponentModel.DefaultValue(Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls.ResCheckTokens)]
    
    public Net.Sz.Game.MMOGame.GameMessages.Login.ProtoGLSMessage.Protos_gls msgID
    {
    get { return _msgID; }
    set { _msgID = value; 
      OnPropertyChanged(@"msgID");
    }
    }
    private string _Token;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Token
    {
    get { return _Token; }
    set { _Token = value; 
      OnPropertyChanged(@"Token");
    }
    }
    private string _UserInfoStr;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"UserInfoStr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UserInfoStr
    {
    get { return _UserInfoStr; }
    set { _UserInfoStr = value; 
      OnPropertyChanged(@"UserInfoStr");
    }
    }
      public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
      protected virtual void OnPropertyChanged(string propertyName)
      { if(PropertyChanged != null) PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName)); }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"Protos_gls")]
    public enum Protos_gls
    {
    
    [global::ProtoBuf.ProtoEnum(Name=@"ReqUpdateServerInfo", Value=100201)]
      ReqUpdateServerInfo = 100201
      ,
    
    [global::ProtoBuf.ProtoEnum(Name=@"ResUpdateServerInfo", Value=100101)]
      ResUpdateServerInfo = 100101
      ,
    
    [global::ProtoBuf.ProtoEnum(Name=@"ReqUpdateTokens", Value=100202)]
      ReqUpdateTokens = 100202
      ,
    
    [global::ProtoBuf.ProtoEnum(Name=@"ReqCheckTokens", Value=100203)]
      ReqCheckTokens = 100203
      ,
    
    [global::ProtoBuf.ProtoEnum(Name=@"ResCheckTokens", Value=100103)]
      ResCheckTokens = 100103
    }
  
      public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
      protected virtual void OnPropertyChanged(string propertyName)
      { if(PropertyChanged != null) PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName)); }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
      }
    