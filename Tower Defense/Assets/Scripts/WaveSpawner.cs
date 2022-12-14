using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveSpawner : MonoBehaviour
{

    [SerializeField]
    private Transform enemyPrefab;

    [SerializeField]
    private Transform spawnPoint;

    [SerializeField]
    private float timeBetweenWaves = 20f;

    private float countdown = 5f;

    [SerializeField]
    private TextMeshProUGUI waveCountdownTimer;

    private int waveIndex = 0;
  

    void Update()
    {
        if (countdown <=0)
            {
                StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;
            }
        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownTimer.text = string.Format("{0:00,00}", countdown);
    }
    IEnumerator SpawnWave()
    {
        waveIndex++;
        PlayerStats.rounds++;

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
