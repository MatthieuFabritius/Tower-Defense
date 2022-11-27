using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform enemyPrefab;

    [SerializeField]
    private Transform spawnPoint;

    [SerializeField]
    private float timeBetweenWaves = 5f;

    private float countdown = 2f;

    [SerializeField]
    private Text waveCountdownTimer;

    private int waveIndex = 0;
    // Update is called once per frame
    void Update()
    {
        if (countdown <=0)
            {
                StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;
            }
        countdown -= Time.deltaTime;
        waveCountdownTimer.text = Mathf.Round(countdown).ToString();
    }
    IEnumerator SpawnWave()
    {
        waveIndex++;

        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnnemy();
            yield return new WaitForSeconds(0.5f);
        }

        
    }

    void SpawnEnnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
