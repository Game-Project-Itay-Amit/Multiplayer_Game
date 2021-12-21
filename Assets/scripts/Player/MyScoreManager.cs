using Photon.Pun;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;



public class MyScoreManager : MonoBehaviourPunCallbacks, IPunObservable
{   
    public GameObject LaserBeam;
    public string enemyTriggeringTag;
    public Text score;
    private int currScore = 0;

    // private MyScoreManager

    // Start is called before the first frame update
    void Start()
    {
        // score = gameObject.GetComponent<Text>();
        score.text = "Score: " + currScore;        
    }

    // Update is called once per frame
    void Update()
    {
        // score.text = "Score: " + currScore;
        // currScore = PlayerPrefs.GetInt("TOTALSCORE"); 
        // PlayerPrefs.SetInt("SHOWSTARTSCORE",currScore); 
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == enemyTriggeringTag && photonView.IsMine)
        {
            currScore += 10;
            score.text = "Score: " + currScore;
            Debug.Log("Added score");
        }
    }

    #region IPunObservable implementation

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            // We own this player: send the others our data

        }
        else
        {
            // Network player, receive data

        }
    }

    #endregion
}
