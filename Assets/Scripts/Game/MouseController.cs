using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseController : MonoBehaviour
{

    public SelectionController selectionController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousePos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Ground")
                {
                    selectionController.SetGo(hit.point);
                }
                else if(hit.collider.tag == "Resource")
                {
                    // Если текущий выбранный персонаж - строитель
                    VillagerController villager;
                    if(selectionController.currentUnit != null &&
                        selectionController.currentUnit.TryGetComponent(out villager))
                    {
                        selectionController.SetGo(hit.transform.position);
                        villager.currentTarget = hit.collider.gameObject;
                    }
                }
                else if(hit.collider.tag == "Capital")
                {
                    // Если нажали на ратушу - идем к ней
                    selectionController.SetGo(hit.collider.transform.position);
                }
                else if( hit.collider.tag == "Enemy")
                {
                    // Если выбранный юнит - арчер
                    ArcherController archer;
                    if (selectionController.currentUnit != null &&
                        selectionController.currentUnit.TryGetComponent(out archer))
                    {
                        selectionController.SetGo(hit.transform.position);
                        archer.currentTarget = hit.collider.gameObject;
                    }
                }
            }
        }
    }
}
