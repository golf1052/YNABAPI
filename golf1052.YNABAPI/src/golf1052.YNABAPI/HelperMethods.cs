using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace golf1052.YNABAPI
{
    public class HelperMethods
    {
        /// <summary>
        /// The cleared status of the transaction
        /// </summary>
        /// <value>The cleared status of the transaction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClearedEnum
        {

            /// <summary>
            /// Enum Cleared for value: cleared
            /// </summary>
            [EnumMember(Value = "cleared")]
            Cleared = 1,

            /// <summary>
            /// Enum Uncleared for value: uncleared
            /// </summary>
            [EnumMember(Value = "uncleared")]
            Uncleared = 2,

            /// <summary>
            /// Enum Reconciled for value: reconciled
            /// </summary>
            [EnumMember(Value = "reconciled")]
            Reconciled = 3
        }

        /// <summary>
        /// The transaction flag
        /// </summary>
        /// <value>The transaction flag</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlagColorEnum
        {

            /// <summary>
            /// Enum Red for value: red
            /// </summary>
            [EnumMember(Value = "red")]
            Red = 1,

            /// <summary>
            /// Enum Orange for value: orange
            /// </summary>
            [EnumMember(Value = "orange")]
            Orange = 2,

            /// <summary>
            /// Enum Yellow for value: yellow
            /// </summary>
            [EnumMember(Value = "yellow")]
            Yellow = 3,

            /// <summary>
            /// Enum Green for value: green
            /// </summary>
            [EnumMember(Value = "green")]
            Green = 4,

            /// <summary>
            /// Enum Blue for value: blue
            /// </summary>
            [EnumMember(Value = "blue")]
            Blue = 5,

            /// <summary>
            /// Enum Purple for value: purple
            /// </summary>
            [EnumMember(Value = "purple")]
            Purple = 6
        }
    }
}
