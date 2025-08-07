using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
    [SerializeField] private GameObject cloudTemplate;
    [SerializeField] private float interval = 3f;
    [SerializeField] private float yPosition = -0.042f;

    private float countdown;

    void Start()
    {
        countdown = interval;
    }

    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f)
        {
            Vector3 positionToSpawn = new Vector3(transform.position.x, yPosition, 0f);
            GameObject newCloud = Instantiate(cloudTemplate, positionToSpawn, Quaternion.identity);
            Destroy(newCloud, 10f);

            countdown = interval;
        }
    }
}