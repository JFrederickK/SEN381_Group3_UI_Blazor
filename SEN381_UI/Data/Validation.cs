using System.Text.RegularExpressions;

namespace SEN381_UI.Data
{
    public class Validation
    {
        public bool StringOnly(string word) {
            var Inputletters = @"^[a-zA-Z]{2,}$";
            bool val = Regex.IsMatch(word, Inputletters);

            return val;
        }
        public bool numberOnlu(string word) {
            var Inputletter = @"^([+]?\d{1,2}[-\s]?|)\d{3}[-\s]?\d{3}[-\s]?\d{4}$";
            bool val = Regex.IsMatch(word, Inputletter);
            return val;
        }
        public bool AddressFormat(string word) {
            var Inputletter = @"^[0-9]+\s[a-zA-Z\s\-']{2,}.\s?[a-zA-Z\s\(\),]{2,}$";
            bool val = Regex.IsMatch(word, Inputletter);
            return val;
        }
        public bool EmailFormat(string word) { 
            var Inputletter = @"/(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|
        \\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|
        \[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:
        (?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])/";
            bool val = Regex.IsMatch(word,Inputletter);
            return val;
        }
    }
}

