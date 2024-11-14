using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingObjects : MonoBehaviour
{
    [SerializeField]
    private GameObject ballPrefab;

    // Start is called before the first frame update
    void Start()
    {

        // Ex 1
        //Vector3 startPosition = new Vector3(4, 0, 7);
        //GameObject ob = Instantiate(ballPrefab, startPosition, Quaternion.identity);
        //ob.SetActive(false);

        // Ex 2
        StartCoroutine(GenerateBalls());

    }

    private IEnumerator GenerateBalls() {

        while (true) {

            Vector3 startPosition = new Vector3(
                Random.Range(-5, 5),
                0.0f,
                Random.Range(-5, 5));

            GameObject ob = Instantiate(ballPrefab, startPosition, Quaternion.identity);

            Destroy(ob, 2);

            yield return new WaitForSeconds(0.7f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
