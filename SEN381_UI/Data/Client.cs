using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace SEN381_UI.Data {
    public class Client : IEqualityComparer<Client> 
    {
        public string clientID;
        public string clientName;
        public string clientSurname;
        public string clientAddress;
        public string clientEmail;
        public string clientPhoneNumber;
        public ClientPolicy? policy;
        public string clientStatus;
        public string clientAdHocNotes;

        public Client()
        {
        }

        public Client(string clientID, string clientName, string clientSurname, string clientAddress, string clientEmail, string clientPhoneNumber, ClientPolicy policy, string clientStatus, string clientAdHocNotes)
        {
            this.clientID = clientID;
            this.clientName = clientName;
            this.clientSurname = clientSurname;
            this.clientAddress = clientAddress;
            this.clientEmail = clientEmail;
            this.clientPhoneNumber = clientPhoneNumber;
            this.policy = policy;
            this.clientStatus = clientStatus;
            this.clientAdHocNotes = clientAdHocNotes;
        }
        public string ClientID { get => clientID; set => clientID = value; }
        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        [RegularExpression(@"^[a-zA-Z]{2,}$", ErrorMessage = "The Name contains invalid characters.")]
        public string ClientName { get => clientName; set => clientName = value; }
        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        [RegularExpression(@"^[a-zA-Z]{2,}$", ErrorMessage = " Surename contains invalid characters.")]
        public string ClientSurname { get => clientSurname; set => clientSurname = value; }
        [Required]
        [RegularExpression(@"^[0-9]+\s[a-zA-Z\s\-']{2,}.\s?[a-zA-Z\s\(\),]{2,}$", ErrorMessage = "Wrong address format.")]
        public string ClientAddress { get => clientAddress; set => clientAddress = value; }
        [Required]
        [EmailAddress]
        public string ClientEmail { get => clientEmail; set => clientEmail = value; }
        [Required]
        [RegularExpression(@"^([+]?\d{1,2}[-\s]?|)\d{3}[-\s]?\d{3}[-\s]?\d{4}$", ErrorMessage = "Invalid phone number.")]
        public string ClientPhoneNumber { get => clientPhoneNumber; set => clientPhoneNumber = value; }
        public ClientPolicy? Policy { get => policy; set => policy = value; }
        [Required]
        public string ClientStatus { get => clientStatus; set => clientStatus = value; }
        [Required]
        public string ClientAdHocNotes { get => clientAdHocNotes; set => clientAdHocNotes = value; }

        public   bool Equals(Client? x, Client? y)
        {
            if (x == null || y == null)
                return false;
            else if (x.ClientName == y.ClientName || x.ClientSurname == y.ClientSurname || x.ClientAddress == y.ClientAddress || x.ClientEmail == y.ClientEmail || x.ClientPhoneNumber == y.ClientPhoneNumber || x.Policy == y.Policy || x.ClientStatus == y.ClientStatus || x.ClientAdHocNotes == y.ClientAdHocNotes)
                return true;
            else
                return false;

        }


        public int GetHashCode([DisallowNull] Client obj)
        {
            return obj.GetHashCode();
        }

    }

    public class ClientPolicy
    {
        private string? policyID;
        private string? policyName;
        private string? policyStatus;

        public ClientPolicy(string policyID, string policyName, string policyStatus)
        {
            this.policyID = policyID;
            this.policyName = policyName;
            this.policyStatus = policyStatus;
        }

        public ClientPolicy()
        {
        }

        public string? PolicyID { get => policyID; set => policyID = value; }
        public string? PolicyName { get => policyName; set => policyName = value; }
        public string? PolicyStatus { get => policyStatus; set => policyStatus = value; }
    }
}



