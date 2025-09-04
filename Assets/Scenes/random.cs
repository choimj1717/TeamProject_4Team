using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private Transform spawnPoint;

    private GameObject currentBlock;

    public void SpawnRandom()
    {
        if (prefabs.Length > 0 && spawnPoint != null)
        {
            if (currentBlock != null)
            {
                // Ensure old block is disabled before spawning new one
                if (currentBlock.GetComponent<land>() != null && currentBlock.GetComponent<land>().enabled)
                {
                    return;
                }
            }

            int index = Random.Range(0, prefabs.Length);
            currentBlock = Instantiate(prefabs[index], spawnPoint.position, Quaternion.identity);
        }
    }

    void Start()
    {
        SpawnRandom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
