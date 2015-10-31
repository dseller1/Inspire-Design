using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using database_class;
using elements_class;
using System.Web.UI.WebControls;

namespace product_class
{
    public class product_image
    {
        public ObjectId _id { get; set; }
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Product_Link { get; set; }
        public string Image_Link { get; set; }
        public string Color { get; set; }
        public string Line { get; set; }
        public string Balance { get; set; }
        public string Space { get; set; }
        public string Light { get; set; }
        public string Texture { get; set; }
        public string Form { get; set; }
        public string Pattern { get; set; }
        public string Mass { get; set; }
        public string Unity { get; set; }
        public string Harmony { get; set; }
        public string Proportion { get; set; }
        public string Rhythm { get; set; }
        public string Scale { get; set; }
        public string Variety { get; set; }
        public string Emphasis { get; set; }
        public string Chosen { get; set; }

        public product_image findProduct(List<product_image> allItems, database myDB, elements el)
        {
            product_image p = new product_image();
            List<product_image> queryItems = allItems;
            queryItems = queryProducts(queryItems, el);
            if (queryItems.Count() != 0)
            {
                int r = myDB.generateID(queryItems);
                p = queryItems[r];
            }
            return p;

        }
        public static List<product_image> queryProducts(List<product_image> queryItems, elements el)
        {
            if (el.Color != null)
            {
                queryItems = (from product in queryItems
                              where product.Color == el.Color
                              select product).ToList<product_image>();
            }
            if (el.Line != null)
            {
                queryItems = (from product in queryItems
                              where product.Line == el.Line
                              select product).ToList<product_image>();
            }
            if (el.Light != null)
            {
                queryItems = (from product in queryItems
                              where product.Light == el.Light
                              select product).ToList<product_image>();
            }
            if (el.Form != null)
            {
                queryItems = (from product in queryItems
                              where product.Form == el.Form
                              select product).ToList<product_image>();
            }
            if (el.Space != null)
            {
                queryItems = (from product in queryItems
                              where product.Space == el.Space
                              select product).ToList<product_image>();
            }
            if (el.Texture != null)
            {
                queryItems = (from product in queryItems
                              where product.Texture == el.Texture
                              select product).ToList<product_image>();
            }
            if (el.Pattern != null)
            {
                queryItems = (from product in queryItems
                              where product.Pattern == el.Pattern
                              select product).ToList<product_image>();
            }
            if (el.Mass != null)
            {
                queryItems = (from product in queryItems
                              where product.Mass == el.Mass
                              select product).ToList<product_image>();
            }
            if (el.Balance != null)
            {
                queryItems = (from product in queryItems
                              where product.Balance == el.Balance
                              select product).ToList<product_image>();
            }
            if (el.Unity != null)
            {
                queryItems = (from product in queryItems
                              where product.Unity == el.Unity
                              select product).ToList<product_image>();
            }
            if (el.Harmony != null)
            {
                queryItems = (from product in queryItems
                              where product.Harmony == el.Harmony
                              select product).ToList<product_image>();
            }
            if (el.Rhythm != null)
            {
                queryItems = (from product in queryItems
                              where product.Rhythm == el.Rhythm
                              select product).ToList<product_image>();
            }
            if (el.Proportion != null)
            {
                queryItems = (from product in queryItems
                              where product.Proportion == el.Proportion
                              select product).ToList<product_image>();
            }
            if (el.Variety != null)
            {
                queryItems = (from product in queryItems
                              where product.Variety == el.Variety
                              select product).ToList<product_image>();
            }
            if (el.Emphasis != null)
            {
                queryItems = (from product in queryItems
                              where product.Emphasis == el.Emphasis
                              select product).ToList<product_image>();
            }
            if (el.Scale != null)
            {
                queryItems = (from product in queryItems
                              where product.Scale == el.Scale
                              select product).ToList<product_image>();
            }
            if (el.Type != null)
            {
                queryItems = (from product in queryItems
                              where product.Type == el.Type
                              select product).ToList<product_image>();
            }
            return queryItems;
        }
        public List<product_image> getItems(IMongoCollection<product_image> coll)
        {
            List<product_image> items = coll.Find(itm => itm.ID != 0)
               .ToListAsync()
               .Result;
            return items;
        }
        public static List<product_image> getElements(IMongoCollection<product_image> coll)
        {
            List<product_image> items = coll.Find(itm => itm.Color != null)
                .ToListAsync()
                .Result;
            return items;
        }
    }
}