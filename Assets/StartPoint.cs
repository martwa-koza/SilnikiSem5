using UnityEngine;

public class StartPoint : Checkpoint
{
    private void Start()
    {
        GameObject player = GameObject.Find("Player");
        player.transform.position = transform.position;
    }
}
