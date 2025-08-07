using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    [SerializeField] private float minSpeed = 0.2f;
    [SerializeField] private float maxSpeed = 0.7f;
    [SerializeField] private float leftLimit = -10f;
    [SerializeField] private float rightLimit = 10f;
    [SerializeField] private float minY = 2f;
    [SerializeField] private float maxY = 4f;

    private float currentSpeed;

    void Start()
    {
        
        currentSpeed = Random.Range(minSpeed, maxSpeed);
    }

    void Update()
    {
        transform.position += Vector3.left * currentSpeed * Time.deltaTime;

        if (transform.position.x < leftLimit)
        {
            
            float randomY = Random.Range(minY, maxY);
            transform.position = new Vector3(rightLimit, randomY, transform.position.z);

            
            currentSpeed = Random.Range(minSpeed, maxSpeed);
        }
    }
}