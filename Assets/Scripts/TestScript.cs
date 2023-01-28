using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private float _something;
    [SerializeField] private SomeData _data;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

    }

    private void OnTriggerEnter2D(Collider2D other) {
        
    }
}

[System.Serializable]
public class SomeData
{
    public string Name;
    public int Count;
}