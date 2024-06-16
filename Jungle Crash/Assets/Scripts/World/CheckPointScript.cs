using UnityEngine;

public class CheckPointScript : MonoBehaviour
{
    private PlayerController respawn;

    private void Awake()
    {
        respawn = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            respawn.respawnPoint = this.gameObject;
        }
    }    
}
