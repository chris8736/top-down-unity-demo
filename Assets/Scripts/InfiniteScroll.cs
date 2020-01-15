
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScroll : MonoBehaviour
{
    public Transform playerTransform;
    public Transform bottomGround;
    public Transform topGround;

    //update is called every frame; tracks player position and scrolls
    void Update()
    {
        //bottomGround (bottom) must swap up if player is above
        if (playerTransform.position.y > 28 + bottomGround.position.y)
        {
            bottomGround.transform.position = new Vector3(0, bottomGround.transform.position.y + 44, 0);
            SwapGround();
        }
        //topGround (top) must swap down if player is below
        if (playerTransform.position.y < -16 + topGround.position.y)
        {
            topGround.transform.position = new Vector3(0, topGround.position.y - 44, 0);
            SwapGround();
        }
    }

    //swaps transform references if needed
    void SwapGround()
    {
        Transform tmp = bottomGround;
        bottomGround = topGround;
        topGround = tmp;
    }
}
