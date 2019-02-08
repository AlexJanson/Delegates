using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{

    public event Action enemyKilledEvent;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                DestroyEnemy(hit.transform.gameObject);
            }
        }
    }

    void DestroyEnemy(GameObject target)
    {
        Destroy(target);

        if (enemyKilledEvent != null)
        {
            enemyKilledEvent();
        }
    }
}