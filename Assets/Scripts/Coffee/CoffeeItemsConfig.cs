using UnityEngine;

namespace Coffee
{
    [CreateAssetMenu(fileName = "CoffeeItemsConfig", menuName = "CoffeeItemsConfig", order = 0)]
    public class CoffeeItemsConfig : ScriptableObject
    {
        public CoffeeItem[] CoffeeItems;
    }
}
    