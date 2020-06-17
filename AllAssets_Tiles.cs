using System;
using System.Collections;
using System.Collections.Generic;
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
        Asset_tile tile0 = new Asset_tile("GO","Individuals", 0, -200, 0);
        tilesList.Add(tile0);
        Asset_tile tile1 = new Asset_tile("Downtown", "Haifa", 300, 30, 100);
        tilesList.Add(tile1);
        Asset_tile tile2 = new Asset_tile("Moriah", "Haifa", 400, 40, 100);
        tilesList.Add(tile2);
        Asset_tile tile3 = new Asset_tile("Krayot", "Haifa", 200, 20, 100);
        tilesList.Add(tile3);
        Asset_tile tile4 = new Asset_tile("Krayot", "Haifa", 200, 20, 100);
        tilesList.Add(tile4);
        Asset_tile tile5 = new Asset_tile("Krayot", "Haifa", 200, 20, 100);
        tilesList.Add(tile5);
        Asset_tile tile6 = new Asset_tile("Krayot", "Haifa", 200, 20, 100);
        tilesList.Add(tile6);
        Asset_tile tile7 = new Asset_tile("Krayot", "Haifa", 200, 20, 100);
        tilesList.Add(tile7);
        Vector3 posVectorTemp;

        //check player acoount
        PlayerAccount.addAsset(tile1);

       
        for (int i = 0; i < Math.Min(tilesList.Count, this.gameObject.transform.childCount); i++) //amur lihiyot< this.gameObject.transform.GetChildCount()
        {
            //if (this.gameObject.transform.GetChild(i).name!=null)
            //{
                posVectorTemp = new Vector3(this.gameObject.transform.GetChild(i).position.x, transform.GetChild(i).position.y);
                tilesList[i].set_tilePOS(posVectorTemp);
            
            //Debug.Log("temp pos = " + posVectorTemp.x);
            //Debug.Log("i pos = " + tilesList[i].get_tilePOS().x);

            //}
        }

    }

   
}
