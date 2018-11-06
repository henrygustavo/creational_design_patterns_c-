namespace CreationalDesignPatterns.Entities.ProtoType
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserAccount : ICloneable
    {
        public string UserName { set; get; }


        public string Password { set; get; }


        public string FName { set; get; }


        public string LName { set; get; }


        public List<Permission> Permissions { set; get; } = new List<Permission>();


        public void AddPermission(Permission p)
        {
            Permissions.Add(p);
        }

        public object Clone()
        {
            //Shallow Copy
            return MemberwiseClone();

            //Deep Copy

            //UserAccount account = new UserAccount
            //{
            //    UserName = this.UserName,
            //    Password = this.Password,
            //    FName = this.FName,
            //    LName = this.LName
            //};

            //List<Permission> permissions = new List<Permission>();
            //for (int i = 0; i < permissions.Count; i++)
            //{
            //    Permission permission = (Permission) permissions.ElementAt(i).Clone();
            //    permissions.Add(permission);
            //}

            //account.Permissions = permissions;
            //return account;

        }

        public override string ToString()
        {
            string str = "User: " + UserName + "\n" + " Permissions : \n";
            for (int i = 0; i < Permissions.Count; i++)
            {
                str = str + (Permission) Permissions[i] + "\n";
            }

            return str;
        }
    }
}