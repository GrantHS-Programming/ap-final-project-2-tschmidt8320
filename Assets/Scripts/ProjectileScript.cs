using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force;
    private float initTime;
    // Start is called before the first frame update
    void Start()
    {
        initTime = Time.timeSinceLevelLoad;
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad - initTime >= 5.0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {

        Destroy(gameObject);
        GameObject player = GameObject.Find("player");
        player.GetComponent<TarodevController.PlayerController>().transform.position += new Vector3(0, 5, 0);
    }
}
