using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float tocDoXe = 100f; // Tốc độ mặc định
    private float currentSpeed; // Tốc độ hiện tại của xe
    [SerializeField]
    private float lucReXe = 100f;
    [SerializeField]
    private float lucPhanhXe = 50f;
    [SerializeField]
    private GameObject hieuUngPhanh;

    private float dauVaoDiChuyen;
    private float dauVaoRe;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = tocDoXe; 
    }

    private void FixedUpdate()
    {
        dauVaoDiChuyen = Input.GetAxis("Vertical");
        DiChuyenXe();
        dauVaoRe = Input.GetAxis("Horizontal");
        ReXe();
        if (dauVaoDiChuyen > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            PhanhXe();
        }
    }

    private void DiChuyenXe()
    {
        //Debug.Log("Current Speed: " + currentSpeed);
        rb.AddRelativeForce(Vector3.forward * dauVaoDiChuyen * currentSpeed); 
        hieuUngPhanh.SetActive(false);
    }

    private void ReXe()
    {
        Quaternion re = Quaternion.Euler(Vector3.up * dauVaoRe * lucReXe * Time.deltaTime);
        rb.MoveRotation(rb.rotation * re);
    }

    private void PhanhXe()
    {
        if (rb.velocity.z != 0)
        {
            rb.AddRelativeForce(-Vector3.forward * lucPhanhXe);
            hieuUngPhanh.SetActive(true);
        }
    }

    public void ThayDoiTocDo(float tocDo)
    {
        currentSpeed += tocDo; // Cập nhật tốc độ hiện tại
    }
}