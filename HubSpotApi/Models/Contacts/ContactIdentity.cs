using Newtonsoft.Json;
using System;

namespace HubSpotApi.Models.Contacts
{
    public class ContactIdentity
    {
        /// <summary>
        /// The type of the identity (EMAIL or LEAD_GUID)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The value of the identity
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// A Unix timestamp (in milliseconds) for when the identity was created.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long TimestampEpoch { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => TimestampEpoch.FromUnixTimeMilliseconds();
    }
}