using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    //  Variables used to access prefab and start position
    public Rigidbody foodPrefab;
    public Transform startPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  Instantiate object when user presses "Fire2" button
        if(Input.GetButtonDown("Fire2"))
        {
            Rigidbody newInstance;

            newInstance = Instantiate(foodPrefab, startPosition.position, startPosition.rotation);

            newInstance.AddForce(startPosition.forward * 50);
        }
    }
}
