using System;
using TMPro;
using UnityEngine;
using Random = Unity.Mathematics.Random;

namespace Coffee
{
    public class PeopleController : MonoBehaviour
    {
        [SerializeField] private GameObject _humanPrefab;
        [SerializeField] private Transform _spawnPoint;
        public int wantedCoffee { get; private set; }
        private GameObject humanInstance;
        private Random rnd;

        private void Start()
        {
            rnd = new Random((uint)DateTime.Now.Millisecond);
            SpawnHuman();
        }

        private void SpawnHuman()
        {
            humanInstance = Instantiate(_humanPrefab, _spawnPoint.position, Quaternion.identity);
            humanInstance.transform.rotation = Quaternion.Euler(0, -90, 0);
            wantedCoffee = rnd.NextInt(1,3);
            humanInstance.GetComponentInChildren<TextMeshPro>().text = "Coffee "+ wantedCoffee.ToString();
        }

        public void DestroyHuman()
        {
            Destroy(humanInstance);
            SpawnHuman();
        }
    }
}
