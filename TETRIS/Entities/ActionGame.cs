using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.Entities.Enums;
using Tetris.Entities.BackEnd;
using Tetris.Forms;
using System.Media;
using System.Threading;
using NAudio.Wave;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Security.Cryptography.X509Certificates;


namespace Tetris.Entities
{
    public class ActionGame
    {
        // Định nghĩa vị trí bắt đầu của khối
        public Position StartPiecePosition { get; private set; }
        // Vị trí hiện tại của khối trên bảng game
        public Position CurrentPiecePositionOnGameBoard { get; private set; }
        // Khối hiện tại trên bảng game
        public Piece CurrentPieceOnGameboard { get; private set; }
        // Khối tiếp theo sẽ xuất hiện trên bảng game
        public Piece NextPieceOnGameboard { get; private set; }
        public formOption option;
        public int ChooseLevel { get; set; } = 1;


        // Constructor mặc định, khởi tạo với giá trị mặc định
        public ActionGame()
        {
            // Khởi tạo vị trí bắt đầu và vị trí hiện tại
            StartPiecePosition = new Position();
            CurrentPiecePositionOnGameBoard = new Position();

            // Khởi tạo khối hiện tại là null
            CurrentPieceOnGameboard = null;

            // Lưu trữ vị trí bắt đầu như một giá trị mặc định (0,1) từ constructor của Position
            StartPiecePosition.Row = CurrentPiecePositionOnGameBoard.Row;
            StartPiecePosition.Column = CurrentPiecePositionOnGameBoard.Column;
        }

        // Constructor với tham số, khởi tạo với vị trí bắt đầu được xác định
        public ActionGame(int startCurrentPiecePositionRow, int startCurrentPiecePositionColumn)
        {
            StartPiecePosition = new Position(startCurrentPiecePositionRow, startCurrentPiecePositionColumn);
            CurrentPiecePositionOnGameBoard = new Position(startCurrentPiecePositionRow, startCurrentPiecePositionColumn);
            
            CurrentPieceOnGameboard = null;

            StartPiecePosition.Row = CurrentPiecePositionOnGameBoard.Row;
            StartPiecePosition.Column = CurrentPiecePositionOnGameBoard.Column;
        }

        // Thêm một khối mới
        public MachineStateName AddNewPiece(BackBoardGame backBoardGame)
        {
            // Thiết lập vị trí ban đầu tới các vị trí đã định trong CurrentPiecePositionOnGameBoard
            CurrentPiecePositionOnGameBoard.Row = StartPiecePosition.Row;
            CurrentPiecePositionOnGameBoard.Column = StartPiecePosition.Column;

            // Xác định thứ tự của các khối để được sắp xếp ngẫu nhiên
            ElementID[] PiecetoBeSortedByRandom = new ElementID[] { ElementID.JBlock,
                                                                    ElementID.TBlock,
                                                                    ElementID.LBlock,
                                                                    ElementID.IBlock,
                                                                    ElementID.OBlock,
                                                                    ElementID.SBlock,
                                                                    ElementID.ZBlock
            };
            // Tạo một bộ tạo số ngẫu nhiên
            Random rnd = new Random();

            if (CurrentPieceOnGameboard == null)
            {
                // Nếu khối hiện tại là null, tạo một khối mới và khối tiếp theo
                CurrentPieceOnGameboard = new Piece(PiecetoBeSortedByRandom[rnd.Next((int)ElementID.ZBlock + 1)]);
                NextPieceOnGameboard = new Piece(PiecetoBeSortedByRandom[rnd.Next((int)ElementID.ZBlock + 1)]);
            }
            else
            {
                // Nếu khối hiện tại tồn tại, di chuyển nó tới khối tiếp theo và tạo một khối tiếp theo mới
                CurrentPieceOnGameboard = NextPieceOnGameboard;
                NextPieceOnGameboard = new Piece(PiecetoBeSortedByRandom[rnd.Next((int)ElementID.ZBlock + 1)]);
            }


            // Thiết kế khối tiếp theo trên lưới Piece tiếp theo (backend)
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 4; i++)
                    backBoardGame.NextPieceMatrix[j, i] = ElementID.NextPieceGrid;
            }
            for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
            {
                backBoardGame.NextPieceMatrix[NextPieceOnGameboard.PixelVector[PiecePixel].Row + 1, NextPieceOnGameboard.PixelVector[PiecePixel].Column + 1] = NextPieceOnGameboard.id;
            }


            // Nếu vị trí tiếp theo là trống, thiết kế khối hiện tại trên bảng game (backend)
            if (NextPositionIsFree(backBoardGame, MovementName.Down))
            {
                // Thiết kế khối hiện tại trên bảng game (backend)
                for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                {
                    backBoardGame.Matrix[StartPiecePosition.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, StartPiecePosition.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] = CurrentPieceOnGameboard.id;
                }

                return MachineStateName.Move; // Trả về trạng thái chỉ định một bước di chuyển thành công
            }
            else
            {
                //Console.WriteLine("GAME OVER");
                return MachineStateName.GameOver; // Trả về trạng thái chỉ định trò chơi kết thúc
            }
        }

        // Thêm một khối đã được chỉ định
        public void AddNewPiece(BackBoardGame backBoardGame, ElementID pieceId)
        {
            // Tạo một khối mới với ID được chỉ định
            CurrentPieceOnGameboard = new Piece(pieceId);

            // Thiết lập vị trí ban đầu tới các vị trí đã định trong CurrentPiecePositionOnGameBoard
            CurrentPiecePositionOnGameBoard.Row = StartPiecePosition.Row;
            CurrentPiecePositionOnGameBoard.Column = StartPiecePosition.Column;

            // Thiết kế khối trên bảng game (backend)
            for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
            {
                backBoardGame.Matrix[StartPiecePosition.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, StartPiecePosition.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] = CurrentPieceOnGameboard.id;
            }
        }

        // Di chuyển một khối 
        public MachineStateName MovePiece(BackBoardGame backBoardGame, MovementName movement)
        {
 
            if (movement == MovementName.Down)
            {
                if (NextPositionIsFree(backBoardGame, movement))
                {
                    // Xóa vị trí hiện tại
                    
                    for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                    {
                        backBoardGame.Matrix[CurrentPiecePositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, CurrentPiecePositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] = ElementID.Free;
                    }
                    
                    // Di chuyển xuống
                    CurrentPiecePositionOnGameBoard.Row++;

                    // Thiết kế khối ở vị trí mới
                    for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                    {
                        backBoardGame.Matrix[CurrentPiecePositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, CurrentPiecePositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] = CurrentPieceOnGameboard.id;
                    }
                }
                else
                {
                    return MachineStateName.TiePiece; // Trả về trạng thái khi không thể di chuyển xuống
                }
            }
            else if (movement == MovementName.Left)
            {
                if (NextPositionIsFree(backBoardGame, movement))
                {
                    // Xóa vị trí hiện tại
                    for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                    {
                        backBoardGame.Matrix[CurrentPiecePositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, CurrentPiecePositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] = ElementID.Free;
                    }

                    // Di chuyển sang trái
                    CurrentPiecePositionOnGameBoard.Column--;

                    // Thiết kế khối ở vị trí mới
                    for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                    {
                        backBoardGame.Matrix[CurrentPiecePositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, CurrentPiecePositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] = CurrentPieceOnGameboard.id;
                    }
                }
            }
            else if (movement == MovementName.Right)
            {
                if (NextPositionIsFree(backBoardGame, movement))
                {
                    // Xóa vị trí hiện tại
                    for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                    {
                        backBoardGame.Matrix[CurrentPiecePositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, CurrentPiecePositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] = ElementID.Free;
                    }

                    // Di chuyển sang phải
                    CurrentPiecePositionOnGameBoard.Column++;

                    // Thiết kế khối ở vị trí mới
                    for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                    {
                        backBoardGame.Matrix[CurrentPiecePositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, CurrentPiecePositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] = CurrentPieceOnGameboard.id;
                    }
                }
            }
            else if (movement == MovementName.Rotate)
            {
                if (NextPositionIsFree(backBoardGame, movement))
                {
                    // Xóa vị trí hiện tại
                    for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                    {
                        backBoardGame.Matrix[CurrentPiecePositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, CurrentPiecePositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] = ElementID.Free;
                    }
                     
                    // Xoay khối
                    CurrentPieceOnGameboard.PieceOrientation++;
                    CurrentPieceOnGameboard.SetPiecePixelVector();

                    // Thiết kế khối ở vị trí mới
                    for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                    {
                        backBoardGame.Matrix[CurrentPiecePositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, CurrentPiecePositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] = CurrentPieceOnGameboard.id;
                    }
                }
            }
            else
            {
                ; // Do nothing
            }

            return MachineStateName.Move; // Trả về trạng thái khi di chuyển thành công
        }

        // Hàm xử lý khi khối không thể di chuyển xuống nữa
        public void TiePiece(BackBoardGame backBoardGame)
        {
         
              for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
              {
                  int row = CurrentPiecePositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row;
                  int column = CurrentPiecePositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column;
                  backBoardGame.Matrix[row, column] = ElementID.OldPiece;   
                 
              }
        }

        // Hàm khởi tạo lại trò chơi
        public void ResetGame(BackBoardGame backBoardGame, formPlay formp)
        {
            // Tạm dừng đồng hồ đếm thời gian
            formp.timer1.Enabled = false;

            // Đặt lại vị trí hiện tại của khối
            CurrentPiecePositionOnGameBoard.Column = StartPiecePosition.Column;
            CurrentPiecePositionOnGameBoard.Row = StartPiecePosition.Row;

            // Khởi tạo lại đối tượng của khối hiện tại và khối kế tiếp
            CurrentPieceOnGameboard = null;
            NextPieceOnGameboard = null;

            // Đặt lại điểm số và bảng điểm
            backBoardGame.ScoreBoard = 0;
            backBoardGame.ResetBackBoardGame();

            // Khởi động lại đồng hồ đếm thời gian
            formp.timer1.Enabled = true;
        }

        // Hàm kiểm tra và xóa các dòng đã đầy trên bảng
        public void CheckFullLine(BackBoardGame backBoardGame, SoundPlayer tetris, SoundPlayer clear, int chooseSound, int chooseEffect)
        {
            int[] RowID = new int[backBoardGame.RowQty];
            int IndexRowID = 0;

            for (int row = 0; row < backBoardGame.RowQty - 1; row++)
            {
                for (int column = 1; column < backBoardGame.ColunmQty - 1; column++)
                {
                    // Nếu có ô trống, thoát vòng lặp
                    if (backBoardGame.Matrix[row, column] == ElementID.Free)
                    {
                        break;
                    }

                    // Nếu đến cột cuối cùng và không có ô trống, đánh dấu dòng đã đầy
                    if (column == backBoardGame.ColunmQty - 2)
                    {
                        RowID[IndexRowID] = row;
                        IndexRowID++;
                    }
                }
            }
            // Gọi hàm xóa các dòng đã đầy
            EraseRows(backBoardGame, RowID, tetris, clear, chooseSound, chooseEffect);
        }

        // Hàm kiểm tra xem vị trí tiếp theo có trống không
        private bool NextPositionIsFree(BackBoardGame backBoardGame, MovementName movement)
        {
            
            // Sao chép vị trí hiện tại để kiểm tra vị trí tiếp theo
            Position NextVerifyPositionOnGameBoard = new Position(CurrentPiecePositionOnGameBoard.Row, CurrentPiecePositionOnGameBoard.Column);

            
            // Kiểm tra theo hướng di chuyển
            if (movement == MovementName.Down)
            {
                // Di chuyển vị trí xuống dưới
                NextVerifyPositionOnGameBoard.Row++;
                

                // Kiểm tra từng điểm của khối
                for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                {

                    // Nếu ô không trống và không phải là phần của khối hiện tại, trả về false
                    if (backBoardGame.Matrix[NextVerifyPositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, NextVerifyPositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] != ElementID.Free
                    && backBoardGame.Matrix[NextVerifyPositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, NextVerifyPositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] != CurrentPieceOnGameboard.id)
                    {
                        return (false);
                    }
                }

                // Nếu tất cả đều trống, trả về true
                return true;
            }
            else if (movement == MovementName.Left)
            {
                // Di chuyển vị trí sang trái
                NextVerifyPositionOnGameBoard.Column--;

                // Kiểm tra từng điểm của khối
                for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                {
                    // Nếu ô không trống và không phải là phần của khối hiện tại, trả về false
                    if (backBoardGame.Matrix[NextVerifyPositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, NextVerifyPositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] != ElementID.Free
                  && backBoardGame.Matrix[NextVerifyPositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, NextVerifyPositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] != CurrentPieceOnGameboard.id)
                    {
                        return (false);
                    }
                }
                // Nếu tất cả đều trống, trả về true
                return (true);
            }
            else if (movement == MovementName.Right)
            {
                NextVerifyPositionOnGameBoard.Column++;
                for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                {
                    if (backBoardGame.Matrix[NextVerifyPositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, NextVerifyPositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] != ElementID.Free
                   && backBoardGame.Matrix[NextVerifyPositionOnGameBoard.Row + CurrentPieceOnGameboard.PixelVector[PiecePixel].Row, NextVerifyPositionOnGameBoard.Column + CurrentPieceOnGameboard.PixelVector[PiecePixel].Column] != CurrentPieceOnGameboard.id)
                    {
                        return (false);
                    }
                }
                return (true);
            }
            else if (movement == MovementName.Rotate)
            {
                // Tạo mảng vị trí mới sau khi xoay khối
                Position[] NextRotationPositionOnGameboard = new Position[4];
                for (int MemPixel = 0; MemPixel < 4; MemPixel++)
                {
                    NextRotationPositionOnGameboard[MemPixel] = new Position();
                }

                // Xoay khối và lấy vị trí mới của các điểm trên khối
                NextRotationPositionOnGameboard = Piece.SetPiecePixelVector(CurrentPieceOnGameboard.id, CurrentPieceOnGameboard.PieceOrientation + 1);

                // Kiểm tra từng điểm của khối sau khi xoay
                for (int PiecePixel = 0; PiecePixel < 4; PiecePixel++)
                {
                    if (backBoardGame.Matrix[CurrentPiecePositionOnGameBoard.Row + NextRotationPositionOnGameboard[PiecePixel].Row, CurrentPiecePositionOnGameBoard.Column + NextRotationPositionOnGameboard[PiecePixel].Column] == ElementID.Wall
                               || backBoardGame.Matrix[CurrentPiecePositionOnGameBoard.Row + NextRotationPositionOnGameboard[PiecePixel].Row, CurrentPiecePositionOnGameBoard.Column + NextRotationPositionOnGameboard[PiecePixel].Column] == ElementID.OldPiece)
                    {
                        
                        return (false);
                    }
                }
                return (true);
            }
            return (false);
        }

        // Hàm xóa các dòng đã đầy trên bảng
        private void EraseRows(BackBoardGame backBoardGame, int[] RowID, SoundPlayer _tetris, SoundPlayer _clear, int _chooseSound, int _chooseEffect)
        {
            int qtyEraseRows = 0;
            int baseDifficulty = 10; // hoặc giá trị cơ bản phù hợp khác

            // Tính điểm dựa trên cấp độ đã chọn
            int difficultyMultiplier = 0;
            if (ChooseLevel == 1)
                difficultyMultiplier = baseDifficulty * 1;
            if (ChooseLevel == 2)
                difficultyMultiplier = baseDifficulty * 3;
            if (ChooseLevel == 3)
                difficultyMultiplier = baseDifficulty * 5;

            // Tô màu dòng với màu của khối hiện tại
            for (int row = 0; row < backBoardGame.RowQty; row++)
            {
                if (RowID[row] != 0)
                {
                    qtyEraseRows++;

                    // Tô màu từng ô trong dòng với màu của khối hiện tại
                    for (int column = 1; column < backBoardGame.ColunmQty - 1; column++)
                    {
                        backBoardGame.Matrix[RowID[row], column] = CurrentPieceOnGameboard.id;
                    }
                }
            }

            // Nếu có dòng nào đó bị xóa, thì thực hiện xóa dòng
            if (qtyEraseRows > 0)
            {
                if (_chooseEffect == 1 && _chooseSound == 1)
                {
                    System.Threading.Thread.Sleep(500);
                    _clear.Play();
                    System.Threading.Thread.Sleep(500);
                    _tetris.PlayLooping();
                }
                if (_chooseEffect == 1 && _chooseSound == 2)
                {
                    _clear.Play();
                }

                for (int row = 0; row < backBoardGame.RowQty; row++)
                {
                    if (RowID[row] != 0)
                    {
                        // Dịch chuyển các dòng phía trên xuống
                        for (int eraseRow = RowID[row]; eraseRow > 0; eraseRow--)
                        {
                            for (int column = 1; column < backBoardGame.ColunmQty - 1; column++)
                            {
                                if (eraseRow > 0)
                                    backBoardGame.Matrix[eraseRow, column] = backBoardGame.Matrix[eraseRow - 1, column];
                            }
                        }
                    }
                }
            }
            // Cập nhật điểm số
            backBoardGame.ScoreBoard += difficultyMultiplier * qtyEraseRows;
        }
    }
}
