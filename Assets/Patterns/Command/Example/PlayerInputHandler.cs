using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Command.Example
{
    public class PlayerInputHandler : MonoBehaviour
    {
        public Player player;

        private ICommand _jumpCommand;
        private ICommand _shootCommand;

        private void Start()
        {
            // Configura os comandos para o InputHandler
            SetJumpCommand(new JumpCommand(player));
            SetShootCommand(new ShootCommand(player));
        }

        public void SetJumpCommand(ICommand command)
        {
            _jumpCommand = command;
        }

        public void SetShootCommand(ICommand command)
        {
            _shootCommand = command;
        }

        private void Update()
        {
            // Exemplo simplificado para detecção de entrada do jogador
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _jumpCommand.Execute();
            }
            else if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                _shootCommand.Execute();
            }
        }
    }
}

