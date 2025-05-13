using UnityEngine;
using CI.HttpClient;
using System;


public class GroqClient : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    [SerializeField]
    private string apiKey;

    private HttpClient client;

    private void Awake()
    {
        client = new HttpClient();
        client.Headers.Add("Authorization", $"Bearer {apiKey}");
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
