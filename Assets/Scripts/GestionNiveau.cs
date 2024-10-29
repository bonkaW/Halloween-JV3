using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionNiveau : MonoBehaviour
{
    [SerializeField] private InfosJoueur _infosJoueur;
    [SerializeField] private TMP_Text _compteurObjets;

    void Start()
    {
        _infosJoueur.nbObjets = 0;
    }

    void Update()
    {
        _compteurObjets.text = _infosJoueur.nbObjets.ToString();
    }
}
