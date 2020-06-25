using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener_IfPlayerStanding : MonoBehaviour
{

    public GameObject Panel;

    public void OpenPanel()
    {
        if (PlayersList.CurrentplayerSituation == 0)
        {
            if (Panel != null)
            {
                bool isPanelActive= Panel.activeSelf;
                Panel.SetActive(!isPanelActive);
            }
        }
    }
}