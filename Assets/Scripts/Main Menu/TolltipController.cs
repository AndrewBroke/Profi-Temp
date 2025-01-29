using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TolltipController : MonoBehaviour
{
    public Text tooltipText;

    public void ShowTooltip(string tip)
    {
        tooltipText.text = tip;
    }

    public void HideTooltip()
    {
        tooltipText.text = "";
    }
}
