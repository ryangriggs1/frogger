using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;
    float nextTimeToSpawn = 0f;
    public GameObject car;
    public Transform[] spawnPoints;
    public float destroytime = 2f;
    GameObject cloneCar;

    private void Update()
    {
        if(nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            DestroyCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        cloneCar = Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }

    void DestroyCar()
    {
        Destroy(cloneCar, destroytime);
    }
}
