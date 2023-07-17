using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Command.Example
{
    public class ShootCommand : ICommand
    {
        private Player _player;

        public ShootCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Shoot();
        }
    }
}
