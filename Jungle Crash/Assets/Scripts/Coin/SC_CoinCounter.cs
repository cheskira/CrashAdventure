using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_CoinCounter : MonoBehaviour
{
    [SerializeField] private Text counterText;  // Utiliser SerializeField pour attribuer via l'inspecteur

    // Start is called before the first frame update
    void Start()
    {
        if(counterText == null)
        {
            Debug.LogError("CounterText is not assigned.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Set the current number of coins to display
        if(counterText != null && counterText.text != SC_2DCoin.totalCoins.ToString())
        {
            counterText.text = SC_2DCoin.totalCoins.ToString();
        }
    }
}
