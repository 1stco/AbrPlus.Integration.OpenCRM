using System.Collections.Generic;

namespace AbrPlus.Integration.OpenCRM.Responses
{
    public class BillableObjectTypePropsResponse
    {
        public BillableObjectTypePropsResponse()
        {
            CRMObjectTypes = new List<CrmObjectTypeResponse>();
        }
        public List<CrmObjectTypeResponse> CRMObjectTypes { get; set; }
    }
}