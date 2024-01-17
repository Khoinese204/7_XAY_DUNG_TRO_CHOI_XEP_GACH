using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Entities.Enums
{
    // Các giá trị đại diện cho các trạng thái trong trò chơi
    public enum MachineStateName : int
    {
        // Thêm một khối mới
        AddNewPiece,
        // Di chuyển một khối
        Move,
        // Cố định một khối (khối không thể rơi xuống hay quay được nữa)
        TiePiece,
        // Trò chơi kết thúc
        GameOver,
    }
}
