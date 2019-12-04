using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackGround : MonoBehaviour
{

    public float speed = 0;
    public GameObject BackGround;

    private Vector3 coinBasGauche;
    private Vector3 coinBasDroit;
    private Vector3 coinHautGauche;
    private Vector3 coinHautDroit;
    private float borderLeft;
    private float borderRight;

    // Start is called before the first frame update
    void Start()
    {
        coinBasGauche = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        coinBasDroit = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        coinHautGauche = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        coinHautDroit = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        borderRight = coinHautDroit.x;
        borderLeft = coinHautGauche.x;

        

    }

    // Update is called once per frame
    void Update()
    {
        BackGround.transform.position = new Vector3(BackGround.transform.position.x - (Time.deltaTime * speed),
                                            BackGround.transform.position.y,
                                            BackGround.transform.position.z);

        if (BackGround.transform.position.x < borderLeft)
        {
            BackGround.transform.position = new Vector3(borderRight,
                                            BackGround.transform.position.y,
                                            BackGround.transform.position.z);
        }
    }
}
