using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;
using product_class;
using user_class;
using board_class;

namespace database_class
{
    public class database
    {
        static Random rnd = new Random();
        // Create variables to hold the Mongo clients
        private IMongoClient productsClient;
        private IMongoClient accountsClient;
        private IMongoClient boardsClient;

        // Create variables to hold the Mongo databases
        private IMongoDatabase productsDB;
        private IMongoDatabase accountsDB;
        private IMongoDatabase boardsDB;

        // Create variables to hold the Mongo collections
        private IMongoCollection<product_image> images_collection;
        private IMongoCollection<user> userinfo_collection;
        private IMongoCollection<board_item> usersboard_collection;

        public database() { }

        // Connect to the Products database
        public void connectToProductsDatabase()
        {
            productsClient = new MongoClient("mongodb://dseller1:bball234@ds037283.mongolab.com:37283/products");
            retrieveProductsDatabase();
        }

        // Connect to the Accounts database
        public void connectToAccountsDatabase()
        {
            accountsClient = new MongoClient("mongodb://dseller1:bball234@ds041643.mongolab.com:41643/accounts");
            retrieveAccountsDatabase();
        }

        // Connect to the Boards Database
        public void connectToBoardsDatabase(user u)
        {
            boardsClient = new MongoClient("mongodb://dseller1:bball234@ds059712.mongolab.com:59712/boards");
            retrieveBoardsDatabase(u);
        }

        public int generateID(List<product_image> images)
        {
            return rnd.Next(images.Count);
        }
        // Inserts a document to the Boards collection
        public bool insertBoardDoc(IMongoCollection<board_item> coll, board_item b)
        {
            bool result = false;
            List<board_item> items = coll.Find(itm => itm.ID == b.ID && itm.Board_Name == b.Board_Name)
              .ToListAsync()
              .Result;

            if(items.Count == 0)
            {
                coll.InsertOneAsync(b);
                result = true;
            }
            return result;
        }

        // Deletes the specified document from the Boards collection
        public void deleteBoardDoc(IMongoCollection<board_item> coll, int id, string boardName)
        {
            board_item deleteBoard = findItemForDeletion(coll, id, boardName);
            coll.DeleteOneAsync(Builders<board_item>.Filter.Eq("_id", deleteBoard._id));
        }
        public board_item findItemForDeletion(IMongoCollection<board_item> coll, int id, string boardName)
        {
            board_item b = new board_item();

            List<board_item> items = coll.Find(itm => itm.ID == id && itm.Board_Name == boardName)
                .Limit(1)
                .ToListAsync()
                .Result;

            foreach (board_item item in items)
            {
                b = item;
            }

            return b;
        }
        // Inserts a User into the User Info collection
        public void insertUserInfoDoc(IMongoCollection<user> coll, user u)
        {
            coll.InsertOneAsync(u);
        }
        public void updateUserPhoneDoc(IMongoCollection<user> coll, user u, string phone)
        {
            var filter = Builders<user>.Filter.Eq("Username", u.Username);
            var update = Builders<user>.Update.Set("Phone", phone);
            coll.UpdateOneAsync(filter, update);
        }
        public void updateUserEmailDoc(IMongoCollection<user> coll, user u, string email)
        {
            var filter = Builders<user>.Filter.Eq("Username", u.Username);
            var update = Builders<user>.Update.Set("Email", email);
            coll.UpdateOneAsync(filter, update);
        }
        // Returns the Images collection
        public IMongoCollection<product_image> getImagesCollection()
        {
            return images_collection;
        }

        // Returns the User Info collection
        public IMongoCollection<user> getUserInfoCollection()
        {
            retrieveUserInfoCollection();
            return userinfo_collection;
        }

        // Returns the Boards collection
        public IMongoCollection<board_item> getUsersBoardCollection(user u)
        {
            retrieveUsersBoardCollection(u);
            return usersboard_collection;
        }
        
        // Retrieves the Images collection from the Products database
        private void retrieveImagesCollection()
        {
            images_collection = productsDB.GetCollection<product_image>("images");
        }

        // Retrieves the User Info collecton from the Accounts database
        private void retrieveUserInfoCollection()
        {
            userinfo_collection = accountsDB.GetCollection<user>("user_info");
        }

        // Retrieves the current user's collection from the Boards database
        private void retrieveUsersBoardCollection(user u)
        {
            usersboard_collection = boardsDB.GetCollection<board_item>(u.Username);
        }

        // Retrieves the Products database from the Mongo server
        private void retrieveProductsDatabase()
        {
            productsDB = productsClient.GetDatabase("products");
            retrieveImagesCollection();
        }

        // Retrieves the Accounts database from the Mongo server
        private void retrieveAccountsDatabase()
        {
            accountsDB = accountsClient.GetDatabase("accounts");
            retrieveUserInfoCollection();
        }

        // Retrieves the Boards database from the Mongo server
        private void retrieveBoardsDatabase(user u)
        {
            boardsDB = boardsClient.GetDatabase("boards");
        }
    }
}