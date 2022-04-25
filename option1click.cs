using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class option1click : MonoBehaviour
{
    public bool clickedon;
    public void update()
    {
        clickedon = false;
    }
    public void option1clicked()
    {
        clickedon = true;

    }
}
