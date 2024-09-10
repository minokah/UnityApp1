using UnityEngine;

public class Observer : MonoBehaviour
{
    bool m_IsPlayerInRange;
    public GameObject player;
    public GameEnding gameEnding;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position + Vector3.up;
        Ray ray = new Ray(transform.position, direction);
        RaycastHit raycastHit;

        if (m_IsPlayerInRange && Physics.Raycast(ray, out raycastHit))
        {
            if (raycastHit.collider.transform == player.transform)
            {
                gameEnding.SetPlayerCaught(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerInRange = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerInRange = false;
        }
    }
}
