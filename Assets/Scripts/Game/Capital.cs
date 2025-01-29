using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capital : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        VillagerController vilContr;
        if(other.TryGetComponent(out vilContr))
        {
            if(vilContr.wood > 0)
            {
                Global.wood += vilContr.wood;
                print("��������� " +  vilContr.wood + " ���������");
                vilContr.wood = 0;
            }
            if(vilContr.rock > 0)
            {
                Global.rock += vilContr.rock;
                print("��������� " + vilContr.rock + " �����");
                vilContr.rock = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
