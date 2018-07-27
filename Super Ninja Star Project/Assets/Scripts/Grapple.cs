﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple : MonoBehaviour
{

    public LineRenderer line;
    SpringJoint2D joint;
    Vector3 targetPos;
    RaycastHit2D hit;
    public float distance = 10f;
    public LayerMask mask;
    public bool tethered;
    Movement playerMovement;

    // Use this for initialization
    void Start()
    {
        playerMovement = GetComponent<Movement>();
        joint = GetComponent<SpringJoint2D>();
        joint.enabled = false;
        line.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPos.z = 0;

            hit = Physics2D.Raycast(transform.position, targetPos - transform.position, distance, mask);

            if(hit.collider!=null && hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
            {
                joint.enabled = true;
                joint.connectedAnchor = hit.point;
                joint.distance = Vector2.Distance(transform.position, hit.point);

                line.enabled = true;
                line.SetPosition(0, transform.position);
                line.SetPosition(1, hit.point);
                tethered = true;
                playerMovement.timesJumped = 0;
            }
        }

        line.SetPosition(0, transform.position);

        if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Space))
        {
            Detatch();
        }
        if (gameObject.transform.position.y > hit.point.y)
        {
            Detatch();
        }
    }

    public void Detatch()
    {
        joint.enabled = false;
        line.enabled = false;
        tethered = false;
    }
}
