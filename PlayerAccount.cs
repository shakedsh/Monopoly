using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerAccount : MonoBehaviour
{

    public  string playerName="abc";
    public int playerMoney =2000;
    public  List<Asset_tile> playerAssets = new List<Asset_tile>();
    public List<Asset_tile> playerLettersAssets = new List<Asset_tile>();




    // Start is called before the first frame update
    void Start()
    {
        //playerAssets = new List<Asset_tile>();
        //YourMoneyScript.moneyValue = playerMoney;
       
    }   


    

    // Update is called once per frame
    void Update()
    {
        
    }

     

}
