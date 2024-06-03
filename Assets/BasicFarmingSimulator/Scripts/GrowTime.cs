using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowTime : MonoBehaviour
{
    public GameObject prefab;

    public float timer;

    bool timeLapse = false;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        // if timer is = 0
        if(timer <= 0 && timeLapse == false)
        {
            timeLapse = true;
            transform.GetChild(0).gameObject.SetActive(false);

            //Instantiate new prefab of grown crop version after timer is less than 0
            GameObject crop = Instantiate(prefab, transform.position, transform.rotation);

            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
