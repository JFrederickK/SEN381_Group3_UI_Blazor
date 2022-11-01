namespace SEN381_UI.Data
{
    public class Claim
    {
        public int claimID;
        public string client;
        public int medicalConditions;
        public string placeOfTreatment;
        public int callDetails ;
        public string claimeStatus;
        public Claim()
        {
        }

        public Claim(int claimID, string client, int medicalConditions, string placeOfTreatment, int callDetails, string claimeStatus)
        {
            this.claimID = claimID;
            this.client = client;
            this.medicalConditions = medicalConditions;
            this.placeOfTreatment = placeOfTreatment;
            this.callDetails = callDetails;
            this.claimeStatus = claimeStatus;
        }


        public int ClaimID { get => claimID; set => claimID = value; }
        public string Client { get => client; set => client = value; }
        public int MedicalConditions { get => medicalConditions; set => medicalConditions = value; }
        public string PlaceOfTreatment { get => placeOfTreatment; set => placeOfTreatment = value; }
        public int CallDetails { get => callDetails; set => callDetails = value; }
        public string ClaimeStatus { get => claimeStatus; set => claimeStatus = value; }


        public void approveClaim()
        {
            //Implement Logic
        }

        public void rejectClaim()
        {
            //Implement Logic
        }

        public void pendAwaitingClaimForm()//When Claim needs to use a form instead of the new system
        {
            //Implement Logic
        }

        public void sendConfirmation()//Send sms or email confirmation to client
        {
            //Implement Logic
        }

    }
}

