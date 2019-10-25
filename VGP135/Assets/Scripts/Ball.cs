using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float force = 100.0f;
    Vector3 hitDirection;
    Rigidbody rb;
    public bool isDragging = false;
    public GameObject aimer;
    public Transform mball;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mball = transform.Find("Sphere");
        aimer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (mball.gameObject.activeInHierarchy)
        {
            rb.useGravity = true;
            if(isDragging)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {
                    Vector3 groundHitPosition = hit.point;
                    groundHitPosition.y = transform.position.y;
                    hitDirection = (transform.position - groundHitPosition).normalized;

                    aimer.SetActive(true);
                    aimer.transform.forward = hitDirection;
                    aimer.transform.position = transform.position + (hitDirection * 1.5f);
                }
            }
            else
            {
                aimer.SetActive(false);
            }
        }
        else
        {
            rb.useGravity = false;
            rb.Sleep();
        }
    }

    private void OnMouseDown()
    {
        isDragging = true;
        rb.isKinematic = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
        rb.isKinematic = false;
        //hitDirection.y = 0;
        rb.AddForce(hitDirection * force);
    }
}
