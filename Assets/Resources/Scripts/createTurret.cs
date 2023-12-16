using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTurret : MonoBehaviour
{
    public string turretPlaceTag = "turretPlace";
    private setTurretScript SetTurretScript;

    void Start()
    {
        SetTurretScript = GetComponent<setTurretScript>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1, QueryTriggerInteraction.Ignore))
            {
                Debug.Log(hit.collider.gameObject.tag);
                if (hit.collider.gameObject.CompareTag(turretPlaceTag)) 
                {
                    SetTurretScript.CreateTurret(hit.collider.gameObject);
                }
            }

        }
    }
}
