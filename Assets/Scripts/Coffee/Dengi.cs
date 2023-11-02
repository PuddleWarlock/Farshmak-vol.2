using TMPro;
using UnityEngine;

namespace Coffee
{
    public class Dengi : MonoBehaviour
    {
        [SerializeField] private TextMeshPro moneyText;
        private int money;
    
        public void PlusMoney(int value)
        {
            money += value;
            moneyText.text = "Деньги: " + money.ToString();
        }
        public void MinusMoney(int value)
        {
            money -= value;
            moneyText.text = money.ToString();
        }
    }
}
