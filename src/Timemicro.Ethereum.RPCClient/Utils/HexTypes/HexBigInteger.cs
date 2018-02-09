using System.Numerics;
using TimemicroCore.Ethereum.Hex.HexConvertors;
using Newtonsoft.Json;

namespace TimemicroCore.Ethereum.Hex.HexTypes
{
    [JsonConverter(typeof(HexRPCTypeJsonConverter<HexBigInteger, BigInteger>))]
    public class HexBigInteger:HexRPCType<BigInteger>
    {
       

        public HexBigInteger(string hex) : base(new HexBigIntegerBigEndianConvertor(), hex)
        {
           
        }

        public HexBigInteger(BigInteger value) : base(value, new HexBigIntegerBigEndianConvertor())
        {

        }


    }
}