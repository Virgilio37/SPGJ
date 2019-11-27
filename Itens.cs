using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Itens : MonoBehaviour
{
    [SerializeField]
    Text legenda;
    [SerializeField]
    string conteudo;
    [SerializeField]
    GameObject Descricao;
    [SerializeField]
    string textoDescricao;
    // Start is called before the first frame update
    void Start()
    {
        //Começa o jogo com os textos desativados ou apagados
        legenda.text = "";
        Descricao.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Ativa a descrição quando o personagem está sobre o objeto e com a tecla x pressionada
        if (legenda.text != "" && Input.GetKey(KeyCode.X))
            Descricao.SetActive(true);
        else
            Descricao.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Coloca uma legenda com o nome do objeto quando o jogador para por ele
        if (collision.gameObject.tag == "Player")
            legenda.text = conteudo;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Apaga a legenda quando o jogador sai de cima do objeto
        if (collision.gameObject.tag == "Player")
            legenda.text = "";
    }
}
