using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerController : MonoBehaviour
{
    public int wood = 0;
    public int rock = 0;

    public GameObject currentTarget;

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);
        if (other.gameObject == currentTarget)
        {
            print("REsource");
            Resource resource = other.GetComponent<Resource>();
            if (resource.rock == 1)
            {
                if(rock == 0)
                {
                    rock++;
                    Destroy(other.gameObject);
                }
            }
            else
            {
                if(wood == 0)
                {
                    wood++;
                    Destroy(other.gameObject);
                }
            }
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
