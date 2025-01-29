using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    public Text woodUI;
    public Text rockUI;

    // Update is called once per frame
    void Update()
    {
        woodUI.text = Global.wood.ToString();
        rockUI.text = Global.rock.ToString();
    }
}
