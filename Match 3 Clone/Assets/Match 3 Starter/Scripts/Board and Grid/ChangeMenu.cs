using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenu : MonoBehaviour
{
    public void changeMenuScene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
   
}
