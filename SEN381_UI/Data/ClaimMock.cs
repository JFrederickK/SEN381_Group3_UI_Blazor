namespace SEN381_UI.Data
{
    public class ClaimMock
    {
        public List<Claim> GetClaims() { 
        List<Claim> claims = new List<Claim>();
            claims.Add(new Claim("1", "1", "1", "Brakpan", "1", "approved"));
            return claims;
        }
    }
}
