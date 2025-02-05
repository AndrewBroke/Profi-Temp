using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int waveCount = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Смотрим сколько врагов
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if( enemies.Length >= waveCount)
        {
            // Направляем к юниту игрока
            GameObject playerUnit = GameObject.FindGameObjectWithTag("PlayerUnit");
            GameObject playerCapital = GameObject.FindGameObjectWithTag("Capital");
            if (playerUnit != null)
            {
                foreach (var enemy in enemies)
                {
                    Unit unit;
                    if(enemy.TryGetComponent(out unit))
                    {
                        unit.Go(playerUnit.transform.position);
                        unit.GetComponent<ArcherController>().currentTarget=playerUnit;
                    }
                }
            }
            else
            {
                foreach (var enemy in enemies)
                {
                    Unit unit;
                    if (enemy.TryGetComponent(out unit))
                    {
                        unit.Go(playerCapital.transform.position);
                        unit.GetComponent<ArcherController>().currentTarget = playerCapital;
                    }
                }
            }
        }
    }
}
