using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace golf1052.YNABAPI.Model
{
    [DataContract]
    public class YNABResponse<T>
    {
        [JsonConstructor]
        protected YNABResponse()
        {
        }

        [DataMember(Name = "data", EmitDefaultValue = false)]
        public T Data { get; set; }
    }
}
