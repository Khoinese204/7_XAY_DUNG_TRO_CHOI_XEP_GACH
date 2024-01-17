using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.Entities.DataBase;
using Tetris.Entities.Enums;


namespace Tetris.Entities
{
    public class InterfaceDBandGame
    {
        public List<ScoreBoardItems> ScoreBoardItemsList { get; set; } = new List<ScoreBoardItems>();
        public ScoreBoardItems NewScoreBoardData { get; private set; } = new ScoreBoardItems();
        public Connection _connection { get; private set; } = new Connection();

        public int read { get; set; } = 1;

        public InterfaceDBandGame()
        {

        }

        // Phương thức làm mới bảng điểm local từ cơ sở dữ liệu
        public void RefreshLocalScoreBoard()
        {
            if (read == 1)
            {
                _connection.SendCommand(ScoreBoardCommand.read1, this);
            }
            else
            {
                _connection.SendCommand(ScoreBoardCommand.read2, this);
            }
        }

        // Phương thức đọc thông tin một mục trong bảng điểm local
        public ScoreBoardItems ReadLocalScoreBoard(int item)
        {
            return ScoreBoardItemsList.ElementAt(item);
        }

        // Phương thức trả về số lượng mục trong bảng điểm local
        public int LocalScoreBoardItemsQty()
        {
            return ScoreBoardItemsList.Count();
        }

        // Phương thức đọc thông tin một mục trong bảng điểm từ cơ sở dữ liệu
        public ScoreBoardItems ReadDataBaseScoreBoard(int item)
        {
            if (read == 1)
            {
                _connection.SendCommand(ScoreBoardCommand.read1, this);
            }
            else
            {
                _connection.SendCommand(ScoreBoardCommand.read2, this);
            }
            return ScoreBoardItemsList.ElementAt(item);
        }

        // Phương thức ghi thông tin vào bảng điểm
        public void WriteScoreBoard(string addAccountId, string addName, int addScore, string addTime, int addLevel)
        {
            // Gán dữ liệu mới từ tham số
            NewScoreBoardData.AccountId = addAccountId;
            NewScoreBoardData.PlayerName = addName;       
            NewScoreBoardData.Score = addScore;
            NewScoreBoardData.TotalTime = addTime;
            NewScoreBoardData.Level = addLevel;
            
            // Gửi lệnh ghi dữ liệu đến cơ sở dữ liệu
            _connection.SendCommand(ScoreBoardCommand.write, this);

        }        
    }
}
