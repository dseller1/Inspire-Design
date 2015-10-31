using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using MongoDB.Driver;
using product_class;

namespace elements_class
{
    public class elements
    {
        public string Type { get; set; }
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

        public elements()
        {
            Color = null;
            Line = null;
            Balance = null;
            Space = null;
            Light = null;
            Texture = null;
            Form = null;
            Pattern = null;
            Mass = null;
            Unity = null;
            Harmony = null;
            Proportion = null;
            Rhythm = null;
            Scale = null;
            Variety = null;
            Emphasis = null;
        }
        public static void loadElements(IMongoCollection<product_image> coll, DropDownList colorList, DropDownList lineList, DropDownList lightList, DropDownList formList, DropDownList spaceList, DropDownList textureList, DropDownList patternList, DropDownList massList, DropDownList balanceList, DropDownList unityList, DropDownList harmonyList, DropDownList rhythmList, DropDownList proportionList, DropDownList varietyList, DropDownList emphasisList, DropDownList scaleList, DropDownList typeList)
        {
            List<product_image> items = product_image.getElements(coll);
            foreach (product_image itm in items)
            {
                if (!colorList.Items.Contains(new ListItem(itm.Color)))
                {
                    colorList.Items.Add(new ListItem(itm.Color));
                }
                if (!lineList.Items.Contains(new ListItem(itm.Line)))
                {
                    lineList.Items.Add(new ListItem(itm.Line));
                }
                if (!lightList.Items.Contains(new ListItem(itm.Light)))
                {
                    lightList.Items.Add(new ListItem(itm.Light));
                }
                if (!formList.Items.Contains(new ListItem(itm.Form)))
                {
                    formList.Items.Add(new ListItem(itm.Form));
                }
                if (!spaceList.Items.Contains(new ListItem(itm.Space)))
                {
                    spaceList.Items.Add(new ListItem(itm.Space));
                }
                if (!textureList.Items.Contains(new ListItem(itm.Texture)))
                {
                    textureList.Items.Add(new ListItem(itm.Texture));
                }
                if (!patternList.Items.Contains(new ListItem(itm.Pattern)))
                {
                    patternList.Items.Add(new ListItem(itm.Pattern));
                }
                if (!massList.Items.Contains(new ListItem(itm.Mass)))
                {
                    massList.Items.Add(new ListItem(itm.Mass));
                }
                if (!balanceList.Items.Contains(new ListItem(itm.Balance)))
                {
                    balanceList.Items.Add(new ListItem(itm.Balance));
                }
                if (!unityList.Items.Contains(new ListItem(itm.Unity)))
                {
                    unityList.Items.Add(new ListItem(itm.Unity));
                }
                if (!harmonyList.Items.Contains(new ListItem(itm.Harmony)))
                {
                    harmonyList.Items.Add(new ListItem(itm.Harmony));
                }
                if (!rhythmList.Items.Contains(new ListItem(itm.Rhythm)))
                {
                    rhythmList.Items.Add(new ListItem(itm.Rhythm));
                }
                if (!proportionList.Items.Contains(new ListItem(itm.Proportion)))
                {
                    proportionList.Items.Add(new ListItem(itm.Proportion));
                }
                if (!varietyList.Items.Contains(new ListItem(itm.Variety)))
                {
                    varietyList.Items.Add(new ListItem(itm.Variety));
                }
                if (!emphasisList.Items.Contains(new ListItem(itm.Emphasis)))
                {
                    emphasisList.Items.Add(new ListItem(itm.Emphasis));
                }
                if (!scaleList.Items.Contains(new ListItem(itm.Scale)))
                {
                    scaleList.Items.Add(new ListItem(itm.Scale));
                }
                if (!typeList.Items.Contains(new ListItem(itm.Type)))
                {
                    typeList.Items.Add(new ListItem(itm.Type));
                }
            }
        }
        public static void setElements(DropDownList colorList, DropDownList lineList, DropDownList lightList, DropDownList formList, DropDownList spaceList, DropDownList textureList, DropDownList patternList, DropDownList massList, DropDownList balanceList, DropDownList unityList, DropDownList harmonyList, DropDownList rhythmList, DropDownList proportionList, DropDownList varietyList, DropDownList emphasisList, DropDownList scaleList, DropDownList typeList, elements el)
        {
            if (colorList.SelectedItem.Value != "null")
            {
                el.Color = colorList.SelectedItem.Value;
            }
            if (lineList.SelectedItem.Value != "null")
            {
                el.Line = lineList.SelectedItem.Value;
            }
            if (lightList.SelectedItem.Value != "null")
            {
                el.Light = lightList.SelectedItem.Value;
            }
            if (formList.SelectedItem.Value != "null")
            {
                el.Form = formList.SelectedItem.Value;
            }
            if (spaceList.SelectedItem.Value != "null")
            {
                el.Space = spaceList.SelectedItem.Value;
            }
            if (textureList.SelectedItem.Value != "null")
            {
                el.Texture = textureList.SelectedItem.Value;
            }
            if (patternList.SelectedItem.Value != "null")
            {
                el.Pattern = patternList.SelectedItem.Value;
            }
            if (massList.SelectedItem.Value != "null")
            {
                el.Mass = massList.SelectedItem.Value;
            }
            if (balanceList.SelectedItem.Value != "null")
            {
                el.Balance = balanceList.SelectedItem.Text;
            }
            if (unityList.SelectedItem.Value != "null")
            {
                el.Unity = unityList.SelectedItem.Value;
            }
            if (harmonyList.SelectedItem.Value != "null")
            {
                el.Harmony = harmonyList.SelectedItem.Value;
            }
            if (rhythmList.SelectedItem.Value != "null")
            {
                el.Rhythm = rhythmList.SelectedItem.Value;
            }
            if (proportionList.SelectedItem.Value != "null")
            {
                el.Proportion = proportionList.SelectedItem.Value;
            }
            if (varietyList.SelectedItem.Value != "null")
            {
                el.Variety = varietyList.SelectedItem.Value;
            }
            if (emphasisList.SelectedItem.Value != "null")
            {
                el.Emphasis = emphasisList.SelectedItem.Value;
            }
            if (scaleList.SelectedItem.Value != "null")
            {
                el.Scale = scaleList.SelectedItem.Value;
            }
            if (typeList.SelectedItem.Value != "null")
            {
                el.Type = typeList.SelectedItem.Value;
            }
        }
    }
}