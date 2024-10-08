#if !BESTHTTP_DISABLE_ALTERNATE_SSL && (!UNITY_WEBGL || UNITY_EDITOR)
#pragma warning disable
using System;
using System.Text;

namespace Best.HTTP.SecureProtocol.Org.BouncyCastle.Bcpg
{
    /**
    * Basic type for a user ID packet.
    */
    public class UserIdPacket
        : ContainedPacket
    {
        private readonly byte[] idData;

        public UserIdPacket(
            BcpgInputStream bcpgIn)
        {
            this.idData = bcpgIn.ReadAll();
        }

		public UserIdPacket(
			string id)
        {
            this.idData = Encoding.UTF8.GetBytes(id);
        }

		public string GetId()
        {
			return Encoding.UTF8.GetString(idData, 0, idData.Length);
        }

		public override void Encode(
            BcpgOutputStream bcpgOut)
        {
            bcpgOut.WritePacket(PacketTag.UserId, idData, true);
        }
    }
}
#pragma warning restore
#endif
