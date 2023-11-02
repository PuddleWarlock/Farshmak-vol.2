using UnityEngine;

namespace Coffee
{
    public class CoffeeSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _coffeePrefab1;
        [SerializeField] private GameObject _coffeePrefab2;
        [SerializeField] private Transform _spawnPos1;
        [SerializeField] private Transform _spawnPos2;

        public void SpawnCoffee1()
        {
            Instantiate(_coffeePrefab1, _spawnPos1.position, Quaternion.identity);
        }
        public void SpawnCoffee2()
        {
            Instantiate(_coffeePrefab2, _spawnPos2.position, Quaternion.identity);
        }
    }
}
