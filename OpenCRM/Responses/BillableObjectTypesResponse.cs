using System.Collections.Generic;

namespace AbrPlus.Integration.OpenCRM.Responses
{
    public class BillableObjectTypesResponse
    {
        public BillableObjectTypesResponse()
        {
            CRMObjectTypes = new List<CrmObjectTypeResponse>();
        }
        public List<CrmObjectTypeResponse> CRMObjectTypes { get; set; }
    }
}