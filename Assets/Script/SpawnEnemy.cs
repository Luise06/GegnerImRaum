using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemyObjekt;
    [SerializeField] private float spawnTimeMin = 4f;
    [SerializeField] private float spawnTimeMax = 10f;
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private Material enemyMaterial;
    [Header("Enemy Levels")]
    [SerializeField] private int[] killScores;
    [SerializeField] private int[] startHealthValues;
    [SerializeField] private Material[] enemyMaterials;
    //[SerializeField] private GameObject shootableObjekt;
    private int startIndex = 0;

    private Vector3 spawnPosition;
    private bool waitActive;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!waitActive)
        {
            StartCoroutine(RandomWait());
        }
    }

    private void Spawn()
    {
        int index = Random.Range(startIndex, 3);
        spawnPosition = spawnPoints[index].transform.position;
        GameObject spawnEnemy = Instantiate(enemyObjekt, spawnPosition, Quaternion.identity);
        ShootableBox shootableBox = spawnEnemy.GetComponent<ShootableBox>();
        shootableBox.killScore = 1;
        shootableBox.currentHealth = 3;
        spawnEnemy.GetComponent<MeshRenderer>().material = enemyMaterial;
        /*Shoot shootScript = spawnEnemy.GetComponent<Shoot>();
        shootScript.killScore = 10;
        shootScript.currentHealth = 30;*/
    }
    private IEnumerator RandomWait()
    {
        waitActive = true;
        yield return new WaitForSeconds(Random.Range(spawnTimeMin,spawnTimeMax));
        Spawn();
        waitActive = false;
    }

    public void SpawnPointDelete()
    {
        startIndex = 1;
        spawnPoints.RemoveAt(0);
    }
}
