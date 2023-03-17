using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    internal static object main;
    public Transform player;
    public Vector3 offset;

    private void Update()
    {
        player.position = new Vector3(transform.position.x, Mathf.Clamp(player.position.y, -160f, 160f), transform.position.z);


        Vector3 position = transform.position;
         position.y = (player.position + offset).y;
         transform.position = position;
    }

}
