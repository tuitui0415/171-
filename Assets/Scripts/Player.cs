using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum ROW {Row1, Row2, Row3, Row4, Row5 }
public class Player : MonoBehaviour
{
    public ROW m_Row = ROW.Row3;
    float NewXpos = 0f;
    public bool SwipeLeft;
    public bool SwipeRight;
    public float XValue = 0;
    private CharacterController m_character;
    // Start is called before the first frame update
    void Start()
    {
        m_character = GetComponent<CharacterController>();
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Movement()
    {
        SwipeLeft = Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
        SwipeRight = Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);
        if (SwipeLeft)
        {
            if (m_Row == ROW.Row3)
            {
                NewXpos = XValue;
            }

        }
    }
}
