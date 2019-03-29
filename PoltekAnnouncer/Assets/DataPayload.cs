using System;
using System.Collections.Generic;
using static PoltekAnnouncer.Assets.Launcher;

namespace PoltekAnnouncer.Assets
{
    /// <summary>Make the payload of data</summary>
    public class DataPayload : IEquatable<DataPayload>
    {
        public AddPagesEnum Type           { get; set; }
        public       string Value          { get; set; }
        public      decimal FontSize       { get; set; }
        public      decimal PictDuration   { get; set; }
        public      decimal TextDuration   { get; set; }

        public List<DataPayload> Output { get; set; }
        public int Length { get { return Output.Count; } }
        private readonly string DebugString = "~# SECTION {0} #~\nType: {1}\nValue: {2}";

        /// <summary>Make the String output from index.</summary>
        public string ToIndexString(int index)
        {
            if (index > Output.Count || index < 0)
                return null;
            else
                return string.Format(DebugString, index, Output[index].Type, Output[index].Value);
        }

        /// <summary>Bypass the data</summary>
        public class BypassData
        {
            public BypassData(List<DataPayload> datas)
            {
                Data = datas;
            }

            private DataPayload data = new DataPayload();
            public List<DataPayload> Data { get; private set; }
            public int Length { get { return Data.Count; } }

            public string ToIndexString(int index)
            {
                data.Output = Data;
                return data.ToIndexString(index);
            }

            public override string ToString()
            {
                data.Output = Data;
                return data.ToString();
            }
        }

        public bool Equals(DataPayload type = null)
        {
            if (type != null) return Type.Equals(type);
            else return false;
        }

        /// <summary>Make the String output.</summary>
        public override string ToString()
        {
            var length = Length;
            string[] res = new string[length];

            for (var i = 0; i < length; i++)
                res[i] = string.Format(DebugString, i, Output[i].Type, Output[i].Value);

            return string.Join("\n\n", res);
        }
    }
}
