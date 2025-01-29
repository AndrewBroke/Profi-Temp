using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject pausePanel;

    public void PauseButtonClick()
    {
        if(pausePanel.activeSelf == true)
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;

        }
        else
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
