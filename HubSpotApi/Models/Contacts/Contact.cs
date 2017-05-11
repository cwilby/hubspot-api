using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSpotApi.Models.Contacts
{
    public class Contact
    {
        /// <summary>
        /// The internal ID of the contact record.
        /// </summary>
        public int Vid { get; set; }

        /// <summary>
        /// The internal ID of the contact record. Contacts may have multiple vids, but the canonical vid will be the primary ID for a record.
        /// </summary>
        [JsonProperty(PropertyName = "canonical-vid")]
        public int CanonicalVid { get; set; }

        /// <summary>
        /// A list of vids that have been merged into this contact record.
        /// </summary>
        [JsonProperty(PropertyName = "merged-vids")]
        public IEnumerable<int> MergedVids { get; set; }

        /// <summary>
        /// The Portal ID (Hub ID) that the record belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "portal-id")]
        public int PortalId { get; set; }

        /// <summary>
        /// Indicates if the record is a valid contact record. Any record where this is set to false is not a valid contact. Those records will only have placeholder data and cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "is-contact")]
        public bool IsContact { get; set; }

        /// <summary>
        /// A unique token that can be used to view the contact without logging into HubSpot. See <see cref="ProfileUrl"/>.
        /// </summary>
        [JsonProperty(PropertyName = "profile-token")]
        public string ProfileToken { get; set; }

        /// <summary>
        /// A URL that can be used to view the contact data without logging in. Anyone with this link would be able to view (but not edit) the record.
        /// </summary>
        [JsonProperty(PropertyName = "profile-url")]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// An object containing objects representing the properties that are set for the contact record.
        /// The keys in the object represent the API name of the contact property
        /// Contacts will only contain an entry for a property if that property has been set for the record.
        /// </summary>
        public IDictionary<string, ContactProperty> Properties { get; set; }

        /// <summary>
        /// A list of form submissions for the contact. This list will be empty for records with no form submissions
        /// </summary>
        [JsonProperty(PropertyName = "form-submissions")]
        public IEnumerable<ContactFormSubmission> FormSubmissions { get; set; }

        /// <summary>
        /// A list of objects representing the contact's membership in contact lists.
        /// This list may be empty if the record is not a member of any lists.
        /// </summary>
        [JsonProperty(PropertyName = "list-memberships")]
        public IEnumerable<ContactListMembership> ListMemberships { get; set; }

        /// <summary>
        /// A list of objects representing the identities of the contact.  Each identity represents an identifier for the object, many records will only have a single identity, but merged records may have multiple.
        /// </summary>
        [JsonProperty(PropertyName = "identity-profiles")]
        public IEnumerable<ContactIdentityProfile> IdentityProfiles { get; set; }

        /// <summary>
        /// A list of data related to any merges that have happened for the record. This list will be empty for records that have not been merged.
        /// </summary>
        [JsonProperty(PropertyName = "merge-audits")]
        public IEnumerable<ContactMergeAudit> MergeAudits { get; set; }

    }
}
