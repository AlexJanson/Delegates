using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {

    public delegate void EnemyKilled();
    public event EnemyKilled enemyKilledEvent;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit)) {
                Destroy(hit.transform.gameObject);
                if (enemyKilledEvent != null) {
                    enemyKilledEvent();
                }
            }
        }
    }
}