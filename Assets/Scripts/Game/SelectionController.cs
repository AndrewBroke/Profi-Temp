using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionController : MonoBehaviour
{
    public MovableUnit currentUnit;

    [Header("Villager")]
    // Данные про Villager
    public Text woodCount;
    public Text rockCount;
    public GameObject vilalgerActions;
    public GameObject villagerInfo;

    [Header("UI objects")]
    public GameObject[] actions;
    public GameObject[] infos;

    public void ResetUIs()
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].SetActive(false);
            infos[i].SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        ResetUIs();
        // Если выделен Unit
        if (currentUnit != null)
        {
            // Если выделен Villager
            VillagerController vilContr;
            if(currentUnit.TryGetComponent(out vilContr))
            {
                // ВЫводим инфу
                rockCount.text = vilContr.rock.ToString();
                woodCount.text = vilContr.wood.ToString();

                // Включаем нужные объекты
                villagerInfo.SetActive(true);
                vilalgerActions.SetActive(true);
            }
        }
    }

    public void SetGo(Vector3 pos)
    {
        if (currentUnit != null)
        {
            currentUnit.Go(pos);
        }
    }

    public void DeselectUnit()
    {
        if (currentUnit != null)
        {
            currentUnit.Deselect();
            currentUnit = null;
        }
    }
}
