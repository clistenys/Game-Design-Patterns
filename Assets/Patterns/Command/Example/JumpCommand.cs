using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Command.Example
{
    public class JumpCommand : ICommand
    {
        // The Player is the receiver of the commands
        private Player _player;

        // The Player is passed as a parameter to JumpCommand knows which Player object
        // should perform the jump action when the command is triggered.
        public JumpCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Jump();
        }
    }
}

