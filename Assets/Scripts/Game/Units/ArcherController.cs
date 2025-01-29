using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherController : MonoBehaviour
{
    public float attackDistance = 4;
    public GameObject currentTarget;
    Animator animator;
    Unit unit;
    bool isAttacking = false;

    // Start is called before the first frame update
    void Start()
    {
        unit = GetComponent<Unit>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Остановиться, если дистанция
        if(currentTarget != null)
        {
            float d = Vector3.Distance(transform.position, currentTarget.transform.position);
            if (d <= attackDistance && !isAttacking)
            {
                unit.Stop();
                animator.SetTrigger("Attack");
                isAttacking = true;
            }
        }
    }

    public void Kill()
    {
        Destroy(currentTarget);
        isAttacking = false;
    }
}
