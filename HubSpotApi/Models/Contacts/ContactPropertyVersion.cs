using Newtonsoft.Json;
using System;

namespace HubSpotApi.Models.Contacts
{
    public class ContactPropertyVersion
    {
        /// <summary>
        /// The historical value of the property.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The method by which the property was changed. See https://developers.hubspot.com/docs/methods/contacts/contacts-overview for more details.
        /// </summary>
        [JsonProperty(PropertyName = "source-type")]
        public string SourceType { get; set; }

        /// <summary>
        /// Additional data related to the source-type. May not be populated for all source-types.
        /// </summary>
        [JsonProperty(PropertyName = "source-id")]
        public string SourceId { get; set; }

        /// <summary>
        /// Additional data related to the source-type. May not be populated for all source-types.
        /// </summary>
        [JsonProperty(PropertyName = "source-label")]
        public string SourceLabel { get; set; }

        /// <summary>
        /// A Unix timestamp in milliseconds representing when the property was updated.
        /// </summary>
        public long TimestampEpoch { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => TimestampEpoch.FromUnixTimeMilliseconds();
    }
}