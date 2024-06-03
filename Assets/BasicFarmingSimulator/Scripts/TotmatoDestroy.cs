using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotmatoDestroy : MonoBehaviour
{
    private UIManager uiManager;

    public int pointValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // UI manager handle
        uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Harvester")
        {
            Destroy(gameObject);
            uiManager.UpdateScore(pointValue);
        }
    }
}
