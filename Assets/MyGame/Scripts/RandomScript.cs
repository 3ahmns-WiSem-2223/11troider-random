
using UnityEngine;

public class RandomScript : MonoBehaviour
{
    [SerializeField] Color farbe;

    private void Start()
    {
        float zahl = Random.value;
        Debug.Log(zahl);

        transform.position = Random.insideUnitSphere * 3;

        farbe = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
        GetComponent<Renderer>().material.color = farbe;

    }

}
