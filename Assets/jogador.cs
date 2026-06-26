using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour

{
    public float velocidade = 5f;

    void Update()
    {
        float movimentoX = Input.GetAxis("Horizontal");
        float movimentoZ = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(movimentoX, 0f, movimentoZ);

        transform.Translate(movimento * velocidade * Time.deltaTime, Space.World);
    }
}