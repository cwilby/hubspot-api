using Newtonsoft.Json;
using System;

namespace HubSpotApi.Models.Contacts
{
    public class ContactFormSubmission
    {
        /// <summary>
        /// A Unique ID for the specific form conversion
        /// </summary>
        [JsonProperty(PropertyName = "conversion-id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// A Unix timestamp in milliseconds of the time the submission occurred
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long TimestampEpoch { get; set; }

        /// <summary>
        /// The GUID of the form that the subission belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "form-id")]
        public string FormId { get; set; }

        /// <summary>
        /// The Portal ID (Hub ID) that the submission belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "portal-id")]
        public int PortalId { get; set; }

        /// <summary>
        /// The URL that the form was submitted on. This field may be missing if no URL was provided in the submission.
        /// </summary>
        [JsonProperty(PropertyName = "page-url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// The title of the page that the form was submitted on. This will default to the name of the form if no title is provided.
        /// </summary>
        public string Title { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => TimestampEpoch.FromUnixTimeMilliseconds();
    }
}