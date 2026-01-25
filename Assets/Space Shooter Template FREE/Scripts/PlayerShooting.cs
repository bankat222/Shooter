using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public static PlayerShooting instance;

    public GameObject bulletPrefabs;
    public float shootingInterval = 0.2f;
    public int weaponPower = 1; 
    public int maxweaponPower = 3;
    private float lastBulletTime;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    public void ShootBullet()
    {
        Instantiate(bulletPrefabs, transform.position, transform.rotation);
    }

    public void AddWeapon()
    {
        Debug.Log("Bonus collected");
    }
}
