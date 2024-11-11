using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data; //DataSet 개체 참조
using System.Windows.Forms;

namespace Main
{
    //병원 정보 가져오기
    public class HospitalInfo
    {
        public decimal HospitalSerialNumber { get; set; }
        public string HospitalName { get; set; }
        public decimal HospitalPhoneNumber { get; set; }
        public decimal HospitalDoctorCount { get; set; }
        public string HospitalSpecialNotes { get; set; }
        public string HospitalDivision { get; set; }
        public byte[] HospitalMapImage { get; set; }
        public string HospitalEmail { get; set; }
    }

    public class HospitalLocation
    {
        public decimal HospitalSerialNumber { get; set; }
        public string FirstLocation { get; set; }
        public string SecondLocation { get; set; }
        public string DetailedLocation { get; set; }
    }

    public class HospitalBed
    {
        public decimal HospitalSerialNumber { get; set; }
        public decimal BedSerialNumber { get; set; }
        public int BedQuantity { get; set; }
    }

    class DBconn2
    {
        private const string Name = "PATIENT_SERIAL_NUMBER";

        // 생성자에서 사용할 연결 문자열
        private string conn_info;

        // 생성자 정의
        public DBconn2()
        {
            conn_info = "User Id=jung02; Password=1234; Data Source=(DESCRIPTION = " +
                             "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) " +
                             "(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
        }
        public DBconn2(string con_info)
        {
            conn_info = con_info;
        }
        public void OpenConnection()
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("dbconn2 연결 성공!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                }
            }
        }
        public String get_conn_info()
        {
            return this.conn_info;
        }
        //회원가입
        public bool hospital_join_membership(string id, string pass)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();

                    string sql = "INSERT INTO HOSPITAL_LOGIN (HOSPITAL_SERIAL_NUMBER, HOSPITAL_ID, HOSPITAL_PASSWORD) " +
                                 "VALUES (HOSPITAL_SEQ.NEXTVAL, :hospitalId, :hospitalPassword)";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":hospitalId", OracleDbType.Varchar2).Value = id;
                        command.Parameters.Add(":hospitalPassword", OracleDbType.Varchar2).Value = pass;
                        command.ExecuteNonQuery();
                        Console.WriteLine("행이 삽입되었습니다.");
                        return true;
                    }
                }
                catch (OracleException ex)
                {
                    if (ex.Number == 1)
                    {
                        Console.WriteLine("중복된 병원 ID입니다.");
                    }
                    else
                    {
                        Console.WriteLine("연결 실패: " + ex.Message);
                    }
                    return false;
                }
            }
        }
        //아이디 존제여부 확인
        public bool check_id_pass(string id, string password)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM JUNG02.HOSPITAL_LOGIN " +
                                   "WHERE HOSPITAL_ID = :hospitalId AND HOSPITAL_PASSWORD = :hospitalPassword";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("hospitalId", OracleDbType.Varchar2).Value = id;
                        command.Parameters.Add("hospitalPassword", OracleDbType.Varchar2).Value = password;

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0; // 존재하면 true, 존재하지 않으면 false
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                    return false;
                }
            }
        }
        //아이디와 비밀번호 받고 pk,fk 찾기
        public decimal get_hospital_pk(string hospitalId, string hospitalPassword)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT HOSPITAL_SERIAL_NUMBER FROM JUNG02.HOSPITAL_LOGIN " +
                                   "WHERE HOSPITAL_ID = :hospitalId AND HOSPITAL_PASSWORD = :hospitalPassword";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("hospitalId", OracleDbType.Varchar2).Value = hospitalId;
                        command.Parameters.Add("hospitalPassword", OracleDbType.Varchar2).Value = hospitalPassword;

                        object result = command.ExecuteScalar();

                        // 결과가 null이면 일치하는 데이터 없음
                        return result != null ? Convert.ToDecimal(result) : -1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                    return -1;
                }
            }
        }
        //병원 기본 정보를 저장함
        public void InsertHospitalInfo(
       decimal hospitalSerialNumber,
       string hospitalName,
       decimal hospitalPhoneNumber,
       decimal hospitalDoctorCount,
       string hospitalSpecialNotes,
       string hospitalDivision,
       byte[] hospitalMapImage,
       string hospitalEmail)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO JUNG02.HOSPITAL_INFO " +
                                   "(HOSPITAL_SERIAL_NUMBER, HOSPITAL_NAME, HOSPITAL_PHONE_NUMBER, " +
                                   "HOSPITAL_DOCTOR_COUNT, HOSPITAL_SPECIAL_NOTES, HOSPITAL_DIVISION, " +
                                   "HOSPITAL_MAP_IMAGE, HOSPITAL_EMAIL) " +
                                   "VALUES (:hospitalSerialNumber, :hospitalName, :hospitalPhoneNumber, " +
                                   ":hospitalDoctorCount, :hospitalSpecialNotes, :hospitalDivision, " +
                                   ":hospitalMapImage, :hospitalEmail)";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("hospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;
                        command.Parameters.Add("hospitalName", OracleDbType.Varchar2).Value = hospitalName;
                        command.Parameters.Add("hospitalPhoneNumber", OracleDbType.Decimal).Value = hospitalPhoneNumber;
                        command.Parameters.Add("hospitalDoctorCount", OracleDbType.Decimal).Value = hospitalDoctorCount;
                        command.Parameters.Add("hospitalSpecialNotes", OracleDbType.Varchar2).Value = hospitalSpecialNotes;
                        command.Parameters.Add("hospitalDivision", OracleDbType.Varchar2).Value = hospitalDivision;
                        command.Parameters.Add("hospitalMapImage", OracleDbType.Blob).Value = hospitalMapImage;
                        command.Parameters.Add("hospitalEmail", OracleDbType.Varchar2).Value = hospitalEmail;

                        command.ExecuteNonQuery();
                        Console.WriteLine("병원 정보 행이 삽입되었습니다.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패 또는 삽입 실패: " + ex.Message);
                }
            }
        }
        //병원 진료과목을 저장함
        public void SaveHospitalDepartments(decimal hospitalSerialNumber, List<CheckBox> selectedDepartments)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(conn_info))
                {
                    connection.Open();

                    foreach (CheckBox checkBox in selectedDepartments)
                    {
                        decimal departmentSerialNumber = Convert.ToDecimal(checkBox.Tag);

                        string sql = "INSERT INTO JUNG02.HOSPITAL_DEPARTMENTS " +
                                     "(HOSPITAL_SERIAL_NUMBER, DEPARTMENT_SERIAL_NUMBER) " +
                                     "VALUES (:hospitalSerialNumber, :departmentSerialNumber)";

                        using (OracleCommand command = new OracleCommand(sql, connection))
                        {
                            command.Parameters.Add(":hospitalSerialNumber", OracleDbType.Int32).Value = hospitalSerialNumber;
                            command.Parameters.Add(":departmentSerialNumber", OracleDbType.Decimal).Value = departmentSerialNumber;

                            command.ExecuteNonQuery();
                        }
                    }
              
                    Console.WriteLine("진료과 설정 오류 없이 완료!");
                    MessageBox.Show("진료과 설정을 완료했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        //병원 이름에따른 시리얼 넘버 맵핑
        private int GetBedSerialNumber(string bedType)
        {
            Dictionary<string, int> bedTypeMapping = new Dictionary<string, int>
            {
                { "일반입원실", 1 },
                { "중환자실", 2 },
                { "정신과폐쇄실", 3 },
                { "격리병실", 4 },
                { "무균치료실", 5 },
                { "분만실", 6 },
                { "수술실", 7 },
                { "응급실", 8 },
                { "물리치료실", 9 },
            };

            if (bedTypeMapping.ContainsKey(bedType))
            {
                return bedTypeMapping[bedType];
            }
            return -1;
        }
        //병원 침대수 저장
        public void SaveHospitalBeds(decimal hospitalSerialNumber, Dictionary<string, int> bedCounts)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(conn_info))
                {
                    connection.Open();

                    foreach (var kvp in bedCounts)
                    {
                        string bedType = kvp.Key;
                        int bedCount = kvp.Value;
                        int bedSerialNumber = GetBedSerialNumber(bedType); // 위에서 정의한 매핑 함수 활용

                        string sql = "INSERT INTO JUNG02.HOSPITAL_BEDS " +
                                     "(HOSPITAL_SERIAL_NUMBER, BED_SERIAL_NUMBER, BED_QUANTITY) " +
                                     "VALUES (:hospitalSerialNumber, :bedSerialNumber, :bedCount)";

                        using (OracleCommand command = new OracleCommand(sql, connection))
                        {
                            command.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;
                            command.Parameters.Add(":bedSerialNumber", OracleDbType.Int32).Value = bedSerialNumber;
                            command.Parameters.Add(":bedCount", OracleDbType.Int32).Value = bedCount;

                            command.ExecuteNonQuery();
                        }
                    }

                    Console.WriteLine("침대 설정 오류 없이 완료!");
                    MessageBox.Show("침대 설정을 완료했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }
        //병원 위치 저장
        public void InsertHospitalLocation(decimal hospitalSerialNumber, string firstLocation, string secondLocation, string detailedLocation)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(conn_info))
                {
                    connection.Open();

                    string sql = "INSERT INTO JUNG02.HOSPITAL_LOCATION " +
                                 "(HOSPITAL_SERIAL_NUMBER, FIRST_LOCATION, SECOND_LOCATION, DETAILED_LOCATION) " +
                                 "VALUES (:hospitalSerialNumber, :firstLocation, :secondLocation, :detailedLocation)";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;
                        command.Parameters.Add(":firstLocation", OracleDbType.Varchar2).Value = firstLocation;
                        command.Parameters.Add(":secondLocation", OracleDbType.Varchar2).Value = secondLocation;
                        command.Parameters.Add(":detailedLocation", OracleDbType.Varchar2).Value = detailedLocation;

                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("위치 정보 추가 완료!");
                    MessageBox.Show("위치 정보를 추가했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }
        public bool CheckPrimaryKeyExists(decimal hospitalSerialNumber)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT COUNT(*) FROM JUNG02.HOSPITAL_INFO WHERE HOSPITAL_SERIAL_NUMBER = :hospitalSerialNumber";
                    command.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        //병원 정보 가져오기
        public HospitalInfo GetHospitalInfo(decimal hospitalSerialNumber)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                string sql = "SELECT * FROM JUNG02.HOSPITAL_INFO WHERE HOSPITAL_SERIAL_NUMBER = :hospitalSerialNumber";

                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    command.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            HospitalInfo hospitalInfo = new HospitalInfo
                            {
                                HospitalSerialNumber = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_SERIAL_NUMBER")),
                                HospitalName = reader.GetString(reader.GetOrdinal("HOSPITAL_NAME")),
                                HospitalPhoneNumber = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_PHONE_NUMBER")),
                                HospitalDoctorCount = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_DOCTOR_COUNT")),
                                HospitalSpecialNotes = reader.GetString(reader.GetOrdinal("HOSPITAL_SPECIAL_NOTES")),
                                HospitalDivision = reader.GetString(reader.GetOrdinal("HOSPITAL_DIVISION")),
                                HospitalMapImage = reader.GetOracleBlob(reader.GetOrdinal("HOSPITAL_MAP_IMAGE")).Value as byte[],
                                HospitalEmail = reader.GetString(reader.GetOrdinal("HOSPITAL_EMAIL"))
                            };

                            return hospitalInfo;
                        }
                    }
                }
            }

            return null;
        }
        //병원 위치 가져오기
        public HospitalLocation GetHospitalLocation(decimal hospitalSerialNumber)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                string sql = "SELECT * FROM JUNG02.HOSPITAL_LOCATION WHERE HOSPITAL_SERIAL_NUMBER = :hospitalSerialNumber";

                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    command.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            HospitalLocation hospitalLocation = new HospitalLocation
                            {
                                HospitalSerialNumber = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_SERIAL_NUMBER")),
                                FirstLocation = reader.GetString(reader.GetOrdinal("FIRST_LOCATION")),
                                SecondLocation = reader.GetString(reader.GetOrdinal("SECOND_LOCATION")),
                                DetailedLocation = reader.GetString(reader.GetOrdinal("DETAILED_LOCATION"))
                            };
                            return hospitalLocation;
                        }
                    }
                }
            }

            return null;
        }
        //해당 병원의 모든 병원과의 pk값을 가져온다.
        public List<decimal> GetDepartmentSerialNumbersForHospital(decimal hospitalSerialNumber)
        {
            List<decimal> departmentSerialNumbers = new List<decimal>();

            try
            {
                using (OracleConnection connection = new OracleConnection(conn_info))
                {
                    connection.Open();

                    string sql = "SELECT DEPARTMENT_SERIAL_NUMBER " +
                                 "FROM JUNG02.HOSPITAL_DEPARTMENTS " +
                                 "WHERE HOSPITAL_SERIAL_NUMBER = :hospitalSerialNumber";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal departmentSerialNumber = reader.GetDecimal(reader.GetOrdinal("DEPARTMENT_SERIAL_NUMBER"));
                                departmentSerialNumbers.Add(departmentSerialNumber);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }

            return departmentSerialNumbers;
        }
        public List<HospitalBed> GetHospitalBeds(decimal hospitalSerialNumber)
        {
            List<HospitalBed> hospitalBeds = new List<HospitalBed>();

            try
            {
                using (OracleConnection connection = new OracleConnection(conn_info))
                {
                    connection.Open();

                    string sql = "SELECT * FROM JUNG02.HOSPITAL_BEDS WHERE HOSPITAL_SERIAL_NUMBER = :hospitalSerialNumber";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                HospitalBed bed = new HospitalBed
                                {
                                    HospitalSerialNumber = Convert.ToDecimal(reader["HOSPITAL_SERIAL_NUMBER"]),
                                    BedSerialNumber = Convert.ToDecimal(reader["BED_SERIAL_NUMBER"]),
                                    BedQuantity = Convert.ToInt32(reader["BED_QUANTITY"])
                                };

                                hospitalBeds.Add(bed);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return hospitalBeds;
        }

        public void UpdateHospitalInfoAndLocation(decimal hospitalSerialNumber, HospitalInfo updatedInfo, HospitalLocation updatedLocation)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(conn_info))
                {
                    connection.Open();

                    // 업데이트할 쿼리 작성
                    string updateInfoQuery = "UPDATE JUNG02.HOSPITAL_INFO " +
                                             "SET HOSPITAL_NAME = :hospitalName, " +
                                             "HOSPITAL_PHONE_NUMBER = :phoneNumber, " +
                                             "HOSPITAL_DOCTOR_COUNT = :doctorCount, " +
                                             "HOSPITAL_SPECIAL_NOTES = :specialNotes, " +
                                             "HOSPITAL_DIVISION = :division, " +
                                             "HOSPITAL_EMAIL = :email " +
                                             "WHERE HOSPITAL_SERIAL_NUMBER = :hospitalSerialNumber";

                    using (OracleCommand updateInfoCommand = new OracleCommand(updateInfoQuery, connection))
                    {
                        // 매개변수 설정
                        updateInfoCommand.Parameters.Add(":hospitalName", OracleDbType.Varchar2).Value = updatedInfo.HospitalName;
                        updateInfoCommand.Parameters.Add(":phoneNumber", OracleDbType.Decimal).Value = updatedInfo.HospitalPhoneNumber;
                        updateInfoCommand.Parameters.Add(":doctorCount", OracleDbType.Decimal).Value = updatedInfo.HospitalDoctorCount;
                        updateInfoCommand.Parameters.Add(":specialNotes", OracleDbType.Varchar2).Value = updatedInfo.HospitalSpecialNotes;
                        updateInfoCommand.Parameters.Add(":division", OracleDbType.Varchar2).Value = updatedInfo.HospitalDivision;
                        updateInfoCommand.Parameters.Add(":email", OracleDbType.Varchar2).Value = updatedInfo.HospitalEmail;
                        updateInfoCommand.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;

                        // 쿼리 실행
                        updateInfoCommand.ExecuteNonQuery();
                    }

                    // 업데이트할 쿼리 작성
                    string updateLocationQuery = "UPDATE JUNG02.HOSPITAL_LOCATION " +
                                                 "SET FIRST_LOCATION = :firstLocation, " +
                                                 "SECOND_LOCATION = :secondLocation, " +
                                                 "DETAILED_LOCATION = :detailedLocation " +
                                                 "WHERE HOSPITAL_SERIAL_NUMBER = :hospitalSerialNumber";

                    using (OracleCommand updateLocationCommand = new OracleCommand(updateLocationQuery, connection))
                    {
                        // 매개변수 설정
                        updateLocationCommand.Parameters.Add(":firstLocation", OracleDbType.Varchar2).Value = updatedLocation.FirstLocation;
                        updateLocationCommand.Parameters.Add(":secondLocation", OracleDbType.Varchar2).Value = updatedLocation.SecondLocation;
                        updateLocationCommand.Parameters.Add(":detailedLocation", OracleDbType.Varchar2).Value = updatedLocation.DetailedLocation;
                        updateLocationCommand.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;

                        // 쿼리 실행
                        updateLocationCommand.ExecuteNonQuery();
                    }

                    Console.WriteLine("정보 업데이트 완료!");
                    MessageBox.Show("병원 정보를 업데이트했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }
        public void delete_department(decimal hospitalPk)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(conn_info))
                {
                    connection.Open();

                    string sql = "DELETE FROM JUNG02.HOSPITAL_DEPARTMENTS WHERE HOSPITAL_SERIAL_NUMBER = :hospitalPk";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":hospitalPk", OracleDbType.Decimal).Value = hospitalPk;

                        command.ExecuteNonQuery();
                        MessageBox.Show("행삭제 완료");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("오류 발생: " + ex.Message);
            }
        }
        public void delete_sickbed(decimal hospitalPk)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(conn_info))
                {
                    connection.Open();

                    string sql = $"DELETE FROM JUNG02.HOSPITAL_BEDS WHERE HOSPITAL_SERIAL_NUMBER = {hospitalPk}";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("오류 발생: " + ex.Message);
            }
        }
        public void UpdateHospitalMapImage(decimal hospitalPk, byte[] imageBytes)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(conn_info))
                {
                    connection.Open();

                    string sql = "UPDATE JUNG02.HOSPITAL_INFO SET HOSPITAL_MAP_IMAGE = :imageBytes WHERE HOSPITAL_SERIAL_NUMBER = :hospitalPk";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":imageBytes", OracleDbType.Blob).Value = imageBytes;
                        command.Parameters.Add(":hospitalPk", OracleDbType.Decimal).Value = hospitalPk;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("오류 발생: " + ex.Message);
            }
        }
        public void InsertDoctorInfo(
        string doctorName,
        string doctorExperience,
        string doctorPhoneNumber,
        string doctorEmail,
        string doctorPrimaryDepartment,
        string doctorIntroduction,
        decimal doctorRecommendationCount,
        decimal hospitalSerialNumber)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(conn_info))
                {
                    connection.Open();

                    string sql = "INSERT INTO JUNG02.DOCTOR_INFO " +
                                 "(DOCTOR_SERIAL_NUMBER, DOCTOR_NAME, DOCTOR_EXPERIENCE, DOCTOR_PHONE_NUMBER, " +
                                 "DOCTOR_EMAIL, DOCTOR_PRIMARY_DEPARTMENT, DOCTOR_INTRODUCTION, " +
                                 "DOCTOR_RECOMMENDATION_COUNT, HOSPITAL_SERIAL_NUMBER) " +
                                 "VALUES " +
                                 "(DOCTOR_SEQ.NEXTVAL, :doctorName, :doctorExperience, :doctorPhoneNumber, " +
                                 ":doctorEmail, :doctorPrimaryDepartment, :doctorIntroduction, " +
                                 ":doctorRecommendationCount, :hospitalSerialNumber)";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":doctorName", OracleDbType.Varchar2).Value = doctorName;
                        command.Parameters.Add(":doctorExperience", OracleDbType.Varchar2).Value = doctorExperience;
                        command.Parameters.Add(":doctorPhoneNumber", OracleDbType.Varchar2).Value = doctorPhoneNumber;
                        command.Parameters.Add(":doctorEmail", OracleDbType.Varchar2).Value = doctorEmail;
                        command.Parameters.Add(":doctorPrimaryDepartment", OracleDbType.Varchar2).Value = doctorPrimaryDepartment;
                        command.Parameters.Add(":doctorIntroduction", OracleDbType.Varchar2).Value = doctorIntroduction;
                        command.Parameters.Add(":doctorRecommendationCount", OracleDbType.Decimal).Value = doctorRecommendationCount;
                        command.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("오류 발생: " + ex.Message);
            }
        }
    }
}

