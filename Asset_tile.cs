using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Asset_tile
{
    private Vector3 tilePos;
    public string tileName;
    public string tileGroup;
    public int owner; //-1 when free

    public int tileBuyingPrice; //mehir kniya
    public int tiletransmitionPayment; //tashlum lemi shemahzik baNehes
    public int tileHouseBuyingPrice;

    public Asset_tile(Vector3 tilePos1, string tileName1, string tileGroup1, int tileBuyingPrice1, int tiletransmitionPayment1, int tileHouseBuyingPrice1)
    {
        owner = -1;
        tilePos = tilePos1;
        tileName = tileName1;
        tileGroup = tileGroup1;
        tileBuyingPrice = tileBuyingPrice1;
        tiletransmitionPayment = tiletransmitionPayment1;
        tileHouseBuyingPrice = tileHouseBuyingPrice1;
    }

    public Asset_tile(string tileName1, string tileGroup1, int tileBuyingPrice1, int tiletransmitionPayment1, int tileHouseBuyingPrice1)
    {
        owner = -1;
        tilePos = Vector3.zero; //livdok sheoved
        tileName = tileName1;
        tileGroup = tileGroup1;
        tileBuyingPrice = tileBuyingPrice1;
        tiletransmitionPayment = tiletransmitionPayment1;
        tileHouseBuyingPrice = tileHouseBuyingPrice1;
    }

    public int MyProperty { get; set; } //livdok sheoved// lo oved
    
     public Vector3 get_tilePOS()
    {
        return tilePos;
    }
    public void set_tilePOS(Vector3 posnew)
    {
        tilePos = posnew;
    }

    


}