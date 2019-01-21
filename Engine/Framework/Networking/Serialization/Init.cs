﻿using LiteNetLib.Utils;

namespace Lockstep.Framework.Networking.Serialization
{
    public class Init
    {
        public int Seed { get; set; }

        public byte PlayerID { get; set; }

        public int TargetFPS { get; set; }

        public void Serialize(NetDataWriter writer)
        {
            writer.Put(Seed);
            writer.Put(PlayerID);
            writer.Put(TargetFPS);
        }

        public void Deserialize(NetDataReader reader)
        {
            Seed = reader.GetInt();
            PlayerID = reader.GetByte();
            TargetFPS = reader.GetInt();
        }
    }
}