using System;
using UnityEngine;

namespace Coffee
{
    [Serializable]
    public class CoffeeItem
    {
        [field: SerializeField] public int ID;
        [field: SerializeField] public GameObject prefab;
        [field: SerializeField] public int price;
    }
}

