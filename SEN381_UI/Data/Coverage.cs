namespace SEN381_UI.Data
{
    public class Coverage
    {
        public int coverageID;
        public string coverageDescription;
        public int numberOfGeneralVisits;
        public int numberOfSpecialistsVisits;
        public int totalCoverageUser;



        public Coverage(int coverageID, string coverageDescription, int numberOfGeneralVisits, int numberOfSpecialistsVisits, int totalCoverageUser)
        {
            this.coverageID = coverageID;
            this.coverageDescription = coverageDescription;
            this.numberOfGeneralVisits = numberOfGeneralVisits;
            this.numberOfSpecialistsVisits = numberOfSpecialistsVisits;
            this.totalCoverageUser = totalCoverageUser;
        }

        public int CoverageID { get => coverageID; set => coverageID = value; }
        public string CoverageDescription { get => coverageDescription; set => coverageDescription = value; }
        public int NumberOfGeneralVisits { get => numberOfGeneralVisits; set => numberOfGeneralVisits = value; }
        public int NumberOfSpecialistsVisits { get => numberOfSpecialistsVisits; set => numberOfSpecialistsVisits = value; }
        public int TotalCoverageUser { get => totalCoverageUser; set => totalCoverageUser = value; }



    }
}

