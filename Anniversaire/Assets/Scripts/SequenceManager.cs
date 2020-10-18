using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SequenceManager : MonoBehaviour
{
    public Animator anim;

    [Header("Chats")]
    public GameObject chat;
    public GameObject trex;
    public Transform chatsPosition;
    public float chatsSpeed;
    public int nombreDeChats;
    public float tempsEntreChats;
    public float rotationParChat;

    [Header("Textes")]
    public TextMeshPro text;
    public List<string> texts = new List<string>();
    public float timeBetweenLetters;
    private int index;

    public void Write()
    {
        StartCoroutine(TextByLetterWriter.WriteText(text, texts[index], timeBetweenLetters));
        index++;
    }

    public void Clear()
    {
        text.text = "";
    }

    public void Fade()
    {
        anim.SetTrigger("Fade");
    }

    public void SpawnCats()
    {
        StartCoroutine("Chatons");
    }

    public void SpawnRex()
    {
        StartCoroutine("TREX");
    }

    private IEnumerator TREX()
    {
        float baseRotation = 0;
        for (int i = 0; i < nombreDeChats; i++)
        {
            GameObject newChat = Instantiate(trex, chatsPosition);
            Movement chatMovement = newChat.GetComponent<Movement>();
            chatMovement.speed = chatsSpeed;
            chatMovement.transform.Rotate(Vector3.forward, baseRotation);
            baseRotation += rotationParChat;
            yield return new WaitForSeconds(tempsEntreChats);
        }
    }

    private IEnumerator Chatons()
    {
        float baseRotation = 0;
        for (int i = 0; i < nombreDeChats; i++)
        {
            GameObject newChat = Instantiate(chat, chatsPosition);
            Movement chatMovement = newChat.GetComponent<Movement>();
            chatMovement.speed = chatsSpeed;
            chatMovement.transform.Rotate(Vector3.forward, baseRotation);
            baseRotation += rotationParChat;
            yield return new WaitForSeconds(tempsEntreChats);
        }
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 3;
        }
        else
            Time.timeScale = 1;

        if (Input.GetKeyDown(KeyCode.A))
            SpawnCats();

        if (Input.GetKeyDown(KeyCode.B))
            SpawnRex();
    }
}
