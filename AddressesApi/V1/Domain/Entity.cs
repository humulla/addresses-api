using System;

namespace BaseApi.V1.Domain
{
    //TODO: rename this class to be the domain object which this API will getting. e.g. Residents or Claimants
    public class Entity
    {
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public string Line1 { get; set; }

        public string Postcode { get; set; }
    }
}
