using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.Entities.BackEnd;
using Tetris.Entities.Enums;
using Tetris.Forms;


namespace Tetris.Entities
{
    public class FrontBoardGame : Form
    {
        public formPlay _formP;
        public System.Windows.Forms.Panel[,] Matrix { get; private set; }
        public System.Windows.Forms.Panel[,] NextPieceMatrix { get; private set; }
        public int RowQty { get; private set; }
        public int ColumnQty { get; private set; }
        public System.Drawing.Color BoardGameColor { get; private set; }
        public BackBoardGame BackBoardGame { get; private set; } = new BackBoardGame();

        public FrontBoardGame(formPlay formP)
        {
            _formP = formP;
            BackBoardGame.PlayerName = formP.GetName();
            BackBoardGame.Level = formP.GetLevel();
            BackBoardGame.AccountId = formP.GetAccountId();

            // Thiết lập thông tin trên giao diện người dùng(UI) từ BackBoardGame
            formP.LabelScoreBoard.Text = BackBoardGame.ScoreBoard.ToString();
            formP.LabelPlayerName.Text = BackBoardGame.PlayerName;

            // Khởi tạo các thuộc tính của FrontBoardGame
            this.RowQty = BackBoardGame.RowQty;
            this.ColumnQty = BackBoardGame.ColunmQty;
            this.BoardGameColor = System.Drawing.SystemColors.Desktop;
            this.Matrix = new System.Windows.Forms.Panel[RowQty, ColumnQty];

            // Tạm ngừng việc vẽ UI để tăng hiệu suất
            formP.SuspendLayout();

            // Khởi tạo và cấu hình các ô trong ma trận game
            for (int j = 0; j < this.RowQty; j++)
            {
                for (int i = 0; i < this.ColumnQty; i++)
                {
                    this.Matrix[j, i] = new System.Windows.Forms.Panel();

                    // Cấu hình màu sắc cho các ô trong ma trận
                    if (i == 0 || i == (this.ColumnQty - 1))
                    {
                        this.Matrix[j, i].BackColor = System.Drawing.Color.DarkGray;
                    }
                    else if (j == (this.RowQty - 1))
                    {
                        this.Matrix[j, i].BackColor = System.Drawing.Color.DarkGray;
                    }
                    else
                    {
                        this.Matrix[j, i].BackColor = this.BoardGameColor;
                    }

                    // Cấu hình vị trí, kích thước, và các thuộc tính khác cho ô
                    this.Matrix[j, i].Location = new System.Drawing.Point(14 + (i * 22), 100 + (j * 22));
                    this.Matrix[j, i].Name += "pixel" + (i + (j * this.ColumnQty)).ToString("D2");
                    this.Matrix[j, i].Size = new System.Drawing.Size(20, 20);
                    this.Matrix[j, i].TabIndex = 0;

                    // Thêm ô vào form
                    formP.Controls.Add(this.Matrix[j, i]);
                }
            }

            // Khởi tạo và cấu hình ma trận cho mảnh tiếp theo
            this.NextPieceMatrix = new System.Windows.Forms.Panel[2, 4];
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    // Cấu hình vị trí, kích thước, và các thuộc tính khác cho ô
                    this.NextPieceMatrix[j, i] = new System.Windows.Forms.Panel();
                    this.NextPieceMatrix[j, i].BackColor = this.BoardGameColor;
                    this.NextPieceMatrix[j, i].Location = new System.Drawing.Point(190 + (i * 22), 50 + (j * 22));
                    this.NextPieceMatrix[j, i].Name += "pixel" + (i + (j * this.ColumnQty)).ToString("D2");
                    this.NextPieceMatrix[j, i].Size = new System.Drawing.Size(20, 20);
                    this.NextPieceMatrix[j, i].TabIndex = 0;

                    // Thêm ô vào form
                    formP.Controls.Add(this.NextPieceMatrix[j, i]);
                }
            }

            // Kết thúc quá trình tạm ngừng vẽ UI
            formP.ResumeLayout(false);
        }

        public void RefreshFrontBoardGame(formPlay formP)
        {
            // Cập nhật thông tin trên UI từ BackBoardGame
            formP.LabelScoreBoard.Text = BackBoardGame.ScoreBoard.ToString() + " pts";
            formP.LabelPlayerName.Text = BackBoardGame.PlayerName; 

            // Tạo một đối tượng ElementColor để lấy màu sắc tương ứng với các phần tử trong ma trận
            ElementColor ElementColor = new ElementColor();

            // Cập nhật màu sắc cho các ô trong ma trận mảnh tiếp theo (NextPieceMatrix)
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    this.NextPieceMatrix[j, i].BackColor = ElementColor.SystemDrawingColor[(int)this.BackBoardGame.NextPieceMatrix[j, i]];
                }
            }

            // Cập nhật màu sắc cho các ô trong ma trận chính (Matrix)
            for (int j = 0; j < this.RowQty; j++)
            {
                for (int i = 0; i < this.ColumnQty; i++)
                {
                    this.Matrix[j, i].BackColor = ElementColor.SystemDrawingColor[(int)this.BackBoardGame.Matrix[j, i]];
                }
            }
        }


    }
}