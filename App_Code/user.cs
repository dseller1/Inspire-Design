using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using MongoDB.Driver;
using MongoDB.Bson;
using BCrypt.Net;

namespace user_class
{
    public class user
    {
        public ObjectId _id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Account_Type { get; set; }
        public string Designer { get; set; }

        public user()
        {
            Account_Type = "client";
        }

        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
        }
        public static bool ValidatePassword(string password, string correctHash)
        {
            if (correctHash != null)
                return BCrypt.Net.BCrypt.Verify(password, correctHash);
            else
                return false;
        }
        public static List<user> checkUsername(IMongoCollection<user> coll, user u)
        {
            List<user> users = coll.Find(usr => usr.Username == null || usr.Username == u.Username)
                .ToListAsync()
                .Result;
            return users;
        }
        public static List<user> checkEmail(IMongoCollection<user> coll, user u)
        {
            List<user> users = coll.Find(usr => usr.Email == null || usr.Email == u.Email)
                .ToListAsync()
                .Result;
            return users;
        }
        private static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(12);
        }
        public static user findUser(IMongoCollection<user> coll, string userName)
        {
            user curUser = new user();
            List<user> users = coll.Find(u => u.Username == userName)
                .Limit(1)
                .ToListAsync()
                .Result;
            foreach (user u in users)
            {
                curUser = u;
            }
            return curUser;
        }
        public static void loadUsers(IMongoCollection<user> coll, DropDownList designerUserList, user curUser)
        {
            if (!designerUserList.Items.Contains(new ListItem(curUser.Username)))
            {
                designerUserList.Items.Add(new ListItem(curUser.Username));
            }
            List<user> users = coll.Find(usr => usr.Designer == curUser.Username)
                   .ToListAsync()
                   .Result;
            foreach (user usr in users)
            {
                if (!designerUserList.Items.Contains(new ListItem(usr.Username)))
                {
                    designerUserList.Items.Add(new ListItem(usr.Username));
                }
            }
        }
    }
}