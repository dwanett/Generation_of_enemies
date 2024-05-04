using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Player _prefabPlayer;
    [SerializeField] private float _delaySpawn;

    public void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(_delaySpawn);
            Player player = Instantiate(_prefabPlayer, transform.position, Quaternion.identity);

            Vector3 directionMove = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
            
            while (directionMove == Vector3.zero)
            {
                directionMove = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
            }
            
            player.SetDirectionMove(directionMove);
        }
    }
}
