using System.Collections.Generic;

namespace Lob.Api.Address
{
    public class CreateAddressRequest
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string AddressCountry { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IDictionary<string, string> Metadata { get; set; }
    }
}
