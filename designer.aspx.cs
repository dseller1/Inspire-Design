using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Driver;
using MongoDB.Bson;
using product_class;
using elements_class;
using database_class;

public partial class designer : System.Web.UI.Page
{
    product_image newItem = new product_image();
    IMongoCollection<product_image> imgColl;
    database myDB;
    List<product_image> allItems;
    protected void Page_Load(object sender, EventArgs e)
    {
        allItems = (List<product_image>)Session["allItems"];
        myDB = (database)Session["myDB"];
        myDB.retrieveImagesCollection();
        imgColl = myDB.getImagesCollection();
        elements.loadElements(imgColl, colorList, lineList, lightList, formList, spaceList, textureList, patternList, massList, balanceList, unityList, harmonyList, rhythmList, proportionList, varietyList, emphasisList, scaleList, typeList);
    }

    protected void addItemDbBtn_Click(object sender, EventArgs e)
    {
        urlPnl.Visible = true;
        buttonsPnl.Visible = false;
    }
    protected void urlSbmtBtn_Click(object sender, EventArgs e)
    {
        addItemPnl.Visible = true;
        urlPnl.Visible = false;
    }
    protected void addItemBtn_Click(object sender, EventArgs e)
    {
        newItem.ID = allItems.Count() + 1;
        newItem.Image_Link = imageUrlTxt.Text;
        newItem.Description = descriptTxt.Text;
        newItem.Color = colorTxt.Text;
        newItem.Type = typeList.SelectedItem.Value;
        newItem.Line = lineList.SelectedItem.Value;
        newItem.Light = lightList.SelectedItem.Value;
        newItem.Form = formList.SelectedItem.Value;
        newItem.Space = spaceList.SelectedItem.Value;
        newItem.Texture = textureList.SelectedItem.Value;
        newItem.Pattern = patternList.SelectedItem.Value;
        newItem.Mass = massList.SelectedItem.Value;
        newItem.Balance = balanceList.SelectedItem.Value;
        newItem.Unity = unityList.SelectedItem.Value;
        newItem.Harmony = harmonyList.SelectedItem.Value;
        newItem.Rhythm = rhythmList.SelectedItem.Value;
        newItem.Proportion = proportionList.SelectedItem.Value;
        newItem.Variety = varietyList.SelectedItem.Value;
        newItem.Emphasis = emphasisList.SelectedItem.Value;
        newItem.Scale = scaleList.SelectedItem.Value;
        Session["newItem"] = newItem;

        itemImage.ImageUrl = newItem.Image_Link;
        descriptLbl.Text += newItem.Description;
        typeLbl.Text += newItem.Type;
        colorLbl.Text += newItem.Color;
        lineLbl.Text += newItem.Line;
        lightLbl.Text += newItem.Light;
        formLbl.Text += newItem.Form;
        spaceLbl.Text += newItem.Space;
        textureLbl.Text += newItem.Texture;
        patternLbl.Text += newItem.Pattern;
        massLbl.Text += newItem.Mass;
        balanceLbl.Text += newItem.Balance;
        unityLbl.Text += newItem.Unity;
        harmonyLbl.Text += newItem.Harmony;
        rhythmLbl.Text += newItem.Rhythm;
        proportionLbl.Text += newItem.Proportion;
        varietyLbl.Text += newItem.Variety;
        emphasisLbl.Text += newItem.Emphasis;
        scaleLbl.Text += newItem.Scale;
        addItemPnl.Visible = false;
        confirmPnl.Visible = true;
    }
    protected void submitItemBtn_Click(object sender, EventArgs e)
    {
        newItem = (product_image)Session["newItem"];
        myDB.insertProductDoc(imgColl, newItem);
        myDB.retrieveImagesCollection();
        imgColl = myDB.getImagesCollection();
        allItems = product_image.getItems(imgColl);
        Session["allItems"] = allItems;
        Response.Redirect(Request.RawUrl);

    }
}