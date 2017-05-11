using Newtonsoft.Json;
using System;

namespace HubSpotApi.Models.Contacts
{
    public class ContactListMembership
    {
        /// <summary>
        /// The ID of the contact list
        /// </summary>
        [JsonProperty(PropertyName = "static-list-id")]
        public int StaticListId { get; set; }

        /// <summary>
        /// A Unix timestamp (in milliseconds) for when the contact joined the list.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long TimestampEpoch { get; set; }

        /// <summary>
        /// The vid of the contact record.
        /// </summary>
        public int Vid { get; set; }

        /// <summary>
        /// This will always be true as the API only returns lists that the record is currently a member of.
        /// </summary>
        [JsonProperty(PropertyName = "is-member")]
        public bool IsMember { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => TimestampEpoch.FromUnixTimeMilliseconds();
    }
}