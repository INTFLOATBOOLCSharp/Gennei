using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class People : MonoBehaviour
{
    public Transform Player;
    public Fungus.Flowchart flowchart = null;
    public string SMessage;
    GameObject PlayerOBJ;
    PlayerOperation player;

    private void Start()
    {
        PlayerOBJ = GameObject.Find("Player");
        player = PlayerOBJ.GetComponent<PlayerOperation>();
        flowchart = GetComponent<Flowchart>();
    }

    void Update()
    {
        Vector3 targetPos = transform.position;
        targetPos.z = transform.position.z;
        transform.LookAt(targetPos);
        float distance = Vector3.Distance(transform.position, Player.position);

        if(PlayerOperation.stopf == 1) {
            if (distance < 1)
            {
                    StartCoroutine(Talk());
            }
        }
    }

    IEnumerator Talk()
    {
        player.SetState(PlayerOperation.State.IsTalk);

        flowchart.SendFungusMessage(SMessage);
        yield return new WaitUntil(() => flowchart.GetExecutingBlocks().Count == 0);

        player.SetState(PlayerOperation.State.Normal);
    }
}
