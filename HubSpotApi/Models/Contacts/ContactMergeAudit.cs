using Newtonsoft.Json;
using System;

namespace HubSpotApi.Models.Contacts
{
    public class ContactMergeAudit
    {
        /// <summary>
        /// Vid of the primary contact (record that was merged into).
        /// </summary>
        [JsonProperty(PropertyName = "canonical-vid")]
        public int CanonicalVid { get; set; }

        /// <summary>
        /// The vid of the secondary contact (record that the data was merged from).
        /// </summary>
        [JsonProperty(PropertyName = "vid-to-merge")]
        public int VidToMerge { get; set; }

        /// <summary>
        /// A Unix timestamp (in milliseconds) of when the merge occurred
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long TimestampEpoch { get; set; }

        /// <summary>
        /// The internal ID of the user who initiated the merge.  This will have no value outside of the HubSpot app.
        /// </summary>
        [JsonProperty(PropertyName = "user-id")]
        public int UserId { get; set; }

        /// <summary>
        /// The number of properties updating as a result of the merge
        /// </summary>
        [JsonProperty(PropertyName = "num-properties-moved")]
        public int NumberPropertiesMoved { get; set; }

        /// <summary>
        /// A set of data from the secondary contact
        /// </summary>
        [JsonProperty(PropertyName = "merged_from_email")]
        public ContactMergeAuditFromEmail MergedFromEmail { get; set; }

        /// <summary>
        /// A set of data for the primary contact
        /// </summary>
        [JsonProperty(PropertyName = "merged_to_email")]
        public ContactMergeAuditToEmail MergedToEmail { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => TimestampEpoch.FromUnixTimeMilliseconds();
    }
}