using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float spawnInterval = 1.5f;
    [SerializeField] private float verticalVariation = 0.45f;

    private float countdown;

    void Start()
    {
        countdown = spawnInterval;
        CreateObstacle();
    }

    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0f)
        {
            CreateObstacle();
            countdown = spawnInterval;
        }
    }

    private void CreateObstacle()
    {
        float yOffset = Random.Range(-verticalVariation, verticalVariation);
        Vector3 positionToSpawn = transform.position + new Vector3(0f, yOffset, 0f);
        GameObject spawnedObstacle = Instantiate(obstaclePrefab, positionToSpawn, Quaternion.identity);
        Destroy(spawnedObstacle, 10f);
    }
}