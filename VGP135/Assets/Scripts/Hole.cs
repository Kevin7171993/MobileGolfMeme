using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject text;
    UnityEngine.UI.Text mText;
    // Start is called before the first frame update
    void Start()
    {
        mText = text.GetComponent<UnityEngine.UI.Text>();
        mText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            mText.enabled = true;
        }
    }
}
