using UnityEngine;
using System.Collections;

public class explosion_disappear : MonoBehaviour
{
	public float lifeTime = 1f;
    public GameObject explosion;
	void Awake()
    {
        Destroy(explosion, lifeTime);
    }
}
