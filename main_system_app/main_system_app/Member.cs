using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_system_app
{

    internal class Member
    {
        private string EM;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get {
                return EM;
            } set {
                if (value != string.Empty) EM = value;
                else EM = "unknown@unk.com";
            } }
        public string Gender { get; set; }
        public int? CoachID { get; set; }
        private int? age;
        public int? Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value == null) age = 0;
                else age = value;
            }
        }
        public DateTime RegDate { get; set; }
        public DateTime RenewalON { get; set; }
        public string SubscribtionType { get; set; }
        public bool IsPaid { get; set; } = false;
        public bool IsEnd { get; set; } = false;
        public bool IsNotifyed { get; set; } = false;
    }
}
    
