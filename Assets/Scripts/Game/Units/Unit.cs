using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.AI;

public class Unit : MonoBehaviour
{
    public GameObject selectionPlane;
    public SelectionController selectionController;
    Animator animator;

    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    public void Go(Vector3 pos)
    {
        agent.SetDestination(pos);
    }

    public void Stop()
    {
        agent.ResetPath();
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        Select();
    }

    public void Select()
    {
        selectionController.DeselectUnit();
        selectionPlane.SetActive(true);
        selectionController.currentUnit = this;
    }

    public void Deselect()
    {
        selectionPlane.SetActive(false);
    }

    
}
