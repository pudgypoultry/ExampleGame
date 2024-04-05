using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible1 : MonoBehaviour
{
    public int pointValue = 10;

    public virtual void CollectMe(MyPlayerController5 thePlayer)
    {
        thePlayer.score += pointValue;
        Object.Destroy(this.gameObject);
    }
}
