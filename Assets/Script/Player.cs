using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int score = 0;

    public void AddScore(int value)
    {
        score += value;
    }
}
