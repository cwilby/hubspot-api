using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HubSpotApi.Models.Contacts
{
    public class ContactIdentityProfile
    {
        /// <summary>
        /// The original vid for this identity
        /// </summary>
        public int Vid { get; set; }

        /// <summary>
        /// A unix timestamp (in milliseconds) of when the identity was last updated
        /// </summary>
        [JsonProperty(PropertyName = "saved-at-timestamp")]
        public long SavedAtTimestampEpoch { get; set; }

        /// <summary>
        /// A list of the individual identies for this pointer.
        /// </summary>
        public IEnumerable<ContactIdentity> Identities { get; set; }

        [JsonIgnore]
        public DateTime SavedAtTimestamp => SavedAtTimestampEpoch.FromUnixTimeMilliseconds();
    }
}