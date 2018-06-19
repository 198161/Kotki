using UnityEngine;

public class CatMove : MonoBehaviour {



    Vector3 direction = Vector3.up;

    void Update()
    {
        transform.position += direction * Time.deltaTime;



        if (transform.position.y >= -2.250774)
            direction = Vector3.down;


         if (transform.position.y <= -3.456761)
          Destroy(gameObject);


       

        Debug.Log(transform.position.y);

    }
    void OnMouseDown()
    {
        direction = Vector3.down;
        GameControlScript.health -= 1;
    }

}
