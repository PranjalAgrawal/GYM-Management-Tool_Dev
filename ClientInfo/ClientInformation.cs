using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEntity
{
    public class ClientInformation
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly DateOfJoining{ get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Gender { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public DateOnly DateOfPayment   { get; set; }
        public bool IsActive    { get; set; }
        public PlanType PlanType { get; set; }

        public PaymentInformation paymentInfo { get; set; }
    }
}
