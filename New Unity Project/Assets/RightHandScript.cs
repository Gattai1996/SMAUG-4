using UnityEngine;

public class RightHandScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float firePerSecond = 10f;

    public Camera fpsCamRight;

    private float fireDelay = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= fireDelay)
        {
            fireDelay = Time.time + 1f / firePerSecond;
            RightShoot();
        }
    }

    void RightShoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCamRight.transform.position, fpsCamRight.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            GolemDamageScript golem = hit.transform.GetComponent<GolemDamageScript>();
            if(golem != null)
            {
                golem.TakeDamage(damage);
            }
        }
    }
}
