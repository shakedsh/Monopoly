using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{

    public GameObject Panel;

    public void OpenPanel()
    {
        
        
            if (Panel != null)
            {
                bool isPanelActive = Panel.activeSelf;
                Panel.SetActive(!isPanelActive);
            }
        
    }

    public void ClosePanel()
    {

        if (Panel != null)
        {
            bool isPanelActive = Panel.activeSelf;
            Panel.SetActive(!isPanelActive);
        }

    }
}