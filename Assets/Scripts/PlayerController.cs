using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5.0f;
    public float worldBorder = 100f;
    public int totalTargets, score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody>();
        totalTargets = GameObject.FindGameObjectsWithTag("target").Length;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(h, 0f, 0f);

        transform.Translate(movement * Time.deltaTime * 10f);

        if (Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.Space))
        {
            if (GameManager.instance.isDebugMode == false)
            {
                if (rb.velocity.y == 0f)
                {
                    rb.AddForce(new Vector3(0f, 1f, 0f) * 350);
                }
            } else
            {
                rb.AddForce(new Vector3(0f, 1f, 0f) * 350);
            }
        }
        if (transform.localPosition.x < -worldBorder || transform.localPosition.x > worldBorder) {
            if (transform.localPosition.x < -worldBorder)
            {
                transform.localPosition = new Vector3(-worldBorder, transform.localPosition.y, transform.localPosition.z);
            } else
            {
                transform.localPosition = new Vector3(worldBorder, transform.localPosition.y, transform.localPosition.z);

            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("target"))
        {
            Destroy(other.gameObject);

            score++;
            if (score == totalTargets)
            {
                GameObject.Find("Timer").GetComponent<TimerManager>().isClearStage = true;

                GameManager.instance.timeRecord +=
                GameObject.Find("Timer").GetComponent<TimerManager>().TimeRecordedInstance;


                GameManager.instance.LoadNextSceneLateTime(2f);
            }
        }
    }

}
