using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.AI;

public class Unit : MonoBehaviour, IHealth
{
    public int health { get; set; }
    public int maxHealth { get; set; }
}
