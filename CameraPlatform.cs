using UnityEngine;


public class CameraPlatform : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    public float smoothSpeed = 0.125f;
    public float rotationDamping = 2.5f;


    private void Start()
    {
        if (target == null)
        {
            //Checking once here is better than every Update()/LateUpdate()
            throw new System.ArgumentException("TARGET cannot be null", "original");
        }

        offset = transform.position - target.transform.position;
    }

    private void LateUpdate()
    {
        try
        {
            transform.position = Vector3.Lerp(transform.position, target.transform.position + (-target.transform.forward * offset.magnitude), smoothSpeed);

            transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, Time.deltaTime * rotationDamping);
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}
