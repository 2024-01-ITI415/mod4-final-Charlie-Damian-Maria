using UnityEngine;

public class Rotator : MonoBehaviour
{
    ScoreManager scoreManager;
    void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }
    // Update is called once per frame
    void Update()
    {
        // Rotate the object on X, Y, and Z axes by specified amounts, adjusted for frame rate.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
    public AudioSource pickupSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.IncreaseScore();
            gameObject.SetActive(false);
            pickupSound.Play();
        }
    }
}
