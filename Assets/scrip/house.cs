using UnityEngine;
public class house : MonoBehaviour
{
    move moves;
    public hp hps;
    public int Inputdamage;
    [SerializeField]

    private void OnTriggerEnter(Collider boxCollider)
    {
        if (boxCollider.CompareTag("Player"))
        {
            moves = boxCollider.GetComponent<move>();
            InvokeRepeating("damageCar", 0, 0.1f);
        }
    }

    private void OnTriggerExit(Collider boxCollider)
    {
        if (boxCollider.CompareTag("Player"))
        {
            moves = null;
            CancelInvoke("damageCar");
        }
    }
    void damageCar()
    {
        int damage = Inputdamage;
        moves.takeDame(damage);
    }
}
