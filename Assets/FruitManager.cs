using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{

    public int fruitCount;
    public TMP_Text fruitText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fruitText.text = fruitCount.ToString() + "/3";
    }
}
