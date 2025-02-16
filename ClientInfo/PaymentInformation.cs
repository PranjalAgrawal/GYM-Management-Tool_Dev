using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEntity
{
    public class PaymentInformation
    {
        public PlanType PlanType;
        public string PaymentType { get; set; }
        
        public int DiscountedPlanAmount { get; set; }

        public int PaidAmount { get; set; }
        
        public int RemainingAmount { get; set; }
    }
}
