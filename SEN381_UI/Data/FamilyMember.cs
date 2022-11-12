
using System.ComponentModel.DataAnnotations;

public class FamilyMember{

    private string memberId;
    private string memberName;
    private string memberSurname;
    private string phoneNumber;
    private string email;
    private string address;
    private string role;
    private string clientID;

    public FamilyMember()
    {
    }
    public FamilyMember(string memberId, string memberName, string memberSurname, string phoneNumber, string email, string address, string role, string clientID)
    {
        this.memberId = memberId;
        this.memberName = memberName;
        this.memberSurname = memberSurname;
        this.phoneNumber = phoneNumber;
        this.email = email;
        this.address = address;
        this.role = role;
        this.ClientID = clientID;
    }

    public string MemberId { get => memberId; set => memberId = value; }
    [Required]
    [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
    [RegularExpression(@"^[a-zA-Z]{2,}$", ErrorMessage = "The Name contains invalid characters.")]
    public string MemberName { get => memberName; set => memberName = value; }
    [Required]
    [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
    [RegularExpression(@"^[a-zA-Z]{2,}$", ErrorMessage = " Surename contains invalid characters.")]
    public string MemberSurname { get => memberSurname; set => memberSurname = value; }
    [Required]
    [RegularExpression(@"^([+]?\d{1,2}[-\s]?|)\d{3}[-\s]?\d{3}[-\s]?\d{4}$", ErrorMessage = "Invalid phone number.")]
    public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    [Required]
    [EmailAddress]
    public string Email { get => email; set => email = value; }
    [Required]
    [RegularExpression(@"^[0-9]+\s[a-zA-Z\s\-']{2,}.\s?[a-zA-Z\s\(\),]{2,}$", ErrorMessage = "Wrong address format.")]
    public string Address { get => address; set => address = value; }
    [Required]
    [StringLength(50, ErrorMessage = "Role length can't be more than 50.")]
    [RegularExpression(@"^[a-zA-Z]{2,}$", ErrorMessage = "Role contains invalid characters.")]
    public string Role { get => role; set => role = value; }
    public string ClientID { get => clientID; set => clientID = value; }
}

    