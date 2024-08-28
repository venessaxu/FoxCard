using HotFix_UI;
using MessagePack;


[MessagePackObject]
public class PlayerData : IMessagePack
{
    /// <summary>
    /// 用户id
    /// </summary>
    [Key(0)]
    public long Id { get; set; }

    /// <summary>
    /// 登录类型
    /// </summary>
    [Key(1)]
    public int LoginType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [Key(2)]
    public string NickName { get; set; }


    [Key(3)] public LocationData LocationData { get; set; }

    [Key(4)] public OtherData OtherData { get; set; }
}

public struct OtherData
{
    public string code;
}

//[MessagePackObject]
public struct LocationData
{
    //[Key(0)] 
    public string Addr { get; set; }

    //[Key(1)] 
    public string Country { get; set; }

    //[Key(2)]
    public string Province { get; set; }

    //[Key(3)] 
    public string City { get; set; }
}