using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorInteractor : MonoBehaviour
{
    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.transform.tag == "door")
            {

                hit.transform.gameObject.GetComponent<DoorScript.Door>().OpenDoor();
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
        }
    }
}