using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;


public class HB_NetworkManager : MonoBehaviour
{
    void OnGUI()
    {
        if (!NetworkManager.Singleton.IsClient && !NetworkManager.Singleton.IsServer)
        {
            StartButtons();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void StartButtons()
    {
        if (GUILayout.Button("Host")) NetworkManager.Singleton.StartHost();
        //if (GUILayout.Button("Client")) NetworkManager.Singleton.StartClient();
        //if (GUILayout.Button("Server")) NetworkManager.Singleton.StartServer();
    }

    public void Disconnect()
    {
        if (NetworkManager.Singleton.IsHost) 
        {
            NetworkManager.Singleton.StopHost();
        }
        else if (NetworkManager.Singleton.IsClient) 
        {
            NetworkManager.Singleton.StopClient();
        }
        else if (NetworkManager.Singleton.IsServer) 
        {
            NetworkManager.Singleton.StopServer();
        }
        
        
    }
}
