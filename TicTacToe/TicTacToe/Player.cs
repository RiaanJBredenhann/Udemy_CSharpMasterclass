using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Player
    {
        private bool _isActive;
        private char _playerCharacter;
        private string _name;
        public Player(string name, bool isActive, char playerCharacter)
        {
            this._name = name;
            this._isActive = isActive;
            this._playerCharacter = playerCharacter;
        }

        public bool IsActive 
        {
            get { return _isActive; } 
            set { _isActive = value; } 
        }

        public string Name 
        { 
            get { return _name; }
        }

        public char PlayerCharacter 
        {
            get { return _playerCharacter; } 
        }

    }
}
