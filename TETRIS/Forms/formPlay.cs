using System;
using System.Data.SqlClient;
using System.Media;
using System.Windows.Forms;
using Tetris.Entities;
using Tetris.Entities.Enums;


namespace Tetris.Forms
{
    public partial class formPlay : Form
    {
        private DateTime startTime;
        public formMainMenu frmMM;
        public MachineStateName State { set; get; }
        public FrontBoardGame boardGame { private set; get; }   
        public ActionGame action { private set; get; }
        public string ScoreBoard { set; get; }

        System.Windows.Forms.Panel panel1 = new System.Windows.Forms.Panel();
        public formOption option;
        public int ChooseLevel { get; set; } = 1;
        public int ChooseSound { get; set; } = 1;

        public int Level { get; set; } = 1;
        private string AccountId { get; set; } = null;

        public SoundPlayer tetrisPlayer;
        public SoundPlayer clearLineSound;
        public SoundPlayer gameoverSound;

        public formPlay(formMainMenu a)
        {
            frmMM = a;
            InitializeComponent();
            option = formOption.Instance;
            tetrisPlayer = new SoundPlayer(Properties.Resources.bubbles_003_6397);
            clearLineSound = new SoundPlayer(Properties.Resources.se_game_offset1);
            gameoverSound = new SoundPlayer(Properties.Resources.me_game_gameover);
            startTime = DateTime.Now;
            LabelPlayerName.Text = frmMM.GetName();
            Level = Convert.ToInt32(frmMM.GetLevel());
            AccountId = frmMM.GetAccountId();
            boardGame = new FrontBoardGame(this);
            this.action = new ActionGame(1, 6);
            this.action.ChooseLevel = option.ChooseLevel;
            this.action.AddNewPiece(boardGame.BackBoardGame);
            this.action.MovePiece(boardGame.BackBoardGame, MovementName.Down);
            boardGame.RefreshFrontBoardGame(this);
            State = MachineStateName.Move;


            //Choose Sound
            if (option.ChooseSound != null)
            {
                if (option.ChooseSound == 1)
                {
                    tetrisPlayer.PlayLooping();
                }
                else if (option.ChooseSound == 2)
                {
                    tetrisPlayer.Stop();
                }
            }

            //Choose Level
            if (option.ChooseLevel != null)
            {
                if (option.ChooseLevel == 1)
                {
                    timer1.Interval = 1000; 
                    timer1.Start();
                }
                else if (option.ChooseLevel == 2)
                {
                    timer1.Interval = 300; 
                    timer1.Start();
                }
                else if (option.ChooseLevel == 3)
                {
                    timer1.Interval = 80;
                    timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (State == MachineStateName.AddNewPiece)
            {
                State = this.action.AddNewPiece(boardGame.BackBoardGame);
                boardGame.RefreshFrontBoardGame(this);
            }
            else if (State == MachineStateName.Move)
            {
                State = this.action.MovePiece(boardGame.BackBoardGame, MovementName.Down);
                boardGame.RefreshFrontBoardGame(this);

                if (State == MachineStateName.TiePiece)
                {
                    this.action.TiePiece(boardGame.BackBoardGame);
                    this.action.CheckFullLine(boardGame.BackBoardGame, tetrisPlayer, clearLineSound, option.ChooseSound, option.ChooseEffect);

                    State = MachineStateName.AddNewPiece;

                }
            }
            if (State == MachineStateName.GameOver)
            {
                this.timer1.Enabled = false;
                TimeSpan elapsedTime = DateTime.Now - startTime;
                this.boardGame.BackBoardGame.TotalTime = elapsedTime.ToString(@"hh\:mm\:ss");


                if (option.ChooseEffect == 1 && option.ChooseSound == 1)
                {
                    System.Threading.Thread.Sleep(500);
                    gameoverSound.Play();
                }
                if (option.ChooseEffect == 1 && option.ChooseSound == 2)
                {
                    gameoverSound.Play();
                }

                // SO SÁNH ĐIỂM TRONG DATABASE
                
                InterfaceDBandGame ServerScoreboard = new InterfaceDBandGame();
                if (this.boardGame.BackBoardGame.AccountId != null)
                ServerScoreboard.WriteScoreBoard(this.boardGame.BackBoardGame.AccountId, this.boardGame.BackBoardGame.PlayerName, this.boardGame.BackBoardGame.ScoreBoard, this.boardGame.BackBoardGame.TotalTime, this.boardGame.BackBoardGame.Level);
                else
                ServerScoreboard.WriteScoreBoard(null, this.boardGame.BackBoardGame.PlayerName, this.boardGame.BackBoardGame.ScoreBoard, this.boardGame.BackBoardGame.TotalTime, this.boardGame.BackBoardGame.Level);
                var frmGameOver = new formGameOver();
                frmGameOver.Result(this.boardGame.BackBoardGame.PlayerName, this.boardGame.BackBoardGame.ScoreBoard.ToString(), this.boardGame.BackBoardGame.TotalTime);
                frmGameOver.ShowDialog();

                if (frmGameOver.DialogResult == DialogResult.No)
                {
                    this.DialogResult = DialogResult.No;
                    frmGameOver.Close();
                    this.Close();
                }
                else
                {
                    this.State = Entities.Enums.MachineStateName.AddNewPiece;
                    this.action.ResetGame(boardGame.BackBoardGame, this);
                    if (option.ChooseSound == 1)
                        tetrisPlayer.PlayLooping();
                }
                // Cập nhật level cho người chơi ở giao diện Menu
                frmMM.SetPlayer(AccountId);
            }
        }

        public string GetName()
        {
            return LabelPlayerName.Text;
        }
        public int GetLevel()
        {
            return Level;
        }

        public string GetAccountId()
        {
            return AccountId;
        }

        private void formPlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (State == MachineStateName.Move)
            {
                if (e.KeyCode == Keys.Left)
                {
                    this.action.MovePiece(boardGame.BackBoardGame, MovementName.Left);
                    boardGame.RefreshFrontBoardGame(this);
                }
                else if (e.KeyCode == Keys.Right)
                {
                    this.action.MovePiece(boardGame.BackBoardGame, MovementName.Right);
                    boardGame.RefreshFrontBoardGame(this);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.action.MovePiece(boardGame.BackBoardGame, MovementName.Rotate);
                    boardGame.RefreshFrontBoardGame(this);
                }
                else if (e.KeyCode == Keys.Down)
                {
                    this.action.MovePiece(boardGame.BackBoardGame, MovementName.Down);
                    boardGame.RefreshFrontBoardGame(this);
                }


            }
        }

        private void playPauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        // Trở về Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.Hide();
            frmMM.Closed += (s, args) => this.Close();
            frmMM.Show();
            if (option.ChooseSound == 1)
            tetrisPlayer.Stop();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (option.ChooseSound == 1)
                tetrisPlayer.PlayLooping();
            this.action.ResetGame(boardGame.BackBoardGame, this);
            State = MachineStateName.AddNewPiece;
        }


    }
}

