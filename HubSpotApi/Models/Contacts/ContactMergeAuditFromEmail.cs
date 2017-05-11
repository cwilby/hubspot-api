using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HubSpotApi.Models.Contacts
{
    public class ContactMergeAuditFromEmail
    {
        /// <summary>
        /// The email address of the secondary contact at the time of the merge.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The method by which the email property was last updated
        /// </summary>
        [JsonProperty(PropertyName = "source-type")]
        public string SourceType { get; set; }

        /// <summary>
        /// Additional data related to the source-type. May not be populated for all source-types.
        /// </summary>
        [JsonProperty(PropertyName = "source-id")]
        public string SourceId { get; set; }

        /// <summary>
        /// Additional data realted to the source-type. May not be populated for all source-types.
        /// </summary>
        [JsonProperty(PropertyName = "source-label")]
        public string SourceLabel { get; set; }

        /// <summary>
        /// A list of integers, where each entry is a vid from the secondary contact. This list may contain multiple entries if the secondary record was previously merged.
        /// </summary>
        [JsonProperty(PropertyName = "source-vids")]
        public IEnumerable<int> SourceVids { get; set; }

        /// <summary>
        /// A Unix timestamp (in milliseconds) for when the email address was last updated
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long TimestampEpoch { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => TimestampEpoch.FromUnixTimeMilliseconds();
    }
}