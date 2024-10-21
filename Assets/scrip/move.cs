using UnityEngine;

public class move : MonoBehaviour
{
    public hp hps;
    public float moveSpeed = 5f;
    [SerializeField]

    public int maxHp = 100;
    [SerializeField]

    Vector3 moveInput;

    public int nowHp;
    [SerializeField]


    private void Start()
    {
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
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.z = Input.GetAxis("Vertical");
        transform.position += moveInput * moveSpeed * Time.deltaTime;
        // if (moveInput.z != 0)
        // {
        //     if (moveInput.z > 0)
        //     {
        //         transform.localRotation = Quaternion.Euler(0, 0, 0);
        //     }
        //     else
        //     {
        //         transform.localRotation = Quaternion.Euler(0, 180, 0);
        //     }
        // }
        // if (moveInput.x != 0)
        // {
        //     if (moveInput.x > 0)
        //     {
        //         transform.localRotation = Quaternion.Euler(0, 90, 0);
        //     }
        //     else
        //     {
        //         transform.localRotation = Quaternion.Euler(0, 270, 0);
        //     }
        // }
    }

}
