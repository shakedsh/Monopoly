using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class AllAssets_Tiles : MonoBehaviour
{

     static List<Asset_tile> tilesList;

    public static List<Asset_tile> getTilesList()
    {
        return tilesList;
    }
        

    

    // Start is called before the first frame update
    void Start()
    {
        //TilesList = new List<Asset_tile>();
        tilesList = new List<Asset_tile>();
        Asset_tile tile0 = new Asset_tile("החלצ ךרד","", 0, -200, 0);
        tilesList.Add(tile0);
        Asset_tile tile1 = new Asset_tile("תיתחת ריע", "הפיח", 300, 30, 100);
        tilesList.Add(tile1);
        Asset_tile tile2 = new Asset_tile("ימואל חוטיב", "ימואל חוטיב", 0, 40, 100);
        tilesList.Add(tile2);
        Asset_tile tile3 = new Asset_tile("הירומ", "הפיח", 400, 40, 100);
        //Asset_tile tile3 = new Asset_tile("ראוד", "ראוד", 200, 20, 100);
        tilesList.Add(tile3);
        Asset_tile tile4 = new Asset_tile("למשחה תרבח", "דיגאת", 200, 20, 100);
        tilesList.Add(tile4);
        Asset_tile tile5 = new Asset_tile("תוירק", "הפיח", 200, 20, 100);
        tilesList.Add(tile5);
        Asset_tile tile6 = new Asset_tile("ראוד", "ראוד", 200, 20, 100);
        tilesList.Add(tile6);
        Asset_tile tile7 = new Asset_tile("למרכה ףוח", "תבכר", 200, 20, 100);
        tilesList.Add(tile7);
        Asset_tile tile8 = new Asset_tile("תוקיתעה תושר", "דיגאת", 200, 20, 100);
        tilesList.Add(tile8);
        Asset_tile tile9 = new Asset_tile("הנורש", "ביבא לת", 200, 20, 100);
        tilesList.Add(tile9);
        Asset_tile tile10 = new Asset_tile("ףוגניזיד", "ביבא לת", 200, 20, 100);
        tilesList.Add(tile10);
        Asset_tile tile11 = new Asset_tile("הנגהה ביבא לת", "תבכר", 200, 20, 100);
        tilesList.Add(tile11);
        Asset_tile tile12 = new Asset_tile("ראוד", "ראוד", 0, 0, 100);
        tilesList.Add(tile12);
        Asset_tile tile13 = new Asset_tile("יבנלא", "ביבא לת", 200, 20, 100);
        tilesList.Add(tile13);
        Asset_tile tile14 = new Asset_tile("םימה תרבח", "דיגאת", 200, 20, 100);
        tilesList.Add(tile14);
        Asset_tile tile15 = new Asset_tile("הקורוס", "עבש ראב", 200, 20, 100);
        tilesList.Add(tile15);
        Asset_tile tile16 = new Asset_tile("ראוד", "ראוד", 0, 0, 100);
        tilesList.Add(tile16);
        Asset_tile tile17 = new Asset_tile("בגנה תטרדנא", "עבש ראב", 200, 20, 100);
        tilesList.Add(tile17);
        Asset_tile tile18 = new Asset_tile("זכרמ עבש ראב", "תבכר", 200, 20, 100);
        tilesList.Add(tile18);
        Asset_tile tile19 = new Asset_tile("םירפוסה .פ", "עבש ראב", 200, 20, 100);
        tilesList.Add(tile19);
        Asset_tile tile20 = new Asset_tile("ראוד", "ראוד", 0, 0, 100);
        tilesList.Add(tile20);
        Asset_tile tile21 = new Asset_tile("ג.ט.ר", "דיגאת", 200, 20, 100);
        tilesList.Add(tile21);
        Asset_tile tile22 = new Asset_tile("אליממ", "םילשורי", 400, 40, 100);
        tilesList.Add(tile22);
        Asset_tile tile23 = new Asset_tile("רודישה תושר", "דיגאת", 200, 20, 100);
        tilesList.Add(tile23);
        Asset_tile tile24 = new Asset_tile("םיאפר קמע", "םילשורי", 200, 20, 100);
        tilesList.Add(tile24);
        Asset_tile tile25 = new Asset_tile("תויח ןג", "םילשורי", 200, 20, 100);
        tilesList.Add(tile25);
        Asset_tile tile26 = new Asset_tile("הקיתעה ריעה", "םילשורי", 200, 20, 100);
        tilesList.Add(tile26);
        Asset_tile tile27 = new Asset_tile("םיגומלאה תינוש", "תליא", 200, 20, 100);
        tilesList.Add(tile27);
        Asset_tile tile28 = new Asset_tile("תלייט", "תליא", 200, 20, 100);
        tilesList.Add(tile28);
        Asset_tile tile29 = new Asset_tile("הנומיד", "תבכר", 200, 20, 100);
        tilesList.Add(tile29);
        Asset_tile tile30 = new Asset_tile("ראוד", "ראוד", 0, 0, 100);
        tilesList.Add(tile30);
        Asset_tile tile31 = new Asset_tile("תרצנ", "לילג", 300, 30, 100);
        tilesList.Add(tile31);
        Asset_tile tile32 = new Asset_tile("לאימרכ", "לילג", 400, 40, 100);
        tilesList.Add(tile32);
        Asset_tile tile33 = new Asset_tile("שיפרוח", "לילג", 200, 20, 100);
        tilesList.Add(tile33);
        Asset_tile tile34 = new Asset_tile("ראוד", "ראוד", 0, 0, 100);
        tilesList.Add(tile34);
        Asset_tile tile35 = new Asset_tile("תפצ", "לילג", 200, 20, 100);
        tilesList.Add(tile35);


        Vector3 posVectorTemp;

        /*
        //this.gameObject.transform.GetChild(1).GetComponentInChildren<TMP_Text>().text = tilesList[1].tileName;
        for (int i=0; i<12;i++)
        {
            this.gameObject.transform.GetChild(i).GetChild(0).GetComponent<TMP_Text>().text = tilesList[i].tileGroup + "\n" + tilesList[i].tileName;
           
        }
       */


        for (int i = 0; i < Math.Min(tilesList.Count, this.gameObject.transform.childCount); i++) //amur lihiyot< this.gameObject.transform.GetChildCount()
        {
           
            //this.gameObject.transform.GetChild(i).GetComponentInChildren<TMP_Text>().text = tilesList[i].tileName;
                posVectorTemp = new Vector3(this.gameObject.transform.GetChild(i).position.x, transform.GetChild(i).position.y, transform.GetChild(i).position.z);
                tilesList[i].set_tilePOS(posVectorTemp);
            if(tilesList[i].tileGroup.Equals(tilesList[i].tileName))
                this.gameObject.transform.GetChild(i).GetChild(0).GetComponent<TMP_Text>().text = tilesList[i].tileName;
            else
                this.gameObject.transform.GetChild(i).GetChild(0).GetComponent<TMP_Text>().text = tilesList[i].tileGroup + "\n" + tilesList[i].tileName;

            //Debug.Log("temp pos = " + posVectorTemp.x);
            //Debug.Log("i pos = " + tilesList[i].get_tilePOS().x);

            //}
        }

    }

   
}
