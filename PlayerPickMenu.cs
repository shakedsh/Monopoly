using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPickMenu : MonoBehaviour
{
    public GameObject playerPickMenu;
    public Transform playersOrigin;

    public TMP_InputField name;
    public GameObject playerPrefab;

    public void CreatePlayer()
    {
        GameObject player = Instantiate(playerPrefab, playersOrigin);
        Color randomColor = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
        //player.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        player.GetComponent<PlayerAccount>().name = name.text;
        player.GetComponent<PlayerAccount>().playerName = name.text;
        Debug.Log("name.text"+name.text);
        player.GetComponentInChildren<TMP_Text>().text = name.text;
        PlayersList.listOfPlayers.Add(player);
        name.text = "Another player name";
    }

    public void SwitchMenuState()
    {
        if (playerPickMenu.activeSelf)
            playerPickMenu.SetActive(false);
        else
            playerPickMenu.SetActive(true);
    }

}
