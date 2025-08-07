using UnityEngine;

public class TubeMover : MonoBehaviour
{
    [SerializeField] private float baseSpeed = 0.4f;

    void Update()
    {
        float speedMultiplier = 1f;
        if (ScoreManager.Instance != null)
        {
            speedMultiplier += ScoreManager.Instance.GetAdditionalSpeed();
        }

        float movement = baseSpeed * speedMultiplier * Time.deltaTime;
        transform.Translate(Vector3.left * movement);
    }
}