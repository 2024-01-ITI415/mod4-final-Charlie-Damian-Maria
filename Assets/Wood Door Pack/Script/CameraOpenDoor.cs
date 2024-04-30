using UnityEngine;
using TMPro;

public class DoorOpener : MonoBehaviour
{
    public float interactionDistance = 5f;
    public TextMeshProUGUI interactionText; 

    private void Update()
    {
        RaycastHit hit;
        bool doorInSight = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, interactionDistance);

        // Check if a door is in sight
        if (doorInSight && hit.transform.CompareTag("Door"))
        {
            interactionText.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                DoorScript.Door door = hit.transform.gameObject.GetComponent<DoorScript.Door>();
                if (door != null)
                {
                    door.OpenDoor();
                }
            }
        }
        else
        {
            interactionText.gameObject.SetActive(false);
        }
    }
}
