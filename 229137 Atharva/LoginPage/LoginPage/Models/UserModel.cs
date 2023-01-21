using System.ComponentModel.DataAnnotations;



    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        //default constructor
        public UserModel()
        {
           this.Id = 100;
            this.UserName = "userName";
            this.Password = "password";
        }

       // parameterized constructor
       public UserModel(int id, string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
       }

     


    }

