using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower2D : MonoBehaviour
{
    [SerializeField]
    public GameObject player;

    [SerializeField]
     float timeOffset = 3;

    [SerializeField]
     Vector2 posOffset;

    [SerializeField]
    private Vector3 velocity;

    [SerializeField]
    float leftLimit;
    [SerializeField]
    float rightLimit;
    [SerializeField]
    float bottomLimit;
    [SerializeField]
    float topLimit;



    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        //camera Current Position
        Vector3 startPos = transform.position;

        //Players current Position
        Vector3 endPos = player.transform.position;

        endPos.x += posOffset.x;
        endPos.y += posOffset.y;
        endPos.z += -10;

        //smoothly move the camera toward the player
        transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);

        //Smooth Dampaning v2
        //transform.position = Vector3.Lerp(startPos, endPos, ref velocity, timeOffset);

        transform.position = new Vector3
            (
                Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
                Mathf.Clamp(transform.position.y, bottomLimit, topLimit),
                transform.position.z
            );
    }

    private void OnDrawGizmos()
    {
        //draw a box around our camera boundary
        Gizmos.color = Color.red;
        //top line
        Gizmos.DrawLine(new Vector2(leftLimit, topLimit), new Vector2(rightLimit, topLimit));
        //right line
        Gizmos.DrawLine(new Vector2(rightLimit, topLimit), new Vector2(rightLimit, bottomLimit));
        //bottom line
        Gizmos.DrawLine(new Vector2(rightLimit, bottomLimit), new Vector2(leftLimit, bottomLimit));
        //top line
        Gizmos.DrawLine(new Vector2(leftLimit, bottomLimit), new Vector2(leftLimit, topLimit));
    }
} 
