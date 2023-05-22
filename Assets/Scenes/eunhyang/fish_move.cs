using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_move : MonoBehaviour
{

    private float speed = 1.0f;
    private Transform myTransform = null;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        position = myTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // float moveAmount = Speed * Time.deltaTime;
        //myTransform.Translate(Vector3.forward*moveAmount);

        //myTransform.Translate(Vector3.forward +(1.0f* Time.deltaTime));
        /*myTransform.position.x += 1.0f * Time.deltaTime;
        myTransform.position.y += 1.0f * Time.deltaTime;
        myTransform.position.z += 1.0f * Time.deltaTime;*/

        /*Vector3 move = new Vector3(1,0, 1).normalized * speed * Time.deltaTime;
        myTransform.position += move;*/

        float move = speed * Time.deltaTime;
        position.x += move;
        position.z += move;

        myTransform.position = position;



        //myTransform.position = new Vector3(Random.Range(-1.0f, 7.0f), Random.Range(-1.0f, 0), Random.Range(-8.0f, 3.0f));
        if ((myTransform.position.x >=49.0f || myTransform.position.x <=-49.0f) || (myTransform.position.z >= 49.0f || myTransform.position.z <=-49.0f )) 
        {
            //myTransform.position = new Vector3(Random.Range(-1.0f, 7.0f), -1.017f, Random.Range(-8.0f, 3.0f));
            position.x = Random.Range(-30.0f, 30.0f);
            position.z = Random.Range(-30.0f, 30.0f);
        }

        /*if (myTransform.position.y >= 0) || myTransform.position.x >= 7.0f|| myTransform.position.z >= 3.0f )
        {
            //myTransform.position = new Vector3(Random.Range(-30.0f, 30.0f), -1.017f, Random.Range(-30.0f, 30.0f));
        }*/
    }

    
}
