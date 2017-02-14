using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
        Rigidbody2D rigibBody;
        public float speed;
        Vector3 pos;
        float playerBoundRadius = 0.7f;
    public Camera playerCam;

    void Start()
     {
        rigibBody = GetComponent<Rigidbody2D>();
     }

     void FixedUpdate()
     {
        var mousePosition = playerCam.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        rigibBody.angularVelocity = 0;


        transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime;

        pos = transform.position;

        //Boundaries
        if (pos.y + playerBoundRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - playerBoundRadius;
        }
        if (pos.y - playerBoundRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + playerBoundRadius;
        }
        /*
        //Camera X size
        float w = Screen.width;
        float h = Screen.height;
        float screenRatio = w / h;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        if (pos.x + playerBoundRadius > widthOrtho)
        {
            pos.x = widthOrtho - playerBoundRadius;
        }
        if (pos.x - playerBoundRadius < -widthOrtho)
        {
            pos.x = -widthOrtho + playerBoundRadius;
        }
        */
        transform.position = pos;
        
    }
    }