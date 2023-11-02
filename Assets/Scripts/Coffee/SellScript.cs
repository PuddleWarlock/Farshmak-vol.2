using System;
using System.Collections;
using System.Collections.Generic;
using Coffee;
using UnityEngine;

public class SellScript : MonoBehaviour
{
    [SerializeField] private int price;
    private Dengi dengi;
    private int wantedCoffee;

    private void Start()
    {
        dengi = FindObjectOfType<Dengi>();
        wantedCoffee = FindObjectOfType<PeopleController>().wantedCoffee;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (wantedCoffee * 10 != price) return;
        dengi.PlusMoney(price);
        FindObjectOfType<PeopleController>().DestroyHuman();
        Destroy(gameObject);
    }
}
