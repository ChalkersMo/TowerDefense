using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTurret : MonoBehaviour
{
    public GameObject turretPrefab;
    public string turretPlaceTag = "turretPlace"; 

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
                    Instantiate(turretPrefab, new Vector3(
                        hit.collider.gameObject.transform.position.x, 
                        hit.collider.gameObject.transform.position.y + 1, 
                        hit.collider.gameObject.transform.position.z), Quaternion.identity); 
                }
            }
        }
    }
}
