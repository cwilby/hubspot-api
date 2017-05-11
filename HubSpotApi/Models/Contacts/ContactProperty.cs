using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSpotApi.Models.Contacts
{
    public class ContactProperty
    {
        /// <summary>
        /// The current value of the property for this contact. Values are always stored internally as a string, regardless of the property type.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// A list of the historical values of the property
        /// A new versions entry will be added each time the property is updated.
        /// This data is read-only, and generated automatically when a property is updated.
        /// </summary>
        public IEnumerable<ContactPropertyVersion> Versions { get; set; } 
    }
}
