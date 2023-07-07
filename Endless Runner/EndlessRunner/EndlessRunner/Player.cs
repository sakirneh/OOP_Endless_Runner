using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EndlessRunner
{
    public class Player
    {
        public Image characterImg { get; set; }
        public bool isJumping { get; set; }

        public int jumpForce { get; set; }
        public int jumpSpeed { get; set; }
        public bool isDead { get; set; }
        public int playerScore { get; set; }

        public Player()
        {

        }
        public Player(Image _characterImg,bool _isJumping, int _jumpForce, int _playerScore, int _jumpSpeed)
        {
            characterImg = _characterImg;
            isJumping = _isJumping;
            jumpForce = _jumpForce;
            jumpSpeed = _jumpSpeed;
            playerScore = _playerScore;
        }

        public Player(string _playerScoreString)
        {
            playerScore = Convert.ToInt32(_playerScoreString);
        }
    }
}
