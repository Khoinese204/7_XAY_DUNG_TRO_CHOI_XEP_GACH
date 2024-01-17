using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Entities.Enums
{
    // Các giá trị đại diện cho các lệnh đọc, ghi bảng điểm trong trò chơi
    public enum ScoreBoardCommand : int
    {
        read1 = 1, // đọc bảng điểm cho formHighScore
        read2 = 2, // đọc bảng điểm cho formLeaderBoard
        write, // ghi vào bảng điểm HighScores trong database
    }
}
