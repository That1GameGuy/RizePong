using Unity.Netcode;
using UnityEngine;
using System.Collections;

public class GameManager : NetworkBehaviour
{
  public NetworkVariable<int> player1Score = new NetworkVariable<int>(0);
  public NetworkVariable<int> player2Score = new NetworkVariable<int>(0);
    
  public void AddPlayer1Score()
  {
    //if (IsServer)
    //{
      player1Score.Value++;
      CheckWinCondition();
      Debug.Log("Player 1 Score!");
    //}
  }
    
  public void AddPlayer2Score()
  {
    //if (IsServer)
    //{
      player2Score.Value++;
      CheckWinCondition();
      Debug.Log("Player 2 Score!");
    //}
  }
    
  void CheckWinCondition()
  {
    
  }
  /*
  [SerializeField] private NetworkObject paddle;
  [SerializeField] private NetworkObject paddle1;

  void Start(){
    if (IsServer){
        StartCoroutine(AssignOwnershipAfterSpawn());
    }
  }
  private IEnumerator AssignOwnershipAfterSpawn(){
    yield return new WaitForSeconds(1f);

    if (paddle != null && paddle.IsSpawned){
        paddle.ChangeOwnership(NetworkManager.ServerClientid);
    }
    NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnected;
  }

  private void OnClientConnected(ulong clientid){
    if (!IsServer) return;

    if (clientid == NetworkManager.ServerClientid) return;

    StartCoroutine(AssignPaddle1ToClient(clientid));
  }

  private IEnumerator AssignPaddle1ToClient(ulong clientid){
    yield return new WaitForSeconds(0.5f);

    if (paddle1 != null && paddle1.IsSpawned){
        paddle1.ChangeOwnership(clientid);
    }
  }
  */
}