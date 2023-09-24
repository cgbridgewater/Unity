using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconSpawn : MonoBehaviour
{
    // serializing a field tells it to show up in my inspector as something I can fill in
    [SerializeField]
    private GameObject prefabToSpawn;
    // The interval at which the spawn happens
    [SerializeField]
    private float spawnInterval;
    // set ranges of left and right edges to drop icon objects
    private float minX = -7.0f; 
    private float maxX = 7.5f;
    // Create a sprite array
    [SerializeField]
    private Sprite[] simpsons;

    // Start is called before the first frame update
    void Start()
    {
        // Invoke the IconSpawn method at a particular interval
        InvokeRepeating("iconSpawn", this.spawnInterval, this.spawnInterval*.8f);
    }
    // method to create an icon object
    private void iconSpawn()
    {
        // Create a new Icon
        GameObject newObject = Instantiate(this.prefabToSpawn);
        // Then Set the Icon location
        newObject.transform.position = new Vector2(Random.Range(this.minX, this.maxX), 5);
        // Tell it to use a random sprite
        Sprite objectSprite = simpsons[Random.Range(0,this.simpsons.Length)];
        newObject.GetComponent<SpriteRenderer>().sprite = objectSprite;
    }
}