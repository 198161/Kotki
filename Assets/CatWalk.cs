using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatWalk : MonoBehaviour {

    public Rigidbody2D rb;


    public float minSpeed = 4f;
    public float maxSpeed = 14f;
    public float MaxUpPos;
    public float MaxDownPos;
	public float MaxUpPos2;
    public float MaxDownPos2;
    public int licz = 5;

    float speed = 1f;

     void Start()
    {
       //  speed = Random.Range(minSpeed, 14f);
       // speed = 1f;
    }
    Vector3 direction = Vector3.up;

    void FixedUpdate()
    {
        transform.position += direction * Time.deltaTime * speed;
	if (CatSpa.randomIndex < 2){
        if (transform.position.y >= MaxUpPos)
        {
            direction = Vector3.down;
            GameControlScript.health -= 1;
             }
      if ( Score.scoreValue > licz)
        {
            speed += 0.2f;
            licz += 5;
        }

        if (transform.position.y <= MaxDownPos)
            Destroy(gameObject);

}
	else 
		if (CatSpa.randomIndex >=2)
		{ 
	if (transform.position.y >= MaxUpPos2)
        {
            direction = Vector3.down;
            GameControlScript.health -= 1;
             }
      if ( Score.scoreValue > licz)
        {
            speed += 0.2f;
            licz += 5;
        }

        if (transform.position.y <= MaxDownPos2)
            Destroy(gameObject);
}

      //  Debug.Log(transform.position.y);
    }


    void OnMouseDown()
   {

        if (direction == Vector3.up)
        {
            Score.scoreValue += 1;
            var audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        };
                
        direction = Vector3.down;

       

    }
}
