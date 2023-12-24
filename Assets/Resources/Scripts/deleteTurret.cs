using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteTurret : MonoBehaviour
{
    public string turretTag = "Player";

    void Update()
    {
        if (Input.GetMouseButtonDown(2)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1, QueryTriggerInteraction.Ignore))
            {
                Debug.Log(hit.collider.gameObject.tag);
                if (hit.collider.gameObject.CompareTag(turretTag)) 
                {
                    Destroy(hit.collider.gameObject);
                }
            }

        }
    }
}
