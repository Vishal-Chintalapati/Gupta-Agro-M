using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace CGSolar.Models
{
    public class OperationAndMaintenanceModel
    {
        public string WorkOrderNo { get; set; }
        public string BeneficiaryName { get; set; }
        public int BeneficiaryID { get; set; }
        public string Village { get; set; }

        public string Block { get; set; }
        public string District { get; set; }
        public string SystemCapacity { get; set; }
        public string Contact { get; set; }
        public int AssignedTo { get; set; }
        public string AssignedEmployee { get; set; }
        public DateTime? ReportedDate { get; set; }
        public string ProblemDescription { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Status { get; set; }


        // This will convert the passed XYZ object to JSON string
        public static string Serialize(List<OperationAndMaintenanceModel> onMModel)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(onMModel);
        }

        // This will convert the passed JSON string back to XYZ object
        public static List<OperationAndMaintenanceModel> Deserialize(string data)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<List<OperationAndMaintenanceModel>>(data);
        }

    }
}