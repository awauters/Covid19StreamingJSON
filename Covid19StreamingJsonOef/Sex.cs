using System.Runtime.Serialization;

namespace Covid19StreamingJsonOef
{
    public enum Sex
    {
        [EnumMember(Value = "F")]
        Female,
        [EnumMember(Value = "M")]
        Male
    }
}
