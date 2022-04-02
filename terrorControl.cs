using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class terrorControl : MonoBehaviour
{
    static int money = 0;
    static int bullet = 30;
    public GameObject image;
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI bulletText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        bullet=bullet-1;
        bulletText.text=bullet+" bullets";
        money=money+500;
        moneyText.text=moneyText+"$";
        Destroy(gameObject);
        Destroy(image);
    }
}
