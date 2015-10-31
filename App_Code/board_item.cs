using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using MongoDB.Driver;
using product_class;
using System.Data;

namespace board_class
{
    public class board_item
    {
        public ObjectId _id { get; set; }
        public string Board_Name { get; set; }
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

        public board_item()
        {
            Board_Name = "default";
        }
        public static board_item productToBoardConversion(product_image p)
        {
            board_item b = new board_item();
            b.ID = p.ID;
            b.Type = p.Type;
            b.Description = p.Description;
            b.Product_Link = p.Product_Link;
            b.Image_Link = p.Image_Link;
            b.Color = p.Color;
            b.Line = p.Line;
            b.Space = p.Space;
            b.Light = p.Light;
            b.Texture = p.Texture;
            b.Form = p.Form;
            b.Pattern = p.Pattern;
            b.Mass = p.Mass;
            b.Balance = p.Balance;
            b.Unity = p.Unity;
            b.Harmony = p.Harmony;
            b.Proportion = p.Proportion;
            b.Rhythm = p.Rhythm;
            b.Scale = p.Scale;
            b.Variety = p.Variety;
            b.Emphasis = p.Emphasis;
            return b;
        }
        public static List<board_item> findBoardItems(IMongoCollection<board_item> coll, string boardName)
        {
            List<board_item> items = coll.Find(itm => itm.Board_Name == boardName)
               .ToListAsync()
               .Result;
            return items;
        }
        /*public board_item findItemForDeletion(IMongoCollection<board_item> coll, string boardName, int id)
        {
            board_item b = new board_item();
            List<board_item> items = coll.Find(itm => itm.Board_Name == boardName && itm.ID == id)
                .Limit(1)
                .ToListAsync()
                .Result;
            foreach (board_item i in items)
            {
                b = i;
            }
            return b;
        }*/
        public static void loadBoards(IMongoCollection<board_item> coll, DropDownList boardNameList)
        {
            List<board_item> boards = board_item.getBoards(coll);
            foreach (board_item brd in boards)
            {
                if (!boardNameList.Items.Contains(new ListItem(brd.Board_Name)))
                {
                    boardNameList.Items.Add(new ListItem(brd.Board_Name));
                }
            }
        }
        public static List<board_item> getBoards(IMongoCollection<board_item> coll)
        {
            List<board_item> boards = coll.Find(brd => brd.Color != null)
                .ToListAsync()
                .Result;

            return boards;
        }
    }
}