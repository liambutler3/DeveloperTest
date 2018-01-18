using System.ComponentModel.DataAnnotations;

namespace testWebApp.Models
{
    public class UserModel
    {
        //public string configConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TestDBCon"].ConnectionString;
        public string ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True";

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email Address")]
        [Display(Name = "Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Please Enter A Correct Email Address")]
        public string Email { get; set; }

        [Required]
        //[StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$)"]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public bool Sucess { get; set; }
    }
}