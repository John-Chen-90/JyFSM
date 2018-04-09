using JyFSM.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class TestMono : MonoBehaviour
{
    private Player _player;
    private void Awake()
    {
        _player = new Player();
    }

    private void Start()
    {

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _player.KeyBoard = "A";
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _player.KeyBoard = "D";
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _player.KeyBoard = "W";
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _player.KeyBoard = "S";
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _player.KeyBoard = "Space";
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            _player.KeyBoard = "F";
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _player.KeyBoard = "";
        }


        _player.Update(Time.deltaTime);
    }
}

