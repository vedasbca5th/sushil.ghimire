using System;

namespace PropertiesExample
{
    public class User
    {
        private int Id;
        private string name;
        public int ID
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))//added validation for properties
                {
                    throw new Exception("Given name cannot be blank");
                }
                else
                {
                    name = value;

                }
            }
        }


    }
    public class Program
    {
        public static void Main654(string[] args)
        {
            try{  User user = new User();
            user.ID = 101;
            user.Name = "";
            Console.WriteLine($"The given user {user.Name} id is {user.ID}");
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}