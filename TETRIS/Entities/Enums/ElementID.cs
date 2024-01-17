using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Entities.Enums
{
    // Các giá trị đại diện cho các thành phần trong trò chơi 
    public enum ElementID : int
    {
        // Các khối hình chữ J,T,L,I,O,S,Z
        JBlock = 0,
        TBlock,
        LBlock,
        IBlock,
        OBlock,
        SBlock,
        ZBlock,
        // Ô trống
        Free,
        // Tường hoặc rìa của bảng chơi
        Wall,
        // Khối đã cố định ở vị trí của nó trong quá khứ
        OldPiece,
        // Vùng grid dành cho mảnh tiếp theo
        NextPieceGrid,
    }
}
