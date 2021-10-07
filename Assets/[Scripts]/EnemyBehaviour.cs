using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [Header("Enemy Movement")]
    public Bounds movementBounds;

    public Bounds StartingRange;

    private float StartingPoint;
    private float RandomSpeed;

    // Start is called before the first frame update
    void Start()
    {
        RandomSpeed = Random.Range(movementBounds.Min, movementBounds.Max);
        StartingPoint = Random.Range(StartingRange.Min, StartingRange.Max);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time, RandomSpeed) + StartingPoint, transform.position.y);
    }
}
