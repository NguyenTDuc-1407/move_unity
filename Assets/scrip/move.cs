using UnityEngine;

public class move : MonoBehaviour
{
    public hp hps;
    [SerializeField]

    public int maxHp = 100;

    public float moveInputz;

    public float moveInputx;
    [SerializeField] public int nowHp;

    private Rigidbody rb;

    float speed = 3f;

    float re = 10f;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        nowHp = maxHp;
        hps.UpdateHp(nowHp, maxHp);
    }

    public void takeDame(int damage)
    {
        nowHp = nowHp - damage;
        if (nowHp < 0)
        {
            nowHp = 0;
        }
        hps.UpdateHp(nowHp, maxHp);
    }
    void Update()
    {
        moveInputx = Input.GetAxis("Horizontal");
        moveInputz = Input.GetAxis("Vertical");
        rb.AddRelativeForce(Vector3.forward * moveInputz * speed);
        Quaternion qa = Quaternion.Euler(Vector3.up * moveInputx * re * Time.deltaTime);
        rb.MoveRotation(rb.rotation*qa);
    }
}
