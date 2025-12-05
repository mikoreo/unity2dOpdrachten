
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private List<Transform> _coinSpawnLocation = new List<Transform>();
    
    void Start()
    {
        foreach (Transform location in _coinSpawnLocation)
        {
            Instantiate(_coinPrefab, location.position, location.rotation);
        }
        
    }

    
    void Update()
    {
        
    }
}
