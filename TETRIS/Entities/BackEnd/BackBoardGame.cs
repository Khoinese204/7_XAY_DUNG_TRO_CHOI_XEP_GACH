using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.Entities.Enums;
using Tetris.Forms;

namespace Tetris.Entities.BackEnd
{
    public class BackBoardGame 
    {
        public string AccountId { get; set; }
        public string PlayerName { get; set; }
        public int ScoreBoard { get; set; }
        public string TotalTime { get; set; }
        public int Level { get; set; }
        public ElementID[,] Matrix { get; set; }
        public ElementID[,] NextPieceMatrix { get; set; }
        public int RowQty { get; private set; }
        public int ColunmQty { get; private set; }




        public BackBoardGame()
        {
            
            this.ScoreBoard = 0;
            this.PlayerName = "Guest"; 
            this.TotalTime = "00:00:00";
            this.Level = 1;
            this.AccountId = null;
            
            // Bảng có 20 hàng chứa các khối gạch được rơi xuống và 1 hàng chứa tường dưới
            this.RowQty = 21;
            // Bảng có 10 cột chứa các khối gạch được rơi xuống và 2 cột chừa 2 tường lề trái phải.
            this.ColunmQty = 12;

            // Khởi tạo ma trận 
            this.Matrix = new ElementID[this.RowQty, this.ColunmQty];

            for (int j = 0; j < this.RowQty; j++)
            {
                for (int i = 0; i < this.ColunmQty; i++)
                {
                    if (i == 0 || i == (this.ColunmQty - 1))
                    {
                        this.Matrix[j, i] = ElementID.Wall; 
                    }
                    else if (j == (this.RowQty - 1))
                    {
                        this.Matrix[j, i] = ElementID.Wall;
                    }
                    else
                    {
                        this.Matrix[j, i] = ElementID.Free;
                    }
                }
            }

            // Khởi tạo Ma trận Mảnh Tiếp Theo
            this.NextPieceMatrix = new ElementID[this.RowQty, this.ColunmQty];                                                                                                                                                                                                                                                                                                                                                           

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    this.NextPieceMatrix[j, i] = ElementID.NextPieceGrid;
                }
            }

        }

        public void ResetBackBoardGame()
        {
            // Khởi tạo ma trận mới với các vị trí ở giữa
            for (int j = 0; j < this.RowQty; j++)
            {
                for (int i = 0; i < this.ColunmQty; i++)
                {
                    if (i == 0 || i == (this.ColunmQty - 1))
                        ;
                    else if (j == (this.RowQty - 1))
                        ;
                    else
                    {
                        this.Matrix[j, i] = ElementID.Free;
                    }
                }
            }
        }

        public override string ToString()
        {
            // Khởi tạo một đối tượng StringBuilder để xây dựng chuỗi kết quả.
            StringBuilder completeString = new StringBuilder();
            completeString.AppendLine("");
            completeString.AppendLine(PlayerName);
            completeString.AppendLine(ScoreBoard.ToString());
            completeString.AppendLine("");
            completeString.AppendLine("Next Piece:");

            // Lặp qua ma trận NextPieceMatrix (2x4) để thêm giá trị vào chuỗi kết quả.
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    completeString.Append(((int)this.NextPieceMatrix[j, i]).ToString("D2") + " ");
                }
                completeString.AppendLine(" ");
            }

            completeString.AppendLine("");

            // Lặp qua ma trận Matrix để thêm giá trị vào chuỗi kết quả.
            for (int j = 0; j < this.RowQty; j++)
            {
                for (int i = 0; i < this.ColunmQty; i++)
                {
                    completeString.Append(((int)this.Matrix[j, i]).ToString() + " ");
                }
                completeString.AppendLine(" ");
            }
            return completeString.ToString();
        }

    }
}
