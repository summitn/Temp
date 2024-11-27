using Pathfinding;
using UnityEngine;

public class MonsterComponent : MonoBehaviour
{
    private IAstarAI AstarAI { get; set; }

    private void Awake()
    {
        AstarAI = GetComponent<IAstarAI>();
    }

    private void Start()
    {
        StartMove();
    }

    private void StartMove()
    {
        AstarAI.isStopped = false;
        AstarAI.destination = Vector3.zero;
        AstarAI.SearchPath();
    }
}
