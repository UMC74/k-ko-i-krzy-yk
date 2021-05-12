using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.buttons = new[]
            {
                topLeft,
                topCenter,
                topRight,
                centerLeft,
                centerCenter,
                centerRight,
                bottomLeft,
                bottomCenter,
                bottomRight
            };
        }

        private static readonly Dictionary<string, int> ButtonIds = new()
        {
            {"topLeft", 0b1 << 0},
            {"topCenter", 0b1 << 1},
            {"topRight", 0b1 << 2},
            {"centerLeft", 0b1 << 3},
            {"centerCenter", 0b1 << 4},
            {"centerRight", 0b1 << 5},
            {"bottomLeft", 0b1 << 6},
            {"bottomCenter", 0b1 << 7},
            {"bottomRight", 0b1 << 8},
        };

        private static readonly List<short> WinCombinations = new()
        {
            0b000000111,
            0b000111000,
            0b111000000,
            0b100100100,
            0b010010010,
            0b001001001,
            0b100010001,
            0b001010100
        };

        private bool _currentPlayer = false;
        private int _player0GameState = 0;
        private int _player1GameState = 0;
        private readonly Button[] buttons;

        private void ButtonClick(object sender, EventArgs e)
        {
            if (!(sender is Button button)) return;
            if (!ButtonIds.TryGetValue(button.Name, out var id)) return;
            if ((_player1GameState & id) > 0 || (_player0GameState & id) > 0) return;

            var player = this._currentPlayer ? "O" : "X";
            button.Text = player;

            if (this._currentPlayer) _player1GameState |= id;
            else _player0GameState |= id;
                
            if (this.CheckWin(this._currentPlayer))
            {
                MessageBox.Show(player + " win!");
                this.ResetGame();
                return;
            }

            if (this.CheckTie())
            {
                MessageBox.Show("tie!");
                this.ResetGame();
                return;
            }

            this._currentPlayer = !this._currentPlayer;
        }

        private bool CheckWin(bool player)
        {
            var values = player ? _player1GameState : _player0GameState;
            var combination = Form1.WinCombinations.Find(winCombination => (values & winCombination) == winCombination);
            if (combination == default) return false;

            for (var i = 0; i < 9; i++)
            {
                var bit = (combination & 1) == 1;
                combination >>= 1;
                if (!bit) continue;
                this.buttons[i].ForeColor = Color.Red;
            }

            return true;
        }

        private bool CheckTie()
        {
            return (_player0GameState | _player1GameState) == 0b111111111;
        }

        private void ResetGame()
        {
            this._currentPlayer = false;
            this._player0GameState = 0;
            this._player1GameState = 0;
            foreach (var button in this.buttons)
            {
                button.Text = "";
                button.ForeColor = Color.Black;
            }
        }
    }
}