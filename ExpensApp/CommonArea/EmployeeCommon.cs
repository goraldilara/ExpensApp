
using System.Reflection;
using ExpensApp.DataAccess;
using ExpensApp.DataAccess.Concrete.EntityFramework;
using ExpensApp.DataAccess.Concrete.EntityFramework.Models;

namespace CommonArea
{

    public partial class EmployeeCommon
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }

        public EmployeeCommon(int EmployeeID, string Name, string Surname, string Username, string Password, string Email, string UserType)
        {
            this.EmployeeID = EmployeeID;
            this.Name = Name;
            this.Surname = Surname;
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.UserType = UserType;
        }
        public EmployeeCommon()
        {
          
        }

        public EmployeeCommon(string Username, string Password)
        {
            this.EmployeeID = EmployeeID;
            this.Name = Name;
            this.Surname = Surname;
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.UserType = UserType;
        }
    }
}
