using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class CoinCounterscript : MonoBehaviour
{
    public UnityEvent collectedreceive;
    public TextMeshProUGUI coinCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinCounter.text = "Coins: " + PlayerPrefs.GetInt("Coins");
    }

    public void onCollection()
    {
        collectedreceive.Invoke();
    }
}
