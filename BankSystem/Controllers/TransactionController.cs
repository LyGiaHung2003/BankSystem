using BankSystem.Controlles;
using BankSystem.Models;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace BankSystem.Controllers
{
    internal class TransactionController : IController
    {
        ConnectDB db = new ConnectDB();
        public List<IModel> Items { get; private set; } = new List<IModel>();
        public bool Create(IModel model)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "INSERT INTO [TRANSACTION] (from_account_id, branch_id, date_of_trans, amount, pin, to_account_id, employee_id, content) VALUES (@from_account_id, @branch_id, @date_of_trans, @amount, @pin, @to_account_id, @employee_id, @content)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@from_account_id", transaction.From_account_id);
                    //command.Parameters.AddWithValue("@branch_id", transaction.Branch_id);
                    //command.Parameters.AddWithValue("@date_of_trans", transaction.Date_of_trans);
                    //command.Parameters.AddWithValue("@amount", transaction.Amount);
                    //command.Parameters.AddWithValue("@pin", transaction.Pin);
                    //command.Parameters.AddWithValue("@to_account_id", transaction.To_account_id);
                    //command.Parameters.AddWithValue("@employee_id", transaction.Employee_id);
                    //command.Parameters.AddWithValue("@content", transaction.content);

                    var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        stopwatch.Stop();
                        Console.WriteLine($"Thời gian thực hiện Create: {stopwatch.ElapsedMilliseconds} ms");
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Có lỗi xảy ra trong Create: " + ex.Message);
                        return false; // Trả về false nếu có lỗi
                    }
                }
            }
        }


        public string Deposit(int fromAccountId, string branchId, float soTien, string pin, int employeeId, string content)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string checkBranchStatusQuery = "SELECT Status FROM BRANCH WHERE branch_Id = @BranchId";
                    using (SqlCommand checkBranchStatusCmd = new SqlCommand(checkBranchStatusQuery, connection, transaction))
                    {
                        checkBranchStatusCmd.Parameters.AddWithValue("@BranchId", branchId);
                        var branchStatus = (string)checkBranchStatusCmd.ExecuteScalar();

                        if (branchStatus == "Block")
                        {
                            transaction.Rollback();
                            return "Chi nhánh hiện đang đóng, không thể thực hiện giao dịch.";
                        }
                    }
                    string checkPinQuery = "SELECT COUNT(*) FROM CUSTOMER WHERE id = @AccountId AND Pin = @Pin";
                    using (SqlCommand checkPinCmd = new SqlCommand(checkPinQuery, connection, transaction))
                    {
                        checkPinCmd.Parameters.AddWithValue("@AccountId", fromAccountId);
                        checkPinCmd.Parameters.AddWithValue("@Pin", pin);
                        int pinCount = (int)checkPinCmd.ExecuteScalar();

                        if (pinCount == 0)
                        {
                            transaction.Rollback();
                            return "Mã PIN không chính xác.";
                        }
                    }
                    string checkStatusQuery = "SELECT Status FROM ACCOUNT WHERE CUSTOMER_Id = @AccountId";
                    using (SqlCommand checkStatusCmd = new SqlCommand(checkStatusQuery, connection, transaction))
                    {
                        checkStatusCmd.Parameters.AddWithValue("@AccountId", fromAccountId);
                        var status = (string)checkStatusCmd.ExecuteScalar();

                        if (status == "Block")
                        {
                            transaction.Rollback();
                            return "Tài khoản bị đóng băng, không thể thực hiện giao dịch.";
                        }
                    }

                    string queryNap = "UPDATE ACCOUNT SET Balance = Balance + @SoTien WHERE Id = @AccountId";
                    using (SqlCommand cmdNap = new SqlCommand(queryNap, connection, transaction))
                    {
                        cmdNap.Parameters.AddWithValue("@SoTien", soTien);
                        cmdNap.Parameters.AddWithValue("@AccountId", fromAccountId);
                        cmdNap.ExecuteNonQuery();
                        MessageBox.Show($"Nạp tiền thành công.\nSố tiền nạp: {soTien} VNĐ\nSố tài khoản: {fromAccountId}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string insertTransactionQuery = @"INSERT INTO [TRANSACTION] (From_account_id, Branch_id, Date_of_trans, Amount, Employee_id, Pin, id_type, Content)
                                                      VALUES (@FromAccountId, @BranchId, @DateOfTrans, @Amount, @EmployeeId, @Pin, @id_type, @Content)";
                    using (SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionQuery, connection, transaction))
                    {
                        insertTransactionCmd.Parameters.AddWithValue("@FromAccountId", fromAccountId);
                        insertTransactionCmd.Parameters.AddWithValue("@BranchId", branchId);
                        insertTransactionCmd.Parameters.AddWithValue("@DateOfTrans", DateTime.Now);
                        insertTransactionCmd.Parameters.AddWithValue("@Amount", soTien);
                        insertTransactionCmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                        insertTransactionCmd.Parameters.AddWithValue("@Pin", pin);
                        insertTransactionCmd.Parameters.AddWithValue("@id_type", 1);
                        insertTransactionCmd.Parameters.AddWithValue("@Content", content);

                        insertTransactionCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return "Nạp tiền thành công.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                    transaction.Rollback();
                    return "Có lỗi xảy ra: " + ex.Message;
                }
            }
        }
        public string Withdraw(int fromAccountId, string branchId, float soTien, string pin, int employeeId, string content)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string checkBranchStatusQuery = "SELECT Status FROM BRANCH WHERE branch_Id = @BranchId";
                    using (SqlCommand checkBranchStatusCmd = new SqlCommand(checkBranchStatusQuery, connection, transaction))
                    {
                        checkBranchStatusCmd.Parameters.AddWithValue("@BranchId", branchId);
                        var branchStatus = (string)checkBranchStatusCmd.ExecuteScalar();

                        if (branchStatus == "Block")
                        {
                            transaction.Rollback();
                            return "Chi nhánh hiện đang đóng, không thể thực hiện giao dịch.";
                        }
                    }
                    string checkPinQuery = "SELECT COUNT(*) FROM CUSTOMER WHERE id = @AccountId AND Pin = @Pin";
                    using (SqlCommand checkPinCmd = new SqlCommand(checkPinQuery, connection, transaction))
                    {
                        checkPinCmd.Parameters.AddWithValue("@AccountId", fromAccountId);
                        checkPinCmd.Parameters.AddWithValue("@Pin", pin);
                        int pinCount = (int)checkPinCmd.ExecuteScalar();

                        if (pinCount == 0)
                        {
                            transaction.Rollback();
                            return "Mã PIN không chính xác.";
                        }
                    }

                    string checkStatusQuery = "SELECT Status FROM ACCOUNT WHERE CUSTOMER_Id = @AccountId";
                    using (SqlCommand checkStatusCmd = new SqlCommand(checkStatusQuery, connection, transaction))
                    {
                        checkStatusCmd.Parameters.AddWithValue("@AccountId", fromAccountId);
                        var status = (string)checkStatusCmd.ExecuteScalar();

                        if (status == "Block")
                        {
                            transaction.Rollback();
                            return "Tài khoản bị đóng băng, không thể thực hiện giao dịch.";
                        }
                    }

                    string checkQuery = "SELECT Balance FROM ACCOUNT WHERE Id = @AccountId";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection, transaction))
                    {
                        checkCmd.Parameters.AddWithValue("@AccountId", fromAccountId);
                        object balanceResult = checkCmd.ExecuteScalar();
                        float soDu = Convert.ToSingle(balanceResult);
                        Console.WriteLine("Số dư hiện tại: " + soDu);
                        Console.WriteLine("Số tiền cần rút: " + soTien);

                        if (soDu < soTien)
                        {
                            transaction.Rollback();
                            return "Số dư không đủ.";
                        }
                    }

                    string queryRut = "UPDATE ACCOUNT SET Balance = Balance - @SoTien WHERE Id = @AccountId";
                    using (SqlCommand cmdRut = new SqlCommand(queryRut, connection, transaction))
                    {
                        cmdRut.Parameters.AddWithValue("@SoTien", soTien);
                        cmdRut.Parameters.AddWithValue("@AccountId", fromAccountId);
                        cmdRut.ExecuteNonQuery();
                    }

                    string insertTransactionQuery = @"INSERT INTO [TRANSACTION] (From_account_id,Branch_id, Date_of_trans, Amount, Employee_id, Pin, id_type, Content)
                                                      VALUES (@FromAccountId, @BranchId, @DateOfTrans, @Amount, @EmployeeId, @Pin, @id_type, @Content)";
                    using (SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionQuery, connection, transaction))
                    {
                        insertTransactionCmd.Parameters.AddWithValue("@FromAccountId", fromAccountId);
                        insertTransactionCmd.Parameters.AddWithValue("@BranchId", branchId);
                        insertTransactionCmd.Parameters.AddWithValue("@DateOfTrans", DateTime.Now);
                        insertTransactionCmd.Parameters.AddWithValue("@Amount", soTien);
                        insertTransactionCmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                        insertTransactionCmd.Parameters.AddWithValue("@Pin", pin);
                        insertTransactionCmd.Parameters.AddWithValue("@id_type", 2);
                        insertTransactionCmd.Parameters.AddWithValue("@Content", content);

                        insertTransactionCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return "Rút tiền thành công.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                    transaction.Rollback();
                    return "Có lỗi xảy ra: " + ex.Message;
                }
            }
        }
        public string Transaction(int fromAccountId, string branchId, float soTien, string pin, int toAccountId, int employeeId, string content)
        {
            if (fromAccountId == toAccountId)
            {
                return "Hai tài khoản không được trùng nhau.";
            }

            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string checkBranchStatusQuery = "SELECT Status FROM BRANCH WHERE Branch_Id = @BranchId";
                    using (SqlCommand checkBranchStatusCmd = new SqlCommand(checkBranchStatusQuery, connection, transaction))
                    {
                        checkBranchStatusCmd.Parameters.AddWithValue("@BranchId", branchId);
                        var branchStatus = (string)checkBranchStatusCmd.ExecuteScalar();

                        if (branchStatus == "Block")
                        {
                            transaction.Rollback();
                            return "Chi nhánh hiện đang đóng, không thể thực hiện giao dịch.";
                        }
                    }
                    string checkPinQuery = "SELECT COUNT(*) FROM CUSTOMER WHERE id = @From_Account_Id AND Pin = @Pin";
                    using (SqlCommand checkPinCmd = new SqlCommand(checkPinQuery, connection, transaction))
                    {
                        checkPinCmd.Parameters.AddWithValue("@From_Account_Id", fromAccountId);
                        checkPinCmd.Parameters.AddWithValue("@Pin", pin);
                        int pinCount = (int)checkPinCmd.ExecuteScalar();

                        if (pinCount == 0)
                        {
                            transaction.Rollback();
                            return "Mã PIN không chính xác.";
                        }
                    }

                    // Kiểm tra trạng thái tài khoản gửi
                    string checkStatusFrQuery = "SELECT Status FROM ACCOUNT WHERE branch_ID = @From_Account_Id";
                    using (SqlCommand checkStatusCmd = new SqlCommand(checkStatusFrQuery, connection, transaction))
                    {
                        checkStatusCmd.Parameters.AddWithValue("@From_Account_Id", fromAccountId);
                        string status = (string)checkStatusCmd.ExecuteScalar();

                        if (status == "Block")
                        {
                            transaction.Rollback();
                            return "Tài khoản gửi bị đóng băng, không thể thực hiện giao dịch.";
                        }
                    }

                    // Kiểm tra trạng thái tài khoản nhận
                    string checkStatusToQuery = "SELECT Status FROM ACCOUNT WHERE ID = @To_Account_Id";
                    using (SqlCommand checkStatusCmd = new SqlCommand(checkStatusToQuery, connection, transaction))
                    {
                        checkStatusCmd.Parameters.AddWithValue("@To_Account_Id", toAccountId);
                        string status = (string)checkStatusCmd.ExecuteScalar();

                        if (status == "Block")
                        {
                            transaction.Rollback();
                            return "Tài khoản nhận bị đóng băng, không thể thực hiện giao dịch.";
                        }
                    }

                    // Kiểm tra số dư tài khoản gửi
                    string checkBalanceQuery = "SELECT Balance FROM ACCOUNT WHERE ID = @From_Account_Id";
                    using (SqlCommand checkCmd = new SqlCommand(checkBalanceQuery, connection, transaction))
                    {
                        checkCmd.Parameters.AddWithValue("@From_Account_Id", fromAccountId);
                        object balanceResult = checkCmd.ExecuteScalar();
                        float soDuNguon = Convert.ToSingle(balanceResult);
                        if (soDuNguon < soTien)
                        {
                            transaction.Rollback();
                            return "Số dư không đủ.";
                        }
                    }

                    // Cập nhật số dư tài khoản gửi
                    string queryRut = "UPDATE ACCOUNT SET Balance = Balance - @SoTien WHERE ID = @From_Account_Id";
                    using (SqlCommand cmdRut = new SqlCommand(queryRut, connection, transaction))
                    {
                        cmdRut.Parameters.AddWithValue("@SoTien", soTien);
                        cmdRut.Parameters.AddWithValue("@From_Account_Id", fromAccountId);
                        cmdRut.ExecuteNonQuery();
                    }

                    // Cập nhật số dư tài khoản nhận
                    string queryNap = "UPDATE ACCOUNT SET Balance = Balance + @SoTien WHERE ID = @To_Account_Id";
                    using (SqlCommand cmdNap = new SqlCommand(queryNap, connection, transaction))
                    {
                        cmdNap.Parameters.AddWithValue("@SoTien", soTien);
                        cmdNap.Parameters.AddWithValue("@To_Account_Id", toAccountId);
                        cmdNap.ExecuteNonQuery();
                    }

                    // Tạo giao dịch và lưu vào database
                    string insertTransactionQuery = @"
                                                INSERT INTO [TRANSACTION] (From_account_id, To_account_id, Branch_id, Date_of_trans, Amount, Employee_id, Pin, id_type, Content)
                                                VALUES (@From_account_id, @To_account_id, @Branch_id, @Date_of_trans, @Amount, @Employee_id, @Pin, @id_type, @Content)";
                    using (SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionQuery, connection, transaction))
                    {
                        insertTransactionCmd.Parameters.AddWithValue("@From_account_id", fromAccountId);
                        insertTransactionCmd.Parameters.AddWithValue("@To_account_id", toAccountId);
                        insertTransactionCmd.Parameters.AddWithValue("@Branch_id", branchId);
                        insertTransactionCmd.Parameters.AddWithValue("@Date_of_trans", DateTime.Now);
                        insertTransactionCmd.Parameters.AddWithValue("@Amount", soTien);
                        insertTransactionCmd.Parameters.AddWithValue("@Employee_id", employeeId);
                        insertTransactionCmd.Parameters.AddWithValue("@Pin", pin);
                        insertTransactionCmd.Parameters.AddWithValue("@id_type", 3);
                        insertTransactionCmd.Parameters.AddWithValue("@Content", content);

                        insertTransactionCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return "Chuyển tiền thành công.";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return "Có lỗi xảy ra: " + ex.Message;
                }
            }
        }
        //public async Task<string> ChuyenTien(int fromAccountId, string branchId, float soTien, string pin, int toAccountId, int employeeId, string content)
        //{
        //    if (fromAccountId == toAccountId)
        //    {
        //        return "Hai tài khoản không được trùng nhau.";
        //    }

        //    using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
        //    {
        //        await connection.OpenAsync();
        //        SqlTransaction transaction = connection.BeginTransaction();

        //        long totalExecutionTime = 0; // Biến lưu tổng thời gian thực hiện

        //        try
        //        {
        //            // Kiểm tra mã PIN
        //            string checkPinQuery = "SELECT COUNT(*) FROM CUSTOMER WHERE id = @From_Account_Id AND Pin = @Pin";
        //            using (SqlCommand checkPinCmd = new SqlCommand(checkPinQuery, connection, transaction))
        //            {
        //                checkPinCmd.Parameters.AddWithValue("@From_Account_Id", fromAccountId);
        //                checkPinCmd.Parameters.AddWithValue("@Pin", pin);

        //                var watch = System.Diagnostics.Stopwatch.StartNew(); // Bắt đầu đo thời gian
        //                int pinCount = (int)await checkPinCmd.ExecuteScalarAsync();
        //                watch.Stop(); // Dừng đo thời gian
        //                totalExecutionTime += watch.ElapsedMilliseconds; // Cộng dồn thời gian

        //                if (pinCount == 0)
        //                {
        //                    return $"Mã PIN không chính xác. Thời gian kiểm tra: {watch.ElapsedMilliseconds} ms.";
        //                }
        //            }

        //            // Kiểm tra trạng thái và số dư tài khoản gửi
        //            string checkStatusQueryFrom = "SELECT Status, Balance FROM ACCOUNT WHERE ID = @Account_Id";
        //            using (SqlCommand checkStatusCmdFrom = new SqlCommand(checkStatusQueryFrom, connection, transaction))
        //            {
        //                checkStatusCmdFrom.Parameters.AddWithValue("@Account_Id", fromAccountId);

        //                var watch = System.Diagnostics.Stopwatch.StartNew(); // Bắt đầu đo thời gian
        //                using (SqlDataReader reader = await checkStatusCmdFrom.ExecuteReaderAsync())
        //                {
        //                    watch.Stop(); // Dừng đo thời gian
        //                    totalExecutionTime += watch.ElapsedMilliseconds; // Cộng dồn thời gian

        //                    if (reader.Read())
        //                    {
        //                        if (reader["Status"].ToString() == "Block")
        //                        {
        //                            return $"Tài khoản gửi bị đóng băng, không thể thực hiện giao dịch. Thời gian kiểm tra: {watch.ElapsedMilliseconds} ms.";
        //                        }

        //                        float soDuNguon = Convert.ToSingle(reader["Balance"]);
        //                        if (soDuNguon < soTien)
        //                        {
        //                            return $"Số dư không đủ. Thời gian kiểm tra: {watch.ElapsedMilliseconds} ms.";
        //                        }
        //                    }
        //                    else
        //                    {
        //                        return $"Tài khoản gửi không tồn tại. Thời gian kiểm tra: {watch.ElapsedMilliseconds} ms.";
        //                    }
        //                }
        //            }

        //            // Kiểm tra trạng thái tài khoản nhận
        //            string checkStatusQueryTo = "SELECT Status FROM ACCOUNT WHERE ID = @Account_Id";
        //            using (SqlCommand checkStatusCmdTo = new SqlCommand(checkStatusQueryTo, connection, transaction))
        //            {
        //                checkStatusCmdTo.Parameters.AddWithValue("@Account_Id", toAccountId);

        //                var watch = System.Diagnostics.Stopwatch.StartNew(); // Bắt đầu đo thời gian
        //                string statusTo = (string)await checkStatusCmdTo.ExecuteScalarAsync();
        //                watch.Stop(); // Dừng đo thời gian
        //                totalExecutionTime += watch.ElapsedMilliseconds; // Cộng dồn thời gian

        //                if (statusTo == "Block")
        //                {
        //                    return $"Tài khoản nhận bị đóng băng, không thể thực hiện giao dịch. Thời gian kiểm tra: {watch.ElapsedMilliseconds} ms.";
        //                }
        //            }

        //            // Cập nhật số dư tài khoản gửi
        //            string queryRut = "UPDATE ACCOUNT SET Balance = Balance - @SoTien WHERE ID = @From_Account_Id";
        //            using (SqlCommand cmdRut = new SqlCommand(queryRut, connection, transaction))
        //            {
        //                cmdRut.Parameters.AddWithValue("@SoTien", soTien);
        //                cmdRut.Parameters.AddWithValue("@From_Account_Id", fromAccountId);

        //                var watch = System.Diagnostics.Stopwatch.StartNew(); // Bắt đầu đo thời gian
        //                await cmdRut.ExecuteNonQueryAsync();
        //                watch.Stop(); // Dừng đo thời gian
        //                totalExecutionTime += watch.ElapsedMilliseconds; // Cộng dồn thời gian
        //            }

        //            // Cập nhật số dư tài khoản nhận
        //            string queryNap = "UPDATE ACCOUNT SET Balance = Balance + @SoTien WHERE ID = @ToAccount_Id";
        //            using (SqlCommand cmdNap = new SqlCommand(queryNap, connection, transaction))
        //            {
        //                cmdNap.Parameters.AddWithValue("@SoTien", soTien);
        //                cmdNap.Parameters.AddWithValue("@ToAccount_Id", toAccountId);

        //                var watch = System.Diagnostics.Stopwatch.StartNew(); // Bắt đầu đo thời gian
        //                await cmdNap.ExecuteNonQueryAsync();
        //                watch.Stop(); // Dừng đo thời gian
        //                totalExecutionTime += watch.ElapsedMilliseconds; // Cộng dồn thời gian
        //            }

        //            // Tạo giao dịch
        //            TransactionModel trans = new TransactionModel
        //            {
        //                From_account_id = fromAccountId,
        //                To_account_id = toAccountId,
        //                Branch_id = branchId,
        //                Date_of_trans = DateTime.Now,
        //                Amount = soTien,
        //                Employee_id = employeeId,
        //                Pin = pin,
        //                content = content
        //            };

        //            // Thực thi hàm Create với thời gian chờ
        //            var createTask = Task.Run(() => Create(trans));
        //            var watchCreate = System.Diagnostics.Stopwatch.StartNew(); // Bắt đầu đo thời gian
        //            if (await Task.WhenAny(createTask, Task.Delay(5000)) == createTask)
        //            {
        //                watchCreate.Stop(); // Dừng đo thời gian
        //                totalExecutionTime += watchCreate.ElapsedMilliseconds; // Cộng dồn thời gian

        //                if (!createTask.Result)
        //                {
        //                    transaction.Rollback();
        //                    return $"Có lỗi xảy ra khi lưu giao dịch. Thời gian thực hiện: {totalExecutionTime} ms.";
        //                }
        //            }
        //            else
        //            {
        //                // Nếu hàm Create không hoàn thành trong 5 giây
        //                transaction.Rollback();
        //                return $"Thời gian thực thi Create quá lâu, giao dịch đã bị hủy. Tổng thời gian thực hiện: {totalExecutionTime} ms.";
        //            }

        //            transaction.Commit();
        //            return $"Chuyển tiền thành công. Tổng thời gian thực hiện: {totalExecutionTime} ms.";
        //        }
        //        catch (Exception ex)
        //        {
        //            transaction.Rollback();
        //            return $"Có lỗi xảy ra: {ex.Message}. Tổng thời gian thực hiện: {totalExecutionTime} ms.";
        //        }
        //    }
        //}
        public bool Update(IModel model)
        {
            TransactionModel transaction = (TransactionModel)model;
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "UPDATE TRANSACTION";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool Delete(Object Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
                {
                    connection.Open();

                    string query = "DELETE TRANSACTION";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                return false;
            }
        }


        public IModel? Read(object id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM TRANSACTION WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new TransactionModel
                        {
                            Id = (int)reader["id"],
                            From_account_id = (int)reader["from_account_id"],
                            To_account_id = (int)reader["to_account_id"],
                            Amount = (float)reader["amount"],
                            Branch_id = (string)reader["branch_id"],
                            content = (string)reader["content"],
                            Date_of_trans = (DateTime)reader["date_of_trans"],
                            Employee_id = (int)reader["employee_id"],
                            id_type = (int)reader["id_type"],
                            Pin = (string)reader["pin"]
                        };
                    }
                    return null;
                }
            }
        }
        public bool Load()
        {
            Items.Clear();

            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT T.id, T.from_account_id, C1.name AS FromCustomerName, T.to_account_id, C2.name AS ToCustomerName, T.branch_id, T.date_of_trans, T.amount, T.id_type, T.employee_id, T.content " +
                               "FROM [TRANSACTION] T " +
                               "LEFT JOIN [CUSTOMER] C1 ON T.from_account_id = C1.id " +
                               "LEFT JOIN [CUSTOMER] C2 ON T.to_account_id = C2.id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TransactionModel transaction = new TransactionModel
                            {
                                Id = (int)reader["id"],
                                From_account_id = (int)reader["from_account_id"],
                                To_account_id = reader["to_account_id"] != DBNull.Value ? (int)reader["to_account_id"] : 0,
                                Amount = Convert.ToSingle(reader["amount"]),
                                Branch_id = (string)reader["branch_id"],
                                content = (string)reader["content"],
                                Date_of_trans = (DateTime)reader["date_of_trans"],
                                Employee_id = (int)reader["employee_id"],
                                id_type = (int)reader["id_type"],
                            };

                            Items.Add(transaction);
                        }
                    }
                }
            }
            return Items.Count > 0;
        }
        public bool Load(Object id)
        {
            var transaction = Read(id);
            if (transaction != null)
            {
                Items.Clear();
                Items.Add(transaction);
                return true;
            }
            return false;
        }

        public bool IsExist(object id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM TRANSACTION WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool IsExist(IModel model)
        {
            TransactionModel transaction = (TransactionModel)model;
            return IsExist(transaction.Id);
        }

        public bool ValidateAmount(string input, out decimal amount, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(input))
            {
                errorMessage = "Số tiền không được để trống!";
                amount = 0;
                return false;
            }
            string cleanedInput = input.Replace(" VNĐ", "").Replace(",", ".");

            if (!decimal.TryParse(cleanedInput, NumberStyles.Any, CultureInfo.InvariantCulture, out amount))
            {
                errorMessage = "Số tiền phải là một số hợp lệ!";
                return false;
            }

            if (amount < 0)
            {
                errorMessage = "Số tiền không được âm!";
                return false;
            }
            if (amount == 0)
            {
                errorMessage = "Số tiền phải lớn hơn không!";
                return false;
            }

            return true;
        }
        public string GetNameType(int id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT name_type FROM Typetransaction WHERE id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return "Không tìm thấy loại giao dịch";
                    }
                }
            }
        }
    }
}