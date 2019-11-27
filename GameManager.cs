using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject astronoma;
    [SerializeField]
    private GameObject engenheira;
    [SerializeField]
    private GameObject paleontologo;
    [SerializeField]

    private GameObject sociologo;
    // Start is called before the first frame update
    void Start()
    {
        //Começa o jogo com a astronoma selecionada
        astronoma.SetActive(true);
        engenheira.SetActive(false);
        paleontologo.SetActive(false);
        sociologo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TrocaPersonagem();
    }

    private void TrocaPersonagem()
    {

        //Troca para a astronoma
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            astronoma.SetActive(true);
            engenheira.SetActive(false);
            paleontologo.SetActive(false);
            sociologo.SetActive(false);
        }

        //Troca para a engenheira
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            astronoma.SetActive(false);
            engenheira.SetActive(true);
            paleontologo.SetActive(false);
            sociologo.SetActive(false);
        }

        //Troca para o paleontologo
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            astronoma.SetActive(false);
            engenheira.SetActive(false);
            paleontologo.SetActive(true);
            sociologo.SetActive(false);
        }

        //Troca para o sociologo
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            astronoma.SetActive(false);
            engenheira.SetActive(false);
            paleontologo.SetActive(false);
            sociologo.SetActive(true);
        }
    }
}
