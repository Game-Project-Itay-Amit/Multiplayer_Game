using Photon.Pun;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShieldManager : MonoBehaviourPunCallbacks, IPunObservable
{
    private bool isShieldInGame = true, enterIf = true;
    public GameObject shield;

    public string triggeringTag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enterIf && !isShieldInGame){
            shield.SetActive(false);
            enterIf = false;
        }
        if(!enterIf && isShieldInGame){
            shield.SetActive(true);
            enterIf = true;
        }
    }

    public void OnTriggerEnter(Collider other)
        {
            if (other.tag == triggeringTag && photonView.IsMine)
            {
                shield.SetActive(false);
                isShieldInGame = false;
            }
        }


    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            // We own this player: send the others our data
            stream.SendNext(this.isShieldInGame);
        }
        else
        {
            // Network player, receive data
            this.isShieldInGame = (bool) stream.ReceiveNext();
        }
    }
}
