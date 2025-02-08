using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTipHandler : MonoBehaviour
{
    public Text tooltipText;

    /// <summary>
    /// Change the text of the tooltip.
    /// </summary>
    /// <param name="text">New text of the tooltip. Set empty to clear.</param>
    public void ChangeText(string text)
    {
        tooltipText.text = text;
    }
}
