using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.Entities.DataBase;
using Tetris.Entities.Enums;
using Tetris.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Tetris.Entities
{
    public class Connection
    {
        public Connection()
        {
            _connection.ConnectionString = @"Persist Security Info=False;Integrated Security=True;Initial Catalog=TetrisDataBase;Data Source=KHOIPRO2K4\SQLEXPRESS01";
        }

        public SqlConnection _connection2 = new SqlConnection(@"Persist Security Info=False;Integrated Security=True;Initial Catalog=TetrisDataBase;Data Source=KHOIPRO2K4\SQLEXPRESS01");

        public SqlConnection _connection { get; set; } = new SqlConnection();
        public SqlCommand _command { get; set; } = new SqlCommand();
        public SqlDataReader _dataReader { get; set; }


        // Phương thức thực hiện các truy vấn đến cơ sở dữ liệu
        public void SendCommand(ScoreBoardCommand command, InterfaceDBandGame interfaceDBandGame)
        {
            // Nếu là truy vấn đọc dữ liệu
            if (command == ScoreBoardCommand.read1)
            {
                try
                {
                    // Kết nối đến cơ sở dữ liệu
                    _command.Connection = Connect();
                    if (interfaceDBandGame.NewScoreBoardData.AccountId != null)
                    {
                        _command.CommandText = $"select top 10 Initials, Scores, TotalTime from GameSession where AccountId = '{interfaceDBandGame.NewScoreBoardData.AccountId}' order by Scores desc";
                    }
                    else
                    {
                        _command.CommandText = $"select top 10 Initials, Scores, TotalTime from GameSession where AccountId is NULL order by Scores desc";
                    }
                    _dataReader = _command.ExecuteReader();

                    while (_dataReader.Read())
                    {
                        // Lấy dữ liệu từ cột tương ứng
                        string _initials = _dataReader[0].ToString();
                        int _score = Convert.ToInt32(_dataReader[1]);
                        string _totalTime = _dataReader[2].ToString();

                        // Thêm dữ liệu vào danh sách
                        interfaceDBandGame.ScoreBoardItemsList.Add(new ScoreBoardItems(_initials, _score, _totalTime));
                    }

                }
                catch (SqlException Ex)
                {
                    // Xử lý ngoại lệ SQL
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    // Đóng kết nối sau khi sử dụng
                    _command.Connection = Disconnect();
                }
            }
            else if (command == ScoreBoardCommand.read2)
            {
                try
                {
                    // Kết nối đến cơ sở dữ liệu
                    _command.Connection = Connect();

                    // Truy vấn SQL để đọc dữ liệu từ bảng HighScores và sắp xếp theo điểm giảm dần
                    _command.CommandText = @" 
                        WITH RankedHighScores AS
                        (
                            SELECT 
                                gs.AccountId,
                                gs.Scores,
                                ROW_NUMBER() OVER (PARTITION BY gs.AccountId ORDER BY gs.Scores DESC) AS RANK
                            FROM GameSession gs
                            WHERE gs.AccountId IS NOT NULL
                        )
                        SELECT rhs.AccountId ,ga.PlayerName, rhs.Scores
                        FROM RankedHighScores rhs
                        JOIN GameAccount ga on ga.AccountId = rhs.AccountId
                        WHERE Rank = 1
                        ORDER BY rhs.Scores DESC
                        ";

                    _dataReader = _command.ExecuteReader();
                    int _rank = 1;
                    int _temp = 0;
                    int _turn = 1;
                    int _level = 1;

                    // Đọc tất cả các dòng chứa dữ liệu
                    while (_dataReader.Read())
                    {
                        // Lấy dữ liệu từ cột tương ứng
                        int _accountId = Convert.ToInt32(_dataReader[0]);
                        string _playerName = _dataReader[1].ToString();
                        int _score = Convert.ToInt32(_dataReader[2]);
                        if (_turn != 1 && _score != _temp)
                            _rank++;
                        _temp = _score;
                        _connection2.Open();
                        SqlCommand levelCmd = new SqlCommand($"SELECT TOP 1 Level FROM GameSession  WHERE AccountId = {_accountId} order by Level DESC", _connection2);
                        string levelStr = levelCmd.ExecuteScalar().ToString();
                        _level = Convert.ToInt32(levelStr);
                        _connection2.Close();
                        // Thêm dữ liệu vào danh sách
                        interfaceDBandGame.ScoreBoardItemsList.Add(new ScoreBoardItems(_rank , _playerName, _score, _level));
                        _turn++;
                    }
                }
                catch (SqlException Ex)
                {
                    // Xử lý ngoại lệ SQL
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    // Đóng kết nối sau khi sử dụng
                    _command.Connection = Disconnect();
                }
            }
            // Nếu là truy vấn ghi dữ liệu
            else if (command == ScoreBoardCommand.write)
            {
                try
                {
                    
                    _command.Connection = Connect();

                    
                    // Kiểm tra xuất ra thông báo "Congratulations!"
                    string inits = "";       
                    int currentScore = interfaceDBandGame.NewScoreBoardData.Score; // điểm hiện tại
                    string x_query = "";
                    if (interfaceDBandGame.NewScoreBoardData.AccountId != null)
                    x_query = $"select top 1 Scores from GameSession where AccountId = '{interfaceDBandGame.NewScoreBoardData.AccountId}' order by Scores desc";
                    else
                    x_query = $"select top 1 Scores from GameSession where AccountId is NULL order by Scores desc";
                    SqlCommand x = new SqlCommand(x_query, _connection);
                    string bestScoreStr = x.ExecuteScalar().ToString();
                    int bestScore = Convert.ToInt32(bestScoreStr);
                    if (currentScore > bestScore)
                    {
                        frmCongratulation frmCongratulation = new frmCongratulation(interfaceDBandGame.NewScoreBoardData.Score);
                        frmCongratulation.ShowDialog();
                        inits = frmCongratulation.intials;
                    }
                    // Kiểm tra xuất ra thông báo "Tăng Level!"
                    // Level 1: >=0
                    // Level 2: >=1000
                    // Level 3: >=3000
                    // Level 4: >=7000
                    // Level 5: >=15000
                    int level = interfaceDBandGame.NewScoreBoardData.Level; // level hiện tại
                    string y_query = "";
                    if (interfaceDBandGame.NewScoreBoardData.AccountId != null)
                        y_query = $"SELECT SUM(Scores) FROM GameSession WHERE AccountId = '{interfaceDBandGame.NewScoreBoardData.AccountId}'";
                    else
                        y_query = $"SELECT SUM(Scores) FROM GameSession WHERE AccountId is NULL";
                    SqlCommand y = new SqlCommand(y_query, _connection);
                    string totalScoreStr = y.ExecuteScalar().ToString();
                    double previousTotalScore = Convert.ToInt32(totalScoreStr);
                    double currentTotalScore = previousTotalScore + currentScore;
                    bool showLevelUp = false;
                    
                    if (previousTotalScore < 1000 && currentTotalScore >= 1000)
                    {
                        level = 2;
                        showLevelUp = true;
                    }
                    else if (previousTotalScore < 3000 && currentTotalScore >= 3000)
                    {
                        level = 3;
                        showLevelUp = true;
                    }
                    else if (previousTotalScore < 7000 && currentTotalScore >= 7000)
                    {
                        level = 4;
                        showLevelUp = true;
                    }
                    else if (previousTotalScore < 15000 && currentTotalScore >= 15000)
                    {
                        level = 5;
                        showLevelUp = true;
                    }
                    if (showLevelUp == true)
                    {
                        frmLevelUp frmLevelUp = new frmLevelUp(level);
                        frmLevelUp.ShowDialog();
                    }
                    string z_query = "";
                    if(interfaceDBandGame.NewScoreBoardData.AccountId != null)
                    z_query = $"INSERT into GameSession(AccountId, Scores, TotalTime, Initials, Level) values ('{interfaceDBandGame.NewScoreBoardData.AccountId}', '{interfaceDBandGame.NewScoreBoardData.Score}', '{interfaceDBandGame.NewScoreBoardData.TotalTime}', '{inits}', {level}) SELECT SCOPE_IDENTITY()";
                    else
                    z_query = $"INSERT into GameSession(AccountId, Scores, TotalTime, Initials, Level) values (NULL, '{interfaceDBandGame.NewScoreBoardData.Score}', '{interfaceDBandGame.NewScoreBoardData.TotalTime}', '{inits}', {level}) SELECT SCOPE_IDENTITY()";
                    SqlCommand z = new SqlCommand(z_query, _connection);
                    z.ExecuteNonQuery();


                }
                catch (SqlException Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    _command.Connection = Disconnect();
                }
            }
            else
                ;
        }

        private SqlConnection Connect()
        {
            // Mở kết nối nếu nó đang đóng
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }

        private SqlConnection Disconnect()
        {
            // Đóng kết nối nếu nó đang mở
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
            return _connection;
        }
    }
}
